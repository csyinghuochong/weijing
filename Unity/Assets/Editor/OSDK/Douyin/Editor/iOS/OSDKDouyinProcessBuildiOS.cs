#if UNITY_EDITOR && UNITY_IOS
using System.Collections;
using System.IO;
using Douyin.Game;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

namespace OSDK.Douyin.Editor.iOS
{
    public class OSDKDouyinProcessBuildiOS
    {
        [PostProcessBuild((int)PostProcessBuildCallBackOrder.Douyin)]
        private static void OnPostprocessBuild(BuildTarget buildTarget, string buildPath)
        {
            if (buildTarget != BuildTarget.iOS) return;
            
            var projPath = PBXProject.GetPBXProjectPath(buildPath);
            var proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));
            
            var mainTargetGuid = OSDKXcodeProjectUtils.GetMainTargetGuid(proj);
            // 添加 Schemes && URL Types
            var bundleURLTypes = new ArrayList(1)
            {
                new Hashtable(3)
                {
                    { "CFBundleTypeRole", "Editor" },
                    { "CFBundleURLSchemes", new ArrayList(1) { OSDKIntegrationConfig.ClientKey(OSDKPlatform.iOS) } },
                    { "CFBundleURLName",  "douyin"}
                }
            };
            var appendInfo = new Hashtable
            {
                {
                    "LSApplicationQueriesSchemes", new ArrayList(3) {
                        "douyinopensdk",
                        "douyinliteopensdk",
                        "snssdk1128"
                    }
                },
                {
                    "CFBundleURLTypes", bundleURLTypes
                },
            };
            OSDKXcodeProjectUtils.AddInfoPlistProperties(buildPath, appendInfo);
            // 添加动态库
            var embedFrameworkDir = "Frameworks/OSDK/Douyin/Plugins/iOS";
            var embedFrameworks = new[]
            {
                "DouyinOpenSDK.framework",
                "BDTicketGuard.framework",
                "UnionOpenPlatformDouyin.framework",
            };
            OSDKXcodeProjectUtils.AddEmbedFrameworks(proj, embedFrameworkDir, embedFrameworks, mainTargetGuid);
            // 保存修改
            OSDKXcodeProjectUtils.SaveProject(proj, projPath);
        }
    }
}
#endif