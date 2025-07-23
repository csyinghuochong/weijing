using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 看播模块，附加
    /// </summary>
    public class OSDKIntegrationLiveModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void LiveLayout()
        {
            if (!OSDKIntegrationPathUtils.LiveModuleImported) return;
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            // 初始化
            OSDKIntegrationEditor.Instance.showLive = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showLive,
                OSDKIntegrationString.KTitleLive, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showLive)
            {
                // 1、标准化代码跳转
                GUILayout.Space(12);
                var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.Live)
                    ? OSDKIntegrationString.KTitleOpenButton
                    : OSDKIntegrationString.KTitleCreateButton;
                var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                    buttonTitle, OSDKIntegrationString.KTipsStandardCodeGuide, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, 
                    disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                if (clicked)
                {
                    OSDKIntegrationSampleHandler.LiveSampleClickAction();
                    GUIUtility.ExitGUI();
                }
                
                // 2、模拟验证
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvLiveConfigState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvLiveConfigState,
                        new string[] { "直播配置成功", "直播配置失败" });
                if (pcEnvLiveConfigState != OSDKIntegrationEditor.Instance.pcEnvLiveConfigState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_live_config");
                    OSDKIntegrationEditor.Instance.pcEnvLiveConfigState = pcEnvLiveConfigState;
                }
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvLiveEnterRoomState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvLiveEnterRoomState,
                        new string[] { "进入房间成功", "进入房间失败" });
                if (pcEnvLiveEnterRoomState != OSDKIntegrationEditor.Instance.pcEnvLiveEnterRoomState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_live_enter_room");
                    OSDKIntegrationEditor.Instance.pcEnvLiveEnterRoomState = pcEnvLiveEnterRoomState;
                }
                
                // 拉取接口模拟验证
                GUILayout.Space(8);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitlePCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvLiveFetchRoomListState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvLiveFetchRoomListState,
                        new string[] { "拉取直播间列表成功", "拉取直播间列表失败" });
                if (pcEnvLiveFetchRoomListState != OSDKIntegrationEditor.Instance.pcEnvLiveFetchRoomListState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_live_fetch_room");
                    OSDKIntegrationEditor.Instance.pcEnvLiveFetchRoomListState = pcEnvLiveFetchRoomListState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}