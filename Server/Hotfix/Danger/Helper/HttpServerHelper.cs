using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        public static async ETTask<string> OnWebRequestPostBody(string url, Dictionary<string, string> headers, Dictionary<string, string> dictionary)
        {
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
            httpClient.DefaultRequestHeaders.Clear();

            if (headers != null)
            {
                foreach (var head in headers)
                {
                    httpClient.DefaultRequestHeaders.Add(head.Key, head.Value);
                }
            }

            var body = JsonSerializer.Serialize(dictionary);

            //var body = JsonHelper.ToJson(dictionary);

            HttpContent postContent = new StringContent(body);

            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            try
            {
                var responseMessage = await httpClient.PostAsync(url, postContent);
                if (responseMessage != null && responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var result = await responseMessage.Content.ReadAsStringAsync();
                    return result;
                }
                else
                {
                    // 网络请求失败，授权失败
                    Console.WriteLine($"OnWebRequestPostBody 网络请求失败:{url}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return string.Empty;
        }



        public static string UrlEncodeInterface(string str)
        {
            return Uri.EscapeDataString(str);
            //int useType = TimeHelper.DateTimeNow().Minute % 3;
            //Log.Console($"useType:  {useType}");
            //if (useType == 0)
            //{
            //    return UrlEncode_2(str);
            //}
            //if (useType == 1)
            //{
            //    return Uri.EscapeDataString(str);
            //}
            //if (useType == 2)
            //{
            //    return System.Web.HttpUtility.UrlEncode(str, System.Text.Encoding.UTF8);
            //}
            //return Uri.EscapeDataString(str);
        }

        public static string OnWebRequestPost_TikTokLogin(string url, Dictionary<string, string> dic)
        {
            string result = "";
            try
            {
                string url_access_token = UrlEncodeInterface(dic["access_token"]);
                string url_app_id = UrlEncodeInterface(dic["app_id"]);
                string url_ts = UrlEncodeInterface(dic["ts"]);
                string url_sign = UrlEncodeInterface(dic["sign"]);

                string postData = $"access_token={url_access_token}&app_id={url_app_id}&ts={url_ts}&sign={url_sign}";
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromMinutes(100);
                HttpContent httpContent = new StringContent(postData);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                response.EnsureSuccessStatusCode();//用来抛异常的
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                Log.Info($"Exception ex: {ex}");
                return "";
            }
            return result;//读取微信返回的数据
        }

        public static string OnWebRequestPost_TikTokGetAccessToken(string url, Dictionary<string, string> dic)
        {
            string result = "";
            try
            {
                //paramslist.Add("code", request.auth_code);
                //paramslist.Add("app_id", TikTokHelper.AppID.ToString());
                //paramslist.Add("app_secret", TikTokHelper.AppSecret);
                string code = UrlEncodeInterface(dic["code"]);
                string app_id = UrlEncodeInterface(dic["app_id"]);
                string app_secret = UrlEncodeInterface(dic["app_secret"]);

                string postData = $"code={code}&app_id={app_id}&app_secret={app_secret}";
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromMinutes(100);
                HttpContent httpContent = new StringContent(postData);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                response.EnsureSuccessStatusCode();//用来抛异常的
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                Log.Info($"Exception ex: {ex}");
                return "";
            }
            return result;//
        }


        public static string OnWebRequestPost_Pay(string url, Dictionary<string, string> dic)
        {
            string result = "";
            try
            {
                string postData = string.Empty;

                foreach (var item in dic)
                {
                    if (item.Key.Equals("sign"))
                    {
                        dic[item.Key] = UrlEncodeInterface(item.Value);
                        postData = postData + $"{item.Key}={dic[item.Key]}";
                    }
                    else
                    {
                        dic[item.Key] = UrlEncodeInterface(item.Value);
                        postData = postData + $"{item.Key}={dic[item.Key]}&";
                    }
                }
                //Log.Console($"OnWebRequestPost_Pay:  {postData}");
                //Log.Warning($"OnWebRequestPost_Pay:  {postData}");

                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromMinutes(100);
                HttpContent httpContent = new StringContent(postData);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                response.EnsureSuccessStatusCode();//用来抛异常的
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                Log.Info($"Exception ex: {ex}");
                return "";
            }
            return result;//读取微信返回的数据
        }


        public static async ETTask<string> OnWebRequestPost_TikTokGetHistorydAccountInfo(string url, string clientToken, string open_id, string access_token)
        {
            string result = "";

            Console.WriteLine($"open_id: {open_id}");
            Console.WriteLine($"access_token: {access_token}");
            Console.WriteLine($"clientToken: {clientToken}");

            var dictionary = new Dictionary<string, string>()
            {
                { "app_id", "554726" },
                { "user_type","1" },
                { "open_id", open_id },
                { "app_package", "com.example.weijinggame" },
                { "access_token", access_token },
            };

            var body = JsonSerializer.Serialize(dictionary);
            HttpContent postContent = new StringContent(body);
            var httpClient = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("access-token", clientToken);

            postContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
            try
            {
                var responseMessage = await httpClient.PostAsync(url, postContent);
                if (responseMessage != null && responseMessage.StatusCode == HttpStatusCode.OK)
                {
                    var responeresult = await responseMessage.Content.ReadAsStringAsync();

                    Console.WriteLine($"TikTokGetHistorydAccountInfo: {responeresult}");
                    Log.Debug($"TikTokGetHistorydAccountInfo: {responeresult}");

                    //TikTokGetHistorydAccountInfo: //2025 - 07 - 29 15:06:24.1326(LocationComponentSystem.cs:98) location get key: 3008513405486170112 instanceId: 1242666873481855057

                    //7492384281722297124
                    //_000EX1CG4-EAWlO9YUsp1y4HnwdP1XV1X9P
                    //这个接口有配额 要注意！！！
                    //OSDK.get_history_account_info return: {"err_no":28003017,"err_msg":"quota已用完","log_id":"20250724161757EE2515F1BFF953756E79"}
                    GetHistoryAccountResponse obj = JsonSerializer.Deserialize<GetHistoryAccountResponse>(responeresult);


                    //var err_msg = obj["err_msg"] as string;
                    // 授权成功
                    string sdk_open_id = string.Empty;
                    if (obj != null && obj.Data != null)
                    {
                        sdk_open_id = obj.Data.SdkOpenId;
                        Console.WriteLine($"TikTokGetHistorydAccountInfo_sdk_open_id != null: {sdk_open_id}  {sdk_open_id.Length}");
                    }
                    else
                    {
                        Console.WriteLine($"TikTokGetHistorydAccountInfo_sdk_open_id == null: {sdk_open_id}");
                    }
                    if (obj == null)
                    {
                        Console.WriteLine($"TikTokGetHistorydAccountInfo_obj == null");
                    }
                    if (obj != null && obj.Data == null)
                    {
                        Console.WriteLine($"TikTokGetHistorydAccountInfo_obj != null && obj.data == null");
                    }

                    if (!string.IsNullOrEmpty(sdk_open_id))
                    {
                        //账号找回通知。 游戏侧账号迁移完成后，需通知抖音侧找回账号成功。
                        //通知情况将会影响抖音对历史用户的触达方式。
                        return sdk_open_id;
                    }
                }
                else
                {
                    // 网络请求失败，授权失败
                    Console.WriteLine($"抖音找不到渠道包账号 Error: {responseMessage}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"抖音找不到渠道包账号  Exception e" + e);
            }

            return result;//
        }
    }
}