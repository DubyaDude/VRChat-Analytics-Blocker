namespace VRChat_Analytics_Blocker
{
    public static class Constants
    {
        public const string Version = "1.4.0.0";

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
            "analytics.amplitude.com",
            "analytics.eu.amplitude.com",
            "api3.amplitude.com",
            "cdn.amplitude.com",
            "info.amplitude.com",
            "static.amplitude.com",

            // Unity Specific
            "ads-brand-postback.unityads.unity3d.com",
            "ads-game-configuration-master.ads.prd.ie.internal.unity3d.com",
            "ads-game-configuration.unityads.unity3d.com",
            "ads-privacy-api.prd.mz.internal.unity3d.com",
            "adserver.unityads.unity3d.com",
            "analytics.cloud.unity3d.com",
            "analytics.social.unity.com",
            "analytics.uca.cloud.unity3d.com",
            "analytics.unity3d.com",
            "api.uca.cloud.unity3d.com",
            "auction.unityads.unity3d.com",
            "cdp.cloud.unity3d.com",
            "config.uca.cloud.unity3d.com",
            "config.unityads.unity3d.com",
            "data-optout-service.uca.cloud.unity3d.com",
            "ecommerce.iap.unity3d.com",
            "events.iap.unity3d.com",
            "events.mz.unity3d.com",
            "geocdn.unityads.unity3d.com",
            "httpkafka.unityads.unity3d.com",
            "mediation-tracking.prd.mz.internal.unity3d.com",
            "perf-events.cloud.unity3d.com",
            "public.cloud.unity3d.com",
            "publisher-event.ads.prd.ie.internal.unity3d.com",
            "thind-gke-euw.prd.data.corp.unity3d.com",
            "tracking.prd.mz.internal.unity3d.com",
            "unityads.unity3d.com",
            "userreporting.cloud.unity3d.com",
            "webview.unityads.unity3d.com",
            
            // No longer up
            // "stats.unity3d.com",
        };
    }
}
