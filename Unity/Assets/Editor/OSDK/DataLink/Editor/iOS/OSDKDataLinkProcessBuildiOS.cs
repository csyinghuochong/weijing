#if UNITY_EDITOR && UNITY_IOS
using System.Collections;
using System.IO;
using Douyin.Game;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace OSDK.Douyin.Editor.iOS
{
    public class OSDKDataLinkProcessBuildiOS
    {
        [PostProcessBuild((int)PostProcessBuildCallBackOrder.DataLink)]
        private static void OnPostprocessBuild(BuildTarget buildTarget, string buildPath)
        {
            if (buildTarget != BuildTarget.iOS) return;

            // 需要还原文件夹重命名时，直接return，不需要加Framework
            string newFolderPath = OSDKProjectPathUtils.DataLinkModuleDir;
            string oldFolderPath = OSDKProjectPathUtils.DataLinkModuleDir + "~";

            if (OSDKIntegrationPathUtils.SDKDeveloperExists && Directory.Exists(oldFolderPath))
            {
                Directory.Move(oldFolderPath, newFolderPath);
                AssetDatabase.Refresh();
                return;
            }
            
            var projPath = PBXProject.GetPBXProjectPath(buildPath);
            var proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));

            var mainTargetGuid = OSDKXcodeProjectUtils.GetMainTargetGuid(proj);
            var scheme = "dygame" + OSDKIntegrationConfig.AppID(OSDKPlatform.iOS);
            // 添加 Schemes && URL Types
            var bundleURLTypes = new ArrayList(1)
            {
                new Hashtable(3)
                {
                    { "CFBundleTypeRole", "Editor" },
                    { "CFBundleURLSchemes", new ArrayList(1) { scheme } },
                    { "CFBundleURLName",  "dygame"}
                }
            };
            var appendInfo = new Hashtable
            {
                {
                    "CFBundleURLTypes", bundleURLTypes
                },
            };
            OSDKXcodeProjectUtils.AddInfoPlistProperties(buildPath, appendInfo);
            // 添加动态库
            var embedFrameworkDir = "Frameworks/OSDK/DataLink/Plugins/iOS";
            var embedFrameworks = new[]
            {
                "UnionOpenPlatformDataLink.framework",
            };
            OSDKXcodeProjectUtils.AddEmbedFrameworks(proj, embedFrameworkDir, embedFrameworks, mainTargetGuid);
            // 保存修改
            OSDKXcodeProjectUtils.SaveProject(proj, projPath);
        }
    }

    public class OSDKDataLinkPreProcessBuildiOS : IPreprocessBuildWithReport
    {
        public int callbackOrder => (int)PostProcessBuildCallBackOrder.DataLink;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.iOS) return;

            OSDKIntegrationConfig.BizMode bizMode = OSDKIntegrationConfig.GetBizMode();
            if (OSDKIntegrationPathUtils.SDKDeveloperExists && bizMode != OSDKIntegrationConfig.BizMode.OmniChannel) {
                // 文件夹重命名
                string oldFolderPath = OSDKProjectPathUtils.DataLinkModuleDir;
                string newFolderPath = OSDKProjectPathUtils.DataLinkModuleDir + "~";

                if (Directory.Exists(oldFolderPath))
                {
                    Directory.Move(oldFolderPath, newFolderPath);
                    AssetDatabase.Refresh();
                }
            }

        }
    }
}
#endif