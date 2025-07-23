using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationAdModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void AdLayout()
        {
            if (!OSDKIntegrationPathUtils.AdModuleImported) return;
            
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            OSDKIntegrationEditor.Instance.showAd = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showAd, 
                OSDKIntegrationString.KTitleAd, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showAd)
            {
                bool clicked;
                var buttonTitle = OSDKIntegrationString.KTitleUpdateADInfo;
                GUILayout.Space(12);
                EditorGUI.indentLevel++;
                EditorGUILayout.HelpBox("广告位在抖音游戏开放平台配置，配置成功或更新广告配置后，点击「同步广告信息」按钮，自动拉取广告配置。", MessageType.Info);
                
                // 拉取广告信息
                GUILayout.Space(12);
                clicked = OSDKIntegrationLayout.Button(buttonTitle, OSDKMargin.Tab2);
                if (clicked)
                {
                    OSDKIntegrationHandler.FetchSDKConfigClickAction(OSDKPlatform.Android);
                    GUIUtility.ExitGUI();
                }
                // 0.广告配置文件
                GUILayout.Space(20);
                OSDKIntegrationEditor.Instance.showAdConfig = EditorGUILayout.Foldout(
                    OSDKIntegrationEditor.Instance.showAdConfig,
                    OSDKIntegrationString.KTitleADConfig, OSDKIntegrationStyles.getStepStyle());
                if (OSDKIntegrationEditor.Instance.showAdConfig)
                {
                    GUILayout.Space(12);
                    EditorGUILayout.HelpBox("请创建广告基础配置模板代码，将模板代码脚本挂在到游戏物体上，完成广告基础配置。", MessageType.Info);
                    GUILayout.Space(12);
                    buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.AdBasic)
                        ? OSDKIntegrationString.KTitleOpenButton
                        : OSDKIntegrationString.KTitleCreateButton;
                    clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                        buttonTitle, null, OSDKMargin.Tab2, OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                    if (clicked)
                    {
                        OSDKIntegrationSampleHandler.AdBasicSampleClickAction();
                        GUIUtility.ExitGUI();
                    }
                }

                // 1.激励视频广告
                GUILayout.Space(20);
                OSDKIntegrationEditor.Instance.showRewardAd = EditorGUILayout.Foldout(
                    OSDKIntegrationEditor.Instance.showRewardAd,
                    OSDKIntegrationString.KTitleRewardAD, OSDKIntegrationStyles.getStepStyle());
                if (OSDKIntegrationEditor.Instance.showRewardAd)
                {
                    GUILayout.Space(12);
                    LayoutAdComponents(OSDKSampleType.AdReward);
                }

                // 2.插全屏广告
                GUILayout.Space(20);
                OSDKIntegrationEditor.Instance.showInterstitialAd = EditorGUILayout.Foldout(
                    OSDKIntegrationEditor.Instance.showInterstitialAd,
                    OSDKIntegrationString.KTitleInterstitialAD, OSDKIntegrationStyles.getStepStyle());
                if (OSDKIntegrationEditor.Instance.showInterstitialAd)
                {
                    GUILayout.Space(12);
                    LayoutAdComponents(OSDKSampleType.AdNewInteraction);
                }

                // 3.横幅广告
                GUILayout.Space(20);
                OSDKIntegrationEditor.Instance.showBannerAd = EditorGUILayout.Foldout(
                    OSDKIntegrationEditor.Instance.showBannerAd,
                    OSDKIntegrationString.KTitleBannerAD, OSDKIntegrationStyles.getStepStyle());
                if (OSDKIntegrationEditor.Instance.showBannerAd)
                {
                    GUILayout.Space(12);
                    LayoutAdComponents(OSDKSampleType.AdBanner);
                }
                
                // 4.开屏广告
                GUILayout.Space(20);
                OSDKIntegrationEditor.Instance.showSplashAd = EditorGUILayout.Foldout(
                    OSDKIntegrationEditor.Instance.showSplashAd,
                    OSDKIntegrationString.KTitleSplashAD, OSDKIntegrationStyles.getStepStyle());
                if (OSDKIntegrationEditor.Instance.showSplashAd)
                {
                    GUILayout.Space(12);
                    LayoutAdComponents(OSDKSampleType.AdSplash);
                }

                EditorGUI.indentLevel--;

                // 广告模拟验证
                GUILayout.Space(20);
                OSDKIntegrationLayout.LabelTipsLayout("广告配置模拟验证（Config）", null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvADConfigState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvADConfigState, new string[]{"广告配置成功", "广告配置失败"});
                if (pcEnvADConfigState != OSDKIntegrationEditor.Instance.pcEnvADConfigState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_ad_config");
                    OSDKIntegrationEditor.Instance.pcEnvADConfigState = pcEnvADConfigState;
                }
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout("加载广告模拟验证（Load）", null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvADLoadState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvADLoadState, new string[]{"广告加载成功", "广告加载失败"});
                if (pcEnvADLoadState != OSDKIntegrationEditor.Instance.pcEnvADLoadState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_ad_load");
                    OSDKIntegrationEditor.Instance.pcEnvADLoadState = pcEnvADLoadState;
                }
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout("展示广告模拟验证（Show）", null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvADShowState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvADShowState, new string[]{"广告展示成功", "广告展示失败"});
                if (pcEnvADShowState != OSDKIntegrationEditor.Instance.pcEnvADShowState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_ad_show");
                    OSDKIntegrationEditor.Instance.pcEnvADShowState = pcEnvADShowState;
                }
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout("奖励领取模拟验证（仅激励视频广告）", null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvADRewardState = 
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvADRewardState, new string[]{"奖励领取成功", "奖励领取失败"});
                if (pcEnvADRewardState != OSDKIntegrationEditor.Instance.pcEnvADRewardState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_ad_reward");
                    OSDKIntegrationEditor.Instance.pcEnvADRewardState = pcEnvADRewardState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
        
        private static void LayoutAdComponents(OSDKSampleType type)
        {
            var adids = OSDKIntegrationEditor.Instance.GetAdids(type);
            if (adids.Count == 0)
            {
                GUILayout.Space(12);
                EditorGUILayout.HelpBox("厂商开放平台未配置此类广告", MessageType.Info);
                GUILayout.Space(12);
                return;
            }
            var index = 0;
            var count = adids.Count;
            foreach (var adInfo in adids)
            {
                // 目标文件是否存在
                var fileExist = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(type, adInfo.name);
                // 标题
                var title = OSDKIntegrationString.KTitleStandardCodeGuide;
                if (!fileExist)
                {
                    title += "（未创建）";
                    // 文件不存在，清空存储的标题
                    if (adInfo.created)
                    {
                        adInfo.name = "";
                        adInfo.created = false;
                    }
                }

                // 打开/创建按钮文案
                var button1Title = fileExist && adInfo.created ?
                    OSDKIntegrationString.KTitleOpenButton : OSDKIntegrationString.KTitleCreateButton;
                // 广告标题布局
                
                OSDKIntegrationLayout.AdComponentTitleLayout(title, OSDKMargin.Tab2, button1Title, OSDKIntegrationEditor.CanCreateSample, () =>
                {
                    // 创建模板代码
                    OSDKIntegrationSampleHandler.AdSampleCreateOpenClickAction(type, adInfo);
                    GUIUtility.ExitGUI();
                }, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                
                GUILayout.Space(8);
                adInfo.name = OSDKIntegrationLayout.LabelTextFieldLayout(OSDKIntegrationString.KTitleNameInput, adInfo.name,
                    "请填写广告模板代码文件名称，创建后若要修改需要在目录下移除该文件，建议英文", OSDKMargin.Tab3, !(fileExist && adInfo.created));
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTextFieldLayout(OSDKIntegrationString.KTitleNameInputCloud, adInfo.cloudName,
                    null, OSDKMargin.Tab3, false);
                GUILayout.Space(8);
                // android广告位
                OSDKIntegrationLayout.LabelTextFieldLayout(OSDKIntegrationString.KTitleAndroidAdid,
                    adInfo.androidAdid, null, OSDKMargin.Tab3, false);
                GUILayout.Space(8);
                // android bizid
                OSDKIntegrationLayout.LabelTextFieldLayout(OSDKIntegrationString.KTitleAndroidBizid,
                    adInfo.androidBizid, null, OSDKMargin.Tab3, false);
                GUILayout.Space(8);
                // // iOS广告位
                // OSDKIntegrationLayout.LabelTextFieldLayout(OSDKIntegrationString.KTitleIosAdid,
                //     adInfo.iosAdid, null, OSDKMargin.Tab3, false);
                // GUILayout.Space(8);
                // // iOS bizid
                // OSDKIntegrationLayout.LabelTextFieldLayout(OSDKIntegrationString.KTitleIosBizid,
                //     adInfo.iosBizid, null, OSDKMargin.Tab3, false);
                // GUILayout.Space(8);
                
                // 横竖屏
                var orientation = string.Empty;
                switch (adInfo.orientation)
                {
                    case OSDKAdOrientation.Horizontal:
                        orientation = "横屏";
                        break;
                    case OSDKAdOrientation.Vertical:
                        orientation = "竖屏";
                        break;
                }
                if (!string.IsNullOrWhiteSpace(orientation))
                {
                    OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleAdOrientation, orientation,
                        null, OSDKMargin.Tab3, false);
                }
                if (index != count - 1)
                {
                    OSDKIntegrationLayout.SepLine(OSDKMargin.Tab2);    
                }
                index++;
            }
        }
    }
}