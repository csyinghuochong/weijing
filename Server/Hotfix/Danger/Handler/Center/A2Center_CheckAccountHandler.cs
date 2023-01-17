using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class A2Center_CheckAccountHandler : AMActorRpcHandler<Scene, A2Center_CheckAccount, Center2A_CheckAccount>
    {
        protected override async ETTask Run(Scene scene, A2Center_CheckAccount request, Center2A_CheckAccount response, Action reply)
        {

            List<DBCenterAccountInfo> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(), d => d.Account == request.AccountName && d.Password == request.Password); ;
            DBCenterAccountInfo dBCenterAccountInfo = centerAccountInfoList != null && centerAccountInfoList.Count > 0 ? centerAccountInfoList[0] : null;
            response.PlayerInfo = dBCenterAccountInfo !=null ? dBCenterAccountInfo.PlayerInfo : null;
            response.AccountId = dBCenterAccountInfo != null ? dBCenterAccountInfo.Id : 0;
            if (dBCenterAccountInfo.AccountType == (int)AccountType.Delete)
            {
                response.PlayerInfo = null;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
