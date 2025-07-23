#if UNITY_IOS
namespace Douyin.Game
{
    public class iOSAuthErrorWrapper : BaseErrorWrapper<DouyinAuthorizeErrorEnum, AuthResponse>
    {
        protected override DouyinAuthorizeErrorEnum ConvertCode(int code)
        {
            switch (code)
            {
                case 0:
                    return DouyinAuthorizeErrorEnum.SUCCESS;
                case -2:
                    return DouyinAuthorizeErrorEnum.CANCEL;
                case 7:
                    return DouyinAuthorizeErrorEnum.FREQUENT;
                default:
                    return DouyinAuthorizeErrorEnum.OTHERS;
            }
        }
    }
}
#endif