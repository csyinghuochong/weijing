using System;
using System.Collections.Generic;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemXiLianRewardHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianRewardRequest, M2C_ItemXiLianRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianRewardRequest request, M2C_ItemXiLianRewardResponse response, Action reply)
        {
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();

            if (userInfoComponent.UserInfo.XiLianRewardIds.Contains(request.XiLianId))
            {
                response.Error = ErrorCore.ERR_AlreadyReceived;
                reply();
                return;
            }

            EquipXiLianConfig equipXiLianConfig = EquipXiLianConfigCategory.Instance.Get(request.XiLianId);
            string[] rewarditems = equipXiLianConfig.RewardList.Split('@');
            if (unit.GetComponent<BagComponent>().GetSpaceNumber() < rewarditems.Length)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            userInfoComponent.UserInfo.XiLianRewardIds.Add(request.XiLianId);
            unit.GetComponent<BagComponent>().OnAddItemData(equipXiLianConfig.RewardList, $"{ItemGetWay.XiLianLevel}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
