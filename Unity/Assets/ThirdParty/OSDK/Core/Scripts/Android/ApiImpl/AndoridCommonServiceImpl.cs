#if UNITY_ANDROID
using System;
using UnityEngine;

namespace Douyin.Game
{
    public class AndroidCommonServiceImpl : ICommonService
    {
        public void Android_Prepare()
        {
            AndroidSDKInternalHelper.RunOnAndroidUIThread(() =>
            {
                var applicationContext = AndroidSDKInternalHelper.GetApplicationContext();
                AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic("onCreate", applicationContext);
            });
        }
            
        public void Init(Action onSuccess, Action<BaseErrorEntity<InitErrorEnum>> onFailed)
        {
            var extra = UnityContext.Instance.UnityIntegrationExtra();
            AndroidSDKInternalHelper.RunOnAndroidUIThread(() =>
            {
                var activity = AndroidSDKInternalHelper.GetActivity();
                AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic("setGameActivity",
                    activity);

                // unity公参注入
                AndroidCommonServiceBridgeFactory.ExtraCapability.CallStatic("setReportExtra",
                    AndroidSDKInternalHelper.CSharpHashMap(extra));
                
                var sdkInitCallback = new SDKInitCallback(onSuccess, onFailed);
                AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic("init", activity, sdkInitCallback);
            });
        }

        public bool IsInited()
        {
            return AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic<bool>("isInited");
        }

        public void iOS_RequireIDFA(Action<bool, string> requireCallback)
        {
            requireCallback.Invoke(true, "0");
        }

        public string GetOpenExtraInfo()
        {
            return AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic<string>("getOpenExtraInfo");
        }

        public string GetApkAttributionEx()
        {
            return AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic<string>("getApkAttributionEx");
        }

        public string GetHumeChannel()
        {
            return AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic<string>("getHumeChannel");
        }

        public string GetHumeSdkVersion()
        {
            return AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic<string>("getHumeSDKVersion");
        }

        public bool IsRunningCloud()
        {
            return AndroidCommonServiceBridgeFactory.GBCommonSDK.CallStatic<bool>("isRunningCloud");
        }

        private sealed class SDKInitCallback : AndroidJavaProxy
        {
            private readonly Action _onSuccess;
            private readonly Action<BaseErrorEntity<InitErrorEnum>> _onFailed;

            public SDKInitCallback(Action onSuccess, Action<BaseErrorEntity<InitErrorEnum>> onFailed) : base(
                AndroidCommonServiceBridgeFactory.Interface_Init_Callback)
            {
                _onSuccess = onSuccess;
                _onFailed = onFailed;
            }

            public void onSuccess()
            {
                SDKInternalUnityDispatcher.PostTask(() => { _onSuccess?.Invoke(); });
            }

            public void onFailed(int errorCode, string errorMessage)
            {
                SDKInternalUnityDispatcher.PostTask(() =>
                {
                    var errorWrapper = new AndoridInitErrorWrapper();
                    var errorEntity = new BaseErrorEntity<InitErrorEnum>();
                    var wrapperEntity = errorWrapper.Wrapper(errorEntity, errorCode, errorMessage);
                    _onFailed?.Invoke(wrapperEntity);
                });
            }
        }
    }
}

#endif