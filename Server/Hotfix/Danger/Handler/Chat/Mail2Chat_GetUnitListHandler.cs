using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ActorMessageHandler]
    public class Mail2Chat_GetUnitListHandler : AMActorRpcHandler<Scene, Mail2Chat_GetUnitList, Chat2Mail_GetUnitList>
    {
        protected override async ETTask Run(Scene scene, Mail2Chat_GetUnitList request, Chat2Mail_GetUnitList response, Action reply)
        {
            ChatSceneComponent chatInfoUnitsComponent = scene.GetComponent<ChatSceneComponent>();
            List<long> onlineunitids = chatInfoUnitsComponent.ChatInfoUnitsDict.Keys.ToList();
            response.OnlineUnitIdList = onlineunitids;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
