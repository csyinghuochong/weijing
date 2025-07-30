using System.IO;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKCoreProcessBuildAndroid : IPreprocessBuildWithReport
    {
        private static readonly string CoreGradleDir = $"{OSDKProjectPathUtils.SdkDir}/Core/Plugins/Android/Gradle";

        private static readonly string CoreDependienceConfigTemplatePath =
            Path.Combine(CoreGradleDir, "OSDK_Core_Dependencies_Config.gradle");

        private static readonly string CoreDependienceConfigMultidexTemplatePath =
            Path.Combine(CoreGradleDir, "OSDK_Multidex_Config_Template.gradle");

        private static readonly string CorePackagingOptionsConfigTemplatePath =
            Path.Combine(CoreGradleDir, "OSDK_PackagingOptions_Config_Template.gradle");

        public int callbackOrder => (int)PreProcessBuildCallBackOrder.Core;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.Android) return;

            Debug.Log($"OSDKCoreProcessBuildAndroid.OnPreprocessBuild");


#if TikTokGuanFu8
            // 自动配置模块Gradle
            AutoConfigGradle();
            // 自动配置模块Manifest
            AutoConfigManifest();
#endif
        }

        private static void AutoConfigGradle()
        {
            //Update Or Insert core dependencies
            OSDKMainTemplateGradle.Instance.UpdateOrInsertDependencies(CoreDependienceConfigMultidexTemplatePath);
            OSDKMainTemplateGradle.Instance.UpdateOrInsertDependencies(CoreDependienceConfigTemplatePath);

            // 解决so冲突问题
            OSDKMainTemplateGradle.Instance.UpdateOrInsertToAndroidTag(CorePackagingOptionsConfigTemplatePath);
            OSDKLauncherTemplateGradle.Instance.UpdateOrInsertToAndroidTag(CorePackagingOptionsConfigTemplatePath);
        }

        private static void AutoConfigManifest()
        {
            var manifest = OSDKAndroidManifest.Instance;
            const string manifestApplicationPushTag = "com.bytedance.ttgame.tob.common.host.api.GBApplication";
            manifest.UpdateXmlSingleNodeAttr(
                "application",
                "android:name",
                manifestApplicationPushTag,
                (state, element) =>
                {
                    switch (state)
                    {
                        case UpdateXmlAttributeState.Insert:
                            element.SetAttribute("name", OSDKAndroidManifest.NameSpaceUriAndroid,
                                manifestApplicationPushTag);
                            break;
                        case UpdateXmlAttributeState.DifferentValue:
                            GUIUtility.systemCopyBuffer = "https://game.open.douyin.com/platform/subapp/live/learning_center/detail/doc/?id=283&tab=X4g4fKRNtlzPddd3CPkcR2PBnKh";
                            EditorUtility.DisplayDialog("Application类冲突",
                                "参考学习中心Q&A解决" +
                                "\n已为您复制学习中心链接到剪贴板" +
                                "\n请粘贴到浏览器查看解决方案",
                                "OK");
                            break;
                        case UpdateXmlAttributeState.Fail:
                            EditorUtility.DisplayDialog("提示", "未找到要修改的标签，请检查sdk", "OK");
                            break;
                        case UpdateXmlAttributeState.HaveSameValue:
                            break;
                    }
                });
            AssetDatabase.Refresh();
        }
    }
}