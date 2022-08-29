using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_RealNameRewardHandler : AMActorLocationRpcHandler<Unit, C2M_RealNameRewardRequest, M2C_RealNameRewardResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_RealNameRewardRequest request, M2C_RealNameRewardResponse response, Action reply)
        {
            long accid = unit.GetComponent<UserInfoComponent>().UserInfo.AccInfoID;

            long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());
            D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = accid, Component = DBHelper.DBAccountInfo });
            DBAccountInfo accountInfo = d2GGetUnit.Component as DBAccountInfo;

            if (accountInfo.PlayerInfo.RealNameReward == 0)
            {
                string globalValueConfig = GlobalValueConfigCategory.Instance.Get(6).Value;
                string[] itemCost = globalValueConfig.Split('@');
                List<RewardItem> rewardItems = new List<RewardItem>();
                for (int i = 0; i < itemCost.Length; i++)
                {
                    string[] itemInfo = itemCost[i].Split(';');
                    int itemId = int.Parse(itemInfo[0]);
                    int itemNum = int.Parse(itemInfo[1]);
                    rewardItems.Add(new RewardItem() {  ItemID = itemId, ItemNum = itemNum });
                }

                bool sucess = unit.GetComponent<BagComponent>().OnAddItemData(rewardItems);
                accountInfo.PlayerInfo.RealNameReward = sucess ? 1 : 0;
                response.Error = sucess ? ErrorCore.ERR_Success : ErrorCore.ERR_BagIsFull;
            }

            D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = accid, Component = accountInfo, ComponentType = DBHelper.DBAccountInfo });
            reply();
        }

    }
}
