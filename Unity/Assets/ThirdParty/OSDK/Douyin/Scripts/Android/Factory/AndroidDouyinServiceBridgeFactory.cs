using UnityEngine;

#if UNITY_ANDROID

namespace Douyin.Game
{
    public static class AndroidDouyinServiceBridgeFactory
    {
        public const string DouYinClassName = "com.bytedance.ttgame.tob.optional.aweme.api.IAwemeService";
        private static readonly AndroidJavaClass DouyinServiceClass =
            new AndroidJavaClass(DouYinClassName);

        public const string Interface_DouyinAuth_Callback =
            "com.bytedance.ttgame.tob.optional.aweme.api.callback.AwemeAuthCallback";

        public const string Interface_DouYinAuthInfoDelegate =
            "com.bytedance.ttgame.tob.optional.aweme.api.callback.IDouYinAuthInfoDelegate";

        //public static AndroidJavaObject DouyinService => AndroidCommonServiceBridgeFactory.GetService(DouyinServiceClass);

        public static AndroidJavaObject CSharpDouYinInfoToJavaObject(AuthInfo info)
        {
            var androidJavaObject =
                new AndroidJavaObject("com.bytedance.ttgame.tob.optional.aweme.api.callback.DouYinAuthInfo", info.Token,
                    info.OpenID);
            return androidJavaObject;
        }
    }
}

#endif