using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_FindJingLingRequestHandler : AMActorLocationRpcHandler<Unit, C2M_FindJingLingRequest, M2C_FindJingLingResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_FindJingLingRequest request, M2C_FindJingLingResponse response, Action reply)
        {
            int jinglingid = 0;
            List<Unit> units = UnitHelper.GetUnitList( unit.DomainScene(), UnitType.Monster );
            for (int i = 0; i < units.Count; i++)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(units[i].ConfigId);

                if (monsterConfig.MonsterSonType == 58 || monsterConfig.MonsterSonType == 59)
                {
                    jinglingid = monsterConfig.Id;
                    break;
                }
            }

            response.MonsterID = jinglingid;    
            reply();
            await ETTask.CompletedTask;
        }
    }
}
