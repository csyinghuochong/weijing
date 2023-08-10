using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_BattleSummonRequestHandler : AMActorLocationRpcHandler<Unit, C2M_BattleSummonRequest, M2C_BattleSummonResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_BattleSummonRequest request, M2C_BattleSummonResponse response, Action reply)
        {
            AttackRecordComponent attackRecordComponent = unit.GetComponent<AttackRecordComponent>();
            List<BattleSummonInfo> BattleSummonList = attackRecordComponent.BattleSummonList;

            //先判断一下人口上限

            bool have = false;
            for (int i = 0; i < BattleSummonList.Count; i++)
            {
                if (BattleSummonList[i].SummonId == request.SummonId)
                {
                    BattleSummonList[i].SummonNumber++;
                    BattleSummonList[i].SummonTime = TimeHelper.ServerNow(); 
                }
            }
            if (!have)
            {
                BattleSummonList.Add( new BattleSummonInfo()
                { 
                    SummonId = request.SummonId,
                    SummonTime = TimeHelper.ServerNow(),
                    SummonNumber = 1
                });
            }

            //发兵

            response.BattleSummonList = BattleSummonList;   
            reply();
            await ETTask.CompletedTask;
        }
    }

}