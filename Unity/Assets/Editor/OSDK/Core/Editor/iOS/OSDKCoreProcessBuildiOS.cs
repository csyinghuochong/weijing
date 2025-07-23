#if UNITY_EDITOR && UNITY_IOS
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKCoreProcessBuildiOS
    {
        [PostProcessBuild((int)PostProcessBuildCallBackOrder.Core)]
        private static void OnPostprocessBuild(BuildTarget buildTarget, string buildPath)
        {
            if (buildTarget != BuildTarget.iOS) return;
            
            var projPath = PBXProject.GetPBXProjectPath(buildPath);
            var proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));
            
            var mainTargetGuid = OSDKXcodeProjectUtils.GetMainTargetGuid(proj);
            
            // 添加Json文件，Demo场景文件在Sample Editor中处理
            AddSDKConfigJson(buildPath, proj);
            
            // 添加framework
            var frameworks = new []
            {
                "Foundation.framework",
                "UIKit.framework",
            };
            var optionsFrameworks = new[]
            {
                "ApptrackingTransparency.framework",
            };
            OSDKXcodeProjectUtils.AddFrameworks(proj, frameworks);
            OSDKXcodeProjectUtils.AddFrameworks(proj, optionsFrameworks, mainTargetGuid, true);
            // 添加动态库
            var embedFrameworkDir = "Frameworks/OSDK/Core/Plugins/iOS";
            var embedFrameworks = new[]
            {
                "UnionOpenPlatformCore.framework",
            };
            OSDKXcodeProjectUtils.AddEmbedFrameworks(proj, embedFrameworkDir, embedFrameworks, mainTargetGuid);
            // 设置bitcode和Other link flags
            var otherLinkFlags = new List<string>()
            {
                "-ObjC",
            };
            OSDKXcodeProjectUtils.AddBuildProperty(proj,"OTHER_LDFLAGS", otherLinkFlags);
            OSDKXcodeProjectUtils.SetBuildProperty(proj,"ENABLE_BITCODE", "NO");
            OSDKXcodeProjectUtils.SetBuildProperty(proj, "LD_GENERATE_MAP_FILE", "YES");
            // 添加权限描述
            var permissionDescription = "该标识符用于向您推送个性化服务";
            if (!string.IsNullOrEmpty(OSDKIntegrationEditor.Instance.iOSUserTrackingUsageDescription)) {
                 permissionDescription = OSDKIntegrationEditor.Instance.iOSUserTrackingUsageDescription;
            }
            var appendInfo = new Hashtable
            {
                {"NSUserTrackingUsageDescription", permissionDescription},
            };
            OSDKXcodeProjectUtils.AddInfoPlistProperties(buildPath,appendInfo);
            // 保存修改
            OSDKXcodeProjectUtils.SaveProject(proj, projPath);
        }

        private static void AddSDKConfigJson(string buildPath, PBXProject proj)
        {
            var mainTargetGuid = OSDKXcodeProjectUtils.GetMainTargetGuid(proj);
            OSDKIntegrationHandler.WriteIOSJsonFile();
            var targetDir = $"{buildPath}/OSDKData";
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
            if (File.Exists(OSDKIntegrationPathUtils.ConfigJsonFilePathIOS))
            {
                var targetPath = $"{targetDir}/{OSDKIntegrationPathUtils.ConfigJsonFileNameIOS}";
                File.Copy(OSDKIntegrationPathUtils.ConfigJsonFilePathIOS, targetPath, true);
                var path = $"OSDKData/{OSDKIntegrationPathUtils.ConfigJsonFileNameIOS}";
                var fileGuid = proj.AddFile(path, path);
                proj.AddFileToBuild(mainTargetGuid, fileGuid);
            }
            // 直播证书
            if (File.Exists(OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicensePathIOS))
            {
                var targetPath = $"{targetDir}/{OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicenseFileName}";
                File.Copy(OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicensePathIOS, targetPath, true);
                var path = $"OSDKData/{OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicenseFileName}";
                var fileGuid = proj.AddFile(path, path);
                proj.AddFileToBuild(mainTargetGuid, fileGuid);
            }
            // msext证书
            if (File.Exists(OSDKIntegrationPathUtils.ConfigFromLocalTTLiveMsextPathIOS))
            {
                var targetPath = $"{targetDir}/{OSDKIntegrationPathUtils.ConfigFromLocalTTLiveMsextFileNameIOS}";
                File.Copy(OSDKIntegrationPathUtils.ConfigFromLocalTTLiveMsextPathIOS, targetPath, true);
                var path = $"OSDKData/{OSDKIntegrationPathUtils.ConfigFromLocalTTLiveMsextFileNameIOS}";
                var fileGuid = proj.AddFile(path, path);
                proj.AddFileToBuild(mainTargetGuid, fileGuid);
            }
        }
    }
}

#endif