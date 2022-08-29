using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
	public static class AWebUtils
	{
		public static string OnWebRequestGet(string url, Dictionary<string, string> heads = null)
		{
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
				//Console.WriteLine("OnWebRequestGet " + url);
				HttpWebRequest req = null;// (HttpWebRequest)HttpWebRequest.Create(url);
				if (heads != null)
				{
					foreach (var kv in heads)
					{
						req.Headers.Add(kv.Key, kv.Value);
					}
				}
				using (WebResponse wr = req.GetResponse())
				{
					return new StreamReader(wr.GetResponseStream(), Encoding.UTF8).ReadToEnd();
				}
			}
			catch (System.Net.WebException ex)
			{
				string result = string.Empty;
				//响应流
				var mResponse = ex.Response as HttpWebResponse;
				var responseStream = mResponse.GetResponseStream();
				if (responseStream != null)
				{
					var streamReader = new StreamReader(responseStream, Encoding.GetEncoding(65001));
					//获取返回的信息
					result = streamReader.ReadToEnd();
					streamReader.Close();
					responseStream.Close();
				}
				Console.WriteLine($"{url} 返回错误信息" + result);
				return result;
			}
		}

		public static string OnWebRequestPost_2(string url, string body, string ContentType, Dictionary<string, string> dic)
		{
			ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

			HttpClient httpClient = new HttpClient();
			httpClient.DefaultRequestHeaders.Clear();
			foreach (var kv in dic)
			{
				httpClient.DefaultRequestHeaders.Add(kv.Key, kv.Value);
			}

			HttpContent httpContent = new StringContent(body);
			httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

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

			//byte[] bs = Encoding.UTF8.GetBytes(body);
			//HttpWebRequest req = null; // (HttpWebRequest)HttpWebRequest.Create(url);
			//req.Method = "POST";
			//req.ContentType = ContentType;
			//req.ContentLength = bs.Length;
			//req.ProtocolVersion = HttpVersion.Version10;
			//foreach (var kv in dic)
			//{
			//	req.Headers.Add(kv.Key, kv.Value);
			//}
			//try
			//{
			//	using (Stream reqStream = req.GetRequestStream())
			//	{
			//		reqStream.Write(bs, 0, bs.Length);
			//		using (WebResponse wr = req.GetResponse())
			//		{
			//			return new StreamReader(wr.GetResponseStream(), Encoding.UTF8).ReadToEnd();
			//		}
			//	}
			//}
			//catch (System.Net.WebException ex)
			//{
			//	if (ex.Response != null)
			//	{
			//		string result = string.Empty;
			//		//响应流
			//		var mResponse = ex.Response as HttpWebResponse;
			//		var responseStream = mResponse.GetResponseStream();
			//		if (responseStream != null)
			//		{
			//			var streamReader = new StreamReader(responseStream, Encoding.GetEncoding(65001));
			//			//获取返回的信息
			//			result = streamReader.ReadToEnd();
			//			streamReader.Close();
			//			responseStream.Close();
			//		}
			//		Console.WriteLine($"{url} 返回错误信息" + result);
			//		return result;
			//	}
			//	else
			//	{
			//		Console.WriteLine($"{url} 返回错误信息" + ex);
			//		return ex.Message;
			//	}
			//}
		}

		public static string OnWebRequestPost(string url, string body, string ContentType, Dictionary<string, string> dic)
		{
			ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
			byte[] bs = Encoding.UTF8.GetBytes(body);

			HttpWebRequest req = null; // (HttpWebRequest)HttpWebRequest.Create(url);
			req.Method = "POST";
			req.ContentType = ContentType;
			req.ContentLength = bs.Length;
			req.ProtocolVersion = HttpVersion.Version10;
			foreach (var kv in dic)
			{
				req.Headers.Add(kv.Key, kv.Value);
			}
			try
			{
				using (Stream reqStream = req.GetRequestStream())
				{
					reqStream.Write(bs, 0, bs.Length);
					using (WebResponse wr = req.GetResponse())
					{
						return new StreamReader(wr.GetResponseStream(), Encoding.UTF8).ReadToEnd();
					}
				}
			}
			catch (System.Net.WebException ex)
			{
				if (ex.Response != null)
				{
					string result = string.Empty;
					//响应流
					var mResponse = ex.Response as HttpWebResponse;
					var responseStream = mResponse.GetResponseStream();
					if (responseStream != null)
					{
						var streamReader = new StreamReader(responseStream, Encoding.GetEncoding(65001));
						//获取返回的信息
						result = streamReader.ReadToEnd();
						streamReader.Close();
						responseStream.Close();
					}
					Console.WriteLine($"{url} 返回错误信息" + result);
					return result;
				}
				else
				{
					Console.WriteLine($"{url} 返回错误信息" + ex);
					return ex.Message;
				}
			}
		}
	}
}