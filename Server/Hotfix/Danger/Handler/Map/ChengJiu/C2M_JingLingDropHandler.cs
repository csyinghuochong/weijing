using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingLingDropHandler : AMActorLocationRpcHandler<Unit, C2M_JingLingDropRequest, M2C_JingLingDropResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingLingDropRequest request, M2C_JingLingDropResponse response, Action reply)
        {
            ChengJiuComponent chengJiuComponent = unit.GetComponent<ChengJiuComponent>();
            int jinglingid = chengJiuComponent.JingLingId;
            if (jinglingid == 0 || chengJiuComponent.RandomDrop == 1)
            {
                reply();
                return;
            }
            JingLingConfig jingLingConfig = JingLingConfigCategory.Instance.Get(jinglingid);
            if (jingLingConfig.FunctionType!= JingLingFunctionType.RandomDrop)
            {
                reply();
                return;
            }
            chengJiuComponent.RandomDrop = 1;
            int dropId = int.Parse(jingLingConfig.FunctionValue);

            List<RewardItem> droplist = new List<RewardItem>();
            DropHelper.DropIDToDropItem_2(dropId, droplist);

            unit.GetComponent<BagComponent>().OnAddItemData(droplist, string.Empty, $"{ItemGetWay.JingLing}_{TimeHelper.ServerNow()}", false);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
