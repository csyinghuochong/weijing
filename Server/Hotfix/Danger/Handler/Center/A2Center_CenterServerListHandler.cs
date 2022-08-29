using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class A2Center_CenterServerListHandler : AMActorRpcHandler<Scene, A2Center_CenterServerList, Center2A_CenterServerList>
    {

        protected override async ETTask Run(Scene scene, A2Center_CenterServerList request, Center2A_CenterServerList response, Action reply)
        {
            List<DBCenterServerInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBCenterServerInfo>(scene.DomainZone(), d => d.Id == scene.DomainZone());
            DBCenterServerInfo dBServerInfo = result[0];
            response.ServerItems = dBServerInfo.ServerItems;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
