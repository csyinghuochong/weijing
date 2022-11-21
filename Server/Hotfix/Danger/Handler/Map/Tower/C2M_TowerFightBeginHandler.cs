using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TowerFightBeginHandler : AMActorLocationRpcHandler<Unit, C2M_TowerFightBeginRequest, M2C_TowerFightBeginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TowerFightBeginRequest request, M2C_TowerFightBeginResponse response, Action reply)
        {
            unit.DomainScene().GetComponent<TowerComponent>().BeginTower();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
