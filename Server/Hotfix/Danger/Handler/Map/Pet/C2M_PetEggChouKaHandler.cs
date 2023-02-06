using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetEggChouKaHandler : AMActorLocationRpcHandler<Unit, C2M_PetEggChouKaRequest, M2C_PetEggChouKaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetEggChouKaRequest request, M2C_PetEggChouKaResponse response, Action reply)
        {
            int dropId = 0;
            if (request.ChouKaType == 1)
            {
                string needItems = GlobalValueConfigCategory.Instance.Get(39).Value.Split('@')[0];
                dropId = int.Parse(GlobalValueConfigCategory.Instance.Get(39).Value.Split('@')[1]);
                bool sucess = unit.GetComponent<BagComponent>().OnCostItemData(needItems);
                if (!sucess)
                {
                    response.Error = ErrorCore.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
            }
            else if (request.ChouKaType == 10)
            {
                //int choukaTim = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Pet_ChouKa);
                //if (choukaTim >= 20)
                //{
                //    reply();
                //    return;
                //}
                UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
                int needDimanond = int.Parse(GlobalValueConfigCategory.Instance.Get(40).Value.Split('@')[0]);
                dropId = int.Parse(GlobalValueConfigCategory.Instance.Get(40).Value.Split('@')[1]);
                if (userInfo.Diamond < needDimanond)
                {
                    response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                    reply();
                    return;
                }
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Diamond, (-1 * needDimanond).ToString(), true,ItemGetWay.ChouKa);
                //unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.Pet_ChouKa, 1, 0);
            }

            List<RewardItem> rewardItems = new List<RewardItem>();
            for (int i = 0; i < request.ChouKaType; i++)
            {
                DropHelper.DropIDToDropItem_2(dropId, rewardItems);
            }
            if (!unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, string.Empty, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}"))
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }
            response.ReardList = rewardItems;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
