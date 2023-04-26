namespace VRChat_Analytics_Blocker
{
    public static class Constants
    {
        public const string Version = "1.2.0.0";

        public static readonly string[] AnalyticsURLs = new string[]
        {
            // VRChat Specific (Proven to use/have used)
            "api.amplitude.com",
            "api2.amplitude.com",
            "api.lab.amplitude.com",

            // VRChat Specific (Hasn't used yet, added for future proofing)
            "api3.amplitude.com",
            "api.eu.amplitude.com",

            // Unity Specific
            "api.uca.cloud.unity3d.com",
            "config.uca.cloud.unity3d.com",
            "perf-events.cloud.unity3d.com",
            "public.cloud.unity3d.com",
            "cdp.cloud.unity3d.com",
            "data-optout-service.uca.cloud.unity3d.com",
            "ecommerce.iap.unity3d.com",
            
            // No longer up
            // "stats.unity3d.com",
        };
    }
}
