namespace Douyin.Game
{
    public enum InitErrorEnum
    {
        // 未知错误
        UNKNOW = 1,
        // 环境配置错误，例如参数、网络异常等
        ENVIRONMENT = 2,
        //禁止在子线程调用
        ERROR_FORBIDDEN = 3,
        //osdk_type与接入组件不匹配
        ERROR_COMPONENT= 4,
        //初始化禁用，未开启SDK合作业务
        ERROR_INIT_DISABLE = 5,
    }
}