using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 初始化模块，必接
    /// </summary>
    public class OSDKIntegrationInitModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void InitLayout()
        {
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 初始化
            OSDKIntegrationEditor.Instance.showInit = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showInit,
                OSDKIntegrationString.KTitleInit, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showInit)
            {
                var tips = OSDKIntegrationString.KTipsStandardCodeGuide;
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.Init)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, tips, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.InitSampleClickAction();
                    GUIUtility.ExitGUI();
                }
                
                    
                // 2、模拟验证
                tips = OSDKIntegrationString.KTipsPCMock;
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, tips, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvInitState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvInitState, new string[]{"初始化成功", "初始化失败"});
                if (pcEnvInitState != OSDKIntegrationEditor.Instance.pcEnvInitState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_init");
                    OSDKIntegrationEditor.Instance.pcEnvInitState = pcEnvInitState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}