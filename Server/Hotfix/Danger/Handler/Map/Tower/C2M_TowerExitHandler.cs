using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TowerExitHandler : AMActorLocationRpcHandler<Unit, C2M_TowerExitRequest, M2C_TowerExitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TowerExitRequest request, M2C_TowerExitResponse response, Action reply)
        {
            unit.DomainScene().GetComponent<TowerComponent>().OnTowerOver();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
