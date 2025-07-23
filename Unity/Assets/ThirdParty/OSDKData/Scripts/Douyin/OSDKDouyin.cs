using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using UnityEngine;

namespace Douyin.Game
{
    // 注意：此脚本请挂载到游戏物体上，顺序位于SDK初始化脚本之后
    
    /// <summary>
    /// 抖音授权相关接口
    /// </summary>
    public class OSDKDouyin : MonoBehaviour
    {
        //【以下代码，外部方法】------------------------------------------------------------------
        
        /// <summary>
        /// 抖音授权接口，授权流程：
        /// 第一步：拉起抖音APP，获取抖音授权码 authCode；
        /// 第二步：请求服务端，通过 authCode 换取 Token 和 Openid，完成授权；
        /// 重要提示⚠️：第二步请求服务端时，需要用到密钥client_secret，为保证密钥不泄露，建议在游戏服务端请求抖音接口获取Token和Openid，
        /// 👉 客户端请求游戏服务端 -> 游戏服务端请求抖音接口 -> 抖音接口返回Token给游戏服务端 -> 游戏服务端返回Token给游戏客户端；
        /// </summary>
        /// <param name="scope"></param>
        public void Authorize(string scope = "user_info")
        {
            Debug.Log("OSDKDouyin.Authorize");
            Scope = scope;
            SetupAuthorize();
            OSDK.GetService<IDouyinService>().Authorize(scope, AuthResponseCallback);
        }
        
        /// <summary>
        /// 设置全局授权代理，SDK在需要授权信息时调用对应的回调方法
        /// </summary>
        public void SetupAuthorize()
        {
            if (_hasSetup)
            {
                return;
            }
            
            // 1.向SDK注入获取授权信息的回调方法，在SDK需要授权信息时，SDK自动调用此回调方法
            OSDK.GetService<IDouyinService>().SetAuthInfoGetCallback(delegate(Action<AuthInfo, AuthError> action)
            {
                // SDK触发了获取授权信息，回调当前的授权信息
                action?.Invoke(new AuthInfo()
                {
                    Token = Token,
                    OpenID = Openid   
                }, null);
            });
            
            // 2.向SDK注入更新授权信息的回调方法，在SDK需要授权信息时，如果识别到未获取授权信息或授权信息过期会自动调用此回调方法
            OSDK.GetService<IDouyinService>().SetAuthInfoUpdateCallback(delegate(Action<AuthInfo, AuthError> action)
            {
                // SDK触发了重新授权，重新发起授权然后回调授权信息给SDK
                _authInfoUpdateAction = action;
                Authorize(Scope);
            });
            _hasSetup = true;
        }
        
        /// <summary>
        /// 清除SDK缓存的授权信息open_id和access_token
        /// </summary>
        public void ClearDouYinAuthInfo()
        {
            OSDK.GetService<IDouyinService>().ClearDouYinAuthInfo();
            
            Token = string.Empty;
            Openid = string.Empty;
            PlayerPrefs.DeleteKey(OSDKAuthTokenKey);
            PlayerPrefs.DeleteKey(OSDKAuthOpenidKey);
        }
        
        //【以下代码，需要开发者完善】------------------------------------------------------------------
        
        /// <summary>
        /// 获取抖音授权成功
        /// </summary>
        /// <param name="token"></param>
        /// <param name="openid"></param>
        private void AuthorizeSuccess(string token, string openid)
        {
            // TODO 请处理抖音授权成功后的游戏逻辑
            
        }

        private void AuthorizeFailed(BaseErrorEntity<DouyinAuthorizeErrorEnum> entity)
        {
            // TODO 请处理抖音授权失败后的游戏逻辑
            
        }
        
        /// <summary>
        /// 请求服务端，通过 authCode 换取 Token 和 Openid，完成授权
        /// 注意：以下为方便描述提供客户端实现示例代码，建议替换成在游戏服务端实现以防止密钥泄漏
        /// </summary>
        /// <param name="authCode">抖音授权返回的auth_code</param>
        private async void RequestOAuth(string authCode)
        {
            // TODO 通过 authCode 换取 Token 和 Openid
            // 结果需回调给RequestOAuthSuccess(token, openid)或RequestOAuthFailed(errorEntity)
            
            var clientKey = OSDKIntegration.AndroidClientKey;
#if UNITY_IOS
            clientKey = OSDKIntegration.iOSClientKey;
#endif
            var clientSecret = "92c5ba08cb13c85554f84f165396c707"; // 请填写抖音游戏厂商合作平台的 Client Secret

            if (string.IsNullOrWhiteSpace(clientSecret))
            {
                throw new Exception("授权Client Secret不能为空，请填写");
            }
            
            // 接口文档 https://developer.open-douyin.com/docs/resource/zh-CN/dop/develop/openapi/account-permission/get-access-token
            const string url = "https://open.douyin.com/oauth/access_token/";
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
            var dictionary = new Dictionary<string, string>()
            {
                { "client_secret", clientSecret },
                { "client_key", clientKey },
                { "code", authCode },
                { "grant_type", "authorization_code" }
            };
            var body = Json.Serialize(dictionary);
            HttpContent postContent = new StringContent(body);
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            try
            {
                var responseMessage = await httpClient.PostAsync(url, postContent);
                if (responseMessage != null && responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var result = await responseMessage.Content.ReadAsStringAsync();

                    if (Json.Deserialize(result) is Dictionary<string, object> obj)
                    {
                        var message = obj["message"] as string;
                        if (message?.Equals("success") == true)
                        {
                            // 授权成功
                            var data = obj["data"] as Dictionary<string, object>;
                            var token = data?["access_token"] as string;
                            var openid = data?["open_id"] as string;
                            RequestOAuthSuccess(token, openid);
                        }
                        else
                        {
                            // 网络请求成功，但server返回了错误信息，授权失败
                            // {"data":{"captcha":"","desc_url":"","description":"code已失效","error_code":10007},"message":"error"}
                            object errorDescription = "";
                            object errCode = -1;
                            var data = obj["data"] as Dictionary<string, object>;
                            data?.TryGetValue("description", out errorDescription);
                            data?.TryGetValue("error_code", out errCode);
                            RequestOAuthFailed(new BaseErrorEntity<DouyinAuthorizeErrorEnum>()
                            {
                                ErrorEnum = DouyinAuthorizeErrorEnum.OTHERS,
                                Message = $"抖音授权失败, resp: {errCode},{errorDescription}"
                            });
                        }
                    }
                    else
                    {
                        // 数据格式错误，授权失败
                        RequestOAuthFailed(new BaseErrorEntity<DouyinAuthorizeErrorEnum>()
                        {
                            ErrorEnum = DouyinAuthorizeErrorEnum.OTHERS,
                            Message = "抖音授权access_token解析失败"
                        });
                    }
                }
                else
                {
                    // 网络请求失败，授权失败
                    RequestOAuthFailed(new BaseErrorEntity<DouyinAuthorizeErrorEnum>()
                    {
                        ErrorEnum = DouyinAuthorizeErrorEnum.OTHERS,
                        Message = $"抖音授权access_token获取失败, StatusCode={responseMessage?.StatusCode}"
                    });
                }
            }
            catch (Exception e)
            {
                RequestOAuthFailed(new BaseErrorEntity<DouyinAuthorizeErrorEnum>()
                {
                    ErrorEnum = DouyinAuthorizeErrorEnum.OTHERS,
                    Message = $"抖音授权access_token获取报错，{e.Message}"
                });
            }
        }

        
        

        //【以下代码，开发者无需关注】------------------------------------------------------------------
        private bool _hasSetup = false;

        private Action<AuthInfo, AuthError> _authInfoUpdateAction;
        
        private const string OSDKAuthTokenKey = "osdk_auth_token_key";
        private const string OSDKAuthOpenidKey = "osdk_auth_openid_key";
        
        private string Token;
        private string Openid;
        private string Scope = "user_info";
        
        /// <summary>
        /// 抖音授权结果回调
        /// </summary>
        /// <param name="response"></param>
        private void AuthResponseCallback(AuthResponse response)
        {
            if (response.ErrorEnum == DouyinAuthorizeErrorEnum.SUCCESS)
            {
                RequestOAuth(response.AuthCode);
            }
            else
            {
                AuthorizeFailed(new BaseErrorEntity<DouyinAuthorizeErrorEnum>()
                {
                    ErrorEnum = response.ErrorEnum,
                    Message = response.Message
                });
            }
        }

        private void Awake()
        {
            Token = PlayerPrefs.GetString(OSDKAuthTokenKey);
            Openid = PlayerPrefs.GetString(OSDKAuthOpenidKey);
            
            SetupAuthorize();
        }

        private void RequestOAuthSuccess(string token, string openid)
        {
            PlayerPrefs.SetString(OSDKAuthTokenKey, token);
            PlayerPrefs.SetString(OSDKAuthOpenidKey, openid);
            Token = token;
            Openid = openid;
            if (_authInfoUpdateAction != null)
            {
                _authInfoUpdateAction(new AuthInfo()
                {
                    OpenID = Openid,
                    Token = Token
                }, null);
                _authInfoUpdateAction = null;
            }
            AuthorizeSuccess(Token, Openid);
        }

        private void RequestOAuthFailed(BaseErrorEntity<DouyinAuthorizeErrorEnum> entity)
        {
            if (_authInfoUpdateAction != null)
            {
                _authInfoUpdateAction(null, new AuthError()
                {
                    Code = (int)entity.ErrorEnum,
                    Message = entity.Message
                });
                _authInfoUpdateAction = null;
            }
            AuthorizeFailed(entity);
        }
    }
}
