using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    internal class A2Center_DeleteAccountHandler : AMActorRpcHandler<Scene, A2Center_DeleteAccount, Center2A_DeleteAccount>
    {
        protected override async ETTask Run(Scene scene, A2Center_DeleteAccount request, Center2A_DeleteAccount response, Action reply)
        {
            List<DBCenterAccountInfo> centerAccountInfoList = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(), d => d.Account == request.AccountName && d.Password == request.Password); ;
            DBCenterAccountInfo dBCenterAccountInfo = centerAccountInfoList != null && centerAccountInfoList.Count > 0 ? centerAccountInfoList[0] : null;
            if (dBCenterAccountInfo != null)
            {
                dBCenterAccountInfo.AccountType = (int)AccountType.Delete;
                Log.Warning($"账号移除：{request.AccountName}");
            }
            else
            {
                Log.Warning($"账号无效：{request.AccountName}");
            }
            //response.PlayerInfo = dBCenterAccountInfo != null ? dBCenterAccountInfo.PlayerInfo : null;
            //response.AccountId = dBCenterAccountInfo != null ? dBCenterAccountInfo.Id : 0;
            reply();
            await ETTask.CompletedTask;
        }
    }
}