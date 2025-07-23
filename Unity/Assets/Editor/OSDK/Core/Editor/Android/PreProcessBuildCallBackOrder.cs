namespace Douyin.Game
{
    // 数字越小越优先执行
    public enum PreProcessBuildCallBackOrder
    {
        // 准备阶段，最优先执行
        Prepare = 0,

        // Core模块
        Core = 1,

        // 抖音授权登录模块
        Douyin = 2,

        // Union
        Union = 3,

        // 数据采集
        DataLink = 4,

        // 直播
        Live = 5,

        // 录屏
        ScreenRecord = 6,

        // 分享
        Share = 7,

        // 一键上车
        TeamPlay = 8,

        // 云游戏
        CloudGame = 9,
        
        // Cps
        Cps = 10,
        
        // 检测工具（开发调试用）
        DevTools = 11,
    }
}