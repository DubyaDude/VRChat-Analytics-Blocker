using EasyConsole;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace VRChat_Analytics_Blocker
{
    public static class Actions
    {
        //This endpoint is no longer up/used
        //"stats.unity3d.com"

        private static readonly string[] analyticsURLs = new string[]
        {
            "api.amplitude.com", //This is VRChat specific
            "api2.amplitude.com", //This is VRChat specific
            "api.uca.cloud.unity3d.com",
            "config.uca.cloud.unity3d.com",
            "perf-events.cloud.unity3d.com",
            "public.cloud.unity3d.com",
            "cdp.cloud.unity3d.com",
            "data-optout-service.uca.cloud.unity3d.com",
            "ecommerce.iap.unity3d.com"
        };

        private static readonly string HostsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/");
        private static readonly string HostsFile = Path.Combine(HostsFolder, "hosts");

        public static void ModifyAnalyticsBlocking(bool isBlocking)
        {
            Output.WriteLine("====================================================================================");
            try
            {
                List<string> hostsFile = GetHostsFile();
                List<string> hostsFileEdited = new List<string>(hostsFile);

                if (isBlocking)
                    BlockAnalytics(hostsFile, ref hostsFileEdited);
                else
                    UnblockAnalytics(hostsFile, ref hostsFileEdited);

                SaveHostsFile(hostsFileEdited);
            }
            catch (Exception e)
            {
                Output.WriteLine($"There was an Error!\n{e}");
            }

            Output.WriteLine("====================================================================================");
            Output.WriteLine($"Checking Urls...\n");

            int amountUp = 0;
            foreach (string url in analyticsURLs)
            {
                bool isBlocked = true;
                try
                {
                    Uri uri = new Uri("http://" + url + "/");
                    var ip = Dns.GetHostAddresses(uri.Host)[0];
                    isBlocked = ip.ToString() == "0.0.0.0";
                }
                catch /*(Exception e)*/
                {
                    //If throws exception, is down
                }
                finally
                {
                    Output.WriteLine($"{url} : {(isBlocked ? "Down" : "Up")}");
                    if (!isBlocked)
                        amountUp++;
                }
            }

            if (isBlocking)
            {
                if (amountUp == 0)
                {
                    Output.WriteLine(ConsoleColor.Green, $"\nBlocking Analytics Successful!");
                }
                else
                {
                    Output.WriteLine(ConsoleColor.Red, $"\nBlocking Analytics FAILED!");
                }
            }
            else
            {
                if (amountUp == analyticsURLs.Length)
                {
                    Output.WriteLine(ConsoleColor.Green, $"\nUnblocking Analytics Successful!");
                }
                else if (amountUp < analyticsURLs.Length)
                {
                    Output.WriteLine(ConsoleColor.Red, $"\nUnblocking Analytics partially FAILED!");
                }
                else
                {
                    Output.WriteLine(ConsoleColor.Red, $"\nUnblocking Analytics FAILED!");
                }
            }


            Output.WriteLine("====================================================================================");

            Output.WriteLine($"Process complete, press [ENTER] to exit");
            Console.ReadLine();
        }

        public static void BlockAnalytics(List<string> hostsFile, ref List<string> hostsFileEdited)
        {
            foreach (string url in analyticsURLs)
            {
                bool alreadyExists = false;

                foreach (string line in hostsFile)
                {
                    if (line.Contains(url))
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (alreadyExists)
                {
                    Output.WriteLine(ConsoleColor.Yellow, $"Analytic block already exists: {url}");
                }
                else
                {
                    Output.WriteLine(ConsoleColor.Green, $"Analytic block added: {url}");
                    hostsFileEdited.Add($"0.0.0.0 {url}");
                }
            }
        }

        public static void UnblockAnalytics(List<string> hostsFile, ref List<string> hostsFileEdited)
        {
            foreach (string line in hostsFile)
            {
                foreach (string url in analyticsURLs)
                {
                    if (line.Contains(url))
                    {
                        Output.WriteLine(ConsoleColor.Green, $"Analytic block removed: {line}");
                        hostsFileEdited.Remove(line);
                        break;
                    }
                }
            }
        }

        private static void SaveHostsFile(List<string> lines)
        {
            File.WriteAllLines(HostsFile, lines);
            Output.WriteLine(ConsoleColor.Green, $"\nSaved 'hosts' file");
        }

        private static List<string> GetHostsFile()
        {
            if (Directory.Exists(HostsFolder))
            {
                if (File.Exists(HostsFile))
                {
                    Output.WriteLine(ConsoleColor.Green, "'hosts' file found\n");
                    return File.ReadAllLines(HostsFile).ToList<string>();
                }
            }
            else
            {
                Directory.CreateDirectory(HostsFolder);
            }
            Output.WriteLine(ConsoleColor.Yellow, "'hosts' file not found, creating file\n");
            return new List<string>();
        }
    }
}
