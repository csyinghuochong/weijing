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
            int drawIndex = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.DrawIndex);
            if (drawIndex == -1)
            {
                reply();
                return;
            }

            //已经生成了奖励格子
            if (drawIndex > 0)
            {
                reply();
                return;
            }          
            List<int> weights = new List<int>();

            List<KeyValuePair> drawlist = ConfigHelper.WelfareDrawList;
            for (int i = 0; i < drawlist.Count; i++)
            {
                weights.Add(drawlist[i].KeyId );
            }

            int index = RandomHelper.RandomByWeight( weights );
            unit.GetComponent<NumericComponent>().ApplyValue( NumericType.DrawIndex, index + 1 );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
