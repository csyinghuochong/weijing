using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationAndroidArchive
    {
        public static string genApkName()
        {
            string type = "0";
            switch (OSDKIntegrationConfig.AndroidSdkType())
            {
                case "Android_Merge":
                    type = "1";
                    break;
                case "Android_GameId":
                    type = "2";
                    break;
                case "Android_Official":
                    type = "3";
                    break;
            }

            return $"{PlayerSettings.productName}_{type}";
        }
        
        internal static void ArchiveDebug()
        {
            BuildApk(true);
        }

        internal static void ArchiveRelease()
        {
            BuildApk(false);
        }
        
        public static void AutoArchiveRelease()
        {
            SwitchDemo();
            OSDKIntegrationHandler.FetchSDKConfigClickAction(OSDKPlatform.Android, false, false);
            BuildApk(false);
        }

        static void SwitchDemo()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();
            var relevantArgs = commandLineArgs.SkipWhile(arg => arg!= "-executeMethod")
                .Skip(1)
                .ToArray();
            
            var packageName = relevantArgs[1];
            var appSecret = relevantArgs[2];
            var osdkType = relevantArgs[3];
            Debug.Log("packageName:" + packageName + " appSercret: " + appSecret + " osdkType" + osdkType);
            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, packageName);
            OSDKIntegrationConfig.SetAppSecret(appSecret, true);
            OSDKIntegrationEditor.Instance.osdkTypeState = int.Parse(osdkType);

            // if (OSDKIntegrationPathUtils.LiveModuleImported)
            // {
            //     OSDKIntegrationEditor.Instance.pAndroidLiveTTWebcastID = DemoWebCastIdAndroidMode1;
            //     OSDKIntegrationEditor.Instance.pAndroidLiveTTSDKID = DemoTTSDKIdAndroidMode1;
            //     result = SetTTSDKLicense(DemoLiveTTSDKLicenseAndroidMode1, buildTarget);
            // }
            EditorUtility.SetDirty(OSDKIntegrationEditor.Instance);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private static void BuildApk(bool isDebug)
        {
            Debug.Log(isDebug ? "开始构建 Debug 环境APK包" : "开始构建 Release 环境APK包");

            var startTime = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
            var buildPlayerOptions = default(BuildPlayerOptions);
            buildPlayerOptions.scenes = GetBuildScenes();
            buildPlayerOptions.target = BuildTarget.Android;
            buildPlayerOptions.targetGroup = BuildTargetGroup.Android;
            buildPlayerOptions.locationPathName = Path.Combine(OSDKProjectPathUtils.SdkArchiveApkDirAndroid, 
                $"{genApkName()}.apk");
            var debugOptions = (BuildOptions.Development | BuildOptions.ConnectWithProfiler | BuildOptions.AllowDebugging);
            buildPlayerOptions.options = isDebug ? debugOptions : BuildOptions.None;
            var buildReport = BuildPipeline.BuildPlayer(buildPlayerOptions);

            var summary = buildReport.summary;
            if (summary.result == BuildResult.Succeeded)
            {
                var duration = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() - startTime;
                var msg = $"APK导出所用时间：{duration}秒\n导出路径为：{OSDKProjectPathUtils.SdkArchiveApkDirAndroid}";
                Debug.Log(msg);
                var isOpen = EditorUtility.DisplayDialog("恭喜(￣∇￣)APK导出完成", msg, "Open", "Cancel");
                if (isOpen)
                {
                    EditorUtility.RevealInFinder(OSDKProjectPathUtils.SdkArchiveApkDirAndroid);
                }
            }
        }
        
        // 找出所有需要构建的场景
        private static string[] GetBuildScenes()
        {
            var names = new List<string>();
            foreach (var settingsScene in EditorBuildSettings.scenes)
            {
                if (settingsScene == null)
                {
                    continue;
                }
                if (settingsScene.enabled)
                {
                    names.Add(settingsScene.path);
                }
            }
            return names.ToArray();
        }
    }
}