namespace Douyin.Game
{

    public enum OSDKTypeEnum
    {
        Undefined,
        Android_Merge,
        Android_GameId,
        Android_Official,
        Android_Else,
        Omnichannel_DataLink,
        Omnichannel_ActivityLink,
        // iOS 非全渠时的OSDKType取值
        iOS,
    }

    public enum OSDKPlatform
    {
        Android = 1,
        iOS = 2
    }
    
    // 标准化代码 类型
    public enum OSDKSampleType
    {
        // 初始化
        Init = 1,
        // 抖音授权
        Authorize,
        // 抖音授权
        GameRole,
        // 游戏归因上报
        Cps,
        // 广告基础配置
        AdBasic,
        // 激励视频广告
        AdReward,
        // 插全屏广告
        AdNewInteraction,
        // 横幅广告
        AdBanner,
        // 开屏广告
        AdSplash,
        // 抖音账号登录
        DouYinAccount,
        // 游戏账号登录
        GameAccount,
        // 抖音支付
        DouYinPay,
        // 抖音分享
        Share,
        // 屏幕录制
        Record,
        // 抖音看播
        Live,
        // 云游戏
        CloudGame,
        // 一起玩
        TeamPlay,
        // 全官服促活分账
        DataLink
    }
    
    // 模拟验证配置状态
    public enum OSDKMockStatus
    {
        Success = 0,
        Fail = 1,
    }
}