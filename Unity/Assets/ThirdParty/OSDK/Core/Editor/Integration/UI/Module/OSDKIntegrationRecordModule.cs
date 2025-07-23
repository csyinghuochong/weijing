using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 录制模块，附加
    /// </summary>
    public class OSDKIntegrationRecordModule
    {
        // ReSharper disable Unity.PerformanceAnalysis
        public static void RecordLayout()
        {
            if (!OSDKIntegrationPathUtils.ScreenRecordModuleImported) return;
            GUILayout.Space(12);
            EditorGUI.indentLevel++;
            
            OSDKIntegrationEditor.Instance.showRecord = EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showRecord,
                OSDKIntegrationString.KTitleRecord, OSDKIntegrationStyles.getStepStyle());
            if (OSDKIntegrationEditor.Instance.showRecord)
            {
                // 标准化代码跳转
                    GUILayout.Space(12);
                    var buttonTitle = OSDKIntegrationPathUtils.StandardSampleTargetFileIfExist(OSDKSampleType.Record)
                        ? OSDKIntegrationString.KTitleOpenButton
                        : OSDKIntegrationString.KTitleCreateButton;
                    var clicked = OSDKIntegrationLayout.LabelButtonTipsLayout(OSDKIntegrationString.KTitleStandardCodeGuide,
                        buttonTitle, OSDKIntegrationString.KTipsStandardCodeGuide, OSDKMargin.Tab1, OSDKIntegrationEditor.CanCreateSample, 
                        disableWarningText: OSDKIntegrationString.KWarningSecretKey);
                    if (clicked)
                    {
                        OSDKIntegrationSampleHandler.RecordSampleClickAction();
                        GUIUtility.ExitGUI();
                    }
                // 开始录制模拟验证
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleStartRecordPCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvStartRecordState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvStartRecordState, new string[]{"成功", "失败"});
                if (pcEnvStartRecordState != OSDKIntegrationEditor.Instance.pcEnvStartRecordState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_start_record");
                    OSDKIntegrationEditor.Instance.pcEnvStartRecordState = pcEnvStartRecordState;
                }
                // 结束录制模拟验证
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleStopRecordPCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvStopRecordState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvStopRecordState, new string[]{"成功", "失败"});
                if (pcEnvStopRecordState != OSDKIntegrationEditor.Instance.pcEnvStopRecordState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_stop_record");
                    OSDKIntegrationEditor.Instance.pcEnvStopRecordState = pcEnvStopRecordState;
                }
                // 获取录制列表模拟验证
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleGetRecordListPCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvGetRecordListState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvGetRecordListState, new string[]{"成功", "失败"});
                if (pcEnvGetRecordListState != OSDKIntegrationEditor.Instance.pcEnvGetRecordListState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_get_record_list");
                    OSDKIntegrationEditor.Instance.pcEnvGetRecordListState = pcEnvGetRecordListState;
                }
                // 获取录制列表模拟验证
                GUILayout.Space(12);
                OSDKIntegrationLayout.LabelTipsLayout(OSDKIntegrationString.KTitleDeleteRecordVideoPCMock, null, OSDKMargin.Tab1);
                GUILayout.Space(8);
                var pcEnvDeleteRecordState =
                    OSDKIntegrationLayout.EnumPopupLayout(OSDKIntegrationEditor.Instance.pcEnvDeleteRecordState, new string[]{"成功", "失败"});
                if (pcEnvDeleteRecordState != OSDKIntegrationEditor.Instance.pcEnvDeleteRecordState)
                {
                    OSDKIntegrationRecord.MockSwitch("mock_delete_record");
                    OSDKIntegrationEditor.Instance.pcEnvDeleteRecordState = pcEnvDeleteRecordState;
                }
                GUILayout.Space(8);
            }
            EditorGUI.indentLevel--;
        }
    }
}