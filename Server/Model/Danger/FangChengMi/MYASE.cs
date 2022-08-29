using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ET
{
    public static class MyCryptoClass
    {
        /**
         * 转换16进制字符串
         **/
        private static byte[] hexStringToByte(String str)
        {
            return Enumerable.Range(0, str.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(str.Substring(x, 2), 16))
                     .ToArray();
        }

        public static byte[] getBytes(this string content)
        {
            return Encoding.UTF8.GetBytes(content);
        }


        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="encryptString"></param>
        /// <returns></returns>
        public static string encryptByAES128Gcm_1(string Key, string data)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(Key);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(data);
            //RijndaelManaged rDel = new RijndaelManaged();
            Aes rDel = Aes.Create("AesManaged");
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        /***
         * @version 1.0 aes-128-gcm 加密
         * @params plainData 为加密信息 key 为32位的16进制key
         * @return 返回base64编码
         **/
        public static String encryptByAES128Gcm(String key, String plainData)
        {

            Random rand = new Random();
            byte[] bb = new byte[12];
            rand.NextBytes(bb);

            var gcmBlockCipher = new GcmBlockCipher(new AesEngine());
            var parameters = new AeadParameters(
                new KeyParameter(hexStringToByte(key)),
                128, //128 = 16 * 8 => (tag size * 8)
                bb,
                null);
            gcmBlockCipher.Init(true, parameters);

            var data = Encoding.UTF8.GetBytes(plainData);
            var cipherData = new byte[gcmBlockCipher.GetOutputSize(data.Length)];

            var length = gcmBlockCipher.ProcessBytes(data, 0, data.Length, cipherData, 0);
            gcmBlockCipher.DoFinal(cipherData, length);
            byte[] message = new byte[bb.Length + cipherData.Length];
            Array.Copy(bb, message, bb.Length);
            Array.Copy(cipherData, 0, message, bb.Length, cipherData.Length);
            string aaaaa = Convert.ToBase64String(message);
            return aaaaa;
        }

    }
}