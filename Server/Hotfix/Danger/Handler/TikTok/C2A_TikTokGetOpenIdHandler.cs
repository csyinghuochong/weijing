using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


namespace ET
{

    //抖音官包才会调用
    [MessageHandler]
    public class C2A_TikTokGetOpenIdHandler : AMRpcHandler<C2A_TikTokGetOpenId, A2C_TikTokGetOpenId>
    {
        protected override async ETTask Run(Session session, C2A_TikTokGetOpenId request, A2C_TikTokGetOpenId response, Action reply)
        {
            long serverNow = TimeHelper.ServerNow() / 1000;
            Dictionary<string, string> paramslist = new Dictionary<string, string>();
            paramslist.Add("code", request.AuthCode);
            paramslist.Add("app_id", TikTokHelper.AppID.ToString());
            paramslist.Add("app_secret", TikTokHelper.AppSecret);
        

            /*
            string result = HttpHelper.OnWebRequestPost_TikTokGetAccessToken("https://open.douyin.com/webcast/game/oauth/access_token/", paramslist);

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
            */

            long accountZone = DBHelper.GetAccountCenter();
            Center2A_CheckAccount centerAccount = (Center2A_CheckAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_CheckAccount()
            {
                AccountName = request.OpenId,
                Password = LoginTypeEnum.TikTok.ToString(),
                ThirdLogin = LoginTypeEnum.TikTok.ToString(),
            });


            ///需要获取抖音渠道sdk_open_id 
            ///这个接口要慎用
            ///https://open.douyin.com/api/webcast/v1/osdk/get_history_account_info/  
            string sdk_open_id = string.Empty;
            if (centerAccount.PlayerInfo == null)
            {
                sdk_open_id = await HttpHelper.OnWebRequestPost_TikTokGetHistorydAccountInfo("https://open.douyin.com/webcast/game/oauth/access_token/", request.ClientToken, request.OpenId, request.AccessToken);

                if (ComHelp.IsInnerNet())
                {
                    sdk_open_id = "open_id_202507242026";
                }
            }

             //没有则注册
            if (centerAccount.PlayerInfo == null && string.IsNullOrEmpty(sdk_open_id))
            {
                Center2A_RegisterAccount saveAccount = (Center2A_RegisterAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_RegisterAccount()
                {
                    AccountName = request.OpenId,
                    Password = LoginTypeEnum.TikTok.ToString(),
                    LoginType = LoginTypeEnum.TikTok,
                    age_type = 100,
                });
            }
            if (centerAccount.PlayerInfo == null && !string.IsNullOrEmpty(sdk_open_id))
            {
                //找到了旧账号
                //1  旧账号绑定官方账号
                // C2Center_TikTokBinging c2Center_TikTokBinging
                Center2A_TiktokBinging centerAccountbing = (Center2A_TiktokBinging)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_TiktokBinging()
                {
                    Account = sdk_open_id,
                    TikTokGuanFuAccount = request.OpenId
                });

                //2  通知抖音侧账号迁移
                request.OpenId = sdk_open_id;
            }


            response.access_token = request.AccessToken;
            response.sdk_open_id = request.OpenId;

            reply();
            await ETTask.CompletedTask;
        }
    }
}