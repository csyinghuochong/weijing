using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.IO;
using System.Linq;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace ET
{
    public static class HttpHelper
    {
        /// <summary>
        /// 判断是不是周末/节假日
        /// </summary>
        /// <param name="date">日期</param>
        /// <returns>周末和节假日返回true，工作日返回false</returns>
        public static async ETTask<bool> IsHolidayByDate(DateTime date)
        {
            try
            {
                var isHoliday = false;
                var httpClient = new HttpClient();

                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                param.Add(new KeyValuePair<string, string>("d", date.ToString("yyyyMMdd")));

                var day = date.DayOfWeek;
                //周五一点可以进
                if (day == DayOfWeek.Friday)
                    return true;
                string str = "";
                HttpContent httpContent = new StringContent(str);
                HttpResponseMessage response = await httpClient.PostAsync("http://tool.bitefu.net/jiari/", new FormUrlEncodedContent(param));
                response.EnsureSuccessStatusCode();//用来抛异常的
                string responseBody = await response.Content.ReadAsStringAsync();
                //0为工作日，1为周末，2为法定节假日
                if (responseBody == "1" || responseBody == "2")
                    isHoliday = true;

                return isHoliday;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
            return false;
        }

        public static async ETTask<string> GetIosPayParameter(string url, string postData)
        {
            //-----------------------------------第一步:创建Htt请求----------------------//
            //向Appstpre发起支付参数的请求
            string result = "";
            try
            {
                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromMinutes(100);
                HttpContent httpContent = new StringContent(postData);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);
                response.EnsureSuccessStatusCode();//用来抛异常的
                result = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Log.Info($"Exception ex: {ex}");
                return "";
            }
            return result;//读取微信返回的数据
        }

        public static string OnWebRequestPost_Form(string url, Dictionary<string, string> paramList)
        {
            string result = string.Empty;

            try
            {
                HttpClient httpClient = new HttpClient();
                var multipartFormDataContent = new MultipartFormDataContent();
                foreach (var keyValuePair in paramList)
                {
                    httpClient.DefaultRequestHeaders.Add(keyValuePair.Key, keyValuePair.Value);
                }
                multipartFormDataContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                HttpResponseMessage response = httpClient.PostAsync(url, multipartFormDataContent).Result;
                result = response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;  
        }

        public static string OnWebRequestPost_Form2(string url, Dictionary<string, string> paramList)
        {
            string result = string.Empty;

            try
            {
                var formData = new MultipartFormDataContent();
                HttpContent content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("rPath",  "/RootFolder/"),
                    new KeyValuePair<string, string>("nName", "TestFolder"),
                    new KeyValuePair<string, string>("type", "Folder")
                });

                content.Headers.ContentType = new MediaTypeHeaderValue("multipart/form-data");
                content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
                formData.Add(content);

                HttpResponseMessage response = new HttpResponseMessage();
                using (var client = new HttpClient() { })
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "xxxxxxx=");
                    response = client.PostAsync(url, content).Result;
                }

                string statusCode = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    result = response.Content.ReadAsStringAsync().Result;
                    return result;
                }
                else
                {
                    return statusCode;
                }
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            return result;
        }


#if SERVER
        public static string OnWebRequestPost_TikTokLogin(string url, Dictionary<string, string> dic)
        {
            string result = "";
            try
            {
                dic["access_token"] = System.Web.HttpUtility.UrlEncode(dic["access_token"], System.Text.Encoding.UTF8);
                dic["app_id"] = System.Web.HttpUtility.UrlEncode(dic["app_id"], System.Text.Encoding.UTF8);
                dic["ts"] = System.Web.HttpUtility.UrlEncode(dic["ts"], System.Text.Encoding.UTF8);

                string postData = string.Empty;
                postData = $"access_token={dic["access_token"]}&app_id={dic["app_id"]}&ts={dic["ts"]}&sign={dic["sign"]}";
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
                        postData = postData + $"{item.Key}={item.Value}";
                        continue;
                    }
                    if (item.Key.Equals("client_ip"))
                    {
                        postData = postData + $"{item.Key}={item.Value}&";
                        continue;
                    }
                    dic[item.Key] = System.Web.HttpUtility.UrlEncode(dic[item.Key], System.Text.Encoding.UTF8);
                    postData = postData + $"{item.Key}={item.Value}&";
                }

                HttpClient httpClient = new HttpClient();
                httpClient.Timeout = TimeSpan.FromMinutes(100);
                HttpContent httpContent = new StringContent(postData);
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                HttpResponseMessage response =  httpClient.PostAsync(url, httpContent).Result;
                response.EnsureSuccessStatusCode();//用来抛异常的
                result =  response.Content.ReadAsStringAsync().Result;
            }
            catch (Exception ex)
            {
                Log.Info($"Exception ex: {ex}");
                return "";
            }
            return result;//读取微信返回的数据
        }
#else

        public static string OnWebRequestPost_TikTokLogin(string url, Dictionary<string, string> dic)
        {
            string result = "";
            try
            {
                dic["access_token"] = UrlEncode(dic["access_token"]);
                dic["app_id"] = UrlEncode(dic["app_id"]);
                dic["ts"] = UrlEncode(dic["ts"]);
                string postData = string.Empty;
                postData = $"access_token={dic["access_token"]}&app_id={dic["app_id"]}&ts={dic["ts"]}&sign={dic["sign"]}";
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
#endif

        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }

        //计算签名的时候不需要对参数进行urlencode处理（"application/x-www-form-urlencoded"编码），但是发送请求的时候需要进行urlencode处理
        //sign参数不参与签名，其他字段都会参与验签
        //urlencode处理时，不要对sign重复编码

        //POST http://www.xxx.com HTTP/1.1
        //Content-Type: application/x-www-form-urlencoded;charset=utf-8
        //access_token=q3fafa33sHFU%2BV9h32h0v8weVEH%2F04hgsrHFHOHNNQOBC9fnwejasubw%3D%3D&app_id=1234&ts=1555912969&sign=sTFH83DV%2BVamgr6SRsC%2FNNjw0%2BQ%3D

        public static string OnWebRequestPost_1(string url, Dictionary<string, string> dic)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                HttpClient httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Clear();
                foreach (var kv in dic)
                {
                    httpClient.DefaultRequestHeaders.Add(kv.Key, kv.Value);
                }
                HttpContent httpContent = new StringContent("");
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                HttpResponseMessage response = httpClient.PostAsync(url, httpContent).Result;
                string statusCode = response.StatusCode.ToString();
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    return result;
                }
                else
                {
                    return statusCode;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return "";
            }
        }

        public static async ETTask<string> HttpClientDoGet(string uri, string appcode,  Dictionary<string, string> keyValuePairs)
        {
            string paramss = string.Empty;
            foreach (var item in keyValuePairs)
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
                httpclient.DefaultRequestHeaders.Add("Authorization", appcode);

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

    }
}
