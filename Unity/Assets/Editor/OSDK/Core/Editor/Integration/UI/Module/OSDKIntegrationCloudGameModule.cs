using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationCloudGameModule
    {
        public static void CloudGameLayout()
        {
            if (!OSDKIntegrationPathUtils.CloudGameModuleImported) return;
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 初始化
            OSDKIntegrationEditor.Instance.showCloudGame = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showCloudGame,
                OSDKIntegrationString.KTitleCloudGame, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showCloudGame)
            {
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.CloudGame)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, OSDKIntegrationString.KTipsStandardCodeGuide, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, 
                    disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.CloudGameSampleClickAction();
                    GUIUtility.ExitGUI();
                }
                
                /*
                // 2、模拟验证
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvCloudGameMsgSendState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvCloudGameMsgSendState,
                        new string[] { "消息发送成功", "消息发送失败" });
                if (pcEnvCloudGameMsgSendState != OSDKIntegrationEditor.Instance.pcEnvCloudGameMsgSendState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_cld_game_msg_send");
                    OSDKIntegrationEditor.Instance.pcEnvCloudGameMsgSendState = pcEnvCloudGameMsgSendState;
                }
                GUILayout.Space(8);
                */
            }
            EditorGUI.indentLevel--;
        }
    }
}