using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 分享模块，附加
    /// </summary>
    public class OSDKIntegrationShareModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void ShareLayout()
        {
            if (!OSDKIntegrationPathUtils.ShareModuleImported) return;
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 分享
            OSDKIntegrationEditor.Instance.showShare = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showShare,
                OSDKIntegrationString.KTitleShare, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showShare)
            {
                var tips = OSDKIntegrationString.KTipsStandardCodeGuide;
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.Share)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, tips, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.ShareSampleClickAction();
                    GUIUtility.ExitGUI();
                }
                
                // 2、模拟验证
                tips = OSDKIntegrationString.KTipsPCMock;
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, tips, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvShareState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvShareState, new string[]{"分享成功", "分享失败"});
                if (pcEnvShareState != OSDKIntegrationEditor.Instance.pcEnvShareState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_share");
                    OSDKIntegrationEditor.Instance.pcEnvShareState = pcEnvShareState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}