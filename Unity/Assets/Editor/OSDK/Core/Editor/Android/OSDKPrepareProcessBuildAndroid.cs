using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Douyin.Game
{
    internal class OSDKPrepareProcessBuildAndroid : IPreprocessBuildWithReport
    {
        private static readonly string CoreGradleDir = $"{OSDKProjectPathUtils.SdkDir}/Core/Plugins/Android/Gradle";

        private static readonly string CoreDependienceConfigTemplatePath =
            Path.Combine(CoreGradleDir, "OSDK_Dependencies_Version_Config.gradle");

        private static readonly string InsertStartTag = "Start，此行注释不能删除，用于自动化标记使用";
        private static readonly string InsertEndTag = "End，此行注释不能删除，用于自动化标记使用";

        public int callbackOrder => (int)PreProcessBuildCallBackOrder.Prepare;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.Android) return;

            #if TikTokGuanFu8
            Debug.Log($"OSDKPrepareProcessBuildAndroid.OnPreprocessBuild");

            RemoveInsertedLines();  // 将以前插入到gradle中的东西移除。避免某些模块被删除后，gradle中还保留着对应的依赖。最终导致包体增大。
            PrepareGralde();
            #endif
        }

        // 准备项目需要的Gradle相关配置
        private static void PrepareGralde()
        {
            OSDKMainTemplateGradle.Instance.SetDefaultMainTemplateGradleIfNotExist();
            OSDKLauncherTemplateGradle.Instance.SetDefaultLauncherTemplateGradleIfNotExist();
            OSDKSettingsTemplateGradle.Instance.SetDefaultSettingsTemplateGradleIfNotExist();
            
            // 插入各组件依赖的版本号属性
            OSDKMainTemplateGradle.Instance.UpdateOrInsertLines(OSDKTemplateGradle.GradleApplicationPluginTag,
                CoreDependienceConfigTemplatePath, true);
            OSDKIntegrationHandler.WriteAndroidConfigFiles();
        }

        private static void RemoveInsertedLines()
        {
            OSDKMainTemplateGradle.Instance.RemoveLines(InsertStartTag, InsertEndTag);
        }
    }
}