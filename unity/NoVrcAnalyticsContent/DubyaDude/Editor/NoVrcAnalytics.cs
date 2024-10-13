using HarmonyLib;
using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;

/// <summary>
/// This script stops the VRChat SDK from throwing errors when trying to send analytics data and analytics are blocked.
/// https://github.com/DubyaDude/VRChat-Analytics-Blocker
/// </summary>
[InitializeOnLoad]
public class NoVrcAnalytics
{
    private static readonly Harmony _harmonyInstance;

    static NoVrcAnalytics()
    {
        _harmonyInstance = new Harmony("NoVrcAnalytics");

        try
        {
            var method = typeof(AmplitudeSDKWrapper.AmplitudeWrapper).GetMethod("PostEvents", BindingFlags.NonPublic | BindingFlags.Instance);
            _harmonyInstance.Patch(method, prefix: new HarmonyMethod(typeof(NoVrcAnalytics).GetMethod(nameof(Prefix))));
            Debug.Log("NoVrcAnalytics: Successfully patched AmplitudeWrapper.PostEvents");
        }
        catch (Exception e)
        {
            Debug.LogError("NoVrcAnalytics: Failed to patch AmplitudeWrapper.PostEvents: " + e);
        }
    }

    public static bool Prefix()
    {
        Debug.Log("NoVrcAnalytics: Blocked PostEvents call");
        return false;
    }
}
