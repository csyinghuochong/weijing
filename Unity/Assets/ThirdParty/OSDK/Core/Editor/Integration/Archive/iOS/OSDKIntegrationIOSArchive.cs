using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using System;
#if UNITY_EDITOR && UNITY_IOS
using UnityEditor.Build.Reporting;
using UnityEditor.iOS.Xcode;
#endif
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationIOSArchive
    {
        // ReSharper disable Unity.PerformanceAnalysis
        internal static void ArchiveDebug()
        {
            Debug.Log("开始构建 Debug 环境IPA包");
            BuildIPA(true);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        internal static void ArchiveRelease()
        {
            Debug.Log("开始构建 Release 环境IPA包");
            BuildIPA(false);
        }

        internal static void AutoArchiveRelease()
        {
            SwitchDemo();
            OSDKIntegrationHandler.FetchSDKConfigClickAction(OSDKPlatform.iOS, false, false);
            Debug.Log("Auto Release 环境IPA包");
            BuildIPA(false);
        }

        static void SwitchDemo()
        {
            var commandLineArgs = Environment.GetCommandLineArgs();
            var relevantArgs = commandLineArgs.SkipWhile(arg => arg!= "-executeMethod")
                                      .Skip(1)
                                      .ToArray();

            // relevantArgs[0] 是执行函数名
            var bundleIdParam = relevantArgs[1];
            var appSecretParam = relevantArgs[2];
            var osdkTypeParam = relevantArgs[3];

            PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.iOS, bundleIdParam);
            OSDKIntegrationConfig.SetAppSecret(appSecretParam, true);
            OSDKIntegrationEditor.Instance.osdkTypeState = int.Parse(osdkTypeParam);

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

        internal static void ExportXcodeProject(bool isDebug)
        {
#if UNITY_EDITOR && UNITY_IOS
            var summary = Export(isDebug);
            if (summary.result == BuildResult.Succeeded)
            {
                var exportDir = $"导出路径为 = {OSDKProjectPathUtils.SdkArchiveXcodeProjectDir}";
                var isOk = EditorUtility.DisplayDialog("Xcode 工程导出成功,是否打开目录?",
                    exportDir,
                    "Open",
                    "Cancel");
                if (isOk)
                {
                    EditorUtility.RevealInFinder(OSDKProjectPathUtils.SdkArchiveXcodeProjectDir);
                }
            }
            else
            {
                EditorUtility.DisplayDialog("Xcode 工程导出失败", summary.result.ToString(), "OK");
            }
#endif
        }

        private static void BuildIPA(bool isDebug)
        {
#if UNITY_EDITOR && UNITY_IOS
            var summary = Export(isDebug);
            if (summary.result == BuildResult.Succeeded)
            {
                ExecuteArchiveCmd(isDebug);
            }
            else
            {
                EditorUtility.DisplayDialog("Xcode 工程导出失败", summary.totalErrors.ToString(), "OK");
            }
#endif
        }
#if UNITY_EDITOR && UNITY_IOS
        private static void ExecuteArchiveCmd(bool isDebug)
        {
            // 写Plist文件
            AutoWriteExportOptPlist(isDebug);
            // 授权
            OSDKIntegrationUtils.AccessBashShell(OSDKProjectPathUtils.SdkArchiveExportIpaShellPath);
            // 构建
            var cmd = GetArchiveIOSCmd(isDebug);
            EditorUtility.DisplayProgressBar("Build IPA","正在执行编译脚本导出ipa,请耐心等待....",0.5f);
            var result = OSDKIntegrationUtils.ExecuteBashShellCommand(cmd);
            EditorUtility.ClearProgressBar();
            if (result.ExitCode == 0)
            {
                //脚本执行正常
                var productPath = OSDKProjectPathUtils.SdkArchiveXcodeProductsDir;
                var isOpen = EditorUtility.DisplayDialog("IPA导出成功", $"导出路径为:{productPath}", "打开IPA包目录");
                if (isOpen)
                {
                    EditorUtility.RevealInFinder(productPath + "/Archive"); 
                }
                OSDKIntegrationRecord.ExportIpa(true);
            }
            else
            {
                var isOpen = EditorUtility.DisplayDialog("IPA导出失败", $"导出失败({result.StandardOutput})", "查看构建日志");
                if (isOpen)
                {
                    EditorUtility.RevealInFinder(OSDKProjectPathUtils.SdkArchiveXcodeLogsDir); 
                }
                OSDKIntegrationRecord.ExportIpa(false);
            }
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private static BuildSummary Export(bool isDebug)
        {
            PlayerSettings.iOS.iOSManualProvisioningProfileType =
                isDebug ? ProvisioningProfileType.Development : ProvisioningProfileType.Distribution;
            // 文件创建准备
            PrepareDir();
            // 配置PlaySettings信息
            SetupPlayerSettings(isDebug);
            // 获取打包配置
            var buildPlayerOptions = GetBuildOptions(isDebug);
            // BuildPlayer
            var buildReport = BuildPipeline.BuildPlayer(buildPlayerOptions);
            var summary = buildReport.summary;
            if (summary.result == BuildResult.Succeeded)
            {
                Debug.Log("Export Xcode Project successes.");
            }
            else if (summary.result == BuildResult.Failed)
            {
                Debug.LogError("Export Xcode Project failed : " + summary.totalErrors);
            }
            else
            {   
                Debug.Log($"Export Xcode Project {summary.result}");
            }
            return summary;
        }

        #region 辅助函数
        
        // 配置PlayerSettings
        private static void SetupPlayerSettings(bool isDebug)
        {
            if (PlayerSettings.iOS.appleEnableAutomaticSigning) return;
            // 手动管理证书
            PlayerSettings.iOS.iOSManualProvisioningProfileType =
                isDebug ? ProvisioningProfileType.Development : ProvisioningProfileType.Distribution;
            // Provisioning Profile UUID
            var iOSManualProvisioningProfileID = isDebug
                ? OSDKIntegrationEditor.Instance.developmentProfileUuid
                : OSDKIntegrationEditor.Instance.productionProfileUuid;
            if (!string.IsNullOrWhiteSpace(iOSManualProvisioningProfileID))
            {
                PlayerSettings.iOS.iOSManualProvisioningProfileID = iOSManualProvisioningProfileID;
            }
            // Team ID
            var archiveProfileTeamID = OSDKIntegrationEditor.Instance.archiveProfileTeamID;
            if (!string.IsNullOrWhiteSpace(archiveProfileTeamID))
            {
                PlayerSettings.iOS.appleDeveloperTeamID = archiveProfileTeamID;
            }
        }
        
        // 获取构建信息
        private static BuildPlayerOptions GetBuildOptions(bool isDebug)
        {
            var buildPlayerOptions = default(BuildPlayerOptions);
            buildPlayerOptions.scenes = GetBuildScenes();
            buildPlayerOptions.locationPathName = OSDKProjectPathUtils.SdkArchiveXcodeProjectDir;
            buildPlayerOptions.targetGroup = BuildTargetGroup.iOS;
            buildPlayerOptions.target = BuildTarget.iOS;
            buildPlayerOptions.options = BuildOptions.None;
#if UNITY_2021_2_OR_NEWER
            EditorUserBuildSettings.iOSXcodeBuildConfig = isDebug ? XcodeBuildConfig.Debug : XcodeBuildConfig.Release;
#else
            EditorUserBuildSettings.iOSBuildConfigType = isDebug ? iOSBuildType.Debug : iOSBuildType.Release;
#endif
            return buildPlayerOptions;
        }

        // 文件目录创建准备
        private static void PrepareDir()
        {
            // 如果存在此目录则直接删除
            if (Directory.Exists(OSDKProjectPathUtils.SdkArchiveXcodeProjectDir))
            {
                Directory.Delete(OSDKProjectPathUtils.SdkArchiveXcodeProjectDir,true);
            }
            // 信息准备目录创建
            if (!Directory.Exists(OSDKProjectPathUtils.SdkArchiveXcodePrepareInfoDebugDir))
            {
                Directory.CreateDirectory(OSDKProjectPathUtils.SdkArchiveXcodePrepareInfoDebugDir);
            }
            if (!Directory.Exists(OSDKProjectPathUtils.SdkArchiveXcodePrepareInfoProductDir))
            {
                Directory.CreateDirectory(OSDKProjectPathUtils.SdkArchiveXcodePrepareInfoProductDir);
            }
            // 构建结果目录
            if (Directory.Exists(OSDKProjectPathUtils.SdkArchiveXcodeProductsDir))
            {
                Directory.Delete(OSDKProjectPathUtils.SdkArchiveXcodeProductsDir,true);
            }
            Directory.CreateDirectory(OSDKProjectPathUtils.SdkArchiveXcodeProductsDir);
            // Logs
            if (Directory.Exists(OSDKProjectPathUtils.SdkArchiveXcodeLogsDir))
            {
                Directory.Delete(OSDKProjectPathUtils.SdkArchiveXcodeLogsDir,true);
            }
            Directory.CreateDirectory(OSDKProjectPathUtils.SdkArchiveXcodeLogsDir);
        }
        
        private static void AutoWriteExportOptPlist(bool isDebug)
        {
            var bundleid = OSDKIntegrationConfig.BundleId(OSDKPlatform.iOS);
            var provisioningProfiles = new Hashtable();
            var exportPlistTable = new Hashtable
            {
                {"compileBitcode", false},
                {"uploadBitcode", false},
                {"manageAppVersionAndBuildNumber", true},
                {"destination", "export"},
                {"signingStyle", "manual"},
                {"provisioningProfiles", provisioningProfiles},
                {"stripSwiftSymbols", true},
                {"testFlightInternalTestingOnly", false}
            };
            if (isDebug)
            {
                exportPlistTable["method"] = "development";
                exportPlistTable["signingCertificate"] = "Apple Development";
                exportPlistTable["teamID"] = PlayerSettings.iOS.appleDeveloperTeamID;
                var developmentProfileID = PlayerSettings.iOS.iOSManualProvisioningProfileID;
                provisioningProfiles[bundleid] = developmentProfileID;

                var developmentPushProfileID = OSDKIntegrationEditor.Instance.developmentPushUuid;
                var developmentPushEnable = OSDKIntegrationEditor.Instance.iosNeedPushExtension;
                // 推送文件
                if (developmentPushEnable && !string.IsNullOrWhiteSpace(developmentPushProfileID))
                {
                    provisioningProfiles[$"{bundleid}.NotificationExtension"] =
                        developmentPushProfileID;
                }
            }
            else
            {
                exportPlistTable["method"] = "enterprise";
                exportPlistTable["signingCertificate"] = "Apple Distribution";
                exportPlistTable["teamID"] = PlayerSettings.iOS.appleDeveloperTeamID;
                exportPlistTable["uploadSymbols"] = true;
                var productionProfileID = PlayerSettings.iOS.iOSManualProvisioningProfileID;
                provisioningProfiles[bundleid] = productionProfileID;

                var productionPushProfileID = OSDKIntegrationEditor.Instance.productionPushUuid;
                var productionPushEnable = OSDKIntegrationEditor.Instance.iosNeedPushExtension;
                // 推送文件
                if (productionPushEnable && !string.IsNullOrWhiteSpace(productionPushProfileID))
                {
                    provisioningProfiles[$"{bundleid}.NotificationExtension"] =
                        productionPushProfileID;
                }
            }
            var plist = new PlistDocument();
            plist.Create();
            var rootDict = plist.root;
            OSDKXcodeProjectUtils.SetPlist(rootDict, exportPlistTable);
            //写入
            plist.WriteToFile(isDebug ? OSDKProjectPathUtils.SdkArchiveXcodeExportOptPlistDebugPath : OSDKProjectPathUtils.SdkArchiveXcodeExportOptPlistProductPath);
        }

        private static string GetArchiveIOSCmd(bool isDebug)
        {
            var env = isDebug ? "Debug" : "Release";
            var xcodeProDir = OSDKProjectPathUtils.SdkArchiveXcodeProjectDir;
            return $"{OSDKProjectPathUtils.SdkArchiveExportIpaShellPath} {env} {xcodeProDir}";
        }

        private static string[] GetBuildScenes()
        {
            var names = new List<string>();
            foreach (var e in EditorBuildSettings.scenes)
            {
                if (e == null)
                    continue;
                if (e.enabled)
                    names.Add(e.path);
            }
            return names.ToArray();
        }

        #endregion
#endif
    }
}