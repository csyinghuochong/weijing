using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_YueKaRewardHandler : AMActorLocationRpcHandler<Unit, C2M_YueKaRewardRequest, M2C_YueKaRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_YueKaRewardRequest request, M2C_YueKaRewardResponse response, Action reply)
        {
            if (!unit.IsYueKaStates())
            {
                reply();    //月卡已过期
                return;
            }
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.YueKaAward) == 1)
            {
                reply();    //当天已领取
                return;
            }
            int remainTimes = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.YueKaRemainTimes);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.YueKaAward, 1);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.YueKaRemainTimes, remainTimes -1);
            string reward = GlobalValueConfigCategory.Instance.Get(28).Value;
            unit.GetComponent<BagComponent>().OnAddItemData(reward, $"{ItemGetWay.YueKaReward}_{TimeHelper.ServerNow()}");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
