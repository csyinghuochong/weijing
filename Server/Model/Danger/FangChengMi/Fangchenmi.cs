using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ET
{
	//"{\"errcode\":1005,\"errmsg\":\"SYS REQ IP ERROR\"}"
	public sealed class RealNameCode
	{
		public int errcode;
		public string errmsg;

		public RealNameData data;
	}

	public sealed class RealNameData
	{
		public RealNameResult result;
	}

	public sealed class RealNameResult
	{
		//认证结果
		//0：认证成功
		//1：认证中
		//2：认证失败
		public int status;
		//已通过实名认证用户的唯一标识
		public string pi;
	}

    public static class InitValueDefs
	{
		//"{ ai = 1669902416, name = 唐春光, idNum = 429001198512282996 }"
		//"f6df1ff5f23285679037fef83c398fb18051c13549db60bba9887361e55316c6"
		//test
		//public const string FangChenMi_appid = "46d6895c5d544f1685f4cf343954c018";
		//public const string FangChenMi_secretkey = "f8dbf17bb15192931d4cc096e52f5104";
		//public const string FangChenMi_bizid = "1101999999";
		
		public static long SecondsFrom19700101ms()
		{
			//var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
			//return (long)(DateTime.Now - startTime).TotalMilliseconds; // 相差毫秒数
			TimeSpan ts2 = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds(); // Convert.ToInt64(ts2.TotalMilliseconds);
		}
	}

	public enum EType
	{
		Check,
		Query,
		Collect,
	}

	public static class Fangchenmi
	{

		public static string GetSign(string data, Dictionary<string, string> dic, string akey)
		{
			var keys = dic.Keys.ToList();
			keys.Sort();
			var data1 = "";
			foreach (var k in keys)
			{
				data1 += k + dic[k];
			}
			data1 += data;
			data1 =akey + data1;
			Log.Debug($"OnDoFangchenmi2:  {data1}");
			return EasyEncryption.SHA.ComputeSHA256Hash(data1);
		}

	}
}