using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ET
{
	//"{\"errcode\":1005,\"errmsg\":\"SYS REQ IP ERROR\"}"
	public sealed class RealNameResult
	{
		public int errcode;
		public string errmsg;
	}

    public static class InitValueDefs
	{
		//test
		//public const string FangChenMi_appid = "46d6895c5d544f1685f4cf343954c018";
		//public const string FangChenMi_secretkey = "f8dbf17bb15192931d4cc096e52f5104";
		//public const string FangChenMi_bizid = "1101999999";
		public const string FangChenMi_appid = "764a47910a4a4cce8aa957f6e1b4a535";
		public const string FangChenMi_secretkey = "711a8f9fd43add8672c3d258fb27aa7b";
		public const string FangChenMi_bizid = "1199015682";

		public static long SecondsFrom19700101ms()
		{
			//var startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
			//return (long)(DateTime.Now - startTime).TotalMilliseconds; // 相差毫秒数
			TimeSpan ts2 = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeMilliseconds(); // Convert.ToInt64(ts2.TotalMilliseconds);
		}
	}
	public static class Fangchenmi
	{
		public enum EType
		{
			Check,
			Query,
			Collect,
		}
		private static string[] normalUrls = { "https://api.wlc.nppa.gov.cn/idcard/authentication/check"
			, "http://api2.wlc.nppa.gov.cn/idcard/authentication/query"
			, "http://api2.wlc.nppa.gov.cn/behavior/collection/loginout" };

		public static RealNameResult OnDoFangchenmi(object args, EType eType)
		{

			var url = normalUrls[(int)eType];
			var data = "";
			var strjson = "";
			if (eType == EType.Query)
			{
				strjson = "ai=" + args;
			}
			else
			{
				strjson = args.ToJson(); // Newtonsoft.Json.JsonConvert.SerializeObject(args);
				data = MyCryptoClass.encryptByAES128Gcm(InitValueDefs.FangChenMi_secretkey, strjson);
				object data_n = new { data = data };
				data = data_n.ToJson();	 // Newtonsoft.Json.JsonConvert.SerializeObject(new { data = data });
			}
			var timestamps = InitValueDefs.SecondsFrom19700101ms().ToString();
			var dic = new Dictionary<string, string>();
			dic["timestamps"] = timestamps;
			dic["appId"] = InitValueDefs.FangChenMi_appid;
			dic["bizId"] = InitValueDefs.FangChenMi_bizid;
			var res = "";
			if (eType == EType.Query)
			{
				dic["ai"] = args.ToString();
				res = AWebUtils.OnWebRequestGet($"{url}?{strjson}", new Dictionary<string, string>()
				{
					{ "appId", InitValueDefs.FangChenMi_appid },
					{ "bizId", InitValueDefs.FangChenMi_bizid},
					{ "timestamps", timestamps },
					{ "sign", GetSign(data, dic) },
				});
			}
			else
				res = AWebUtils.OnWebRequestPost_2(url, data, "application/json; charset=utf-8", new Dictionary<string, string>()
			{
				{ "appId", InitValueDefs.FangChenMi_appid },
				{ "bizId", InitValueDefs.FangChenMi_bizid},
				{ "timestamps", timestamps },
				{ "sign", GetSign(data, dic) },
			});

			Log.Debug($"Fangchenmi res {res}");
			//object data_result = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(res);
			// 反序列化json
			RealNameResult result_1 = null;
			try
			{
				 result_1 = BsonSerializer.Deserialize<RealNameResult>(res);
			}
			catch (Exception ex)
			{
				Log.Debug(ex.ToString());
			}
			return result_1;
		}

		private static string GetSign(string data, Dictionary<string, string> dic)
		{
			var keys = dic.Keys.ToList();
			keys.Sort();
			var data1 = "";
			foreach (var k in keys)
			{
				data1 += k + dic[k];
			}
			data1 += data;
			data1 = InitValueDefs.FangChenMi_secretkey + data1;
			Console.WriteLine($"data1 key-values {data1}");
			return EasyEncryption.SHA.ComputeSHA256Hash(data1);
		}

	}
}