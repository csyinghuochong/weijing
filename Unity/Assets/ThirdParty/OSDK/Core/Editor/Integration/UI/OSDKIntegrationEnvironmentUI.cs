using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationEnvironmentUI
    {
        internal static void EnvironmentSection()
        {
            OSDKIntegrationEditor.Instance.showSectionEnvironment = EditorGUILayout.Foldout(
                OSDKIntegrationEditor.Instance.showSectionEnvironment,
                OSDKIntegrationString.KTitleEnvironment, OSDKIntegrationStyles.getSectionStyle());
            if (OSDKIntegrationEditor.Instance.showSectionEnvironment)
            {
                EnvironmentLayout();
            }
            GUILayout.Space(12);
        }

        private static void EnvironmentLayout()
        {
            // 密钥
            SecretKeyLayout();
            
            // Android/iOS 平台选择
            PlatformTabLayout();
            
            // 配置信息
            ReadonlyConfigInfoLayout();

            // Android更多配置
            MoreSettingsLayout();
            
            // iOS权限
            IOSPermissionLayout();

            // 调试开关
            DebugLayout();
        }
        
        private static void MoreSettingsLayout()
        {
            if (!OSDKIntegrationEditor.Instance.IsAndroidTab) return;
            
            GUILayout.Space(8);
            EditorGUI.indentLevel += 2;
            OSDKIntegrationEditor.Instance.showMoreSettings = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showMoreSettings,
                OSDKIntegrationString.KTitleMoreSettings, OSDKIntegrationStyles.getStepStyle(13, FontStyle.Normal));
            if (OSDKIntegrationEditor.Instance.showMoreSettings)
            {
                // 仅Android
                GUILayout.Space(8);
                OSDKIntegrationEditor.Instance.gameStageState = OSDKIntegrationLayout.LabelEnumPopupTipsLayout(
                    OSDKIntegrationString.KTitleGameStage,
                    new string[] {"不删档包(正式包)", "删档测试包"}, 
                    OSDKIntegrationEditor.Instance.gameStageState, 
                    OSDKIntegrationString.KTipsGameStage,
                    OSDKMargin.Tab2);
            }
            EditorGUI.indentLevel -= 2;
            GUILayout.Space(12);
        }
        
        private static void IOSPermissionLayout()
        {
            if (!OSDKIntegrationEditor.Instance.IsIOSTab) return;
            
            GUILayout.Space(8);
            EditorGUI.indentLevel += 2;
            OSDKIntegrationEditor.Instance.showIOSPermissions = EditorGUILayout.Foldout(
                OSDKIntegrationEditor.Instance.showIOSPermissions, OSDKIntegrationString.KTitleIOSPermissions,
                OSDKIntegrationStyles.getStepStyle(13, FontStyle.Normal));
            if (OSDKIntegrationEditor.Instance.showIOSPermissions)
            {
                // UserTrackingUsageDescription
                GUILayout.Space(8);
                OSDKIntegrationEditor.Instance.iOSUserTrackingUsageDescription = EditorGUILayout.TextField(
                    OSDKIntegrationString.KTitleIOSUserTrackingUsageDescription,
                    OSDKIntegrationEditor.Instance.iOSUserTrackingUsageDescription);
                
                // NSPhotoLibraryUsageDescription
                if (OSDKIntegrationPathUtils.ShareModuleImported)
                {
                    GUILayout.Space(8);
                    OSDKIntegrationEditor.Instance.iOSPhotoLibraryUsageDescription = EditorGUILayout.TextField(
                        OSDKIntegrationString.KTitleIOSPhotoLibraryUsageDescription,
                        OSDKIntegrationEditor.Instance.iOSPhotoLibraryUsageDescription);
                }
            }
            EditorGUI.indentLevel -= 2;
            GUILayout.Space(12);
        }

        private static void DebugLayout()
        {
            GUILayout.Space(12);
            // 调试模式开关
            var debugModeState = OSDKIntegrationLayout.LabelEnumPopupTipsLayout(
                OSDKIntegrationString.KTitleDebugMode,
                new string[] { "关闭", "开启" },
                OSDKIntegrationEditor.Instance.debugModeState,
                OSDKIntegrationString.KTipsDebugMode,
                5);
            OSDKIntegrationEditor.Instance.debugModeState = debugModeState;
            GUILayout.Space(12);
        }
        
        private static void SecretKeyLayout()
        {
            GUILayout.Space(12);
            var clicked = false;
            const string placeholder = OSDKIntegrationString.KTitleSecretPlaceholder;
            var textFieldStyle = new GUIStyle(EditorStyles.textField)
            {
                margin = { right = OSDKMargin.Tab1, left = OSDKMargin.Tab1 },
            };
            // secret Key 配置
            // 密钥文本
            clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleSecretKey,
                OSDKIntegrationString.KTitleGetButton, OSDKIntegrationString.KTipsSecretKey, OSDKMargin.TextTab);
            if (clicked)
            {
                OSDKIntegrationRouter.OpenSecretKeyWeb();
                GUIUtility.ExitGUI();
            }
            GUILayout.Space(8);
            // 密钥输入框
            OSDKIntegrationConfig.SetAppSecret(OSDKIntegrationLayout.TextField(OSDKIntegrationConfig.GetAppSecret(), placeholder, textFieldStyle), false);
            
            GUILayout.Space(12);
            
            // 展示接入模式
            if (OSDKIntegrationPathUtils.SDKDeveloperExists) //开发者模式
            {
                OSDKIntegrationEditor.Instance.osdkTypeState = OSDKIntegrationLayout.LabelEnumPopupTipsLayout(
                    OSDKIntegrationString.kTitleOSDKTypeKey, 
                    new string[]{"全官服促活分账", "抖音渠道分账"}, 
                    OSDKIntegrationEditor.Instance.osdkTypeState,
                    OSDKIntegrationString.KTipsOSDKBizMode,
                    OSDKMargin.TextTab);
                //OSDKIntegrationConfig.SetbizMode( OSDKIntegrationEditor.Instance.osdkTypeState == 0 ? OSDKIntegrationConfig.BizMode.OmniChannel: OSDKIntegrationConfig.BizMode.DouyinChannel  );
            }
            else
            {
                OSDKIntegrationLayout.LabelEnumPopupTipsLayout(
                    OSDKIntegrationString.kTitleOSDKTypeKey,
                    OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.OmniChannel
                        ? new string[] { "全官服促活分账" }
                        : new string[] { "抖音渠道分账" },
                    0,
                    OSDKIntegrationString.KTipsOSDKBizMode,
                    OSDKMargin.TextTab);
            }
            
            GUILayout.Space(8);

            // 同步配置信息按钮
            GUILayout.Space(8);
            GUILayout.BeginHorizontal();
            var androidClicked = GUILayout.Button(OSDKIntegrationString.KTitleFetchConfigAndroidButton, new GUIStyle("Button")
            {
                margin = { left = OSDKMargin.Tab1, right = 0 }
            });
            if (androidClicked)
            {
                // 点击拉取才将AppSecret存储到文件
                OSDKIntegrationConfig.SaveAppSecret();
                OSDKIntegrationHandler.FetchSDKConfigClickAction(OSDKPlatform.Android);
                GUIUtility.ExitGUI();
            }

            var iOSClicked = GUILayout.Button(OSDKIntegrationString.KTitleFetchConfigiOSButton, new GUIStyle("Button")
            {
                margin = { left = 0, right = OSDKMargin.Tab1 }
            });
            if (iOSClicked)
            {
                // 点击拉取才将AppSecret存储到文件
                OSDKIntegrationConfig.SaveAppSecret();
                OSDKIntegrationHandler.FetchSDKConfigClickAction(OSDKPlatform.iOS);
                GUIUtility.ExitGUI();
            }
            GUILayout.EndHorizontal();
        }

        private static void PlatformTabLayout()
        {
            OSDKIntegrationLayout.SepLine("------ 平台差异配置 -------");
            GUILayout.BeginHorizontal();
            GUILayout.Space(OSDKMargin.Tab1);
            var index = GUILayout.Toolbar(OSDKIntegrationEditor.Instance.platformTabIndex,
                new string[] {"Android 配置", "iOS 配置"});
            if (index != OSDKIntegrationEditor.Instance.platformTabIndex)
            {
                GUIUtility.keyboardControl = 0;
            }
            OSDKIntegrationEditor.Instance.platformTabIndex = index;
            GUILayout.Space(OSDKMargin.Tab1 - OSDKMargin.TextTab);
            GUILayout.EndHorizontal();
            GUILayout.Space(8);
        }

        // ReSharper disable Unity.PerformanceAnalysis
        private static void ReadonlyConfigInfoLayout()
        {
            GUILayout.Space(12);
            EditorGUI.indentLevel += 2;
            OSDKIntegrationEditor.Instance.showInfoSettings = EditorGUILayout.Foldout(
                OSDKIntegrationEditor.Instance.showInfoSettings, OSDKIntegrationString.KTitleConfigInfo,
                OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showInfoSettings)
            {
                GUILayout.Space(8);
                var platform = OSDKIntegrationEditor.Instance.IsAndroidTab ? OSDKPlatform.Android : OSDKPlatform.iOS;
                // appid（文件读取）
                var appid = OSDKIntegrationConfig.AppID(platform);
                appid = LayoutComponent(OSDKIntegrationString.KTitleUniformId, appid);
                // client_key（文件读取）
                var clientKey = OSDKIntegrationConfig.ClientKey(platform);
                if (!string.IsNullOrEmpty(appid) && string.IsNullOrEmpty(clientKey)) {
                    clientKey = LayoutComponent(OSDKIntegrationString.KTitleClientKey, clientKey, true);
                } else {
                    clientKey = LayoutComponent(OSDKIntegrationString.KTitleClientKey, clientKey);
                }
                
                // 临时处理，支持服务端拉取后，可删除
                if (OSDKIntegrationEditor.Instance.IsAndroidTab)
                {
                    OSDKIntegrationEditor.Instance.pAndroidAppID = appid;
                    OSDKIntegrationEditor.Instance.pAndroidClientKey = clientKey;
                }
                else if (OSDKIntegrationEditor.Instance.IsIOSTab)
                {
                    OSDKIntegrationEditor.Instance.piOSAppID = appid;
                    OSDKIntegrationEditor.Instance.piOSClientKey = clientKey;
                }
                if (OSDKIntegrationPathUtils.LiveModuleImported)
                {
                    // live_ttsdk_id（手动）
                    var liveSDKID = OSDKIntegrationConfig.LiveTTSDKID(platform);
                    liveSDKID = LayoutComponent(OSDKIntegrationString.KTitleLiveTTSDKID, liveSDKID, true);
                    // live_ttwebcast_id（手动）
                    var liveWebcastID = OSDKIntegrationConfig.LiveTTWebcastID(platform);
                    if (OSDKIntegrationEditor.Instance.IsAndroidTab && OSDKIntegrationEditor.Instance.pAndroidSdkType == "Android_Merge") {
                        // Android模式1不需要填liveWebcastID
                    } else {
                        liveWebcastID = LayoutComponent(OSDKIntegrationString.KTitleLiveTTWebcastID, liveWebcastID, true);
                    }

                    // ttsdk_license（手动）
                    var liveLicenseUpdateTime = OSDKIntegrationConfig.LiveLicenseUpdateTime(platform);
                    var liveLicensePath = OSDKIntegrationConfig.LiveLicensePath(platform);
                    LayoutFileSelectComponent(OSDKIntegrationString.KTitleLiveLicense,
                        OSDKIntegrationString.KTipsLiveLicense,
                        liveLicensePath,
                        liveLicenseUpdateTime, localUpdateTime =>
                        {
                            // 因为LayoutFileSelectComponent中回调了更新时间之后就GUIUtility.ExitGUI()了，所以要及时存起来
                            if (OSDKIntegrationEditor.Instance.IsAndroidTab)
                            {
                                OSDKIntegrationEditor.Instance.pAndroidLiveLicenseUpdateTime = localUpdateTime;
                            }
                            else if (OSDKIntegrationEditor.Instance.IsIOSTab)
                            {
                                OSDKIntegrationEditor.Instance.piOSLiveLicenseUpdateTime = localUpdateTime;
                            }
                        });
                    if (OSDKIntegrationEditor.Instance.IsIOSTab)
                    {
                        // ttsdk_license_msext（手动）
                        LayoutFileSelectComponent(OSDKIntegrationString.KTitleLiveMsext,
                            OSDKIntegrationString.KTipsLiveMsext,
                            OSDKIntegrationPathUtils.ConfigFromLocalTTLiveMsextPathIOS,
                            OSDKIntegrationEditor.Instance.liveMsextUpdateTime, s =>
                            {
                                OSDKIntegrationEditor.Instance.liveMsextUpdateTime = s;
                            });
                    }    
                    // 临时处理，支持服务端拉取后，可删除
                    if (OSDKIntegrationEditor.Instance.IsAndroidTab)
                    {
                        OSDKIntegrationEditor.Instance.pAndroidLiveTTSDKID = liveSDKID;
                        OSDKIntegrationEditor.Instance.pAndroidLiveTTWebcastID = liveWebcastID;
                    }
                    else if (OSDKIntegrationEditor.Instance.IsIOSTab)
                    {
                        OSDKIntegrationEditor.Instance.piOSLiveTTSDKID = liveSDKID;
                        OSDKIntegrationEditor.Instance.piOSLiveTTWebcastID = liveWebcastID;
                    }
                }
            }
            EditorGUI.indentLevel -= 2;
            GUILayout.Space(12);
        }

        private static string LayoutComponent(string label, string text, bool enableEdit = false)
        {
            var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(label, 
                "复制", null, OSDKMargin.Tab2, true, false);
            var textAreaStyle = new GUIStyle(EditorStyles.textArea)
            {
                margin = { right = OSDKMargin.Tab1 }
            };
            if (clicked)
            {
                OSDKIntegrationHandler.CopyBufferAndLog(text, label);
            }
            GUILayout.Space(8);
            var result = OSDKIntegrationLayout.TextArea(text, null, textAreaStyle, enableEdit);
            GUILayout.Space(8);
            return result;
        }

        private static void LayoutFileSelectComponent(string label, string tips, string filePath, string updateTime, Action<string>updateAction)
        {
            GUILayout.Space(12);
            EditorGUILayout.BeginHorizontal();
            OSDKIntegrationLayout.LabelTipsLayout(label, tips, OSDKMargin.Tab2);
            GUILayout.Space(30);
            var fileExist = File.Exists(filePath);
            // 按钮1
            var buttonTitle = fileExist ? "更新" : "选取";
            var width = OSDKIntegrationLayout.GetStringWidth(buttonTitle);
            var selectClicked = GUILayout.Button(buttonTitle, new GUIStyle("Button"){fixedWidth = width});
            GUILayout.Space(30);
            // 按钮2
            buttonTitle = "打开文件目录";
            width = OSDKIntegrationLayout.GetStringWidth(buttonTitle);
            var openClicked = GUILayout.Button(buttonTitle, new GUIStyle("Button"){fixedWidth = width});
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
            if (selectClicked)
            {
                GUIUtility.keyboardControl = 0;
                var extension = filePath.Substring(filePath.LastIndexOf(".", StringComparison.Ordinal) + 1);
                var selectFilePath = EditorUtility.OpenFilePanel("Select Mobileprovision", null, extension);
                // 点击取消
                if (string.IsNullOrWhiteSpace(selectFilePath))
                {
                    GUIUtility.ExitGUI();
                }
                if (!Directory.Exists(OSDKIntegrationPathUtils.SdkDataResourceDir))
                {
                    Directory.CreateDirectory(OSDKIntegrationPathUtils.SdkDataResourceDir);
                }
                File.Copy(selectFilePath, filePath, true);
                // 记录更新时间
                var localUpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                updateAction?.Invoke(localUpdateTime);
                GUIUtility.ExitGUI();
            }
            if (openClicked)
            {
                GUIUtility.keyboardControl = 0;
                EditorUtility.RevealInFinder(Path.GetDirectoryName(filePath));
                GUIUtility.ExitGUI();
            }
            GUILayout.Space(8);
            var text = fileExist ? $"已选取，更新时间：{updateTime}" : $"未选取，请选取{label}文件";
            var textAreaStyle = new GUIStyle(EditorStyles.textArea)
            {
                margin = { right = OSDKMargin.Tab1 },
                normal =
                {
                    textColor = fileExist ? Color.black : Color.red
                }
            };
            OSDKIntegrationLayout.TextArea(text, null, textAreaStyle, false);
            GUILayout.Space(8);
        }
    }
}