using System;
using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 战场召唤记录
    /// </summary>
    [ActorMessageHandler]
    public class C2M_BattleSummonRecordHandler : AMActorLocationRpcHandler<Unit, C2M_BattleSummonRecord, M2C_BattleSummonRecord>
    {
        protected override async ETTask Run(Unit unit, C2M_BattleSummonRecord request, M2C_BattleSummonRecord response, Action reply)
        {
            AttackRecordComponent attackRecordComponent = unit.GetComponent<AttackRecordComponent>();
            List<BattleSummonInfo> BattleSummonList = attackRecordComponent.BattleSummonList;
            response.BattleSummonList = BattleSummonList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
