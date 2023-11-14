using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ET
{

    public static class TikTokHelper
    {

        public static int AppID = 554726;
        public static string AppSecret = "gacT8bvbGb9X3f52j8bZDtjvkAkhrOZy";

        /// <summary>
        /// HMACSHA1加密
        /// </summary>
        /// <param name="text">要加密的原串</param>
        ///<param name="key">私钥</param>
        /// <returns></returns>
        public static string HMACSHA1Text_1(string text, string key)
        {
            //HMACSHA1加密
            HMACSHA1 hmacsha1 = new HMACSHA1();
            hmacsha1.Key = System.Text.Encoding.UTF8.GetBytes(key);

            byte[] dataBuffer = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] hashBytes = hmacsha1.ComputeHash(dataBuffer);

            var enText = new StringBuilder();
            foreach (byte iByte in hashBytes)
            {
                enText.AppendFormat("{0:x2}", iByte);
            }
            return enText.ToString();

        }

        /// <summary>
        /// HMACSHA1加密
        /// </summary>
        /// <param name="text">要加密的原串</param>
        ///<param name="key">私钥</param>
        /// <returns></returns>
        public static string HMACSHA1Text_2(string text, string key)
        {
            //HMACSHA1加密
            HMACSHA1 hmacsha1 = new HMACSHA1();
            hmacsha1.Key = System.Text.Encoding.UTF8.GetBytes(key);

            byte[] dataBuffer = System.Text.Encoding.UTF8.GetBytes(text);
            byte[] hashBytes = hmacsha1.ComputeHash(dataBuffer);

            return Convert.ToBase64String(hashBytes);
        }

        public static string HMACSHA1Text_3(string your_data, string your_key)
        {
            var key = Encoding.UTF8.GetBytes(your_key);
            var hmac = new HMACSHA1(key);
            var data = Encoding.UTF8.GetBytes(your_data);
            var result = hmac.ComputeHash(data);
            var base64Result = Convert.ToBase64String(result);
            return base64Result;
            //HMACSHA1 hmacsha1 = new HMACSHA1();
            //hmacsha1.Key = Encoding.UTF8.GetBytes(your_key);
            //byte[] dataBuffer = Encoding.UTF8.GetBytes(your_data);
            //byte[] hashBytes = hmacsha1.ComputeHash(dataBuffer);
            //return Convert.ToBase64String(hashBytes);
        }

        public static string HMACSHA1Text_4(string text, string key)
        {
            Encoding encode = Encoding.GetEncoding(text);
            byte[] byteData = encode.GetBytes(text);
            byte[] byteKey = encode.GetBytes(key);
            HMACSHA1 hmac = new HMACSHA1(byteKey);
            CryptoStream cs = new CryptoStream(Stream.Null, hmac, CryptoStreamMode.Write);
            cs.Write(byteData, 0, byteData.Length);
            cs.Close();
            return Convert.ToBase64String(hmac.Hash);
        }

        //jave加密秘钥: rvaJrM4BTYA/aGWIfuRaQmNPRTo=
        public static string getSign( Dictionary<string, string> params1)
        {
            //给参数进行排序，游戏方自己实现排序算法，通过各种方式都可以，只要实现key按字母从小到大排序即可

            var dictList = params1.OrderBy(d => d.Key).ToList();

            params1.Clear();
            string lastKey = string.Empty;
            foreach (var item in dictList)
            {
                params1.Add(item.Key, item.Value);
                lastKey = item.Key; 
            }

            //拼接成字符串
            StringBuilder sb = new StringBuilder();
           
            foreach (var item in params1)
            {
                sb.Append(item.Key).Append("=").Append(item.Value);

                if (!item.Key.Equals(lastKey))
                {
                    sb.Append("&");
                }
            }

            //使用密钥进行Hmac-sha1加密
            string sign = HMACSHA1Text_2(sb.ToString(), AppSecret);
            return sign;    
        }
    }

}