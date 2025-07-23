using System;
using Douyin.Game;
using UnityEngine;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class DemoCoreFunctionScript : Singeton<DemoCoreFunctionScript>
    {
        public const string ITEM_ID_SDK_INIT = "sdk_init";
        public const string ITEM_ID_IS_INIT = "sdk_is_init";
        public const string ITEM_ID_GET_OPEN_EXTRA_INFO = "get_open_extra_info";
        public const string ITEM_ID_GET_APK_ATTRIBUTION_EXTRA = "get_apk_attribution_extra";
        public const string ITEM_ID_GET_HUME_CHANNEL = "get_hume_channel";
        public const string ITEM_ID_GET_HUME_SDK_VERSION = "get_hume_sdk_version";
        public const string ITEM_ID_RUNNING_CLOUD = "is_running_cloud";

        [Preserve]
        public void FunctionDispatcher(string ItemID)
        {
            switch (ItemID)
            {
                case ITEM_ID_SDK_INIT:
                    Debug.Log("调用初始化方法");
                    // 初始化
                    DemoStandardCore.Instance.InitSDK();
                    break;

                case ITEM_ID_IS_INIT:
                    var isInited = DemoStandardCore.Instance.IsInited();
                    ShowToastAndPrint("isInit = " + isInited);
                    break;

                case ITEM_ID_GET_OPEN_EXTRA_INFO:
                    var openExtraInfo = DemoStandardCore.Instance.GetOpenExtraInfo();
                    ShowToastAndPrint("[COPY]openExtraInfo = " + openExtraInfo);
                    Clipboard.CopyToClipboard(openExtraInfo);
                    break;

                case ITEM_ID_GET_APK_ATTRIBUTION_EXTRA:
                    var apkAttributionEx = DemoStandardCore.Instance.GetApkAttributionEx();
                    ShowToastAndPrint("[COPY]apkAttributionEx = " + apkAttributionEx);
                    Clipboard.CopyToClipboard(apkAttributionEx);
                    break;

                case ITEM_ID_GET_HUME_CHANNEL:
                    var humeChannel = DemoStandardCore.Instance.GetHumeChannel();
                    ShowToastAndPrint("[COPY]humeChannel = " + humeChannel);
                    Clipboard.CopyToClipboard(humeChannel);
                    break;

                case ITEM_ID_GET_HUME_SDK_VERSION:
                    var humeSdkVersion = DemoStandardCore.Instance.GetHumeSdkVersion();
                    ShowToastAndPrint("[COPY]humeSdkVersion = " + humeSdkVersion);
                    Clipboard.CopyToClipboard(humeSdkVersion);
                    break;

                case ITEM_ID_RUNNING_CLOUD:
                    var isRunningCloud = DemoStandardCore.Instance.IsRunningCloud();
                    ShowToastAndPrint("isRunningCloud = " + isRunningCloud);
                    break;
            }
        }

        private static void ShowToastAndPrint(string message)
        {
            message = "Core " + message;
            DemoLog.D(message);
            ToastManager.Instance.ShowToast(message);
        }
    }
}