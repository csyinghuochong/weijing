using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKDataLinkProcessBuildAndroid : IPreprocessBuildWithReport
    {
        private static readonly string DataLinkGradleDir = $"{OSDKProjectPathUtils.SdkDir}/DataLink/Plugins/Android/Gradle";

        private static readonly string DataLinkDependienceConfigTemplatePath =
            Path.Combine(DataLinkGradleDir, "OSDK_DataLink_Dependencies_Config.gradle");

        private static readonly string DataLinkAndroidManifestPath =
            $"{OSDKProjectPathUtils.SdkDir}/DataLink/Plugins/Android/DataLinkHandleUrlAndroidManifest.xml";

        private static readonly string HandleUrlPluginPath =
            "Assets/Plugins/Android";

        private static readonly string HandleUrlPluginName = "unity_handle_url";

        public int callbackOrder => (int)PreProcessBuildCallBackOrder.DataLink;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.Android) return;
            if(OSDKIntegrationPathUtils.SDKDeveloperExists && 
               OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.DouyinChannel) 
                return;
            // 自动配置Core模块Gradle
            
#if TikTokGuanFu8
            AutoConfigGradle();
            AutoConfigManifest();
#endif
        }

        private static void AutoConfigGradle()
        {
            //Update Or Insert core dependencies
            OSDKMainTemplateGradle.Instance.UpdateOrInsertDependencies(DataLinkDependienceConfigTemplatePath);
        }

        private static void AutoConfigManifest()
        {
            if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.OmniChannel && IsImportHandleUrlPlugin())
            {
                var manifest = OSDKAndroidManifest.Instance;
                manifest.InsertHandleUrlActivity();
            }
        }

        private static bool IsImportHandleUrlPlugin()
        {
            var aarFiles = Directory.GetFiles(HandleUrlPluginPath, "*.aar")
                .Where(file => Path.GetFileName(file).Contains(HandleUrlPluginName)).ToArray();
            return aarFiles.Length > 0;
        }
    }
}