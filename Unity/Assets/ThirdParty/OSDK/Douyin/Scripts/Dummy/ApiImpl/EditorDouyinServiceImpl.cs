using System;

#if UNITY_EDITOR

namespace Douyin.Game
{
    public class EditorDouyinServiceImpl : IDouyinService
    {
        public void Authorize(string scope, Action<AuthResponse> authCallback)
        {
            if (OSDKIntegration.AuthorizeMock == OSDKMockStatus.Success)
            {
                authCallback?.Invoke(new AuthResponse()
                {
                    AuthCode = "1",
                    GrantedPermissions = scope,
                    ErrorEnum = DouyinAuthorizeErrorEnum.SUCCESS,
                    Message = "模拟验证 - 授权成功"
                });
            }
            else
            {
                authCallback?.Invoke(new AuthResponse()
                {
                    AuthCode = "",
                    GrantedPermissions = scope,
                    ErrorEnum = DouyinAuthorizeErrorEnum.OTHERS,
                    Message = "模拟验证 - 授权失败"
                });
            }
        }

        public void SetAuthInfoGetCallback(Action<Action<AuthInfo, AuthError>> getCallback)
        {
            
        }

        public void SetAuthInfoUpdateCallback(Action<Action<AuthInfo, AuthError>> updateCallback)
        {
            
        }

        public void ClearDouYinAuthInfo()
        {
            
        }
    }
}

#endif