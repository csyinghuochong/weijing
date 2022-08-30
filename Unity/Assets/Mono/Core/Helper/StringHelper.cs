using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace ET
{
	public static class StringHelper
	{
		public static IEnumerable<byte> ToBytes(this string str)
		{
			byte[] byteArray = Encoding.Default.GetBytes(str);
			return byteArray;
		}

		public static byte[] ToByteArray(this string str)
		{
			byte[] byteArray = Encoding.Default.GetBytes(str);
			return byteArray;
		}

	    public static byte[] ToUtf8(this string str)
	    {
            byte[] byteArray = Encoding.UTF8.GetBytes(str);
            return byteArray;
        }

		public static byte[] HexToBytes(this string hexString)
		{
			if (hexString.Length % 2 != 0)
			{
				throw new ArgumentException(String.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
			}

			var hexAsBytes = new byte[hexString.Length / 2];
			for (int index = 0; index < hexAsBytes.Length; index++)
			{
				string byteValue = "";
				byteValue += hexString[index * 2];
				byteValue += hexString[index * 2 + 1];
				hexAsBytes[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
			}
			return hexAsBytes;
		}

		public static string Fmt(this string text, params object[] args)
		{
			return string.Format(text, args);
		}

		public static string ListToString<T>(this List<T> list)
		{
			StringBuilder sb = new StringBuilder();
			foreach (T t in list)
			{
				sb.Append(t);
				sb.Append(",");
			}
			return sb.ToString();
		}
		
		public static string ArrayToString<T>(this T[] args)
		{
			if (args == null)
			{
				return "";
			}

			string argStr = " [";
			for (int arrIndex = 0; arrIndex < args.Length; arrIndex++)
			{
				argStr += args[arrIndex];
				if (arrIndex != args.Length - 1)
				{
					argStr += ", ";
				}
			}

			argStr += "]";
			return argStr;
		}
        
		public static string ArrayToString<T>(this T[] args, int index, int count)
		{
			if (args == null)
			{
				return "";
			}

			string argStr = " [";
			for (int arrIndex = index; arrIndex < count + index; arrIndex++)
			{
				argStr += args[arrIndex];
				if (arrIndex != args.Length - 1)
				{
					argStr += ", ";
				}
			}

			argStr += "]";
			return argStr;
		}

		/// <summary>
		/// 检测是否有Sql危险字符
		/// </summary>
		/// <param name="str">要判断字符串</param>
		/// <returns>判断结果</returns>
		public static bool IsSafeSqlString(string str)
		{
			return !Regex.IsMatch(str, @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']"); 
		}

		//第一种思路，将所有特殊字符都列出来，判断目标字符串包含特殊字符。
		public static bool IsSpecialChar(string str)
		{
			//中文、英文、数字但不包括下划线等符号
			//Regex regExp = new Regex("[ \\[ \\] \\^ \\-_*×――(^)$%~!＠@＃#$…&%￥—+=<>《》!！??？:：•`·、。，；,.;/\'\"{}（）‘’“”-]");
			//Regex regExp = new Regex(@"^[\u4E00-\u9FA5A-Za-z0-9]{2,20}$");
			//if (regExp.IsMatch(str))
			//{
			//	return true;
			//}
			//return false;
			bool l_bFlag = false;
			l_bFlag = Regex.Matches(str, "^[\u4e00-\u9fa5a-zA-Z-z0-9]+$").Count > 0;
			return l_bFlag;
		}

		//第二种思路，将所有不是特殊字符的字符都列出来，判断目标字符串是否不包含这些字符
		//public bool IsSpecialChar(string str)
		//{
		//	Regex regExp = new Regex("[^0-9a-zA-Z\u4e00-\u9fa5]");
		//	if (regExp.IsMatch(str))
		//	{
		//		return true;
		//	}
		//	return false;
		//}

		/// <summary>
		/// 检查危险字符
		/// </summary>
		/// <param name="Input"></param>
		/// <returns></returns>
		public static string Filter(string sInput)
		{
			if (sInput == null || sInput == "")
				return null;
			string sInput1 = sInput.ToLower();
			string output = sInput;
			string pattern = @"*|and|exec|insert|select|delete|update|count|master|truncate|declare|char(|mid(|chr(|'";
			if (Regex.Match(sInput1, Regex.Escape(pattern), RegexOptions.Compiled | RegexOptions.IgnoreCase).Success)
			{
				throw new Exception("字符串中含有非法字符!");
			}
			else
			{
				output = output.Replace("'", "''");
			}
			return output;
		}

		/// <summary> 
		/// 检查过滤设定的危险字符
		/// </summary> 
		/// <param name="InText">要过滤的字符串 </param> 
		/// <returns>如果参数存在不安全字符，则返回true </returns> 
		public static bool SqlFilter(string word, string InText)
		{
			if (InText == null)
				return false;
			foreach (string i in word.Split('|'))
			{
				if ((InText.ToLower().IndexOf(i + " ") > -1) || (InText.ToLower().IndexOf(" " + i) > -1))
				{
					return true;
				}
			}
			return false;
		}
	}
}