using System;

namespace ET
{
    public class X7CheckLoginData
    {
        public string guid;
        public string username;
    }

    public class X7CheckLoginResponse
    {
        public int errno;
        public string errormsg;
        public X7CheckLoginData data;
    }

    /// <summary>
    /// 小7手游登录校验：https://api.x7sy.com/user/check_v4_login
    /// sign = md5(appkey + tokenkey)，小写
    /// </summary>
    public static class X7LoginHelper
    {
        private const string CheckLoginUrl = "https://api.x7sy.com/user/check_v4_login";
        public const string AppKey = "8e4a4fc224dc249ff012e2623f670b83";

        /// <summary>
        /// 切换小号/登出后需要自动再调一次 SDK 登录（Hotfix 侧标记，不写 Init）
        /// </summary>
        public static bool PendingRelogin;

        public static async ETTask<X7CheckLoginResponse> CheckLogin(string tokenkey)
        {
            string sign = MD5Helper.StringMD5_2(AppKey + tokenkey);
            string url = $"{CheckLoginUrl}?tokenkey={Uri.EscapeDataString(tokenkey)}&sign={sign}";
            Log.ILog.Debug($"X7CheckLogin request: tokenkey={tokenkey}, sign={sign}");
            string result = await HttpClientHelper.Get(url);
            Log.ILog.Debug($"X7CheckLogin response: {result}");
            return JsonHelper.FromJson<X7CheckLoginResponse>(result);
        }


        public static async ETTask<string> CheckLoginServer(string tokenkey)
        {
            string sign = MD5Helper.StringMD5_2(AppKey + tokenkey);
            string url = $"{CheckLoginUrl}?tokenkey={Uri.EscapeDataString(tokenkey)}&sign={sign}";
            Log.ILog.Debug($"X7CheckLogin request: tokenkey={tokenkey}, sign={sign}");
            string result = await HttpClientHelper.Get(url);
            return result;
        }
    }
}
