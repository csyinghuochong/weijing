using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace Douyin.Game
{
    public class OSDKDevToolsProcessBuildAndroid: IPreprocessBuildWithReport
    {
        private static readonly string DevToolsGradleDir =
            $"{OSDKProjectPathUtils.SdkDir}/DevTools/Plugins/Android/Gradle";

        private static readonly string DevToolsDependienceConfigTemplatePath =
            Path.Combine(DevToolsGradleDir, "OSDK_DevTools_Dependencies_Config.gradle");

        public int callbackOrder => (int)PreProcessBuildCallBackOrder.DevTools;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.Android) return;

            #if TikTokGuanFu8
            // 自动配置模块Gradle
            AutoConfigGradle();
            #endif
        }

        private static void AutoConfigGradle()
        {
            bool removeDependencies = !OSDKIntegrationConfig.DebugMode();
            OSDKMainTemplateGradle.Instance.UpdateOrInsertDependencies(DevToolsDependienceConfigTemplatePath, removeDependencies);
        }
    }
}