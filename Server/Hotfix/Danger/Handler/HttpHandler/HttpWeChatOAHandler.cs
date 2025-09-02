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

        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;
            Console.WriteLine($"HttpWeChatOAHandler 1: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}  {request.HttpMethod} {context.Request.RawUrl}");

            if (request.HttpMethod == "POST")
            {
                // 1. 从 InputStream 中读取 POST 过来的原始 XML 数据
                using (StreamReader reader = new StreamReader(request.InputStream, Encoding.UTF8))
                {
                    string sReqData = reader.ReadToEnd(); // 这就是你要的 sReqData
                                                          // 现在你可以使用这个 sReqData 进行解密了
                                                          // ... (你的解密代码，如 wxcpt.DecryptMsg(...))
                }
            }
            if (request.HttpMethod == "GET")
            {
               
            }


            HttpServerHelper.ResponseEmpty(context);

            await ETTask.CompletedTask;
        }
    }
}
