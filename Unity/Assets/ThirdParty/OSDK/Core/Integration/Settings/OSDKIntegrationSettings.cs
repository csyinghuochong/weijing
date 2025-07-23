using System;
using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    public enum OSDKAdType
    {
        Undefined = 0,
        Reward = 5, // 激励视频
        Interstitial = 9,   // 插全屏
        Banner = 2, // 横幅广告
        Splash = 3  // 开屏广告
    }

    public enum OSDKAdOrientation
    {
        Undefined = 0,
        Vertical = 1, // 竖屏
        Horizontal = 2 // 横屏
    }

    [Serializable]
    public class OSDKAdInfo
    {
        /// <summary>
        /// 模板代码文件名
        /// </summary>
        [HideInInspector] public string name;
        
        /// <summary>
        /// 广告类型，OSDKAdType中四种广告类型
        /// </summary>
        [HideInInspector] public OSDKAdType type;
        
        /// <summary>
        /// 广告位开放平台后台名称
        /// </summary>
        [HideInInspector] public string cloudName;
        
        /// <summary>
        /// Android广告位id
        /// </summary>
        [HideInInspector] public string androidAdid;
        
        /// <summary>
        /// Android业务id
        /// </summary>
        [HideInInspector] public string androidBizid;
        
        /// <summary>
        /// iOS广告位id（预留）
        /// </summary>
        [HideInInspector] public string iosAdid;
        
        /// <summary>
        /// iOS业务id （预留）
        /// </summary>
        [HideInInspector] public string iosBizid;
        
        /// <summary>
        /// 横屏horizontal，竖屏vertical
        /// </summary>
        [HideInInspector] public OSDKAdOrientation orientation;
        
        [HideInInspector] public bool created = false;
    }
    
    public class OSDKIntegrationSettings : ScriptableObject
    {
        public void HandleAdInfosList(List<OSDKAdInfo> infoList)
        {
            adRewardIds.Clear();
            adInterstitialIds.Clear();
            adBannerIds.Clear();
            adSplashIds.Clear();
            foreach (var info in infoList)
            {
                var type = info.type;
                if (type == OSDKAdType.Undefined) continue;

                switch (type)
                {
                    case OSDKAdType.Reward:
                        adRewardIds.Add(info);
                        break;
                    case OSDKAdType.Interstitial:
                        adInterstitialIds.Add(info);
                        break;
                    case OSDKAdType.Banner:
                        adBannerIds.Add(info);
                        break;
                    case OSDKAdType.Splash:
                        adSplashIds.Add(info);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
        
        public bool IsAndroidTab => platformTabIndex == 0;
        
        public bool IsIOSTab => platformTabIndex == 1;
        
        // 【广告】获取广告位
        public List<OSDKAdInfo> GetAdids(OSDKSampleType type)
        {
            switch (type)
            {
                case OSDKSampleType.AdReward: return adRewardIds;
                case OSDKSampleType.AdNewInteraction: return adInterstitialIds;
                case OSDKSampleType.AdBanner: return adBannerIds;
                case OSDKSampleType.AdSplash: return adSplashIds;
                default: return null;
            }
        }
        
        /** 广告信息 */
        [SerializeField] public List<OSDKAdInfo> adRewardIds = new List<OSDKAdInfo>();
        [SerializeField] public List<OSDKAdInfo> adInterstitialIds = new List<OSDKAdInfo>();
        [SerializeField] public List<OSDKAdInfo> adBannerIds = new List<OSDKAdInfo>();
        [SerializeField] public List<OSDKAdInfo> adSplashIds = new List<OSDKAdInfo>();
        
        /** UI布局信息 */
        [SerializeField] public int platformTabIndex;/*平台选择*/
        [SerializeField] public bool showSectionIntegration = true;/*展示自助发行Section*/
        [SerializeField] public bool showSectionEnvironment = true;/*展示环境配置Section*/
        [SerializeField] public bool showSectionHelpCenter = true;/*展示帮助中心Section*/
        [SerializeField] public bool showSectionArchive;/*构建Section*/
        [SerializeField] public bool showSectionVersion = true;/*版本Section*/
        [SerializeField] public bool showSectionSampleCenter = true;/*Sample Section*/
        [SerializeField] public bool showInit;
        [SerializeField] public bool showGameRole;
        [SerializeField] public bool showAuthorize;
        [SerializeField] public bool showUnion;
        [SerializeField] public bool showDataLink;
        [SerializeField] public bool showAd;
        [SerializeField] public bool showAdConfig;
        [SerializeField] public bool showRewardAd;
        [SerializeField] public bool showBannerAd;
        [SerializeField] public bool showSplashAd;
        [SerializeField] public bool showInterstitialAd;
        [SerializeField] public bool showShare;
        [SerializeField] public bool showRecord;
        [SerializeField] public bool showLive;
        [SerializeField] public bool showCloudGame;
        [SerializeField] public bool showTeamPlay;
        
        [SerializeField] public bool showMoreSettings;
        [SerializeField] public bool showInfoSettings;/*配置信息展示*/
        [SerializeField] public bool showIOSPermissions;/*iOS权限展示*/
        
        [SerializeField] public bool showArchiveIOSProfile;/*iOS环境证书展示*/

        /** 模拟回调配置信息 */
        [SerializeField] public int pcEnvInitState;
        [SerializeField] public int pcEnvGameRoleState;
        [SerializeField] public int pcEnvAuthorizeState;
        [SerializeField] public int pcEnvADConfigState;
        [SerializeField] public int pcEnvADLoadState;
        [SerializeField] public int pcEnvADShowState;
        [SerializeField] public int pcEnvADRewardState;
        [SerializeField] public int pcEnvAccountLoginState;
        [SerializeField] public int pcEnvAccountSwitchState;
        [SerializeField] public int pcEnvAccountLogoutState;
        [SerializeField] public int pcEnvPayResultState;
        
        [SerializeField] public int pcEnvLiveConfigState;
        [SerializeField] public int pcEnvLiveEnterRoomState;
        [SerializeField] public int pcEnvLiveFetchRoomListState;
        [SerializeField] public int pcEnvShareState;
        [SerializeField] public int pcEnvTeamPlayState;
        [SerializeField] public int pcEnvStartRecordState;
        [SerializeField] public int pcEnvStopRecordState;
        [SerializeField] public int pcEnvGetRecordListState;
        [SerializeField] public int pcEnvDeleteRecordState;
        [SerializeField] public int pcEnvCloudGameMsgSendState;
        
        /** SDK配置信息 */
        [SerializeField] public string iOSUserTrackingUsageDescription = "该标识符用于向您推送个性化服务";/*iOS用户信息权限描述*/
        [SerializeField] public string iOSPhotoLibraryUsageDescription = "用于选择相册内的资源进行分享";/*iOS相册权限描述*/
        
        /** Android配置信息 */
        [SerializeField] public string pAndroidAppID;/* Android appid */
        [SerializeField] public string pAndroidAppName;/* Android app name */
        [SerializeField] public string pAndroidClientKey;/* Android ClientKey */
        [SerializeField] public int pAndroidUnionMode = 100;/* Android union mode */
        [SerializeField] public string pAndroidSdkType = "Android_Merge";/* Android osdk type，Android_Merge */
        [SerializeField] public string pAndroidLiveTTSDKID;
        [SerializeField] public string pAndroidLiveTTWebcastID;
        [SerializeField] public string pAndroidLiveLicenseUpdateTime;/*直播推流证书更新时间*/
        
        /** iOS配置信息 */
        [SerializeField] public string piOSAppID;/* iOS appid */
        [SerializeField] public string piOSAppName;/* iOS app name */
        [SerializeField] public string piOSClientKey;/* iOS ClientKey */
        [SerializeField] public int piOSUnionMode = 100;/* iOS union mode */
        [SerializeField] public string piOSSdkType = "iOS";/* iOS OSDK type */
        [SerializeField] public string piOSLiveTTSDKID;
        [SerializeField] public string piOSLiveTTWebcastID;
        [SerializeField] public string piOSLiveLicenseUpdateTime;/*直播推流证书更新时间*/
        [SerializeField] public string liveMsextUpdateTime;/*mesext文件更新时间*/
        
        //【注意！】获取bizMode统一使用OSDKIntegrationConfig.GetBizMode() osdkTypeState此字段仅用于开发者环境配置，对外产物环境该字段不可用 */
        [SerializeField] public int osdkTypeState = 0; /*CP接入模式，1流水分账，0全官服促活 */ 
        
        [SerializeField] public int debugModeState = 0;/*调试开关，0关闭，1开启*/
        [SerializeField] public int gameStageState = 0;/*游戏阶段，0公测，1内测*/
        [SerializeField] public bool iosNeedPushExtension;/*ios推送扩展功能*/

        /** Archive打包信息 */
        [SerializeField] public int archiveProfileTypeSelect;/* 配置文件类型 */
        [SerializeField] public string archiveProfileTeamID;/* 配置文件Team ID */
        
        [SerializeField] public string developmentProfileUuid;/* development配置文件UUID */
        [SerializeField] public string developmentPushUuid;/* development push配置文件UUID */
        
        [SerializeField] public string productionProfileUuid;/* production配置文件UUID */
        [SerializeField] public string productionPushUuid;/* production push配置文件UUID */

        /** Version版本信息 */
        [SerializeField] public long recommendSdkVersion;/* 推荐升级的目标sdk版本（一般而言，就是目前已发布的最高版本） */
        [SerializeField] public long forceSdkVersion;/* 强制升级的目标sdk版本。0表示没有强制版本 */
        [SerializeField] public string recommendDocumentLink;/* 推荐升级版本，对应的文档链接 */
        [SerializeField] public string forceDocumentLink;/* 强制升级版本，对应的文档链接 */
        [SerializeField] public bool lastFetchVersionSuccess;/* 最近一次拉取是否成功 */
        [SerializeField] public long lastFetchVersionTime;/* 最近一次拉取版本信息的时间戳（C# DateTime.Ticks） */
        [SerializeField] public long lastAutoPopupVersionTime;/* 最近一次自动弹出更新提示的时间戳（C# DateTime.Ticks）。用于限制弹出频率 */

    }
}