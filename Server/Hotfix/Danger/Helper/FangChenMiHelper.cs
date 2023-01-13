using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


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

    }
}
