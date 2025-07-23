#if UNITY_IOS
using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Douyin.Game
{
    public class iOSDouyinServiceImpl : IDouyinService
    {
        private delegate void OSDKAuthorizeEmptyCallback();
        private delegate void OSDKAuthorizeCallback(int errorCode, string errorMsg, string authCode, string grantedPermissions);
        private static Action<AuthResponse> _authCallback;
        private static Action<Action<AuthInfo, AuthError>> _getCallback;
        private static Action<Action<AuthInfo, AuthError>> _updateCallback;

        public void Authorize(string scope, Action<AuthResponse> authCallback)
        {
            _authCallback = authCallback;
            OSDKAuthorize(scope, OSDKAuthorizeCallbackMethod);
        }

        public void SetAuthInfoGetCallback(Action<Action<AuthInfo, AuthError>> getCallback)
        {
            _getCallback = getCallback;
            OSDKSetAuthInfoGetCallback(OSDKSetAuthInfoGetCallbackMethod);
        }

        public void SetAuthInfoUpdateCallback(Action<Action<AuthInfo, AuthError>> updateCallback)
        {
            _updateCallback = updateCallback;
            OSDKSetAuthInfoUpdateCallback(OSDKSetAuthInfoUpdateCallbackMethod);
        }

        public void ClearDouYinAuthInfo()
        {
            OSDKClearAuthInfo();
        }

        private static void OnGetAuthInfo(AuthInfo authInfo, AuthError authError)
        {
            if (authInfo != null)
            {
                OSDKOnGetAuthInfo(authInfo.Token, authInfo.OpenID, 0, null);    
            }
            else if (authError != null)
            {
                OSDKOnGetAuthInfo(null, null, authError.Code, authError.Message);   
            }
        }

        private static void OnUpdateAuthInfo(AuthInfo authInfo, AuthError authError)
        {
            if (authInfo != null)
            {
                OSDKOnUpdateAuthInfo(authInfo.Token, authInfo.OpenID, 0, null);    
            }
            else if (authError != null)
            {
                OSDKOnUpdateAuthInfo(null, null, authError.Code, authError.Message);   
            }
        }

        [DllImport("__Internal")]
        private static extern void OSDKAuthorize(string scope, OSDKAuthorizeCallback callback);

        [DllImport("__Internal")]
        private static extern void OSDKSetAuthInfoGetCallback(OSDKAuthorizeEmptyCallback callback);
        
        [DllImport("__Internal")]
        private static extern void OSDKSetAuthInfoUpdateCallback(OSDKAuthorizeEmptyCallback callback);
        
        [DllImport("__Internal")]
        private static extern void OSDKOnGetAuthInfo(string token, string openid, int code, string message);
        
        [DllImport("__Internal")]
        private static extern void OSDKOnUpdateAuthInfo(string token, string openid, int code, string message);

        [DllImport("__Internal")]
        private static extern void OSDKClearAuthInfo();

        [AOT.MonoPInvokeCallback(typeof(OSDKAuthorizeCallback))]
        private static void OSDKAuthorizeCallbackMethod(int errorCode, string errorMsg, string authCode, string grantedPermissions)
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                if (_authCallback == null) return;
                var authResponse = new AuthResponse();
                authResponse.AuthCode = authCode;
                authResponse.GrantedPermissions = grantedPermissions;
                
                authResponse = new iOSAuthErrorWrapper().Wrapper(authResponse, errorCode, errorMsg);
                _authCallback.Invoke(authResponse);
            });
        }

        [AOT.MonoPInvokeCallback(typeof(OSDKAuthorizeEmptyCallback))]
        private static void OSDKSetAuthInfoGetCallbackMethod()
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                _getCallback?.Invoke(OnGetAuthInfo);
            });
        }
        
        [AOT.MonoPInvokeCallback(typeof(OSDKAuthorizeEmptyCallback))]
        private static void OSDKSetAuthInfoUpdateCallbackMethod()
        {
            SDKInternalUnityDispatcher.PostTask(() =>
            {
                _updateCallback?.Invoke(OnUpdateAuthInfo);
            });
        }
    }
}

#endif