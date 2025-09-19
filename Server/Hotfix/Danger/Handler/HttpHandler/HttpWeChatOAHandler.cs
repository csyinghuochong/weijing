using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using Tencent;

namespace ET
{
    //只能支持80端口  http://127.0.0.1:80/wechatOARecvMessage
    //LoginCenter       http://39.96.194.143:80/wechatOARecvMessage
    //AccountCenter     http://39.96.194.143:20008/wechatOARecvMessage
    [HttpHandler(SceneType.LoginCenter, "/wechatOARecvMessage")]
    public class HttpWeChatOAHandler : IHttpHandler
    {

        // 构建回复消息的XML
        private string BuildReplyXml(string toUser, string fromUser, string content)
        {
            string replyTemplate = @"<xml>
            <ToUserName><![CDATA[{0}]]></ToUserName>
            <FromUserName><![CDATA[{1}]]></FromUserName>
            <CreateTime>{2}</CreateTime>
            <MsgType><![CDATA[text]]></MsgType>
            <Content><![CDATA[{3}]]></Content>
            </xml>";

            return string.Format(replyTemplate,
                toUser,
                fromUser,
                DateTimeOffset.Now.ToUnixTimeSeconds(),
                content);

            //// 注意：这里的ToUserName和FromUserName要对调
            //string xml = $@"<xml>
            //            <ToUserName><![CDATA[{fromUser}]]></ToUserName>
            //            <FromUserName><![CDATA[{toUser}]]></FromUserName>
            //            <CreateTime>{DateTime.Now.Ticks}</CreateTime>
            //            <MsgType><![CDATA[text]]></MsgType>
            //            <Content><![CDATA[{content}]]></Content>
            //            </xml>";
            //return xml;
        }

        public async ETTask Handle(Entity entity, HttpListenerContext context)
        {
            if (ComHelp.IsInnerNet())
            {
                entity.GetComponent<WeChatOACodeComponent>().BingWeChatOACodeResult("tt", string.Empty).Coroutine();
                return;
            }

            var request = context.Request;
            var response = context.Response;
            Console.WriteLine($"HttpWeChatOAHandler 1: {TimeInfo.Instance.ToDateTime(TimeHelper.ServerNow())}  {request.HttpMethod} {context.Request.RawUrl}");

            var query = request.QueryString;

            string signature = query["signature"];
            string timestamp = query["timestamp"];
            string nonce = query["nonce"];


            // 验证必要参数是否存在
            if (string.IsNullOrEmpty(signature) ||
                string.IsNullOrEmpty(timestamp) ||
                string.IsNullOrEmpty(nonce))
            {
                Console.WriteLine("HttpWeChatOAHandler 缺少必要的参数");
            }

            // 2. 验证签名
            bool isValid = WXBizMsgCrypt.GenarateSinature_2(signature, timestamp, nonce);

            if (!isValid)
            {
                Console.WriteLine("签名验证失败，可能不是来自微信服务器的请求");
            }
            else
            {
                Console.WriteLine("签名验证成功，是来自微信服务器的合法请求");
                // 这里可以添加处理消息的逻辑
            }

            string sPostData = "";

            if (request.HasEntityBody)
            {
                using (StreamReader reader = new StreamReader(request.InputStream, request.ContentEncoding))
                {
                    sPostData = reader.ReadToEnd();
                }

                Console.WriteLine($"HttpWeChatOAHandler.requestBody:  {sPostData}");
                XmlDocument doc = new XmlDocument();
                doc.XmlResolver = null;
                XmlNode root;
                string ToUserName;
                string FromUserName;
                string MsgType;
                string Content;

                try
                {
                    doc.LoadXml(sPostData);
                    root = doc.FirstChild;
                    ToUserName = root["ToUserName"].InnerText;
                    FromUserName = root["FromUserName"].InnerText;
                    MsgType = root["MsgType"].InnerText;
                    
                    if (MsgType.Equals("text"))
                    {
                        Content = root["Content"].InnerText;
                        Console.WriteLine($"HttpWeChatOAHandler.MsgType:  {MsgType}  Content: {Content}");

                         string bindresult = await entity.GetComponent<WeChatOACodeComponent>().BingWeChatOACodeResult(FromUserName, Content);

                        // 3. 发送响应
                        // 根据消息类型处理

                        string content =  $"欢迎关注危境游戏公众号！\n\n" +
                        "服务器！\n" +
                        "游戏角色！\n" +
                        $"{bindresult}！";

                        string responseXml = BuildReplyXml(FromUserName, ToUserName, content);

                        // 设置响应头
                        response.ContentType = "text/xml; charset=utf-8";
                        response.ContentEncoding = Encoding.UTF8;

                        // 写入响应
                        byte[] buffer = Encoding.UTF8.GetBytes(responseXml);
                        response.ContentLength64 = buffer.Length;
                        response.OutputStream.Write(buffer, 0, buffer.Length);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing JSON: {ex.Message}");
                }
            }

            HttpServerHelper.ResponseEmpty(context);

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
