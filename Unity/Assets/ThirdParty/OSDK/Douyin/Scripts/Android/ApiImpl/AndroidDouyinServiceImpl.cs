using System;
using UnityEngine;

#if UNITY_ANDROID
namespace Douyin.Game
{
    public class AndroidDouyinServiceImpl : IDouyinService
    {
        private DouYinAuthInfoDelegate _douYinAuthInfoDelegate = new DouYinAuthInfoDelegate();
        private bool _setAuthInfoGetCallbackFinish;

        public void Authorize(string scope, Action<AuthResponse> authCallback)
        {
            AndroidSDKInternalHelper.RunOnAndroidUIThread(() =>
            {
                var douyinAuthCallback = new DouyinAuthCallback(authCallback);
                AndroidUnityBridge.CallServiceMethodEx(AndroidDouyinServiceBridgeFactory.DouYinClassName, "authorize",
                    AndroidSDKInternalHelper.GetActivity(),
                    scope, douyinAuthCallback);
            });
        }

        public void SetAuthInfoGetCallback(Action<Action<AuthInfo, AuthError>> getCallback)
        {
            _douYinAuthInfoDelegate.SetAuthInfoGetCallback(getCallback);
            InvokeAndroidNativeCallback();
        }

        public void SetAuthInfoUpdateCallback(Action<Action<AuthInfo, AuthError>> updateCallback)
        {
            _douYinAuthInfoDelegate.SetAuthInfoUpdateCallback(updateCallback);
            InvokeAndroidNativeCallback();
        }

        private void InvokeAndroidNativeCallback()
        {
            if (_setAuthInfoGetCallbackFinish)
            {
                return;
            }

            AndroidSDKInternalHelper.RunOnAndroidUIThread(() =>
            {
                AndroidUnityBridge.CallServiceMethodEx(AndroidDouyinServiceBridgeFactory.DouYinClassName,"setDouYinAuthInfoDelegate",
                    _douYinAuthInfoDelegate);
                _setAuthInfoGetCallbackFinish = true;
            });
        }

        public void ClearDouYinAuthInfo()
        {
            AndroidSDKInternalHelper.RunOnAndroidUIThread(() =>
            {
                AndroidUnityBridge.CallServiceMethod(AndroidDouyinServiceBridgeFactory.DouYinClassName, "clearDouYinAuthInfo",null);
            });
        }


        private sealed class DouyinAuthCallback : AndroidJavaProxy
        {
            private readonly Action<AuthResponse> _authCallback;

            public DouyinAuthCallback(Action<AuthResponse> authCallback) : base(
                AndroidDouyinServiceBridgeFactory.Interface_DouyinAuth_Callback)
            {
                _authCallback = authCallback;
            }

            public void onResponse(AndroidJavaObject androidJavaObject)
            {
                SDKInternalUnityDispatcher.PostTask(() =>
                {
                    if (androidJavaObject != null)
                    {
                        var errorCode = androidJavaObject.Get<int>("errorCode");
                        var errorMessage = androidJavaObject.Get<string>("errorMsg");
                        var authCode = androidJavaObject.Get<string>("authCode");
                        var grantedPermissions = androidJavaObject.Get<string>("grantedPermissions");
                        var authResponse = new AuthResponse();
                        authResponse.AuthCode = authCode;
                        authResponse.GrantedPermissions = grantedPermissions;

                        authResponse = new AndroidAuthErrorWrapper().Wrapper(authResponse, errorCode, errorMessage);
                        _authCallback?.Invoke(authResponse);
                    }
                    else
                    {
                        SDKInternalLog.E("androidJavaObject is null...");
                    }
                });
            }
        }

        private sealed class DouYinAuthInfoDelegate : AndroidJavaProxy
        {
            private Action<Action<AuthInfo, AuthError>> _getCallback;
            private Action<Action<AuthInfo, AuthError>> _updateCallback;

            public DouYinAuthInfoDelegate() : base(AndroidDouyinServiceBridgeFactory.Interface_DouYinAuthInfoDelegate)
            {
            }

            public void SetAuthInfoGetCallback(Action<Action<AuthInfo, AuthError>> getCallback)
            {
                _getCallback = getCallback;
            }

            public void SetAuthInfoUpdateCallback(Action<Action<AuthInfo, AuthError>> updateCallback)
            {
                _updateCallback = updateCallback;
            }

            public void getDouYinAuthInfo(AndroidJavaObject getDouYinAuthCallback)
            {
                _getCallback?.Invoke(delegate(AuthInfo info, AuthError error)
                {
                    if (error != null)
                    {
                        getDouYinAuthCallback?.Call("onFailed", error.Code, error.Message);
                    }
                    else
                    {
                        getDouYinAuthCallback?.Call("onSuccess",
                            AndroidDouyinServiceBridgeFactory.CSharpDouYinInfoToJavaObject(info));
                    }
                });
            }

            public void updateDouYinAuthInfo(AndroidJavaObject getDouYinAuthCallback)
            {
                _updateCallback?.Invoke(delegate(AuthInfo info, AuthError error)
                {
                    if (error != null)
                    {
                        getDouYinAuthCallback?.Call("onFailed", error.Code, error.Message);
                    }
                    else
                    {
                        getDouYinAuthCallback?.Call("onSuccess",
                            AndroidDouyinServiceBridgeFactory.CSharpDouYinInfoToJavaObject(info));
                    }
                });
            }
        }
    }
}
#endif