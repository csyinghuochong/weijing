#if UNITY_ANDROID
namespace Douyin.Game
{
    public class AndoridInitErrorWrapper : BaseErrorWrapper<InitErrorEnum, BaseErrorEntity<InitErrorEnum>>
    {
        protected override InitErrorEnum ConvertCode(int code)
        {
            switch (code)
            {
                case -1:
                    return InitErrorEnum.ENVIRONMENT;
                case -4:
                    return InitErrorEnum.ERROR_FORBIDDEN;
                case -5:
                    return InitErrorEnum.ERROR_COMPONENT;
                case -13:
                    return InitErrorEnum.ERROR_INIT_DISABLE;
                default:
                    return InitErrorEnum.UNKNOW;
            }
        }
    }
}

#endif