using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace Douyin.Game
{
    public class OSDKDouyinProcessBuildAndroid : IPreprocessBuildWithReport
    {
        private static readonly string DouyinGradleDir = $"{OSDKProjectPathUtils.SdkDir}/Douyin/Plugins/Android/Gradle";

        private static readonly string DouyinDependienceConfigTemplatePath =
            Path.Combine(DouyinGradleDir, "OSDK_Douyin_Dependencies_Config.gradle");

        public int callbackOrder => (int)PreProcessBuildCallBackOrder.Douyin;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.Android) return;
            // 自动配置Core模块Gradle
#if TikTokGuanFu8
            AutoConfigGradle();
#endif
        }

        private static void AutoConfigGradle()
        {
            //Update Or Insert core dependencies
            OSDKMainTemplateGradle.Instance.UpdateOrInsertDependencies(DouyinDependienceConfigTemplatePath);
        }
    }
}