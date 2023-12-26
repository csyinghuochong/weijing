using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_WelfareDraw2Handler: AMActorLocationRpcHandler<Unit, C2M_WelfareDraw2Request, M2C_WelfareDraw2Response>
    {
        protected override async ETTask Run(Unit unit, C2M_WelfareDraw2Request request, M2C_WelfareDraw2Response response, Action reply)
        {
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            //已经生成了奖励格子
            if (numericComponent.GetAsInt(NumericType.DrawIndex2) > 0)
            {
                reply();
                return;
            }

            if (numericComponent.GetAsLong(NumericType.RechargeNumber) / 50 - numericComponent.GetAsLong(NumericType.WelfareChouKaNumber) <= 0)
            {
                reply();
                return;
            }

            int index = RandomHelper.RandomNumber(0, ActivityHelper.WelfareChouKaList.Count) + 1;

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.DrawIndex2, index);
            unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.WelfareChouKaNumber, 1, 0);
            reply();
            await ETTask.CompletedTask;
        }
    }
}