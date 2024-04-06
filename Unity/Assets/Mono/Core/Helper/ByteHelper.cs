using System.Text;
using System;
using System.IO;
using System.Security.Cryptography;

namespace ET
{
	public static class ByteHelper
	{
		public static string ToHex(this byte b)
		{
			return b.ToString("X2");
		}

		public static string ToHex(this byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string ToHex(this byte[] bytes, string format)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(b.ToString(format));
			}
			return stringBuilder.ToString();
		}

		public static string ToHex(this byte[] bytes, int offset, int count)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = offset; i < offset + count; ++i)
			{
				stringBuilder.Append(bytes[i].ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string ToStr(this byte[] bytes)
		{
			return Encoding.Default.GetString(bytes);
		}

		public static string ToStr(this byte[] bytes, int index, int count)
		{
			return Encoding.Default.GetString(bytes, index, count);
		}

		public static string Utf8ToStr(this byte[] bytes)
		{
			return Encoding.UTF8.GetString(bytes);
		}

		public static string Utf8ToStr(this byte[] bytes, int index, int count)
		{
			return Encoding.UTF8.GetString(bytes, index, count);
		}

		public static void WriteTo(this byte[] bytes, int offset, uint num)
		{
			bytes[offset] = (byte)(num & 0xff);
			bytes[offset + 1] = (byte)((num & 0xff00) >> 8);
			bytes[offset + 2] = (byte)((num & 0xff0000) >> 16);
			bytes[offset + 3] = (byte)((num & 0xff000000) >> 24);
		}

		public static void WriteTo(this byte[] bytes, int offset, int num)
		{
			bytes[offset] = (byte)(num & 0xff);
			bytes[offset + 1] = (byte)((num & 0xff00) >> 8);
			bytes[offset + 2] = (byte)((num & 0xff0000) >> 16);
			bytes[offset + 3] = (byte)((num & 0xff000000) >> 24);
		}

		public static void WriteTo(this byte[] bytes, int offset, byte num)
		{
			bytes[offset] = num;
		}

		public static void WriteTo(this byte[] bytes, int offset, short num)
		{
			bytes[offset] = (byte)(num & 0xff);
			bytes[offset + 1] = (byte)((num & 0xff00) >> 8);
		}

		public static void WriteTo(this byte[] bytes, int offset, ushort num)
		{
			bytes[offset] = (byte)(num & 0xff);
			bytes[offset + 1] = (byte)((num & 0xff00) >> 8);
		}

		public static unsafe void WriteTo(this byte[] bytes, int offset, long num)
		{
			byte* bPoint = (byte*)&num;
			for (int i = 0; i < sizeof(long); ++i)
			{
				bytes[offset + i] = bPoint[i];
			}
		}

        public static void Decrypt(string inputFilePath, string outputFilePath, string password)
        {
            byte[] Key = Encoding.UTF8.GetBytes(password); // 16字节密钥
            byte[] IV = Encoding.UTF8.GetBytes(password);  // 16字节初始化向量

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                using (FileStream fileInput = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
                using (FileStream fileOutput = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                using (CryptoStream cryptoStream = new CryptoStream(fileInput, aes.CreateDecryptor(), CryptoStreamMode.Read))
                {
					try
                    {
                        cryptoStream.CopyTo(fileOutput);
                    }
                   catch (Exception e) 
					{
						Console.WriteLine(e.ToString());	
					}
                }
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string password)
        {
            byte[] key = new Rfc2898DeriveBytes(password, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 }).GetBytes(32);

            using (Aes aes = Aes.Create())
            {
                aes.Key = key;

                using (FileStream fsRead = new FileStream(inputFile, FileMode.Open, FileAccess.Read))
                {
                    byte[] iv = new byte[aes.BlockSize / 8];
                    fsRead.Read(iv, 0, iv.Length);

                    aes.IV = iv;

                    using (FileStream fsWrite = new FileStream(outputFile, FileMode.Create, FileAccess.Write))
                    using (CryptoStream cryptoStream = new CryptoStream(fsWrite, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        int data;
                        while ((data = fsRead.ReadByte()) != -1)
                        {
                            cryptoStream.WriteByte((byte)data);
                        }

                        cryptoStream.FlushFinalBlock();
                    }
                }
            }
        }

    }
}