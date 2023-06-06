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
                httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

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
