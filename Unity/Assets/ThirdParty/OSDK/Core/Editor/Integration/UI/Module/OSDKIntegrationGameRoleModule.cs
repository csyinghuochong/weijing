using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 初始化模块，必接
    /// </summary>
    public class OSDKIntegrationGameRoleModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void GameRoleLayout()
        {
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 初始化
            OSDKIntegrationEditor.Instance.showGameRole = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showGameRole,
                OSDKIntegrationString.KTitleGameRole, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showGameRole)
            {
                var tips = OSDKIntegrationString.KTipsStandardCodeGuide;
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.GameRole)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, tips, OSDKMargin.Tab1,OSDKIntegrationEditor.CanCreateSample, disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.GameRoleSampleClickAction();
                    GUIUtility.ExitGUI();
                }
                
                // 2、模拟验证
                tips = OSDKIntegrationString.KTipsPCMock;
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, tips, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvInitState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvGameRoleState, new string[]{"绑定成功", "绑定失败"});
                if (pcEnvInitState != OSDKIntegrationEditor.Instance.pcEnvGameRoleState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_game_role");
                    OSDKIntegrationEditor.Instance.pcEnvGameRoleState = pcEnvInitState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}