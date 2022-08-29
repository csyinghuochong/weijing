using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class Actor_FubenMoNengHandler : AMActorLocationRpcHandler<Unit, Actor_FubenMoNengRequest, Actor_FubenMoNengResponse>
    {
        protected override async ETTask Run(Unit unit, Actor_FubenMoNengRequest request, Actor_FubenMoNengResponse response, Action reply)
        {
            response.MysteryItemInfos = unit.DomainScene().GetComponent<CellDungeonComponent>().MysteryItemInfos;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
