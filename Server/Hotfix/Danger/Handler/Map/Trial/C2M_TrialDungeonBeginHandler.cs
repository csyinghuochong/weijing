using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TrialDungeonBeginHandler : AMActorLocationRpcHandler<Unit, C2M_TrialDungeonBeginRequest, M2C_TrialDungeonBeginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TrialDungeonBeginRequest request, M2C_TrialDungeonBeginResponse response, Action reply)
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

            trialDungeonComponent.GenerateFuben();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
