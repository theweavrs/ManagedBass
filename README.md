# ManagedBass
(c) Mathew Sachin  
Free Open-Source Cross-Platform .Net Wrapper for Un4seen Bass and its AddOns.

Bass and its Add-Ons can be downloaded at http://un4seen.com/  
ManagedBass is targeted for **Any CPU**, but bass Libraries(.dll/.so/.dylib/.a) are separate for x86, x64, ARM, etc.  
Download the versions you need.

See the [Sample Repositories](https://github.com/ManagedBass) for examples.

> ManagedBass depends on [ManagedBass.PInvoke](https://github.com/ManagedBass/ManagedBass.PInvoke) for PInvoke declarations which is quite stable package.

Getting Started
-----------------------------------------
* Install the NuGet package
```powershell
Install-Package ManagedBass
```

* Download the BASS libraries from http://un4seen.com and place them in Build Output Directory.

See https://github.com/ManagedBass/Home for more info.

# Changes coming in v1.0
- The code in this repository will be replaced by that in https://github.com/ManagedBass/ManagedBass.vNext.
- The NuGet package will be split per AddOn.
- ManagedBass.PInvoke package will be discontinued.
- The current repository will be moved to some other repository and package.