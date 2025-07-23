#if UNITY_ANDROID

namespace Douyin.Game
{
    public class AndroidAuthErrorWrapper : BaseErrorWrapper<DouyinAuthorizeErrorEnum, AuthResponse>
    {
        protected override DouyinAuthorizeErrorEnum ConvertCode(int code)
        {
            switch (code)
            {
                case 0:
                    return DouyinAuthorizeErrorEnum.SUCCESS;
                case 7:
                    return DouyinAuthorizeErrorEnum.FREQUENT;
                case -2:
                    return DouyinAuthorizeErrorEnum.CANCEL;
                default:
                    return DouyinAuthorizeErrorEnum.OTHERS;
            }
        }
    }
}

#endif