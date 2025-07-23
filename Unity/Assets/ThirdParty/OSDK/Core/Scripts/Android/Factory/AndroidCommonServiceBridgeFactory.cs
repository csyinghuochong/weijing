using System;
using UnityEngine;

#if UNITY_ANDROID
namespace Douyin.Game
{
    public static class AndroidCommonServiceBridgeFactory
    {
        public static readonly AndroidJavaClass GBCommonSDK =
            new AndroidJavaClass("com.bytedance.ttgame.tob.common.host.api.GBCommonSDK");
        
        public static readonly AndroidJavaClass ExtraCapability =
            new AndroidJavaClass("com.bytedance.ttgame.tob.common.host.api.internal.ExtraCapability");

        // 初始化回调
        public const string Interface_Init_Callback =
            "com.bytedance.ttgame.tob.common.host.api.callback.InitCallback";
        
        // public static AndroidJavaObject GetService(AndroidJavaClass androidJavaClass)
        // {
        //     return GBCommonSDK.CallStatic<AndroidJavaObject>("getService",
        //         androidJavaClass);
        // }
    }




}

#endif