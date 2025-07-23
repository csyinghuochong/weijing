namespace Douyin.Game
{
    public enum DouyinAuthorizeErrorEnum
    {
        // 成功
        SUCCESS = 0,
        // 用户手动取消
        CANCEL = 1,
        // 访问频繁，命中风控
        FREQUENT = 7,
        // 其他错误，可根据返回 MESSAGE 分析具体错误
        OTHERS
    }
}