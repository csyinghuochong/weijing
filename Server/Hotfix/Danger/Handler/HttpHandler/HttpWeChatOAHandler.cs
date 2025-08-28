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

    //http://39.96.194.143:20008/wechatOARecvMessage
    [HttpHandler(SceneType.AccountCenter, "/wechatOARecvMessage")]
    public class HttpWeChatOAHandler : IHttpHandler
    {

        //private readonly string _token = "YourWeChatToken"; // 替换为你在公众号后台设置的Token

        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            Console.WriteLine($"HttpPhoneNumberLoginHandler: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())} {context.Request.RawUrl}");

            


            await ETTask.CompletedTask;
        }
    }
}
