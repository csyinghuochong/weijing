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
    class HexConverter
    {
        public static char ToCharUpper(int value)
        {
            value &= 0xF;
            value += '0';

            if (value > '9')
            {
                value += ('A' - ('9' + 1));
            }

            return (char)value;
        }
    }

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

        public static string UrlEncode_2(string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;

            int safeCount = 0;
            int spaceCount = 0;
            for (int i = 0; i < value.Length; i++)
            {
                char ch = value[i];
                if (IsUrlSafeChar(ch))
                {
                    safeCount++;
                }
                else if (ch == ' ')
                {
                    spaceCount++;
                }
            }

            int unexpandedCount = safeCount + spaceCount;
            if (unexpandedCount == value.Length)
            {
                if (spaceCount != 0)
                {
                    // Only spaces to encode
                    return value.Replace(' ', '+');
                }

                // Nothing to expand
                return value;
            }

            int byteCount = Encoding.UTF8.GetByteCount(value);
            int unsafeByteCount = byteCount - unexpandedCount;
            int byteIndex = unsafeByteCount * 2;

            // Instead of allocating one array of length `byteCount` to store
            // the UTF-8 encoded bytes, and then a second array of length
            // `3 * byteCount - 2 * unexpandedCount`
            // to store the URL-encoded UTF-8 bytes, we allocate a single array of
            // the latter and encode the data in place, saving the first allocation.
            // We store the UTF-8 bytes to the end of this array, and then URL encode to the
            // beginning of the array.
            byte[] newBytes = new byte[byteCount + byteIndex];
            Encoding.UTF8.GetBytes(value, 0, value.Length, newBytes, byteIndex);

            GetEncodedBytes(newBytes, byteIndex, byteCount, newBytes);
            return Encoding.UTF8.GetString(newBytes);
        }

        private static bool IsUrlSafeChar(char ch)
        {
            // Set of safe chars, from RFC 1738.4 minus '+'
            /*
            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch >= '0' && ch <= '9')
                return true;

            switch (ch)
            {
                case '-':
                case '_':
                case '.':
                case '!':
                case '*':
                case '(':
                case ')':
                    return true;
            }

            return false;
            */
            // Optimized version of the above:

            int code = (int)ch;

            const int safeSpecialCharMask = 0x03FF0000 | // 0..9
                1 << ((int)'!' - 0x20) | // 0x21
                1 << ((int)'(' - 0x20) | // 0x28
                1 << ((int)')' - 0x20) | // 0x29
                1 << ((int)'*' - 0x20) | // 0x2A
                1 << ((int)'-' - 0x20) | // 0x2D
                1 << ((int)'.' - 0x20); // 0x2E

            return IsAsciiLetter(ch) ||
                   ((uint)(code - 0x20) <= (uint)('9' - 0x20) && ((1 << (code - 0x20)) & safeSpecialCharMask) != 0) ||
                   (code == (int)'_');
        }

        private static void GetEncodedBytes(byte[] originalBytes, int offset, int count, byte[] expandedBytes)
        {
            int pos = 0;
            int end = offset + count;
            //Debug.Assert(offset < end && end <= originalBytes.Length);
            for (int i = offset; i < end; i++)
            {
#if DEBUG
                // Make sure we never overwrite any bytes if originalBytes and
                // expandedBytes refer to the same array
                if (originalBytes == expandedBytes)
                {
                    //Debug.Assert(i >= pos);
                }
#endif

                byte b = originalBytes[i];
                char ch = (char)b;
                if (IsUrlSafeChar(ch))
                {
                    expandedBytes[pos++] = b;
                }
                else if (ch == ' ')
                {
                    expandedBytes[pos++] = (byte)'+';
                }
                else
                {
                    expandedBytes[pos++] = (byte)'%';
                    expandedBytes[pos++] = (byte)HexConverter.ToCharUpper(b >> 4);
                    expandedBytes[pos++] = (byte)HexConverter.ToCharUpper(b);
                }
            }
        }

        public static bool IsAsciiLetter(char c)
        {
            return (uint)((c | 0x20) - 'a') <= 'z' - 'a';
        }

#if SERVER

        public static string UrlEncodeInterface(string str)
        {
            int useType = TimeHelper.DateTimeNow().Minute % 3;
            Log.Console($"useType:  {useType}");
            if (useType == 0)
            {
                return UrlEncode_2(str);
            }
            if (useType == 1)
            {
                return Uri.EscapeDataString(str);
            }
            if (useType == 2)
            {
                return System.Web.HttpUtility.UrlEncode(str, System.Text.Encoding.UTF8);
            }
            return Uri.EscapeDataString(str);
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
                Log.Console($"OnWebRequestPost_Pay:  {postData}");
                Log.Warning($"OnWebRequestPost_Pay:  {postData}");

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
                dic["access_token"] = Uri.EscapeDataString(dic["access_token"]);
                dic["app_id"] = Uri.EscapeDataString(dic["app_id"]);
                dic["ts"] = Uri.EscapeDataString(dic["ts"]);
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

        public static string UrlEncode_1(string str)
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
