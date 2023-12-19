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
            paramslist.Add("access_token", request.access_token);
            paramslist.Add("app_id", TikTokHelper.AppID.ToString());
            paramslist.Add("ts", serverNow.ToString());
            string sign = TikTokHelper.getSign(paramslist);
            paramslist.Add("sign", sign);

            string result = HttpHelper.OnWebRequestPost_TikTokLogin("https://usdk.dailygn.com/gsdk/usdk/account/verify_user", paramslist);
            //OnWebRequestPost_1: {"code":-1001,"log_id":"202311141714565D4B186ED56A781CCE8D","message":"invalid parameter: app_id error"}

            if (ComHelp.IsInnerNet())
            {
                result = "{\"code\":0,\"data\":{\"age_type\":100,\"log_id\":\"20231121162107BEDB3B3662AD2265532E\",\"sdk_open_id\":\"7303474616922905310\"},\"log_id\":\"20231121162107BEDB3B3662AD2265532E\",\"message\":\"success\"}";
            }

            TikTokCode tikTokCode = BsonSerializer.Deserialize<TikTokCode>(result);
            if (tikTokCode.code != 0 || tikTokCode.data == null)
            {
                response.Error = tikTokCode.code;
                response.sdk_open_id = string.Empty;
                reply();
                return;
            }
            else
            {
                if (tikTokCode.data.age_type <= 0)
                {
                    response.Error = ErrorCode.ERR_NotRealName;
                    reply();
                    return;
                }

                long accountZone = DBHelper.GetAccountCenter();
                Center2A_CheckAccount centerAccount = (Center2A_CheckAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_CheckAccount()
                {
                    AccountName = tikTokCode.data.sdk_open_id,
                    Password = LoginTypeEnum.TikTok.ToString(),
                    ThirdLogin = LoginTypeEnum.TikTok.ToString(),
                });

                //没有则注册
                if (centerAccount.PlayerInfo == null)
                {
                    Center2A_RegisterAccount saveAccount = (Center2A_RegisterAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_RegisterAccount()
                    {
                        AccountName = tikTokCode.data.sdk_open_id,
                        Password = LoginTypeEnum.TikTok.ToString(),
                        LoginType = LoginTypeEnum.TikTok,
                        age_type = tikTokCode.data.age_type,
                    });
                }

                response.sdk_open_id = tikTokCode.data.sdk_open_id;
                response.age_type = tikTokCode.data.age_type;
            }
            Log.Console($"C2A_TikTokVerifyUser sign: {sign}    result: {result}");
            Log.Warning($"C2A_TikTokVerifyUser sign: {sign}    result: {result}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}