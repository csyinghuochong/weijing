using System;
using System.Security.Cryptography;
using System.Text;

namespace ET
{
    public static class AESUtilsHelper
    {

        public static string Base64Encode(byte[] bytes)
        {
            return Convert.ToBase64String(bytes);
        }

        public static byte[] Base64Decode(string base64Code)
        {
            if (string.IsNullOrEmpty(base64Code))
                return null;
            return Convert.FromBase64String(base64Code);
        }

        public static byte[] AesEncryptToBytes(string content, string encryptKey)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(encryptKey, Encoding.UTF8.GetBytes("SALT_STRING"), 1000))
            {
                byte[] key = deriveBytes.GetBytes(16); // 128-bit key

                using (var aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;

                    using (var encryptor = aes.CreateEncryptor())
                    {
                        byte[] contentBytes = Encoding.UTF8.GetBytes(content);
                        return encryptor.TransformFinalBlock(contentBytes, 0, contentBytes.Length);
                    }
                }
            }
        }

        public static string AesEncrypt(string content, string encryptKey)
        {
            return Base64Encode(AesEncryptToBytes(content, encryptKey));
        }

        public static string AesDecryptByBytes(byte[] encryptBytes, string decryptKey)
        {
            using (var deriveBytes = new Rfc2898DeriveBytes(decryptKey, Encoding.UTF8.GetBytes("SALT_STRING"), 1000))
            {
                byte[] key = deriveBytes.GetBytes(16); // 128-bit key

                using (var aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.Mode = CipherMode.ECB;
                    aes.Padding = PaddingMode.PKCS7;

                    using (var decryptor = aes.CreateDecryptor())
                    {
                        byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptBytes, 0, encryptBytes.Length);
                        return Encoding.UTF8.GetString(decryptedBytes);
                    }
                }
            }
        }

        public static string AesDecrypt(string encryptStr, string decryptKey)
        {
            if (string.IsNullOrEmpty(encryptStr))
                return null;
            return AesDecryptByBytes(Base64Decode(encryptStr), decryptKey);
        }
    }
}
