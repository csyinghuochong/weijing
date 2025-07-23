#if UNITY_IOS
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Douyin.Game
{
    public class iOSCommonServiceImpl : ICommonService
    {
        // SDK初始化属性
        private delegate void OSDKInitialize_Success();
        private delegate void OSDKInitialize_Failed(int errorCode, string errorMsg);
        
        private static Action _initSuccessCallback;
        private static Action<BaseErrorEntity<InitErrorEnum>> _initFailedCallback;
        
        // IDFA属性
        private delegate void OSDKRequireIDFACallback(bool hasAuthorized, string idfaString);
        private static Action<bool, string> _requireIdfaCallbackAction;

        public void Android_Prepare()
        {
            // do nothing
        }

        // SDK初始化方法
        public void Init(Action onSuccess, Action<BaseErrorEntity<InitErrorEnum>> onFailed)
        {
            // unity公参注入
            OSDKInjectUnityParams(Json.Serialize(UnityContext.Instance.UnityIntegrationExtra()));

            _initSuccessCallback = onSuccess;
            _initFailedCallback = onFailed;
            OSDKInitialize(OSDKInitialize_SuccessMethod, OSDKInitialize_FailMethod);
        }

        public bool IsInited()
        {
            return OSDKIsInited();
        }

        // IDFA方法
        public void iOS_RequireIDFA(Action<bool, string> requireCallback)
        {
            _requireIdfaCallbackAction = requireCallback;
            OSDKiOSRequireIDFA(OSDKRequireIDFACallback_Method);
        }

        public string GetOpenExtraInfo()
        {
            return string.Empty;
        }

        public string GetApkAttributionEx()
        {
            return string.Empty;
        }

        public string GetHumeChannel()
        {
            return string.Empty;
        }

        public string GetHumeSdkVersion()
        {
            return string.Empty;
        }

        public bool IsRunningCloud()
        {
            return false;
        }

        [DllImport("__Internal")]
        private static extern void OSDKInitialize(OSDKInitialize_Success successCallback, OSDKInitialize_Failed failedCallback);
        
        [DllImport("__Internal")]
        private static extern void OSDKiOSRequireIDFA(OSDKRequireIDFACallback requireIDFACallback);
        
        [DllImport("__Internal")]
        private static extern bool OSDKIsInited();

        [DllImport("__Internal")]
        private static extern void OSDKInjectUnityParams(string paramsJsonString);

        
        [AOT.MonoPInvokeCallback(typeof(OSDKInitialize_Success))]
        private static void OSDKInitialize_SuccessMethod()
        {
            PostTask(() =>
            {
                _initSuccessCallback?.Invoke();
            });
        }

        [AOT.MonoPInvokeCallback(typeof(OSDKInitialize_Failed))]
        private static void OSDKInitialize_FailMethod(int errorCode, string errorMsg)
        {
            PostTask(() =>
            {
                if (_initFailedCallback != null)
                {
                    var errorWrapper = new iOSInitErrorWrapper();
                    var errorEntity = new BaseErrorEntity<InitErrorEnum>();
                    var wrapperEntity = errorWrapper.Wrapper(errorEntity, errorCode, errorMsg);
                    _initFailedCallback.Invoke(wrapperEntity);
                }
            });
        }
        
        [AOT.MonoPInvokeCallback(typeof(OSDKRequireIDFACallback))]
        private static void OSDKRequireIDFACallback_Method(bool hasAuthorized, string idfaString)
        {
            PostTask(() =>
            {
                _requireIdfaCallbackAction?.Invoke(hasAuthorized, idfaString);
            });
        }

        private static void PostTask(Action action)
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                action?.Invoke();
            });
        }

    }
}
#endif