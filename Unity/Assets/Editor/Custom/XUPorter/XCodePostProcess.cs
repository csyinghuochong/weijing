
#if UNITY_IPHONE

using UnityEngine;
using System;
using System.IO;
using AppleAuth.Editor;
using System.Collections.Generic;
using PBXProject = UnityEditor.iOS.Xcode.PBXProject;

#if UNITY_EDITOR
using UnityEditor;
using UnityEditor.iOS.Xcode;
using UnityEditor.Callbacks;
using UnityEditor.XCodeEditor;
#endif

public static class XCodePostProcess
{

#if UNITY_EDITOR

	public static void SetUrlSchemes(PlistDocument plist)
	{
        List<string> urllist = new List<string>()
            {
                "taptap",
			    "sinaweibosso",
				"weibo",
				"weibosdk",
				"weibosdk2.5",
				"sinaweibo",
				"sinaweibohd",
				"weixin",
				"wechat",
				"weixinULAPI",
				"mqq",
				"mqqapi",
				"mqqwpa",
				"mqqbrowser",
				"mttbrowser",
				"mqqOpensdkSSoLogin",
				"mqqopensdkapiV2",
				"mqqopensdkapiV3",
				"mqqopensdkapiV4",
				"wtloginmqq2",
				"mqzone",
				"mqzoneopensdk",
				"mqzoneopensdkapi",
				"mqzoneopensdkapi19",
				"mqzoneopensdkapiV2",
				"mqqapiwallet",
				"mqqopensdkfriend",
				"mqqopensdkdataline",
				"mqqgamebindinggroup",
				"mqqopensdkgrouptribeshare",
				"tencentapi.qq.reqContent",
				"tencentapi.qzone.reqContent",
				"tim",
				"timapi",
				"timopensdkfriend",
				"timwpa",
				"timgamebindinggroup",
				"timapiwallet",
				"timOpensdkSSoLogin",
				"wtlogintim",
				"timopensdkgrouptribeshare",
				"timopensdkapiV4",
				"timopensdkdataline",
				"wtlogintimV1",
				"timapiV1",
				"mqqopensdkminiapp",
				"tapsdk",
				"tapiosdk",
			};

        PlistElementArray plistDocument;
		plistDocument = plist.root.CreateArray("LSApplicationQueriesSchemes");

		 // 删除Key
		// 删除NSUserTrackingUsageDescription键
        if (plist.root.values.ContainsKey("NSUserTrackingUsageDescription"))
        {
            plist.root.values.Remove("NSUserTrackingUsageDescription");
        }


        foreach (var url in urllist)
        {
            plistDocument.AddString(url);
        }
	}

	public static class SignInWithApplePostprocessor
	{
		[PostProcessBuild(1)]
		public static void OnPostProcessBuild(BuildTarget target, string path)
		{
			if (target != BuildTarget.StandaloneOSX)
				return;

			AppleAuthMacosPostprocessorHelper.FixManagerBundleIdentifier(target, path);
		}
	}

	[PostProcessBuild(999)]
	public static void OnPostProcessBuild( BuildTarget target, string pathToBuiltProject )
	{
		UnityEngine.Debug.Log("PostProcess_1");
        if (target != BuildTarget.iOS)
		{
			Debug.LogWarning("Target is not iPhone. XCodePostProcess will not run");
			return;
		}


		
		 var projectPath = PBXProject.GetPBXProjectPath(pathToBuiltProject);
        
        // Adds entitlement depending on the Unity version used
#if UNITY_2019_3_OR_NEWER
            var project_000 = new PBXProject();
			project_000.ReadFromString(System.IO.File.ReadAllText(projectPath));
            var manager = new ProjectCapabilityManager(projectPath, "Entitlements.entitlements", null, project_000.GetUnityMainTargetGuid());
            manager.AddSignInWithAppleWithCompatibility(project_000.GetUnityFrameworkTargetGuid());

			manager.AddInAppPurchase();
			manager.AddPushNotifications(true);

			string[] domains = new string[] { "applinks:c4ovz.share2dlink.com", "applinks:bj2ks.share2dlink.com", "applinks:ahmn.t4m.cn" };

			manager.AddAssociatedDomains(domains);

            manager.WriteToFile();
#else
            var manager = new ProjectCapabilityManager(projectPath, "Entitlements.entitlements", PBXProject.GetUnityTargetName());
            manager.AddSignInWithAppleWithCompatibility();
            manager.WriteToFile();
#endif
		

		UnityEngine.Debug.Log("PostProcess_1: " + pathToBuiltProject);
		// Create a new project object from build target

		XCProject project = new XCProject( pathToBuiltProject );

		// Find and run through all projmods files to patch the project.
		// Please pay attention that ALL projmods files in your project folder will be excuted!
		string[] files = Directory.GetFiles( Application.dataPath, "*.projmods", SearchOption.AllDirectories );
		foreach( string file in files ) {
			UnityEngine.Debug.Log("ProjMod File: "+file);
			//project.ApplyMod( file );
		}

		//TODO disable the bitcode for iOS 9
		project.overwriteBuildSetting("ENABLE_BITCODE", "NO", "Release");
		project.overwriteBuildSetting("ENABLE_BITCODE", "NO", "Debug");
		
		//TODO implement generic settings as a module option
		//		project.overwriteBuildSetting("CODE_SIGN_IDENTITY[sdk=iphoneos*]", "iPhone Distribution", "Release");

		var mainAppPath = Path.Combine(pathToBuiltProject, "MainApp", "main.mm");
		var mainContent = File.ReadAllText(mainAppPath);
		var newContent = mainContent.Replace("#include <UnityFramework/UnityFramework.h>", @"#include ""../UnityFramework/UnityFramework.h""");
		File.WriteAllText(mainAppPath, newContent);

		string path_1 = "//Users/tangzhen/project/gitwj/Unity/HybridCLRData/iOSBuild/build/libil2cpp.a";
		string path_2 = "//Users/tangzhen/project/gitwj/Unity/ios/Libraries/libil2cpp.a";
		File.Copy(path_1, path_2, true);

		// 修改Info.plist文件
		string plistPath = Path.Combine(pathToBuiltProject, "Info.plist");
		PlistDocument plist = new PlistDocument();
		plist.ReadFromFile(plistPath);

		plist.root.SetString("NSPhotoLibraryUsageDescription", "保存照片到系统相册");
		plist.root.SetBoolean("App Uses Non-Exempt Encryption", false);
		SetUrlSchemes(plist);

		plist.WriteToFile(plistPath);

		// Finally save the xcode project
		project.Save();
		UnityEngine.Debug.Log("PostProcess_2");
	}
#endif

	public static void Log(string message)
	{
		UnityEngine.Debug.Log("PostProcess: "+message);
	}
}

#endif