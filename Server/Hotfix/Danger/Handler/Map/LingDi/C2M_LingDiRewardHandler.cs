using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_LingDiRewardHandler : AMActorLocationRpcHandler<Unit, C2M_LingDiRewardRequest, M2C_LingDiRewardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_LingDiRewardRequest request, M2C_LingDiRewardResponse response, Action reply)
        {
            int lingdiLv = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Ling_DiLv);
            int rolelv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;

            LingDiRewardConfig config = LingDiRewardConfigCategory.Instance.Get(request.RewardId);

            if (lingdiLv < config.CountryLvlimit)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            if (unit.GetComponent<BagComponent>().IsBagFull())
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            if (!unit.GetComponent<BagComponent>().OnCostItemData($"{config.BuyItemID};{config.BuyPrice}"))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<BagComponent>().OnAddItemData($"{config.ItemID};1");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
