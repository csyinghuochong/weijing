using System;
using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    public static class OSDKIntegration
    {
        private static OSDKIntegrationSettings Settings => Resources.Load<OSDKIntegrationSettings>("OSDKIntegrationSettings");
        
        // 调试环境
        public static bool IsDebugMode => Settings.debugModeState == 1;
        public static string AndroidClientKey => Settings.pAndroidClientKey;
        public static string iOSClientKey => Settings.piOSClientKey;

        public static string AppId
        {
            get
            {
#if UNITY_ANDROID || UNITY_EDITOR
                return Settings.pAndroidAppID;
#elif UNITY_IOS
                return Settings.piOSAppID;
#endif
            }
        }
        
        // OSDK类型(接入类型)，与config.json中的osdk_type对应的枚举类型
        public static OSDKTypeEnum OSDKType
        {
            get
            {
#if UNITY_ANDROID
                switch (Settings.pAndroidSdkType)
                {
                    case "Android_Merge":
                        return OSDKTypeEnum.Android_Merge;
                    case "Android_GameId":
                        return OSDKTypeEnum.Android_GameId;
                    case "Android_Official":
                        return OSDKTypeEnum.Android_Official;
                    case "Omnichannel_DataLink":
                        return OSDKTypeEnum.Omnichannel_DataLink;
                    case "Omnichannel_ActivityLink":
                        return OSDKTypeEnum.Omnichannel_ActivityLink;
                    case "Android_Else":
                        return OSDKTypeEnum.Android_Else;
                }
#elif UNITY_IOS
                switch (Settings.piOSSdkType)
                {
                    case "Omnichannel_DataLink":
                        return OSDKTypeEnum.Omnichannel_DataLink;
                    case "Omnichannel_ActivityLink":
                        return OSDKTypeEnum.Omnichannel_ActivityLink;
                    case "iOS":
                        return OSDKTypeEnum.iOS;
                }
#endif
                return OSDKTypeEnum.Undefined;
            }
        }
        
        public static int PkgType => Settings.gameStageState;
        

        #region 广告参数获取
        /// <summary>
        /// 获取广告配置中某广告类型的第一个广告bizId
        /// </summary>
        /// <param name="adType"></param>
        /// <param name="fallback">读不到的时候返回的默认值</param>
        /// <returns></returns>
        public static string GetAdBizId(OSDKAdType adType, string fallback)
        {
            var adInfos = GetAdInfos(adType);
            if (adInfos?.Count > 0)
            {
                return adInfos[0].androidBizid; // 目前仅支持Android
            }

            return fallback;
        }
        
        /// <summary>
        /// 获取广告配置中某广告类型的第一个兜底广告位id
        /// </summary>
        /// <param name="adType"></param>
        /// <param name="fallback">读不到的时候返回的默认值</param>
        /// <returns></returns>
        public static string GetAdBackupCodeId(OSDKAdType adType, string fallback)
        {
            var adInfos = GetAdInfos(adType);
            if (adInfos?.Count > 0)
            {
                return adInfos[0].androidAdid; // 目前仅支持Android
            }

            return fallback;
        }

        private static List<OSDKAdInfo> GetAdInfos(OSDKAdType adType)
        {
            List<OSDKAdInfo> adInfos = new List<OSDKAdInfo>();
            switch (adType)
            {
                case OSDKAdType.Reward:
                    adInfos = Settings.adRewardIds;
                    break;
                case OSDKAdType.Interstitial:
                    adInfos = Settings.adInterstitialIds;
                    break;
                case OSDKAdType.Banner:
                    adInfos = Settings.adBannerIds;
                    break;
                case OSDKAdType.Splash:
                    adInfos = Settings.adSplashIds;
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"getAdBizId: not supported ad type: {adType}");
            }

            return adInfos;
        }
        #endregion

        #region 模拟验证状态获取
        // 初始化模拟验证配置
        public static OSDKMockStatus InitMock => (OSDKMockStatus) Settings.pcEnvInitState;
        // 授权模拟验证
        public static OSDKMockStatus AuthorizeMock => (OSDKMockStatus) Settings.pcEnvAuthorizeState;
        
        public static OSDKMockStatus GameRoleBindMock => (OSDKMockStatus) Settings.pcEnvGameRoleState;
        // 广告模拟验证
        public static OSDKMockStatus AdConfigMock => (OSDKMockStatus)Settings.pcEnvADConfigState;
        public static OSDKMockStatus AdLoadMock => (OSDKMockStatus) Settings.pcEnvADLoadState;
        public static OSDKMockStatus AdShowMock => (OSDKMockStatus) Settings.pcEnvADShowState;
        public static OSDKMockStatus AdRewardMock => (OSDKMockStatus) Settings.pcEnvADRewardState;
        // 流水分账 - 账号登录
        // 账号登录成功/失败
        public static OSDKMockStatus AccountLoginMock => (OSDKMockStatus) Settings.pcEnvAccountLoginState;
        // 账号切换成功/失败
        public static OSDKMockStatus AccountSwitchMock => (OSDKMockStatus) Settings.pcEnvAccountSwitchState;
        // 账号退出成功/失败
        public static OSDKMockStatus AccountLogoutMock => (OSDKMockStatus) Settings.pcEnvAccountLogoutState;
        // 流水分账 - 支付
        // 支付结果成功/失败
        public static OSDKMockStatus PayResultMock => (OSDKMockStatus) Settings.pcEnvPayResultState;
        // 云游戏
        public static OSDKMockStatus CloudGameSendMsgMock => (OSDKMockStatus)Settings.pcEnvCloudGameMsgSendState;
        // 看播
        public static OSDKMockStatus LiveConfigMock => (OSDKMockStatus)Settings.pcEnvLiveConfigState;
        public static OSDKMockStatus LiveEnterMock => (OSDKMockStatus)Settings.pcEnvLiveEnterRoomState;
        public static OSDKMockStatus LiveFetchMock => (OSDKMockStatus)Settings.pcEnvLiveFetchRoomListState;
        // 录屏
        public static OSDKMockStatus RecordStartMock => (OSDKMockStatus)Settings.pcEnvStartRecordState;
        public static OSDKMockStatus RecordStopMock => (OSDKMockStatus)Settings.pcEnvStopRecordState;
        public static OSDKMockStatus RecordDeleteMock => (OSDKMockStatus)Settings.pcEnvDeleteRecordState;
        public static OSDKMockStatus RecordGetListMock => (OSDKMockStatus)Settings.pcEnvGetRecordListState;
        // 分享
        public static OSDKMockStatus ShareMock => (OSDKMockStatus)Settings.pcEnvShareState;

        #endregion
    }
}