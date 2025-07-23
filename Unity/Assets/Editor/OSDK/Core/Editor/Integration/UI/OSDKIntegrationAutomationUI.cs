using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationAutomationUI
    {
        public static void IntegrationSection()
        {
            OSDKIntegrationEditor.Instance.showSectionIntegration = 
                EditorGUILayout.Foldout(OSDKIntegrationEditor.Instance.showSectionIntegration, OSDKIntegrationString.KTitleIndex, OSDKIntegrationStyles.getSectionStyle());

            if (OSDKIntegrationEditor.Instance.showSectionIntegration)
            {
                // 初始化
                OSDKIntegrationInitModule.InitLayout();
                if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.DouyinChannel)
                {
                    // 流水分账
                    OSDKIntegrationUnionModule.UnionLayout();
                } 
                else
                {
                    // 全官服促活分账
                    OSDKIntegrationDataLinkModule.DataLinkLayout();
                }
                // 抖音授权
                OSDKIntegrationAuthorizeModule.AuthorizeLayout();
                // 账号绑定
                OSDKIntegrationGameRoleModule.GameRoleLayout();
#if UNITY_ANDROID
                // 云游戏
                if (OSDKIntegration.OSDKType == OSDKTypeEnum.Android_Merge || //支持流水分账模式一与全渠
                    OSDKIntegration.OSDKType == OSDKTypeEnum.Omnichannel_DataLink || 
                    OSDKIntegration.OSDKType == OSDKTypeEnum.Omnichannel_ActivityLink)
                {
                    OSDKIntegrationCloudGameModule.CloudGameLayout();
                }
                
                // 广告
                // if (OSDKIntegration.OSDKType == OSDKTypeEnum.Android_Merge 
                //     || OSDKIntegration.OSDKType == OSDKTypeEnum.Android_GameId)
                // {
                //      OSDKIntegrationAdModule.AdLayout();
                // }
#endif
                // 分享
                OSDKIntegrationShareModule.ShareLayout();
                // 录制
                OSDKIntegrationRecordModule.RecordLayout();
                // 看播
                OSDKIntegrationLiveModule.LiveLayout();
                // // 一键上车
                // OSDKIntegrationTeamPlayModule.TeamPlayLayout();
            }
            GUILayout.Space(12);
        }
    }
}