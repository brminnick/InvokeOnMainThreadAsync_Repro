# InvokeOnMainThreadAsync_Repro
Reproduction sample for Xamarin.Forms.InvokeOnMainThreadAsync

## Reproduction Steps, iOS

1. Open `InvokeOnMainThreadAsync_Repro.sln` in Visual Studio or Visual Studio for Mac
2. Build/Deploy `InvokeOnMainThreadAsync_Repro.iOS` to an iOS Device or Simulator
3. Tap the Button titled `No Crash`
4. Confirm the animation completes successfully
5. Tap the Button titled `Crash1`
6. Confirm the app crashes with `NullReferenceException`
7. Build/Deploy `InvokeOnMainThreadAsync_Repro.iOS` to an iOS Device or Simulator
8. Tap the Button titled `Crash2`
9. Confirm the app crashes with `NullReferenceException`

## Reproduction Steps, Android

1. Open `InvokeOnMainThreadAsync_Repro.sln` in Visual Studio or Visual Studio for Mac
2. Build/Deploy `InvokeOnMainThreadAsync_Repro.Android` to an iOS Device or Simulator
3. Tap the Button titled `No Crash`
4. Confirm the animation completes successfully
5. Tap the Button titled `Crash1`
6. Confirm the app crashes with `NullReferenceException`
7. Build/Deploy `InvokeOnMainThreadAsync_Repro.Android` to an iOS Device or Simulator
8. Tap the Button titled `Crash2`
9. Confirm the app crashes with `NullReferenceException`


![](https://user-images.githubusercontent.com/13558917/60371567-7488ea80-99ae-11e9-8228-a1d8dcee6bc9.gif)

## Environment

=== Visual Studio Enterprise 2019 for Mac (Preview) ===

Version 8.2 Preview (8.2 build 874)
Installation UUID: cc9e7f9a-b3f2-4071-84c4-dd78154d98de
	GTK+ 2.24.23 (Raleigh theme)
	Xamarin.Mac 5.14.0.83 (d16-2 / f08d4e3e)

	Package version: 600000296

=== Mono Framework MDK ===

Runtime:
	Mono 6.0.0.296 (2019-02/1e9f3bfbc5a) (64-bit)
	Package version: 600000296

=== NuGet ===

Version: 5.1.0.6013

=== .NET Core ===

Runtime: /usr/local/share/dotnet/dotnet
Runtime Versions:
	3.0.0-preview6-27804-01
	3.0.0-preview5-27626-15
	3.0.0-preview3-27503-5
	3.0.0-preview-27324-5
	3.0.0-preview-27122-01
	2.2.4
	2.2.0
	2.2.0-preview3-27014-02
	2.1.9
	2.1.8
	2.1.6
	2.1.2
	2.1.1
	2.0.6
	2.0.5
	1.1.10
	1.0.13
SDK: /usr/local/share/dotnet/sdk/3.0.100-preview6-012264/Sdks
SDK Versions:
	3.0.100-preview6-012264
	3.0.100-preview5-011568
	2.2.203
	2.1.505
MSBuild SDKs: /Library/Frameworks/Mono.framework/Versions/6.0.0/lib/mono/msbuild/Current/bin/Sdks

=== Xamarin.Profiler ===

Version: 1.6.10
Location: /Applications/Xamarin Profiler.app/Contents/MacOS/Xamarin Profiler

=== Updater ===

Version: 11

=== Apple Developer Tools ===

Xcode 10.2.1 (14490.122)
Build 10E1001

=== Xamarin Designer ===

Version: 16.2.0.325
Hash: f10cfbf83
Branch: remotes/origin/d16-2
Build date: 2019-06-19 19:00:46 UTC

=== Xamarin.Android ===

Version: 9.4.0.34 (Visual Studio Enterprise)
Commit: xamarin-android/d16-2/7cce305
Android SDK: /Users/bramin/Library/Android/sdk
	Supported Android versions:
		6.0 (API level 23)
		7.0 (API level 24)
		7.1 (API level 25)
		8.0 (API level 26)
		8.1 (API level 27)

SDK Tools Version: 26.1.1
SDK Platform Tools Version: 28.0.2
SDK Build Tools Version: 28.0.3

Build Information: 
Mono: mono/mono/2019-02@c6edaa62f94
Java.Interop: xamarin/java.interop/d16-2@b2b2610
LibZipSharp: grendello/LibZipSharp/d16-2@caa0c74
LibZip: nih-at/libzip/rel-1-5-1@b95cf3f
ProGuard: xamarin/proguard/master@905836d
SQLite: xamarin/sqlite/3.27.1@8212a2d
Xamarin.Android Tools: xamarin/xamarin-android-tools/master@4f717b6

=== Microsoft Mobile OpenJDK ===

Java SDK: /Users/bramin/Library/Developer/Xamarin/jdk/microsoft_dist_openjdk_8.0.25
1.8.0-25
Android Designer EPL code available here:
https://github.com/xamarin/AndroidDesigner.EPL

=== Android Device Manager ===

Version: 1.2.0.58
Hash: d03e3ea
Branch: remotes/origin/d16-2
Build date: 2019-06-19 16:30:22 UTC

=== Xamarin.Mac ===

Version: 5.14.0.91 (Visual Studio Enterprise)
Hash: 2f1cc7bb
Branch: d16-2
Build date: 2019-06-07 02:49:23-0400

=== Xamarin.iOS ===

Version: 12.14.0.91 (Visual Studio Enterprise)
Hash: 2f1cc7bb
Branch: d16-2
Build date: 2019-06-07 02:49:22-0400

=== Xamarin Inspector ===

Version: 1.4.3
Hash: db27525
Branch: 1.4-release
Build date: Mon, 09 Jul 2018 21:20:18 GMT
Client compatibility: 1

=== Build Information ===

Release ID: 802000874
Git revision: e57770efe0d2b92ade1e1b75e52731614e5f9487
Build date: 2019-06-25 19:43:32+00
Build branch: release-8.2-preview2
Xamarin extensions: a74fb3eb8717fbcb82500b3a107694ad5185aa48

=== Operating System ===

Mac OS X 10.14.5
Darwin 18.6.0 Darwin Kernel Version 18.6.0
    Thu Apr 25 23:16:27 PDT 2019
    root:xnu-4903.261.4~2/RELEASE_X86_64 x86_64

=== Enabled user installed extensions ===

NuGet Package Management Extensions 0.19

