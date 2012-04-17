using System;
using MonoTouch.ObjCRuntime;

//[assembly: LinkWith ("libBump.a", LinkTarget.ArmV7 | LinkTarget.ArmV6 | LinkTarget.Simulator, ForceLoad = true )]
[assembly: LinkWith ("libBump.a", LinkTarget.ArmV7 | LinkTarget.ArmV6 | LinkTarget.Simulator, ForceLoad = true, Frameworks = "CFNetwork CoreLocation AudioToolbox", IsCxx = true)]