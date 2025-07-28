using AlibabaCloud.SDK.Sample;
using Alipay.AopSdk.Core.Domain;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

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
            paramslist.Add("app_id", TikTokHelper.AppID.ToString());
            paramslist.Add("app_secret", TikTokHelper.AppSecret);
     
            string result = await HttpHelper.OnWebRequestPostBody("https://open.douyin.com/webcast/game/oauth/access_token/", null, paramslist);
            TikTokOAuth tikTokCode = BsonSerializer.Deserialize<TikTokOAuth>(result);

            //获取加密手机号
            headlist = new Dictionary<string, string>();
            headlist.Add("access-token", "access-token");

            paramslist = new Dictionary<string, string>();
            paramslist.Add("open_id", "open_id");
            result = await HttpHelper.OnWebRequestPostBody("https://open.douyin.com/api/douyin/v1/user/get_user_hash_mobile/", headlist, paramslist);


            //匹配游戏账号
            TikTokPhoneLoginResponse loginResponse = new TikTokPhoneLoginResponse();
            loginResponse.data = new List<TikTokPhoneLoginResponseData>();
            loginResponse.data.Add(new TikTokPhoneLoginResponseData() { game_user_id = "1", game_user_name = "2", mask_account_number = "3" });
            HttpServerHelper.Response(context, loginResponse);
            await ETTask.CompletedTask;
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
            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);
            string app_id = obj["app_id"] as string;
            string phone_num = obj["phone_num"] as string;
            string captcha = obj["captcha"] as string;

            int errorcode =  CheckSmsVerifyCode.Check(phone_num, captcha, string.Empty);


            TikTokPhoneLoginResponse loginResponse = new TikTokPhoneLoginResponse();
            loginResponse.data = new List<TikTokPhoneLoginResponseData>();
            loginResponse.data.Add(new TikTokPhoneLoginResponseData() { game_user_id = "1", game_user_name = "2", mask_account_number = "3" });
            HttpServerHelper.Response(context, loginResponse);
            await ETTask.CompletedTask;
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
            Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);
            string app_id = obj["app_id"] as string;
            string phone_num = obj["phone_num"] as string;

            SendSmsVerifyCode.Send(phone_num);

            HttpServerHelper.Response(context, new TikTokSmsVerifyCodeResponse());
            await ETTask.CompletedTask;
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

            HttpTikTokBingdingResponse bingdingResponse = new HttpTikTokBingdingResponse();
            bingdingResponse.data = new List<HttpTikTokBingdingResponseData>();

            bingdingResponse.data.Add( new HttpTikTokBingdingResponseData() { avatar_url = "" } );

            HttpServerHelper.Response(context, bingdingResponse);
            await ETTask.CompletedTask;
        }
    }


   // http://39.96.194.143:20008/wjtiktokBingdingResult
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
