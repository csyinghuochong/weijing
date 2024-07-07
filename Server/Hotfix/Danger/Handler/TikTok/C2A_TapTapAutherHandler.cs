using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;


namespace ET
{

    [MessageHandler]
    public class C2A_TapTapAutherHandler : AMRpcHandler<C2A_TapTapAuther, A2C_TapTapAuther>
    {

        protected override async ETTask Run(Session session, C2A_TapTapAuther request, A2C_TapTapAuther response, Action reply)
        {

            if (string.IsNullOrEmpty(request.Account))
            {
                response.Error = ErrorCode.ERR_LoginInfoIsNull;
                reply();
                return;
            }
            long accountZone = DBHelper.GetAccountCenter();
            Center2A_CheckAccount centerAccount = (Center2A_CheckAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_CheckAccount()
            {
                AccountName = request.Account,
                Password = LoginTypeEnum.TikTok.ToString(),
                ThirdLogin = LoginTypeEnum.TikTok.ToString(),
            });

            //没有则注册
            if (centerAccount.PlayerInfo == null)
            {
                Center2A_RegisterAccount saveAccount = (Center2A_RegisterAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_RegisterAccount()
                {
                    AccountName = request.Account,
                    Password = request.Password,
                    LoginType = request.LoginType,
                    age_type = request.age_type,
                });
            }



            reply();    

        }
    }
}
