using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TrialDungeonFinishHandler : AMActorLocationRpcHandler<Unit, C2M_TrialDungeonFinishRequest, M2C_TrialDungeonFinishResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TrialDungeonFinishRequest request, M2C_TrialDungeonFinishResponse response, Action reply)
        {
            Scene domainScene = unit.DomainScene();
            TrialDungeonComponent trialDungeonComponent = domainScene.GetComponent<TrialDungeonComponent>();
            if (trialDungeonComponent == null)
            {
                reply();
                return;
            }

            List<Unit> monsterList = FubenHelp.GetUnitList(unit.DomainScene(), UnitType.Monster);
            for (int i = monsterList.Count - 1; i >= 0; i--)
            {
                domainScene.GetComponent<UnitComponent>().Remove(monsterList[i].Id);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
