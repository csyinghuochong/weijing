using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TowerExitHandler : AMActorLocationRpcHandler<Unit, C2M_TowerExitRequest, M2C_TowerExitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TowerExitRequest request, M2C_TowerExitResponse response, Action reply)
        {
            UnitComponent unitComponent = unit.GetParent<UnitComponent>();
            List<Unit> allunits = unitComponent.GetAll();
            for (int i = allunits.Count - 1; i >= 0; i--)
            {
                if (allunits[i].Type == UnitType.Monster)
                {
                    unitComponent.Remove(allunits[i].Id);
                }
            }
            TowerComponent towerComponent = unit.DomainScene().GetComponent<TowerComponent>();
            if (towerComponent.TowerId == 0)
            {
                towerComponent.OnEmptyReward();
            }
            else
            {
                towerComponent.OnTowerOver("TowerExit");
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
