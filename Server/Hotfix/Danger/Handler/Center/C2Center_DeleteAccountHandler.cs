using System;
using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    internal class C2Center_DeleteAccountHandler : AMRpcHandler<C2Center_DeleteAccountRequest, Center2C_DeleteAccountResponse>
    {
        protected override async ETTask Run(Session session, C2Center_DeleteAccountRequest request, Center2C_DeleteAccountResponse response, Action reply)
        {
            List<DBCenterAccountInfo> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(session.DomainZone(), d => d.Account == request.Account && d.Password == request.Password);
            DBCenterAccountInfo dBCenterAccountInfo = centerAccountInfoList != null && centerAccountInfoList.Count > 0 ? centerAccountInfoList[0] : null;
            if (dBCenterAccountInfo != null)
            {
                dBCenterAccountInfo.AccountType = (int)AccountType.Delete;
                await Game.Scene.GetComponent<DBComponent>().Save<DBCenterAccountInfo>(session.DomainZone(), dBCenterAccountInfo); 
            }
            else
            {
            }
            //response.PlayerInfo = dBCenterAccountInfo != null ? dBCenterAccountInfo.PlayerInfo : null;
            //response.AccountId = dBCenterAccountInfo != null ? dBCenterAccountInfo.Id : 0;
            
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}