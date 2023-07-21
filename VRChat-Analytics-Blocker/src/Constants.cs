namespace VRChat_Analytics_Blocker
{
    public static class Constants
    {
        public const string Version = "1.3.0.0";

        public static readonly string[] AnalyticsURLs = new string[]
        {
            // VRChat Specific (Proven to use/have used)
            "api.amplitude.com",
            "api2.amplitude.com",
            "api.lab.amplitude.com",
            "api.eu.amplitude.com",
            "regionconfig.amplitude.com",
            "regionconfig.eu.amplitude.com",
            "o1125869.ingest.sentry.io",

            // VRChat Specific (Hasn't used yet, added for future proofing)
            "api3.amplitude.com",
            "cdn.amplitude.com",
            "info.amplitude.com",
            "static.amplitude.com",

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
