using System;
using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    public class C2A_RealNameHandler : AMRpcHandler<C2A_RealNameRequest, A2C_RealNameResponse>
    {
        protected override async ETTask Run(Session session, C2A_RealNameRequest request, A2C_RealNameResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetDbCacheId(session.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.AccountId, Component = DBHelper.DBAccountInfo });
            DBAccountInfo accountInfo = d2GGetUnit.Component as DBAccountInfo;

            RealNameResult result_check = new RealNameResult();
            using ListComponent<string> testCard = new ListComponent<string>();
            for (int i = 0; i < 30; i++)
            {
                testCard.Add($"400001{1990+i}01012996");
            }
            //内网
            if (ComHelp.IsInnerNet() || testCard.Contains(request.IdCardNO))
            {
                result_check.errcode = 0;
            }
            else
            {
                result_check = Fangchenmi.OnDoFangchenmi(new
                {
                    ai = request.AiType,
                    name = request.Name,
                    idNum = request.IdCardNO,
                }, Fangchenmi.EType.Check);
            }

            PlayerInfo playerInfo = new PlayerInfo();
            if (result_check.errcode == 0)  //认证成功
            {
                playerInfo.Name = request.Name;
                playerInfo.IdCardNo = request.IdCardNO;
                playerInfo.RealName = 1;
            }
            response.ErrorCode = result_check.errcode;

            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = accountInfo.Id, Component = accountInfo, ComponentType = DBHelper.DBAccountInfo });
           
            long accountZone = DBHelper.GetAccountCenter();
            Center2A_SaveAccount saveAccount = (Center2A_SaveAccount)await ActorMessageSenderComponent.Instance.Call(accountZone, new A2Center_SaveAccount()
            {
                AccountId = accountInfo.Id,
                AccountName = accountInfo.Account,
                Password = accountInfo.Password,
                PlayerInfo = playerInfo,
            });

            reply();
        }
    } 
}
