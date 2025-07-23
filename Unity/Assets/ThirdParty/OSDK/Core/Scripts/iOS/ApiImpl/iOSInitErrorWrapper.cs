#if UNITY_IOS
namespace Douyin.Game
{
    public class iOSInitErrorWrapper : BaseErrorWrapper<InitErrorEnum, BaseErrorEntity<InitErrorEnum>>
    {
        protected override InitErrorEnum ConvertCode(int code)
        {
            switch (code)
            {
                case -11001:
                    return InitErrorEnum.ENVIRONMENT;
                case -3:
                    return InitErrorEnum.ENVIRONMENT;
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