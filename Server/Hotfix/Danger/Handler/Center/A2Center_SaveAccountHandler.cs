using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class A2Center_SaveAccountHandler : AMActorRpcHandler<Scene, A2Center_SaveAccount, Center2A_SaveAccount>
    {
        protected override async ETTask Run(Scene scene, A2Center_SaveAccount request, Center2A_SaveAccount response, Action reply)
        {
            List<DBCenterAccountInfo> resulets = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterAccountInfo>(scene.DomainZone(), d => d.Id == request.AccountId);

            DBCenterAccountInfo dBCenterAccountInfo = null;
            if (resulets != null && resulets.Count > 0)
            {
                dBCenterAccountInfo = resulets[0];
            }
            else
            {
                dBCenterAccountInfo = scene.AddChildWithId<DBCenterAccountInfo>(request.AccountId);
            }
            dBCenterAccountInfo.Account = request.AccountName;
            dBCenterAccountInfo.Password = request.Password;
            dBCenterAccountInfo.PlayerInfo = request.PlayerInfo;
    
            await Game.Scene.GetComponent<DBComponent>().Save(scene.DomainZone(), dBCenterAccountInfo);
            dBCenterAccountInfo.Dispose();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
