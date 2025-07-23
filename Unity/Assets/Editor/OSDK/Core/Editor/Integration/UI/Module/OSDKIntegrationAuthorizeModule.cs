using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 授权模块，附加
    /// </summary>
    public class OSDKIntegrationAuthorizeModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void AuthorizeLayout()
        {
            if (!OSDKIntegrationPathUtils.DouyinModuleImported) return;
            
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 授权
            OSDKIntegrationEditor.Instance.showAuthorize = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showAuthorize,
                OSDKIntegrationString.KTitleAuthorize, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showAuthorize)
            {
                var tips = OSDKIntegrationString.KTipsStandardCodeGuide;
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.Authorize)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, tips, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.AuthorizeSampleClickAction();
                    GUIUtility.ExitGUI();
                }
                
                // 2、模拟验证
                tips = OSDKIntegrationString.KTipsPCMock;
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, tips, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvAuthorizeState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvAuthorizeState, new string[]{"授权成功", "授权失败"});
                if (pcEnvAuthorizeState != OSDKIntegrationEditor.Instance.pcEnvAuthorizeState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_authorize");
                    OSDKIntegrationEditor.Instance.pcEnvAuthorizeState = pcEnvAuthorizeState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}