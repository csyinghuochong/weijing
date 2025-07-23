using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationArchiveUI
    {
        private static string _devProfilePath;
        
        // Section - 构建
        internal static void ArchiveSection()
        {
            OSDKIntegrationEditor.Instance.showSectionArchive =
                EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showSectionArchive,
                    OSDKIntegrationString.KTitleArchive, OSDKIntegrationStyles.getSectionStyle());
            if (OSDKIntegrationEditor.Instance.showSectionArchive)
            {
                GUILayout.Space(12);
                OSDKIntegrationEditor.Instance.platformTabIndex =
                    GUILayout.Toolbar(OSDKIntegrationEditor.Instance.platformTabIndex,
                        new string[] { "Android", "iOS" });
                GUILayout.Space(12);
                if (OSDKIntegrationEditor.Instance.IsAndroidTab)
                {
                    AndroidArchiveUI();
                } 
                else if (OSDKIntegrationEditor.Instance.IsIOSTab)
                {
                    IOSArchiveUI();
                }
            }
            GUILayout.Space(12);
        }
        
        // ReSharper disable Unity.PerformanceAnalysis
        private static void AndroidArchiveUI()
        {
            var click = false;
            var enable = true;
#if !UNITY_ANDROID
            EditorGUILayout.HelpBox("安卓构建功能不可用！\n请将 Build Settings 环境切换至 Android 平台后使用。\n操作路径：打开菜单栏File - Build Settings面板，Platform选择Android，点击Switch Platform按钮。", MessageType.Warning);
            GUILayout.Space(12);
            enable = false;
#endif
            click = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleArchiveAndroidDebugAPK,
                OSDKIntegrationString.KTitleArchive, null, 0, enable);
            if (click)
            {
                OSDKIntegrationRecord.ArchiveApkClick();
                OSDKIntegrationHandler.ArchiveAndroidAction(true);
                GUIUtility.ExitGUI();
            }
            GUILayout.Space(12);
            click = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleArchiveAndroidReleaseAPK,
                OSDKIntegrationString.KTitleArchive, null, 0, enable);
            if (click)
            {
                OSDKIntegrationRecord.ArchiveApkClick();
                OSDKIntegrationHandler.ArchiveAndroidAction(false);
                GUIUtility.ExitGUI();
            }
            GUILayout.Space(12);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private static void IOSArchiveUI()
        {
            var click = false;
            var enable = true;
#if !UNITY_IOS
            EditorGUILayout.HelpBox("iOS构建功能不可用！\n请将 Build Settings 环境切换至 iOS 平台后使用。\n操作路径：打开菜单栏File - Build Settings面板，Platform选择iOS，点击Switch Platform按钮。", MessageType.Warning);
            GUILayout.Space(12);
            enable = false;
#endif
            // // 构建环境选择
            // OSDKIntegrationEditor.Instance.archiveProfileTypeSelect = OSDKIntegrationLayout.LabelEnumPopupTipsLayout(
            //     OSDKIntegrationString.KTitleArchiveIOSEnvironmentSelect,
            //     new[] {"Debug", "Release"}, 
            //     OSDKIntegrationEditor.Instance.archiveProfileTypeSelect,
            //     OSDKIntegrationString.KTipsArchiveIOSEnvironmentSelect,
            //     OSDKMargin.TextTab);
            
            // 构建IPA包 目前不提供
            // click = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleArchiveIOSIPA,
            //     OSDKIntegrationString.KTitleArchive, OSDKIntegrationString.KTipsArchiveIOSIPA, OSDKMargin.TextTab, enable);
            // if (click)
            // {
            //     OSDKIntegrationRecord.ArchiveIpaClick();
            //     var isDebug = OSDKIntegrationEditor.Instance.archiveProfileTypeSelect == 0;
            //     OSDKIntegrationHandler.ArchiveIOSAction(isDebug);
            //     GUIUtility.ExitGUI();
            // }
            // GUILayout.Space(20);
            
            // 导出Debug环境Xcode工程
            click = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleExportIOSDebugProject,
                OSDKIntegrationString.KTitleExport, null, OSDKMargin.TextTab, enable);
            if (click)
            {
                OSDKIntegrationRecord.ExportXcodeClick();
                OSDKIntegrationHandler.ExportXcodeProjectAction(true);
                GUIUtility.ExitGUI();
            }

            GUILayout.Space(12);

            // 导出Release环境Xcode工程
            click = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleExportIOSReleaseProject,
                OSDKIntegrationString.KTitleExport, null, OSDKMargin.TextTab, enable);
            if (click)
            {
                OSDKIntegrationRecord.ExportXcodeClick();
                OSDKIntegrationHandler.ExportXcodeProjectAction(false);
                GUIUtility.ExitGUI();
            }

            GUILayout.Space(12);
            
            // 环境配置文件 目前不提供
            // EditorGUI.indentLevel++;
            // OSDKIntegrationEditor.Instance.showArchiveIOSProfile = EditorGUILayout.Foldout(
            //     OSDKIntegrationEditor.Instance.showArchiveIOSProfile,
            //     OSDKIntegrationString.KTitleArchiveIOSProvisionProfile, OSDKIntegrationStyles.getStepStyle());
            // if (OSDKIntegrationEditor.Instance.showArchiveIOSProfile)
            // {
            //     GUILayout.Space(8);
            //     EditorGUILayout.HelpBox("与Build Settings 中 Automatically Sign 选项保持一致,如不勾选请设置描述文件。", MessageType.Info);
            //     GUILayout.Space(8);
            //     PlayerSettings.iOS.appleEnableAutomaticSigning =
            //         EditorGUILayout.Toggle(new GUIContent("Automatically Sign"), PlayerSettings.iOS.appleEnableAutomaticSigning);
            //     if (!PlayerSettings.iOS.appleEnableAutomaticSigning)
            //     {
            //         GUILayout.Space(12);
            //         const string title = "清除配置文件信息";
            //         click = GUILayout.Button(title, new GUIStyle("Button")
            //         {
            //             fixedWidth = OSDKIntegrationLayout.GetStringWidth(title),
            //             margin = { left = OSDKMargin.Tab1 }
            //         });
            //         if (click)
            //         {
            //             OSDKIntegrationEditor.Instance.archiveProfileTeamID = null;
            //             OSDKIntegrationEditor.Instance.productionProfileUuid = null;
            //             OSDKIntegrationEditor.Instance.developmentProfileUuid = null;
            //             GUIUtility.ExitGUI();
            //         }
            //         GUILayout.Space(12);
            //         EditorGUILayout.HelpBox("配置文件后缀名为.mobileprovision，选取后点击构建IPA包或导出Xcode工程时，会自动解析配置文件，根据「构建环境」同步到 Unity - Player Settings - Provision Profile 中。", MessageType.Info);
            //         GUILayout.Space(12);
            //         EditorGUI.indentLevel++;
            //         GUI.enabled = false;
            //         EditorGUILayout.TextField(OSDKIntegrationString.KTitleArchiveIOSTeamID, OSDKIntegrationEditor.Instance.archiveProfileTeamID);
            //         GUI.enabled = true;
            //         EditorGUI.indentLevel--;
            //         LayoutPushConfigFile(true, enable);
            //         LayoutPushConfigFile(false, enable);
            //     }
            // }
            // GUILayout.Space(12);
            // EditorGUI.indentLevel--;
            // GUILayout.Space(12);
        }
        
        private static void LayoutPushConfigFile(bool isDebug, bool enableClick)
        {
            GUILayout.Space(12);
            string title;
            string profileUuid;
            // 测试环境
            if (isDebug)
            {
                title = OSDKIntegrationString.KTitleArchiveIOSDevelopmentCer;
                profileUuid = OSDKIntegrationEditor.Instance.developmentProfileUuid;
            }
            // 正式环境
            else
            {
                title = OSDKIntegrationString.KTitleArchiveIOSProductionCer;
                profileUuid = OSDKIntegrationEditor.Instance.productionProfileUuid;
            }
            var click = OSDKIntegrationLayout.LabelButtonTipsLayout(title, OSDKIntegrationString.KTitleSelect, null, OSDKMargin.Tab1, enableClick);
            if (click)
            {
                _devProfilePath = EditorUtility.OpenFilePanel("Select Mobileprovision", _devProfilePath, "mobileprovision");
                if (!string.IsNullOrWhiteSpace(_devProfilePath))
                {
                    var isSelectDebug = OSDKIntegrationEditor.Instance.archiveProfileTypeSelect == 0;
                    var type = isSelectDebug ? "development" : "production";
                    var env = isSelectDebug ? "Debug" : "Release";
                    var taskAllow = isSelectDebug ? "true" : "false";
                    var tAllow = OSDKIntegrationUtils.GetMobileprovisionTaskAllow(_devProfilePath);
                    var fileType = tAllow == "true" ? "development" : "production";
                    if (string.Equals(tAllow, taskAllow))
                    {
                        profileUuid = OSDKIntegrationUtils.GetMobileprovisionUuid(_devProfilePath);
                        OSDKIntegrationEditor.Instance.archiveProfileTeamID = OSDKIntegrationUtils.GetMobileprovisionTeamid(_devProfilePath);
                        // 另一配置文件置空
                        if (isDebug) {
                            OSDKIntegrationEditor.Instance.productionProfileUuid = null;
                        }
                        else 
                        {
                            OSDKIntegrationEditor.Instance.developmentProfileUuid = null;
                        }
                    }
                    else
                    {
                        EditorUtility.DisplayDialog("配置文件环境错误", $"当前构建环境为{env}, 所选的配置文件类型为{fileType}, 请选择 {type} 配置文件", "OK");
                    }
                }
            }
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            GUI.enabled = false;
            EditorGUILayout.TextField("Profile UUID：", profileUuid);
            GUI.enabled = true;
            EditorGUI.indentLevel--;
            if (isDebug)
            {
                OSDKIntegrationEditor.Instance.developmentProfileUuid = profileUuid;
            }
            else
            {
                OSDKIntegrationEditor.Instance.productionProfileUuid = profileUuid;
            }
            if (click)
            {
                GUIUtility.ExitGUI(); 
            }
        }
    }
}