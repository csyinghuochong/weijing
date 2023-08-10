using System;

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
            

            reply();
            await ETTask.CompletedTask;
        }
    }
}
