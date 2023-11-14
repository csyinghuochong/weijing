using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


namespace ET
{

    [MessageHandler]
    public class C2A_TikTokVerifyUserHandler : AMRpcHandler<C2A_TikTokVerifyUser, A2C_TikTokVerifyUser>
    {
        protected override async ETTask Run(Session session, C2A_TikTokVerifyUser request, A2C_TikTokVerifyUser response, Action reply)
        {
            long serverNow = TimeHelper.ServerNow() / 1000;
            Dictionary<string, string> paramslist = new Dictionary<string, string>();
            paramslist.Add("app_id", TikTokHelper.AppID.ToString());
            paramslist.Add("access_token", request.access_token);
            paramslist.Add("ts", serverNow.ToString());
            string sign = TikTokHelper.getSign(paramslist);
            paramslist.Add("sign", sign);

            string result = HttpHelper.OnWebRequestPost_1("https://usdk.dailygn.com/gsdk/usdk/account/verify_user", paramslist);

            //OnWebRequestPost_1: {"code":-1001,"log_id":"202311141714565D4B186ED56A781CCE8D","message":"invalid parameter: app_id error"}

            TikTokCode result_1 = null;
            try
            {
                result_1 = BsonSerializer.Deserialize<TikTokCode>(result);
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }

            Log.Console($"C2A_TikTokVerifyUser sign: {sign}    result: {result}");

            response.sdk_open_id = 0;
            reply();
            await ETTask.CompletedTask;
        }
    }
}