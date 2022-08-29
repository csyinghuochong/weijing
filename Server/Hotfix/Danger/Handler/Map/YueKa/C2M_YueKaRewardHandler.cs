using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_YueKaRewardHandler : AMActorLocationRpcHandler<Unit, C2M_YueKaRewardRequest, M2C_YueKaRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_YueKaRewardRequest request, M2C_YueKaRewardResponse response, Action reply)
        {
            if (!unit.GetComponent<UserInfoComponent>().IsYueKaStates(unit.GetComponent<NumericComponent>()))
            {
                reply();    //月卡已过期
                return;
            }
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.YueKa_Award) == 1)
            {
                reply();    //当天已领取
                return;
            }
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.YueKa_Award, 1);
            string reward = GlobalValueConfigCategory.Instance.Get(28).Value;
            unit.GetComponent<BagComponent>().OnAddItemData(reward);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
