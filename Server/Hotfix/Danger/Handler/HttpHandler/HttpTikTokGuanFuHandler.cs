using AlibabaCloud.SDK.Sample;
using Alipay.AopSdk.Core;
using Alipay.AopSdk.Core.Domain;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ET
{
    //http://39.96.194.143:20008/wjtiktokPhoneNumberLogin
    //手机登录接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokPhoneNumberLogin")]
    public class HttpTikTokPhoneNumberLoginHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpPhoneNumberLoginHandler: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())} {context.Request.RawUrl}");

            HttpListenerRequest request = context.Request;

            // 1. 处理请求头
            Console.WriteLine("\n收到请求头:");
            foreach (string header in request.Headers.AllKeys)
            {
                Console.WriteLine($"{header}: {request.Headers[header]}");
            }

            // 2. 处理请求体
            string requestBody;
            using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            Console.WriteLine("\n收到请求体:");
            Console.WriteLine(requestBody);

            // 使用System.Text.Json进行反序列化
            // object obj = JsonHelper.FromJson<object>(requestBody);

            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);

            Console.WriteLine("\n转换后的字典:");
            foreach (var item in obj)
            {
                Console.WriteLine($"{item.Key}: {item.Value.ToString()}");
            }

            Dictionary<string, string> headlist = new Dictionary<string, string>();

            //换取access_token
            Dictionary<string, string> paramslist = new Dictionary<string, string>();
            paramslist.Add("code", obj["auth_code"].ToString());
            paramslist.Add("app_id", obj["app_id"].ToString());
            paramslist.Add("app_secret", TikTokHelper.AppSecret);

            string result = await HttpServerHelper.OnWebRequestPostBody("https://open.douyin.com/webcast/game/oauth/access_token/", null, paramslist);
            Console.WriteLine($"access_token:  {result}");
            TikTokOAuth tikTokCode = BsonSerializer.Deserialize<TikTokOAuth>(result);

            //获取加密手机号
            headlist = new Dictionary<string, string>();
            headlist.Add("access-token", tikTokCode.data.access_token);

            paramslist = new Dictionary<string, string>();
            paramslist.Add("open_id", tikTokCode.data.open_id);
            result = await HttpServerHelper.OnWebRequestPostBody("https://open.douyin.com/api/douyin/v1/user/get_user_hash_mobile/", headlist, paramslist);
            Console.WriteLine($"get_user_hash_mobile:  {result}");

            //匹配游戏账号
            //TikTokPhoneLoginResponse loginResponse = new TikTokPhoneLoginResponse();
            //loginResponse.err_no = 0;
            //loginResponse.err_msg = "SUCESS";
            //loginResponse.data = new List<TikTokPhoneLoginResponseData>();
            //loginResponse.data.Add(new TikTokPhoneLoginResponseData() { game_user_id = "1", game_user_name = "2", mask_account_number = "3" });
            //HttpServerHelper.Response(context, loginResponse);

            // 构造响应数据
            //var responseData = new ResponseData
            //{
            //    GameUsers = new List<LoginData>
            //    {
            //        new LoginData() {
            //            GameUserId = "id123",
            //            GameUserName = "关羽",
            //            MaskAccountNumber = "123****6978"
            //        },
            //        new LoginData() {
            //            GameUserId = "id456",
            //            GameUserName = "诸葛亮",
            //            MaskAccountNumber = "123****6978"
            //        }
            //    }
            //};
            var responseData = new ResponseData
            {
                GameUsers = new List<LoginData>
                {
                }
            };

            // 发送成功响应
            var response = new ApiResponse
            {
                ErrNo = 0,
                ErrMsg = "",
                Data = responseData
            };

            SendJsonResponse(context, response);
            Console.WriteLine($"HttpPhoneNumberLoginHandler_Response: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}");
            await ETTask.CompletedTask;
        }

        // 请求/响应模型
        private class AuthRequest
        {
            [JsonPropertyName("app_id")]
            public int AppId { get; set; }

            [JsonPropertyName("auth_code")]
            public string AuthCode { get; set; }
        }

        private class ApiResponse
        {
            [JsonPropertyName("err_no")]
            public int ErrNo { get; set; }

            [JsonPropertyName("err_msg")]
            public string ErrMsg { get; set; }

            [JsonPropertyName("data")]
            public ResponseData Data { get; set; }
        }

        private class ResponseData
        {
            [JsonPropertyName("game_users")]
            public List<LoginData> GameUsers { get; set; }
        }

        private class LoginData
        {
            [JsonPropertyName("game_user_id")]
            public string GameUserId { get; set; }

            [JsonPropertyName("game_user_name")]
            public string GameUserName { get; set; }

            [JsonPropertyName("mask_account_number")]
            public string MaskAccountNumber { get; set; }
        }

        private void SendJsonResponse(HttpListenerContext context, ApiResponse response)
        {
            var json = JsonSerializer.Serialize(response, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });

            var buffer = Encoding.UTF8.GetBytes(json);
            context.Response.ContentType = "application/json";
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = buffer.Length;
            context.Response.StatusCode = 200;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }

        private void SendResponse(HttpListenerContext context, int statusCode, string message)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "text/plain";
            var buffer = Encoding.UTF8.GetBytes(message);
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }
    }

    //http://39.96.194.143:20008/wjtiktokCheckSmsVerifyCode
    //验证码验证接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokCheckSmsVerifyCode")]
    public class HttpTikTokCheckSmsVerifyCodeHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpCheckSmsVerifyCodeHandler: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())} {context.Request.RawUrl}");

            HttpListenerRequest request = context.Request;

            string requestBody;
            using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            Console.WriteLine($"requestBody: {requestBody}");

            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);
            string app_id = obj["app_id"] as string;
            string phone_num = obj["phone_num"] as string;
            string captcha = obj["captcha"] as string;

            int errorcode = CheckSmsVerifyCode.Check(phone_num, captcha, string.Empty);
            //TikTokPhoneLoginResponse loginResponse = new TikTokPhoneLoginResponse();
            //loginResponse.data = new List<TikTokPhoneLoginResponseData>();
            //loginResponse.data.Add(new TikTokPhoneLoginResponseData() { game_user_id = "1", game_user_name = "2", mask_account_number = "3" });
            //Console.WriteLine($"HttpCheckSmsVerifyCodeHandler_Response: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())} ");
            //HttpServerHelper.Response(context, loginResponse);

            // 构造响应数据
            //var responseData = new ResponseData
            //{
            //    GameUsers = new List<LoginData>
            //    {
            //        new LoginData() {
            //            GameUserId = "id123",
            //            GameUserName = "关羽",
            //            MaskAccountNumber = "123****6978"
            //        },
            //        new LoginData() {
            //            GameUserId = "id456",
            //            GameUserName = "诸葛亮",
            //            MaskAccountNumber = "123****6978"
            //        }
            //    }
            //};
            var responseData = new ResponseData
            {
                GameUsers = new List<LoginData>
                {
                }
            };

            // 发送成功响应
            var response = new ApiResponse
            {
                ErrNo = 0,
                ErrMsg = "",
                Data = responseData
            };

            SendJsonResponse(context, response);

            await ETTask.CompletedTask;
        }

        // 请求/响应模型
        private class AuthRequest
        {
            [JsonPropertyName("app_id")]
            public int AppId { get; set; }

            [JsonPropertyName("auth_code")]
            public string AuthCode { get; set; }
        }

        private class ApiResponse
        {
            [JsonPropertyName("err_no")]
            public int ErrNo { get; set; }

            [JsonPropertyName("err_msg")]
            public string ErrMsg { get; set; }

            [JsonPropertyName("data")]
            public ResponseData Data { get; set; }
        }

        private class ResponseData
        {
            [JsonPropertyName("game_users")]
            public List<LoginData> GameUsers { get; set; }
        }

        private class LoginData
        {
            [JsonPropertyName("game_user_id")]
            public string GameUserId { get; set; }

            [JsonPropertyName("game_user_name")]
            public string GameUserName { get; set; }

            [JsonPropertyName("mask_account_number")]
            public string MaskAccountNumber { get; set; }
        }

        private void SendJsonResponse(HttpListenerContext context, ApiResponse response)
        {
            var json = JsonSerializer.Serialize(response, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });

            var buffer = Encoding.UTF8.GetBytes(json);
            context.Response.ContentType = "application/json";
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = buffer.Length;
            context.Response.StatusCode = 200;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }

        private void SendResponse(HttpListenerContext context, int statusCode, string message)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "text/plain";
            var buffer = Encoding.UTF8.GetBytes(message);
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }
    }

    // http://39.96.194.143:20008/wjtiktokSendSmsVerifyCode
    //验证码获取接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokSendSmsVerifyCode")]
    public class HttpTikTokSendSmsVerifyCodeHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpSendSmsVerifyCodeHandler: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())} {context.Request.RawUrl}");

            HttpListenerRequest request = context.Request;

            string requestBody;
            using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                requestBody = await reader.ReadToEndAsync();
            }
            Console.WriteLine($"requestBody: {requestBody}");

            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);
            string app_id = obj["app_id"] as string;
            string phone_num = obj["phone_num"] as string;

            SendSmsVerifyCode.Send(phone_num);

            Console.WriteLine($"HttpSendSmsVerifyCodeHandler_Response: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}");

            HttpServerHelper.Response(context, new ApiResponse());
            await ETTask.CompletedTask;
        }

        private class ApiResponse
        {
            [JsonPropertyName("err_no")]
            public int ErrNo { get; set; }

            [JsonPropertyName("err_msg")]
            public string ErrMsg { get; set; }

        }
    }

   // http://39.96.194.143:20008/wjtiktokGetToken
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokGetToken")]
    public class HttpTikTokGetTokenHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokGetTokenHandler:  {context.Request.RawUrl}");

            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }


    //http://39.96.194.143:20008/wjtiktokRoleQuery
    //角色查询接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokRoleQuery")]
    public class HttpTikTokRoleQueryHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokRoleQueryHandler: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())} {context.Request.RawUrl}");

            string requestBody;
            HttpListenerRequest request = context.Request;
            using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
            {
                requestBody = await reader.ReadToEndAsync();
            }

            Console.WriteLine("\n收到请求体:");
            Console.WriteLine(requestBody);

            // 使用System.Text.Json进行反序列化
            // object obj = JsonHelper.FromJson<object>(requestBody);

            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);
            string app_id = obj["app_id"] as string;
            List<string> game_user_ids = obj["game_user_ids"] as List<string>;
            string open_id = obj["open_id"] as string;

            //HttpTikTokBingdingResponse bingdingResponse = new HttpTikTokBingdingResponse();
            //bingdingResponse.data = new List<HttpTikTokBingdingResponseData>();
            //bingdingResponse.data.Add( new HttpTikTokBingdingResponseData() { avatar_url = "" } );
            //Console.WriteLine($"HttpTikTokRoleQueryHandler_Response: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}");
            //HttpServerHelper.Response(context, bingdingResponse);

            // 5. 生成响应数据
            // 构造角色列表响应
            var roles = new List<GameRole>();
            //roles.Add(new GameRole
            //{
            //    GameUserId = "1",
            //    RoleId = $"role_1",
            //    RoleName = "关羽",
            //    Level = "10",
            //    RegionId = "123",
            //    RegionName = "136区",
            //    AvatarUrl = "https://example.com/avatars/default.jpg"
            //});

            // 构建完整响应
            var response = new RoleInfoResponse
            {
                ErrNo = 0,
                ErrMsg = "",
                Data = new RoleData { Roles = roles }
            };

            Console.WriteLine($"HttpTikTokRoleQueryHandler_Response: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}");
            SendJsonResponse(context, response);
 
            await ETTask.CompletedTask;
        }

        private void SendJsonResponse(HttpListenerContext context, RoleInfoResponse response)
        {
            var json = JsonSerializer.Serialize(response, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });

            var buffer = Encoding.UTF8.GetBytes(json);
            context.Response.ContentType = "application/json";
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = buffer.Length;
            context.Response.StatusCode = 200;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }

        private void SendResponse(HttpListenerContext context, int statusCode, string message)
        {
            context.Response.StatusCode = statusCode;
            context.Response.ContentType = "text/plain";
            var buffer = Encoding.UTF8.GetBytes(message);
            context.Response.ContentLength64 = buffer.Length;
            context.Response.OutputStream.Write(buffer, 0, buffer.Length);
            context.Response.Close();
        }

  
        // 请求/响应模型
        private class RoleInfoRequest
        {
            [JsonPropertyName("app_id")]
            public int AppId { get; set; }

            [JsonPropertyName("game_user_ids")]
            public List<string> GameUserIds { get; set; }
        }

        private class RoleInfoResponse
        {
            [JsonPropertyName("err_no")]
            public int ErrNo { get; set; }

            [JsonPropertyName("err_msg")]
            public string ErrMsg { get; set; }

            [JsonPropertyName("data")]
            public RoleData Data { get; set; }
        }

        private class RoleData
        {
            [JsonPropertyName("roles")]
            public List<GameRole> Roles { get; set; }
        }

        private class GameRole
        {
            [JsonPropertyName("game_user_id")]
            public string GameUserId { get; set; }

            [JsonPropertyName("role_id")]
            public string RoleId { get; set; }

            [JsonPropertyName("role_name")]
            public string RoleName { get; set; }

            [JsonPropertyName("level")]
            public string Level { get; set; }

            [JsonPropertyName("region_id")]
            public string RegionId { get; set; }

            [JsonPropertyName("region_name")]
            public string RegionName { get; set; }

            [JsonPropertyName("avatar_url")]
            public string AvatarUrl { get; set; }
        }
    }


    //http://39.96.194.143:20008/wjtiktokBingdingResult
    //绑定结果接收接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokBingdingResult")]
    public class HttpTikTokBingdingResultHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokBingdingResultHandler:  {context.Request.RawUrl}");

            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //备用接口1
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokBeiYong_1")]
    public class HttpTikTokBeiYong_1Handler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokBeiYong_1Handler:  {context.Request.RawUrl}");

            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //备用接口2
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokBeiYong_2")]
    public class HttpTikTokBeiYong_2Handler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokBeiYong_2Handler:  {context.Request.RawUrl}");

            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //备用接口3
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokBeiYong_3")]
    public class HttpTikTokBeiYong_3Handler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokBeiYong_3Handler:  {context.Request.RawUrl}");

            
            await ETTask.CompletedTask;
        }
    }
}
