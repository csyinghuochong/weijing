using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemXiLianHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianRequest, M2C_ItemXiLianResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianRequest request, M2C_ItemXiLianResponse response, Action reply)
        {
            try
            {
                BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
                int[] costItems = itemConfig.XiLianStone;
                List<RewardItem> rewardItems = new List<RewardItem>();
                if (costItems != null && costItems.Length > 0)
                {
                    rewardItems.Add(new RewardItem() { ItemID = costItems[0], ItemNum = costItems[1] });
                }

                bool sucess = unit.GetComponent<BagComponent>().OnCostItemData(rewardItems);
                int xilianLevel = XiLianHelper.GetXiLianId(unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu));
                xilianLevel = xilianLevel != 0 ? EquipXiLianConfigCategory.Instance.Get(xilianLevel).XiLianLevel : 0;
                if (sucess)
                {
                    XiLianHelper.XiLianItem(bagInfo,1, xilianLevel);     //精炼属性不进行重置

                    M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
                    //通知客户端背包道具发生改变
                    m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
                    m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
                    MessageHelper.SendToClient(unit, m2c_bagUpdate);

                    unit.GetComponent<ChengJiuComponent>().OnEquipXiLian();
                    unit.GetComponent<TaskComponent>().OnEquipXiLian();

                    string[] xiliandu = GlobalValueConfigCategory.Instance.Get(49).Value.Split(";");
                    int addXilian = RandomHelper.RandomNumber(int.Parse(xiliandu[0]), int.Parse(xiliandu[1]));
                    unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.ItemXiLianDu, addXilian, 0, true);
                    //unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.Now_XiLian,1, 0, true);
                }

                reply();
                await ETTask.CompletedTask;
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }
    }
}
