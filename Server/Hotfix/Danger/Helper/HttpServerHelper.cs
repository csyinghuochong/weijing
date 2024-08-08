using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace ET
{
    public static partial class HttpServerHelper
    {

        public static async ETTask<string> Get(string link)
        {
            try
            {
                using HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(link);
                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"http request fail: {link.Substring(0, link.IndexOf('?'))}\n{e}");
            }
        }

        public static void Response(HttpListenerContext context, object response)
        {
            byte[] bytes = MongoHelper.ToJson(response).ToUtf8();
            context.Response.StatusCode = 200;
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = bytes.Length;
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
        }

        public static void ResponseEmpty(HttpListenerContext context)
        {
            string responseString = "SUCCESS";
            byte[] bytes = Encoding.UTF8.GetBytes(responseString);
            context.Response.StatusCode = 200;
            context.Response.ContentEncoding = Encoding.UTF8;
            context.Response.ContentLength64 = bytes.Length;
            context.Response.OutputStream.Write(bytes, 0, bytes.Length);
            //context.Response.OutputStream.WriteAsync(bytes, 0, bytes.Length);
            // 关闭输出流
            //context.Response.OutputStream.Close();
        }


        //1.激活
        //2.注册
        //3.付费
        //4.次留
        //枚举值{1,2,3,4,5,6}：1：激活 首次打开 APP 2：注册 在 APP 内注册账户/创角 3：付费(多次)4：次留 5：全渠道首次吊起（当日 app 首次被促活广告拉起） 6：关键事件 （用户在 app 进行了一些黑盒关键行为， 如加购等）
        //转化事件发生后，开发者/第三方在请求接口后附上回传字段({DEEP_CALLBACK_URL}&tap_project_id=13&tap_track_id=xxxevent_type=xxx&event_timestamp={timestamp}&???=xxx)，并发起 GET 请求，上报给 TapREP。
        public static async ETTask TapReqEvent(string taprepRequest, int eventType, string eventData, string paramdata)
        {
            if (string.IsNullOrEmpty(taprepRequest))
            {
                return;
            }

            string[] taprepinfo = taprepRequest.Split('&');
            if (taprepinfo.Length != 3)
            {
                return;
            }

            //转化事件发生后，开发者/第三方在请求接口后附上回传字段({DEEP_CALLBACK_URL}&event_type=xxx&event_timestamp={timestamp}&???=xxx)，并发起 GET 请求，上报给 TapREP。
            string url = $"{taprepinfo[0]}?v={RandomGenerator.RandUInt32()}&event_type={eventType}&event_timestamp={TimeHelper.ServerNow()}&amount{paramdata}&tap_project_id={taprepinfo[1]}&tap_track_id={taprepinfo[2]}";
            Log.Debug($"TestTapHttp_1  url: {url}");
            string routerInfo = await Get(url);
        }
    }
}