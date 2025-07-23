using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


namespace ET
{

    [MessageHandler]
    public class C2A_TikTokGetOpenIdHandler : AMRpcHandler<C2A_TikTokGetOpenId, A2C_TikTokGetOpenId>
    {
        protected override async ETTask Run(Session session, C2A_TikTokGetOpenId request, A2C_TikTokGetOpenId response, Action reply)
        {

            long serverNow = TimeHelper.ServerNow() / 1000;
            Dictionary<string, string> paramslist = new Dictionary<string, string>();
            paramslist.Add("code", request.auth_code);
            paramslist.Add("app_id", TikTokHelper.AppID.ToString());
            paramslist.Add("app_secret", TikTokHelper.AppSecret);
        
            string result = HttpHelper.OnWebRequestPost_TikTokGetOpenId("https://open.douyin.com/webcast/game/oauth/access_token/", paramslist);
            //OnWebRequestPost_1: {"code":-1001,"log_id":"202311141714565D4B186ED56A781CCE8D","message":"invalid parameter: app_id error"}

            if (ComHelp.IsInnerNet())
            {
                result = "{\"data\":{\"description\":\"参数错误\",  \"open_id\":\"7303474616922905355\",  \"access_token\":\"7303474616922905355\",  \"error_code\":0},\"message\":\"error\"}";
            }

            TikTokOAuth tikTokCode = BsonSerializer.Deserialize<TikTokOAuth>(result);
            if (tikTokCode.data == null || tikTokCode.data.error_code != 0)
            {
                response.Error = ErrorCode.ERR_LoginInfoIsNull;
                reply();
                return;
            }

            if (string.IsNullOrEmpty(tikTokCode.data.open_id))
            {
                response.Error = ErrorCode.ERR_LoginInfoIsNull;
                reply();
                return;
            }

            long accountZone = DBHelper.GetAccountCenter();
            Center2A_CheckAccount centerAccount = (Center2A_CheckAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_CheckAccount()
            {
                AccountName = tikTokCode.data.open_id,
                Password = LoginTypeEnum.TikTok.ToString(),
                ThirdLogin = LoginTypeEnum.TikTok.ToString(),
            });

            //没有则注册
            if (centerAccount.PlayerInfo == null)
            {
                Center2A_RegisterAccount saveAccount = (Center2A_RegisterAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_RegisterAccount()
                {
                    AccountName = tikTokCode.data.open_id,
                    Password = LoginTypeEnum.TikTok.ToString(),
                    LoginType = LoginTypeEnum.TikTok,
                    age_type = 100,
                });
            }

            response.access_token = tikTokCode.data.access_token;
            response.sdk_open_id = tikTokCode.data.open_id;


            reply();
            await ETTask.CompletedTask;
        }
    }
}