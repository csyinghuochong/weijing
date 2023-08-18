using System;
using System.Collections.Generic;
using System.Linq;

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

            int sceneid = unit.DomainScene().GetComponent<MapComponent>().SceneId;
            //默认给个冷却时间
            List<BattleSummonConfig> battleSummonInfos = BattleSummonConfigCategory.Instance.GetAll().Values.ToList();

            if (BattleSummonList.Count == 0)
            {
                for (int i = 0; i < battleSummonInfos.Count; i++)
                {
                    if (battleSummonInfos[i].SceneId != sceneid)
                    {
                        continue;
                    }

                    BattleSummonList.Add(new BattleSummonInfo()
                    {
                        SummonId = battleSummonInfos[i].Id,
                        SummonTime = unit.DomainScene().GetComponent<BattleDungeonComponent>().BattleOpenTime,
                        SummonNumber = 0
                    });
                }
            }

            response.BattleSummonList = BattleSummonList;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
