namespace Douyin.Game
{
    public class AuthInfo
    {
        /// <summary>
        /// 通过 AuthCode 请求服务端获取的 access_token
        /// </summary>
        public string Token;
        
        /// <summary>
        /// 通过 AuthCode 请求服务端获取的 open_id
        /// </summary>
        public string OpenID;
    }
}