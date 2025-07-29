using System.Collections.Generic;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ET
{

    public static class HttpTikTokHelper
    {

        public static void Main(string[] args)
        {
            // 参数
            string appid = "10086";
            string appSecret = "secret";
            string method = "POST";
            string url = "http://some.domain.com/api/v1/demo/";
            string body = "{}";
            string nonce = "041d8d";
            long ts = 1730979810946;

            // 生成签名
            string signHeader = GenerateSign(appid, appSecret, method, url, body, ts, nonce);
            Console.WriteLine($"x-game-sign: {signHeader}");

            // 验证签名
            bool isValid = Verify(signHeader, url, method, body, appSecret);
            Console.WriteLine($"验证结果:{isValid}");
        }

        public static string GenerateSign(string appID, string secretKey, string httpMethod, string rawUrl, string httpBody, long ts, string nonce)
        {
            string method = httpMethod.ToUpper();
            string path = GetURI(rawUrl);
            string sign = GetSign(GetPayload(method, path, ts.ToString(), nonce, httpBody), secretKey);
            return BuildSignHeader(new Dictionary<string, string>
        {
            { "appid", appID },
            { "alg", "HMAC-SHA256" },
            { "v", "2.0" },
            { "nonce", nonce },
            { "timestamp", ts.ToString() },
            { "signature", sign }
        });
        }

        public static bool Verify(string signHeader, string rawUrl, string httpMethod, string body, string secretKey)
        {
            Dictionary<string, string> paramMap = ExtractSignHeader(signHeader);
            if (!paramMap.ContainsKey("appid")) return false;
            if (!paramMap.ContainsKey("alg")) return false;
            if (!paramMap.ContainsKey("nonce")) return false;
            if (!paramMap.ContainsKey("timestamp")) return false;
            if (!paramMap.ContainsKey("signature")) return false;
            if (!paramMap.ContainsKey("v")) return false;


            string alg = paramMap["alg"];
            string v = paramMap["v"];
            string nonce = paramMap["nonce"];
            string timestamp = paramMap["timestamp"];
            string signature = paramMap["signature"];


            if (alg != "HMAC-SHA256")
            {
                return false; // algorithm not support
            }
            if (v != "2.0")
            {
                return false; // version not support
            }

            string method = httpMethod.ToUpper();
            string path = GetURI(rawUrl);
            string sign = GetSign(GetPayload(method, path, timestamp, nonce, body), secretKey);
            return sign == signature;
        }

        public static Dictionary<string, string> ExtractSignHeader(string signHeader)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string[] fields = signHeader.Split(',');
            foreach (string pair in fields)
            {
                string[] kv = pair.Split(new[] { '=' }, 2);
                if (kv.Length != 2)
                {
                    continue; // 跳过无效的键值对
                }
                string key = kv[0].Trim();
                string value = kv[1].Trim('\"');
                result[key] = value;
            }
            return result;
        }

        public static string BuildSignHeader(Dictionary<string, string> parameters)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var kvp in parameters)
            {
                sb.Append($"{kvp.Key}=\"{kvp.Value}\",");
            }
            return sb.ToString().Trim(',');
        }

        public static string GetURI(string rawUrl)
        {
            Regex re = new Regex(@"^https?://[^/]+");
            string result = re.Replace(rawUrl, "");
            return result;
        }

        public static string GetPayload(string method, string path, string timestamp, string nonce, string body)
        {
            return $"{method}\n{path}\n{timestamp}\n{nonce}\n{body}\n";
        }

        public static string GetSign(string payload, string secretKey)
        {
            byte[] hash = HMAC_SHA256(Encoding.UTF8.GetBytes(payload), secretKey);
            return Convert.ToBase64String(hash);
        }

        public static byte[] HMAC_SHA256(byte[] content, string secret)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                return hmac.ComputeHash(content);
            }
        }
    }

}
