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
using Tencent;

namespace ET
{
    //只能支持80端口  
    //LoginCenter       http://39.96.194.143:80/wechatOARecvMessage
    //AccountCenter     http://39.96.194.143:20008/wechatOARecvMessage
    [HttpHandler(SceneType.LoginCenter, "/wechatOARecvMessage")]
    public class HttpWeChatOAHandler : IHttpHandler
    {

        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            var request = context.Request;
            var response = context.Response;
            Console.WriteLine($"HttpWeChatOAHandler 1: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}  {request.HttpMethod} {context.Request.RawUrl}");

            var query = request.QueryString;

            string signature = query["signature"];
            string timestamp = query["timestamp"];
            string nonce = query["nonce"];
            string echostr = query["echostr"]; // 获取echostr参数

            // 验证必要参数是否存在
            if (string.IsNullOrEmpty(signature) ||
                string.IsNullOrEmpty(timestamp) ||
                string.IsNullOrEmpty(nonce))
            {
                throw new ArgumentException("缺少必要的参数");
            }

            string responseString = echostr;
            // 2. 验证签名
            bool isValid = WXBizMsgCrypt.GenarateSinature_2(signature, timestamp, nonce);

            if (!isValid)
            {
                Console.WriteLine("签名验证失败，可能不是来自微信服务器的请求");
                responseString = "invalid signature";
            }
            else
            {
                Console.WriteLine("签名验证成功，是来自微信服务器的合法请求");
                // 这里可以添加处理消息的逻辑
            }

            string requestBody = "";

            if (request.HasEntityBody)
            {
                using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    requestBody = reader.ReadToEnd();
                }

                try
                {
                    Console.WriteLine($"HttpWeChatOAHandler.requestBody:  {requestBody}");
                    // 假设包体是JSON格式，这里进行反序列化示例
                    Dictionary<string, object> data = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);
                    //Console.WriteLine($"ToUserName: {data["ToUserName"]}");
                    //Console.WriteLine($"FromUserName: {data["FromUserName"]}");
                    //Console.WriteLine($"CreateTime: {data["CreateTime"]}");
                    //Console.WriteLine($"MsgType: {data["MsgType"]}");
                    //Console.WriteLine($"Event: {data["Event"]}");
                    //Console.WriteLine($"debug_str: {data["debug_str"]}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing JSON: {ex.Message}");
                }
            }

            // 3. 发送响应
            byte[] buffer = Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            response.ContentType = "text/plain; charset=utf-8";

            using (var output = response.OutputStream)
            {
                await output.WriteAsync(buffer, 0, buffer.Length);
            }
            //response.Close();



            await ETTask.CompletedTask;
        }

        //public async ETTask Handle_old(Entity entity, HttpListenerContext context)
        //{
        //    var request = context.Request;
        //    var response = context.Response;
        //    Console.WriteLine($"HttpWeChatOAHandler 1: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}  {request.HttpMethod} {context.Request.RawUrl}");

        //    string requestBody;
        //    using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
        //    {
        //        requestBody = await reader.ReadToEndAsync();
        //    }

        //    // 使用System.Text.Json进行反序列化
        //    // object obj = JsonHelper.FromJson<object>(requestBody);

        //    Tencent.WXBizMsgCrypt wxcpt = new Tencent.WXBizMsgCrypt(ConfigData.sToken, ConfigData.sEncodingAESKey, ConfigData.sAppID);


        //    Dictionary<string, object> obj = JsonSerializer.Deserialize<Dictionary<string, object>>(requestBody);

        //    if (request.HttpMethod == "POST")
        //    {
        //        // 1. 从 InputStream 中读取 POST 过来的原始 XML 数据
        //        using (StreamReader reader = new StreamReader(request.InputStream, Encoding.UTF8))
        //        {
        //            // 这就是你要的 sReqData
        //            // 现在你可以使用这个 sReqData 进行解密了
        //            // ... (你的解密代码，如 wxcpt.DecryptMsg(...))

        //            string sReqMsgSig = obj["signature"].ToString();
        //            string sReqTimeStamp = obj["timestamp"].ToString();
        //            string sReqNonce = obj["nonce"].ToString();
        //            string sReqData = reader.ReadToEnd();

        //            string sMsg = "";  //解析之后的明文
        //            int ret = 0;
        //            ret = wxcpt.DecryptMsg(sReqMsgSig, sReqTimeStamp, sReqNonce, sReqData, ref sMsg);
        //            if (ret != 0)
        //            {
        //                System.Console.WriteLine("ERR: Decrypt fail, ret: " + ret);
        //            }
        //            else
        //            {
        //                System.Console.WriteLine(sMsg);
        //            }
        //        }
        //    }
        //    if (request.HttpMethod == "GET")
        //    {
        //        string sReqMsgSig = obj["signature"].ToString();
        //        string sReqTimeStamp = obj["timestamp"].ToString();
        //        string sReqNonce = obj["nonce"].ToString();
        //        string echostr = obj["echostr"].ToString();


        //    }


        //    HttpServerHelper.ResponseEmpty(context);

        //    await ETTask.CompletedTask;
        //}
    }
}
