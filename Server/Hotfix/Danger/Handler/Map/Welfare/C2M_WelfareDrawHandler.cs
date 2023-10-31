using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_WelfareDrawHandler : AMActorLocationRpcHandler<Unit, C2M_WelfareDrawRequest, M2C_WelfareDrawResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareDrawRequest request, M2C_WelfareDrawResponse response, Action reply)
        {
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            //已经领取过抽奖奖励
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.DrawReward) == 1)
            {
                reply();
                return;
            }

            //已经生成了奖励格子
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.DrawIndex) > 0)
            {
                reply();
                return;
            }          
           
            int openDay = unit.GetComponent<UserInfoComponent>().GetCrateDay();
            int index = ComHelp.GetWelfareDrawIndex( openDay );

            if (index == -1)
            {
                List<int> weights = new List<int>();

                List<KeyValuePair> drawlist = ConfigHelper.WelfareDrawList;
                for (int i = 0; i < drawlist.Count; i++)
                {
                    weights.Add(drawlist[i].KeyId);
                }
                index = RandomHelper.RandomByWeight(weights) + 1;
            }
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.DrawIndex, index);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
