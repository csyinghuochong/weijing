using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationTeamPlayModule
    {
        public static void TeamPlayLayout()
        {
            if (!OSDKIntegrationPathUtils.TeamPlayModuleImported) return;
            
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 授权
            OSDKIntegrationEditor.Instance.showTeamPlay = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showTeamPlay,
                OSDKIntegrationString.KTitleTeamPlay, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showTeamPlay)
            {
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.TeamPlay)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, OSDKIntegrationString.KTipsStandardCodeGuide, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, 
                    disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.TeamPlaySampleClickAction();
                    GUIUtility.ExitGUI();
                }
                // 2、模拟验证
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvTeamPlayState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvTeamPlayState, new string[]{"一键上车成功", "一键上车失败"});
                if (pcEnvTeamPlayState != OSDKIntegrationEditor.Instance.pcEnvTeamPlayState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_team_play");
                    OSDKIntegrationEditor.Instance.pcEnvTeamPlayState = pcEnvTeamPlayState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}