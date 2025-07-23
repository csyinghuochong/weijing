#if UNITY_EDITOR && UNITY_IOS
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Douyin.Game;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

namespace Demo.Douyin.Game
{
    public class DemoCoreProcessBuildiOS
    {
        [PostProcessBuild((int)PostProcessBuildCallBackOrder.Core)]
        private static void OnPostprocessBuild(BuildTarget buildTarget, string buildPath)
        {
            if (buildTarget != BuildTarget.iOS) return;
            if (!OSDKEditorHelper.IsBuildDemoScene()) return;
            
            var projPath = PBXProject.GetPBXProjectPath(buildPath);
            var proj = new PBXProject();
            proj.ReadFromString(File.ReadAllText(projPath));
            
            // 设置 Demo 包名
            string demoBundleID = PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.iOS);
            var appendInfo = new Hashtable
            {
                { "CFBundleIdentifier", demoBundleID }
            };
            OSDKXcodeProjectUtils.AddInfoPlistProperties(buildPath, appendInfo);
            OSDKXcodeProjectUtils.SetBuildProperty(proj, "PRODUCT_BUNDLE_IDENTIFIER", demoBundleID);
            
            // 保存修改
            OSDKXcodeProjectUtils.SaveProject(proj, projPath);
        }
    }
}
#endif