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

            EquipXiLianConfig equipXiLianConfig = EquipXiLianConfigCategory.Instance.Get(request.XiLianId);
            int shuliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu);
            bool actived = shuliandu >= equipXiLianConfig.NeedShuLianDu;
            if (!actived)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (userInfoComponent.UserInfo.XiuLianRewardIds.Contains(request.XiLianId))
            {
                response.Error = ErrorCode.ERR_AlreadyReceived;
                reply();
                return;
            }


            string[] rewarditems = equipXiLianConfig.RewardList.Split('@');
            if (unit.GetComponent<BagComponent>().GetBagLeftCell() < rewarditems.Length)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            userInfoComponent.UserInfo.XiuLianRewardIds.Add(request.XiLianId);
            unit.GetComponent<BagComponent>().OnAddItemData(equipXiLianConfig.RewardList, $"{ItemGetWay.XiLianLevel}_{TimeHelper.ServerNow()}");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
