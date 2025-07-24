using System;
using System.Collections.Generic;
using System.Net;

namespace ET
{
    //http://39.96.194.143:20008/wjtiktokPhoneNumberLogin
    //手机登录接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokPhoneNumberLogin")]
    public class HttpTikTokPhoneNumberLoginHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpPhoneNumberLoginHandler:  {context.Request.RawUrl}");

            //HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //验证码验证接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokCheckSmsVerifyCode")]
    public class HttpTikTokCheckSmsVerifyCodeHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpCheckSmsVerifyCodeHandler:  {context.Request.RawUrl}");


            HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }


    //验证码获取接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokSendSmsVerifyCode")]
    public class HttpTikTokSendSmsVerifyCodeHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpSendSmsVerifyCodeHandler:  {context.Request.RawUrl}");

            //HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //token接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokGetToken")]
    public class HttpTikTokGetTokenHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokGetTokenHandler:  {context.Request.RawUrl}");

            //HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //角色查询接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokRoleQuery")]
    public class HttpTikTokRoleQueryHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokRoleQueryHandler:  {context.Request.RawUrl}");

            //HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }

    //绑定结果接收接口
    [HttpHandler(SceneType.AccountCenter, "/wjtiktokBingdingResult")]
    public class HttpTikTokBingdingResultHandler : IHttpHandler
    {
        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpTikTokBingdingResultHandler:  {context.Request.RawUrl}");

            //HttpServerHelper.ResponseEmpty(context);
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

            //HttpServerHelper.ResponseEmpty(context);
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

            //HttpServerHelper.ResponseEmpty(context);
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

            //HttpServerHelper.ResponseEmpty(context);
            await ETTask.CompletedTask;
        }
    }
}
