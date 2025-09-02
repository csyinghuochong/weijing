using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Xml;
using System.IO;
using System.Net;

namespace MsgCryptTest
{
    public static class WXSample
    {

 
        public static async ETTask<string> OnGetAccessToken(string uri, Dictionary<string, string> dic)
        {
            string paramss = string.Empty;
            foreach (var item in dic)
            {
                paramss += $"{item.Key}={item.Value}&";
            }
            paramss = paramss.Substring(0, paramss.Length - 1);
            var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.None };

            using (var httpclient = new HttpClient(handler))
            {
                httpclient.BaseAddress = new Uri(uri);
                httpclient.DefaultRequestHeaders.Accept.Clear();
                httpclient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await httpclient.GetAsync($"?{paramss}");

                if (response.IsSuccessStatusCode)
                {
                    Stream myResponseStream = await response.Content.ReadAsStreamAsync();
                    StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                    string retString = myStreamReader.ReadToEnd();
                    myStreamReader.Close();
                    myResponseStream.Close();
                    return retString;
                }
                return string.Empty;
            }
        }

        //Cryptography.cs 文件封装了 AES 加解密过程，用户无须关心具体实现。WRBizMsgCrypt.cs 文件提供了用户接入企业微信的两个接口，Sample.cs 文件提供了如何使用这两个接口的示例。
        //WRBizMsgCrypt.cs 封装了 DecryptMsg、EncryptMsg 两个接口，分别用于收到用户回复消息的解密以及开发者回复消息的加密过程。
        //使用方法可以参考 Sample.cs 文件。
        //加解密协议请参考微信公众平台官方文档。



        public  static void Main()
        {

            Tencent.WXBizMsgCrypt wxcpt = new Tencent.WXBizMsgCrypt(ConfigData.sToken, ConfigData.sEncodingAESKey, ConfigData.sAppID);

            //createTime 是微信公众平台记录粉丝发送该消息的具体时间
            //text: 用于标记该xml 是文本消息，一般用于区别判断
            //欢迎开启服务号开发者模式: 说明该粉丝发给服务号的具体内容是欢迎开启服务号开发者模式
            //MsgId: 是公众平台为记录识别该消息的一个标记数值, 微信后台系统自动产生

            /* 1. 对用户回复的数据进行解密。
            * 用户回复消息或者点击事件响应时，企业会收到回调消息，假设企业收到的推送消息：
            * 	POST /cgi-bin/wxpush? msg_signature=477715d11cdb4164915debcba66cb864d751f3e6&timestamp=1409659813&nonce=1372623149 HTTP/1.1
               Host: qy.weixin.qq.com
               Content-Length: 613
            *
            * 	<xml>
                   <ToUserName><![CDATA[wx5823bf96d3bd56c7]]></ToUserName>
                   <Encrypt><![CDATA[RypEvHKD8QQKFhvQ6QleEB4J58tiPdvo+rtK1I9qca6aM/wvqnLSV5zEPeusUiX5L5X/0lWfrf0QADHHhGd3QczcdCUpj911L3vg3W/sYYvuJTs3TUUkSUXxaccAS0qhxchrRYt66wiSpGLYL42aM6A8dTT+6k4aSknmPj48kzJs8qLjvd4Xgpue06DOdnLxAUHzM6+kDZ+HMZfJYuR+LtwGc2hgf5gsijff0ekUNXZiqATP7PF5mZxZ3Izoun1s4zG4LUMnvw2r+KqCKIw+3IQH03v+BCA9nMELNqbSf6tiWSrXJB3LAVGUcallcrw8V2t9EL4EhzJWrQUax5wLVMNS0+rUPA3k22Ncx4XXZS9o0MBH27Bo6BpNelZpS+/uh9KsNlY6bHCmJU9p8g7m3fVKn28H3KDYA5Pl/T8Z1ptDAVe0lXdQ2YoyyH2uyPIGHBZZIs2pDBS8R07+qN+E7Q==]]></Encrypt>
               </xml>
            */
            string sReqMsgSig = "477715d11cdb4164915debcba66cb864d751f3e6";
            string sReqTimeStamp = "1409659813";
            string sReqNonce = "1372623149";
            string sReqData = "<xml><ToUserName><![CDATA[wx5823bf96d3bd56c7]]></ToUserName><Encrypt><![CDATA[RypEvHKD8QQKFhvQ6QleEB4J58tiPdvo+rtK1I9qca6aM/wvqnLSV5zEPeusUiX5L5X/0lWfrf0QADHHhGd3QczcdCUpj911L3vg3W/sYYvuJTs3TUUkSUXxaccAS0qhxchrRYt66wiSpGLYL42aM6A8dTT+6k4aSknmPj48kzJs8qLjvd4Xgpue06DOdnLxAUHzM6+kDZ+HMZfJYuR+LtwGc2hgf5gsijff0ekUNXZiqATP7PF5mZxZ3Izoun1s4zG4LUMnvw2r+KqCKIw+3IQH03v+BCA9nMELNqbSf6tiWSrXJB3LAVGUcallcrw8V2t9EL4EhzJWrQUax5wLVMNS0+rUPA3k22Ncx4XXZS9o0MBH27Bo6BpNelZpS+/uh9KsNlY6bHCmJU9p8g7m3fVKn28H3KDYA5Pl/T8Z1ptDAVe0lXdQ2YoyyH2uyPIGHBZZIs2pDBS8R07+qN+E7Q==]]></Encrypt></xml>";
            string sMsg = "";  //解析之后的明文
            int ret = 0;
            ret = wxcpt.DecryptMsg(sReqMsgSig, sReqTimeStamp, sReqNonce, sReqData, ref sMsg);
            if (ret != 0)
            {
                System.Console.WriteLine("ERR: Decrypt fail, ret: " + ret);
                return;
            }
            System.Console.WriteLine(sMsg);


            /*
             * 2. 企业回复用户消息也需要加密和拼接xml字符串。
             * 假设企业需要回复用户的消息为：
             * 		<xml>
             * 		<ToUserName><![CDATA[mycreate]]></ToUserName>
             * 		<FromUserName><![CDATA[wx5823bf96d3bd56c7]]></FromUserName>
             * 		<CreateTime>1348831860</CreateTime>
                    <MsgType><![CDATA[text]]></MsgType>
             *      <Content><![CDATA[this is a test]]></Content>
             *      <MsgId>1234567890123456</MsgId>
             *      </xml>
             * 生成xml格式的加密消息过程为：
             */
            string sRespData = "<xml><ToUserName><![CDATA[mycreate]]></ToUserName><FromUserName><![CDATA[wx582测试一下中文的情况，消息长度是按字节来算的396d3bd56c7]]></FromUserName><CreateTime>1348831860</CreateTime><MsgType><![CDATA[text]]></MsgType><Content><![CDATA[this is a test]]></Content><MsgId>1234567890123456</MsgId></xml>";
            string sEncryptMsg = ""; //xml格式的密文
            ret = wxcpt.EncryptMsg(sRespData, sReqTimeStamp, sReqNonce, ref sEncryptMsg);
            System.Console.WriteLine("sEncryptMsg");
            System.Console.WriteLine(sEncryptMsg);

            /*测试：
             * 将sEncryptMsg解密看看是否是原文
             * */
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(sEncryptMsg);
            XmlNode root = doc.FirstChild;
            string sig = root["MsgSignature"].InnerText;
            string enc = root["Encrypt"].InnerText;
            string timestamp = root["TimeStamp"].InnerText;
            string nonce = root["Nonce"].InnerText;
            string stmp = "";
            ret = wxcpt.DecryptMsg(sig, timestamp, nonce, sEncryptMsg, ref stmp);
            System.Console.WriteLine("stemp");
            System.Console.WriteLine(stmp + ret);
            return;
        }
    }
}
