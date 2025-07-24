using Microsoft.Cci.Pdb;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TapTap.Login;
using UnityEngine;

namespace Douyin.Game
{
    // 注意：此脚本请挂载到游戏物体上，顺序位于SDK初始化脚本之后
    
    /// <summary>
    /// 抖音授权相关接口
    /// </summary>
    public class OSDKDouyin : MonoBehaviour
    {
        public string AuthCode;
        public string ClientToken;
        public Action<string> OnTikTokAuthorizeHandler;

        //【以下代码，外部方法】------------------------------------------------------------------

        /// <summary>
        /// 抖音授权接口，授权流程：
        /// 第一步：拉起抖音APP，获取抖音授权码 authCode；
        /// 第二步：请求服务端，通过 authCode 换取 Token 和 Openid，完成授权；
        /// 重要提示⚠️：第二步请求服务端时，需要用到密钥client_secret，为保证密钥不泄露，建议在游戏服务端请求抖音接口获取Token和Openid，
        /// 👉 客户端请求游戏服务端 -> 游戏服务端请求抖音接口 -> 抖音接口返回Token给游戏服务端 -> 游戏服务端返回Token给游戏客户端；
        /// </summary>
        /// <param name="scope"></param>
        public void Authorize(string scope = "user_info,trial.whitelist")
        {
            Debug.Log("OSDKDouyin.Authorize");

#if UNITY_EDITOR
            var dictionary = new Dictionary<string, string>()
            {
                { "auto_code", "auto_code" },
                { "client_token", "client_token" },
                { "access_token", "access_token"},
                { "open_id", "open_id_202507242052" },
            };

            this.OnTikTokAuthorizeHandler?.Invoke(Json.Serialize(dictionary));
#else
            Scope = scope;
            SetupAuthorize();
            OSDK.GetService<IDouyinService>().Authorize(scope, AuthResponseCallback);
#endif

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

        private  void AuthorizeSuccess(string access_token, string open_id)
        {
            var dictionary = new Dictionary<string, string>()
            {
                { "auto_code", AuthCode },
                { "client_token", ClientToken },
                { "access_token", access_token},
                { "open_id", open_id },
            };

            this.OnTikTokAuthorizeHandler?.Invoke(Json.Serialize(dictionary));
        }

        /// <summary>
        /// 获取抖音授权成功  获取渠道包账号放在后端。
        /// </summary>
        /// <param name="token"></param>
        /// <param name="openid"></param>
        private async void AuthorizeSuccess_Old(string access_token, string  open_id)
        {
            // TODO 请处理抖音授权成功后的游戏逻辑
            //this.GetOpenIdCodeHandler?.Invoke(open_id);

            //请求接口：
            //必填Header参数：
            //access - token：通过抖音开放平台Token接口获取的client_token
            //必填Body参数：
            //app_id：从厂商合作平台获取的抖音游戏ID
            const string url = "https://open.douyin.com/api/webcast/v1/osdk/get_history_account_info/";
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("access-token", ClientToken);

            var dictionary = new Dictionary<string, string>()
            {
                { "app_id", "554726" },
                { "user_type","1" },
                { "open_id", open_id },
                { "app_package", "com.example.weijinggame" },
                { "access_token", access_token },
            };

            var body = Json.Serialize(dictionary);
            HttpContent postContent = new StringContent(body);
            Debug.Log($"OSDK.get_history_account_info");
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            try
            {
                var responseMessage = await httpClient.PostAsync(url, postContent);
                if (responseMessage != null && responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var result = await responseMessage.Content.ReadAsStringAsync();
                    Debug.Log($"OSDK.get_history_account_info return: {result}");
                    //7492384281722297124
                    //_000EX1CG4-EAWlO9YUsp1y4HnwdP1XV1X9P
                    //这个接口有配额 要注意！！！
                    //OSDK.get_history_account_info return: {"err_no":28003017,"err_msg":"quota已用完","log_id":"20250724161757EE2515F1BFF953756E79"}
                    if (Json.Deserialize(result) is Dictionary<string, object> obj)
                    {
                        var message = obj["message"] as string;
                        if (message?.Equals("success") == true)
                        {
                            // 授权成功
                            var data = obj["data"] as Dictionary<string, object>;
                            var sdk_open_id = data?["sdk_open_id"] as string;
                            var age_type = data?["age_type"] as string;
                            int age_type_int = int.Parse(age_type);

                            if (!string.IsNullOrEmpty(sdk_open_id))
                            {
                                //账号找回通知。 游戏侧账号迁移完成后，需通知抖音侧找回账号成功。
                                //通知情况将会影响抖音对历史用户的触达方式。
                                return;
                            }
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
                            Debug.Log($"账号转移失败, resp: {errCode},{errorDescription}");
                           
                        }
                    }
                    else
                    {
                        // 数据格式错误，授权失败
                        Debug.Log($"账号转移失败access_token解析失败");
                    }
                }
                else
                {
                    // 网络请求失败，授权失败
                    Debug.Log($"OSDK.OpenID_SDKOpenId Error: {responseMessage}");
                    
                }
            }
            catch (Exception e)
            {
                Debug.Log($"账号转移失败  Exception e");
            }

            Debug.Log($"OSDK  找不到sdk_open_id.  直接用openid");
        }

        private void AuthorizeFailed(BaseErrorEntity<DouyinAuthorizeErrorEnum> entity)
        {
            // TODO 请处理抖音授权失败后的游戏逻辑
            this.OnTikTokAuthorizeHandler?.Invoke(string.Empty);
        }

        private async Task RequestClientToken()
        {
            //要获取渠道包的sdk_open_id，可以按照以下步骤操作：

            //步骤1：获取client_token
            //调用抖音开放平台的Token接口获取client_token，有效期为2小时。
            //注意：频繁调用会触发频控（5分钟内超过500次会报错）​​。
            //步骤2：调用账号找回接口
            //使用POST方法请求接口：
            //            请求头需包含access - token（即client_token）。
            //请求体需包含app_id和用户的open_id（通过抖音账号授权获取）​​。
            //步骤3：处理返回结果
            //接口返回的sdk_open_id若为空，表示该用户无渠道包账号。
            //若返回有效sdk_open_id，可自行迁移至官包账号​​。
            //步骤4：通知找回结果
            //迁移完成后，需调用抖音接口同步找回结果​​。
            const string url = "https://open.douyin.com/webcast/game/oauth/client_token/";
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
            var dictionary = new Dictionary<string, string>()
            {
                { "app_id", "554726" },
                { "app_secret", "gacT8bvbGb9X3f52j8bZDtjvkAkhrOZy" }
            };
            var body = Json.Serialize(dictionary);
            HttpContent postContent = new StringContent(body);
            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            Debug.Log($"OSDK.RequestClientToken");
            try
            {
                var responseMessage = await httpClient.PostAsync(url, postContent);
                if (responseMessage != null && responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var result = await responseMessage.Content.ReadAsStringAsync();

                    Debug.Log($"OSDK.RequestClientToken Return: {result}");

                    //7492384281722297124
                    //_000EX1CG4-EAWlO9YUsp1y4HnwdP1XV1X9P
                    //"data": {
                    //    "access_token": "clt.*******.token",
                    //    "description": "",
                    //    "error_code": 0,
                    //    "expires_in": 7200,
                    //    "log_id": "2024040214560714E282F89002CE23092A"
                    //},
                    //"message": "success"

                    if (Json.Deserialize(result) is Dictionary<string, object> obj)
                    {
                        var message = obj["message"] as string;
                        if (message?.Equals("success") == true)
                        {
                            // 授权成功
                            var data = obj["data"] as Dictionary<string, object>;
                            ClientToken = data?["access_token"] as string;
                        }
                        else
                        {
                            Debug.Log("OSDK.RequestClientToken. Error_1");
                        }
                    }
                    else
                    {
                        // 数据格式错误，授权失败
                        Debug.Log("OSDK.RequestClientToken. Error_2");
                    }
                }
                else
                {
                    // 网络请求失败，授权失败
                    Debug.Log("OSDK.RequestClientToken. Error_3");
                }
            }
            catch (Exception e)
            {
                Debug.Log("OSDK.RequestClientToken. Error_4");
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="authCode"></param>
        private  async void RequeseTokens(string authCode)
        {
            AuthCode = authCode;
            await RequestClientToken();
            await RequestAccessToken(authCode);
        }

        /// <summary>
        /// 请求服务端，通过 authCode 换取 Token 和 Openid，完成授权
        /// 注意：以下为方便描述提供客户端实现示例代码，建议替换成在游戏服务端实现以防止密钥泄漏
        /// </summary>
        /// <param name="authCode">抖音授权返回的auth_code</param>
        private async Task RequestAccessToken(string authCode)
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
            Debug.Log($"OSDK.RequestAccessToken: {authCode}");
            // 这个是旧版本接口
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

                    Debug.Log($"OSDK.RequestAccessToken Return: {result}");

                    //7492384281722297124
                    //_000EX1CG4-EAWlO9YUsp1y4HnwdP1XV1X9P

                    if (Json.Deserialize(result) is Dictionary<string, object> obj)
                    {
                        var message = obj["message"] as string;
                        if (message?.Equals("success") == true)
                        {
                            // 授权成功
                            var data = obj["data"] as Dictionary<string, object>;
                            var access_token = data?["access_token"] as string;
                            var open_id = data?["open_id"] as string;

                            RequestOAuthSuccess(access_token, open_id);
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
                RequeseTokens(response.AuthCode);
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
        
        private void RequestOAuthSuccess(string access_token, string open_id)
        {
            PlayerPrefs.SetString(OSDKAuthTokenKey, access_token);
            PlayerPrefs.SetString(OSDKAuthOpenidKey, open_id);
            Token = access_token;
            Openid = open_id;
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
