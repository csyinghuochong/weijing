using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ET
{
    public static class FangChenMiHelper
    {

        public const string FangChenMi_appid = "764a47910a4a4cce8aa957f6e1b4a535";
        public const string FangChenMi_secretkey = "0f18ce6099aeb3488dd490677ed4ca65";
        public const string FangChenMi_bizid = "1199015682";
        public static string[] normalUrls = { "https://api.wlc.nppa.gov.cn/idcard/authentication/check"
            , "http://api2.wlc.nppa.gov.cn/idcard/authentication/query"
            , "http://api2.wlc.nppa.gov.cn/behavior/collection/loginout" };


        public static RealNameCode OnDoFangchenmi(object args, EType eType)
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
                data = MyCryptoClass.encryptByAES128Gcm(FangChenMi_secretkey, strjson);
                object data_n = new { data = data };
                data = data_n.ToJson();  // Newtonsoft.Json.JsonConvert.SerializeObject(new { data = data });
            }
            var timestamps = InitValueDefs.SecondsFrom19700101ms().ToString();
            var dic = new Dictionary<string, string>();
            dic["timestamps"] = timestamps;
            dic["appId"] = FangChenMi_appid;
            dic["bizId"] = FangChenMi_bizid;
            var res = "";

            Log.Debug($"OnDoFangchenmi2:  {args.ToString()}");
            if (eType == EType.Query)
            {
                dic["ai"] = args.ToString();
                res = AWebUtils.OnWebRequestGet($"{url}?{strjson}", new Dictionary<string, string>()
                {
                    { "appId", FangChenMi_appid },
                    { "bizId", FangChenMi_bizid},
                    { "timestamps", timestamps },
                    { "sign", Fangchenmi.GetSign(data, dic,FangChenMi_secretkey) },
                });
            }
            else
                res = AWebUtils.OnWebRequestPost_2(url, data, "application/json; charset=utf-8", new Dictionary<string, string>()
            {
                { "appId", FangChenMi_appid },
                { "bizId", FangChenMi_bizid},
                { "timestamps", timestamps },
                { "sign", Fangchenmi.GetSign(data, dic,FangChenMi_secretkey) },
            });

            Log.Debug($"Fangchenmi res {res}");
            //object data_result = Newtonsoft.Json.JsonConvert.DeserializeObject<object>(res);
            // 反序列化json
            RealNameCode result_1 = null;
            try
            {
                result_1 = BsonSerializer.Deserialize<RealNameCode>(res);
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
            return result_1;
        }


        private const String host = "https://naidcard.market.alicloudapi.com/nidCard";
        private const String path = "/nidCard";
        private const String method = "GET";
        private const String appcode = "d59fefe68cf644f6a8f54dd039c3806f";//开通服务后 买家中心-查看AppCode

        //ai = ai,
        //name = request.Name,
        //idNum = request.IdCardNO,
        public static async ETTask<RealNameCode> OnDoFangchenmi_2(string idcard, string name)
        {
            String querys = $"idCard={idcard}&name={name}";
            String url = host + path;
            if (0 < querys.Length)
            {
                url = url + "?" + querys;
            }
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("idCard", idcard);
            keyValuePairs.Add("name", name);
            //keyValuePairs.Add("Authorization", "APPCODE " + appcode);
            //httpContent.Headers.Add("Authorization", "APPCODE " + appcode);
            string result =await  HttpHelper.HttpClientDoGet(host, $"APPCODE {appcode}", keyValuePairs);
            if (string.IsNullOrEmpty(result))
            {
                return null;
            }
            try
            {
                //  /*状态码  01: 通过，02: 不通过，202: 无法认证(库无) */
                NidCardData result_1 = BsonSerializer.Deserialize<NidCardData>(result);
                if (result_1.status == "01")
                {
                    RealNameCode realNameCode = new RealNameCode();
                    realNameCode.errcode = 0;
                    realNameCode.data = new RealNameData();
                    realNameCode.data.result = new RealNameResult();
                    realNameCode.data.result.status = 0;
                    return realNameCode;
                }
                return null;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
                return null;
            }
        }

        public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }
    }
}
