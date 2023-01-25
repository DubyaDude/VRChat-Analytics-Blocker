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
0.0.0.0 api.uca.cloud.unity3d.com
0.0.0.0 config.uca.cloud.unity3d.com
0.0.0.0 perf-events.cloud.unity3d.com
0.0.0.0 public.cloud.unity3d.com
0.0.0.0 cdp.cloud.unity3d.com
0.0.0.0 data-optout-service.uca.cloud.unity3d.com
0.0.0.0 ecommerce.iap.unity3d.com
```

- Make sure there is no # in the beginning of any of the lines you just added!
