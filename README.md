# VRChat-Analytics-Blocker
Data collection is something users should have the ability to deny. This tool will help with some aspects of that for VRChat.

## How to block analytics
### Method 1 (Run the executable):
 - Run the [latest release](https://github.com/DubyaDude/VRChat-Analytics-Blocker/releases/latest) of VRChat-Analytics-Blocker.exe as admin.
   - The executable does `Method 2` automatically, adding to Windows's 'hosts' file.

### Method 2 (Manually edit Windows's 'hosts' file):
- Go to C:\Windows\System32\drivers\etc
- Edit the 'hosts' file with a text editor as admin.
   - If it doesn't already exist, create a file called 'hosts' (with no file extension).
- Copy and paste everything [here](https://raw.githubusercontent.com/DubyaDude/VRChat-Analytics-Blocker/refs/heads/master/blocklist/hosts.txt) on a new line in the file.
- Save it!

### Method 3 (Adding the blocklist to existing adblocking tools):
- Add the following link to your adblocking tool:

```
https://raw.githubusercontent.com/DubyaDude/VRChat-Analytics-Blocker/refs/heads/master/blocklist/hosts.txt
```

## How to fix VRChat's SDK after blocking analytics
You may run into errors in the VRChat SDK while analytics are blocked.
- Import [this unity package](https://github.com/DubyaDude/VRChat-Analytics-Blocker/raw/refs/heads/master/unity/NoVrcAnalytics.unitypackage) into your project
