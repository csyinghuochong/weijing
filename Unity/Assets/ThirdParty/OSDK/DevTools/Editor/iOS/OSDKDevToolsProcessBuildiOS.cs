#if UNITY_EDITOR && UNITY_IOS
using System.Collections;
using System.Diagnostics;
using System.IO;
using Douyin.Game;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using UnityEngine;

namespace OSDK.DevTools.Editor.iOS
{
    public class OSDKDevToolsProcessBuildiOS
    {
        [PostProcessBuild((int)PostProcessBuildCallBackOrder.DevTools)]
        private static void OnPostprocessBuild(BuildTarget buildTarget, string buildPath)
        {
            if (buildTarget != BuildTarget.iOS) return;

            var projPath = PBXProject.GetPBXProjectPath(buildPath);
            var proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));
            var mainTargetGuid = OSDKXcodeProjectUtils.GetMainTargetGuid(proj);

            var debugToolFrameworkPath = "Frameworks/OSDK/DevTools/Plugins/iOS/UnionOpenPlatformDebugTool.framework";
            if (!OSDKIntegrationConfig.DebugMode()) {
                // 在非debug模式下，需要主动移除引用，并移除build目录下的对应文件
                OSDKXcodeProjectUtils.RemoveStaticFramework(proj, debugToolFrameworkPath);
                var targetPath = $"{buildPath}/{debugToolFrameworkPath}";
                if (Directory.Exists(targetPath)) {
                    OSDKDirectory.Delete(targetPath, true);
                }
            } else {
                // Unity生成Xcode项目时，会自动引入静态库引用
                // 添加资源bundle
                AddDevToolBundleResource(buildPath, proj);
            }

            // 保存修改
            OSDKXcodeProjectUtils.SaveProject(proj, projPath);
        }

        private static void AddDevToolBundleResource(string buildPath, PBXProject proj)
        {
            var mainTargetGuid = OSDKXcodeProjectUtils.GetMainTargetGuid(proj);
            var targetDir = $"{buildPath}/{OSDKIntegrationPathUtils.DevToolBundleTargetDir}";
            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }
            var bundlePath = OSDKIntegrationPathUtils.DevToolBundleResourceIOSOriPath;
            if (Directory.Exists(bundlePath))
            {
                var targetPath = $"{buildPath}/{OSDKIntegrationPathUtils.DevToolBundleTargetPath}";
                OSDKDirectory.Copy(bundlePath, targetPath, true);
                var fileGuid = proj.AddFile(OSDKIntegrationPathUtils.DevToolBundleTargetPath, OSDKIntegrationPathUtils.DevToolBundleTargetPath);
                proj.AddFileToBuild(mainTargetGuid, fileGuid);
            }
        }
    }
}
#endif