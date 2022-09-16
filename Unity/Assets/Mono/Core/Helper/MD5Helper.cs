using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ET
{
	public static class MD5Helper
	{
		public static string FileMD5(string filePath)
		{
			byte[] retVal;
            using (FileStream file = new FileStream(filePath, FileMode.Open))
            {
	            MD5 md5 = MD5.Create();
				retVal = md5.ComputeHash(file);
			}
			return retVal.ToHex("x2");
		}
        public static string StringMD5_2(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        
        public static string StringMD5(string content)
		{
			MD5 md5 = MD5.Create();
			byte[] result = Encoding.Default.GetBytes(content);
			byte[] output = md5.ComputeHash(result);
			return BitConverter.ToString(output).Replace("-", "");
		}
	}
}
