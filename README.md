# What does VRChat-Analytics-Blocker do?

It goes into your hosts file and modifies it so that any website/endpoint that is known for only collecting statistical data gets null routed (to 0.0.0.0 specifically)

__In Layman Terms:__ It makes it so the sites that collect any sort of statistical data cannot be reached.


Data collection is something users should have the ability to deny. This tool will help with some aspects of that for VRChat.

# I don't trust the EXE file!

That's fine. Here's what it basically does so you can do it yourself:

- Go to C:\Windows\System32\drivers\etc
- Edit the hosts file with a text editor
   - If it doesn't already exist, create a file called 'hosts' (with no extensions)
- Add the following, starting off in a new line:

```
0.0.0.0 api.amplitude.com
0.0.0.0 api2.amplitude.com
0.0.0.0 api.lab.amplitude.com
0.0.0.0 api.eu.amplitude.com
0.0.0.0 regionconfig.amplitude.com
0.0.0.0 regionconfig.eu.amplitude.com
0.0.0.0 o1125869.ingest.sentry.io
0.0.0.0 analytics.amplitude.com
0.0.0.0 analytics.eu.amplitude.com
0.0.0.0 api3.amplitude.com
0.0.0.0 cdn.amplitude.com
0.0.0.0 info.amplitude.com
0.0.0.0 static.amplitude.com
0.0.0.0 ads-brand-postback.unityads.unity3d.com
0.0.0.0 ads-game-configuration-master.ads.prd.ie.internal.unity3d.com
0.0.0.0 ads-game-configuration.unityads.unity3d.com
0.0.0.0 ads-privacy-api.prd.mz.internal.unity3d.com
0.0.0.0 adserver.unityads.unity3d.com
0.0.0.0 analytics.cloud.unity3d.com
0.0.0.0 analytics.social.unity.com
0.0.0.0 analytics.uca.cloud.unity3d.com
0.0.0.0 analytics.unity3d.com
0.0.0.0 api.uca.cloud.unity3d.com
0.0.0.0 auction.unityads.unity3d.com
0.0.0.0 cdp.cloud.unity3d.com
0.0.0.0 config.uca.cloud.unity3d.com
0.0.0.0 config.unityads.unity3d.com
0.0.0.0 data-optout-service.uca.cloud.unity3d.com
0.0.0.0 ecommerce.iap.unity3d.com
0.0.0.0 events.iap.unity3d.com
0.0.0.0 events.mz.unity3d.com
0.0.0.0 geocdn.unityads.unity3d.com
0.0.0.0 httpkafka.unityads.unity3d.com
0.0.0.0 mediation-tracking.prd.mz.internal.unity3d.com
0.0.0.0 perf-events.cloud.unity3d.com
0.0.0.0 public.cloud.unity3d.com
0.0.0.0 publisher-event.ads.prd.ie.internal.unity3d.com
0.0.0.0 thind-gke-euw.prd.data.corp.unity3d.com
0.0.0.0 tracking.prd.mz.internal.unity3d.com
0.0.0.0 unityads.unity3d.com
0.0.0.0 userreporting.cloud.unity3d.com
0.0.0.0 webview.unityads.unity3d.com
```

- Make sure there is no # in the beginning of any of the lines you just added!
