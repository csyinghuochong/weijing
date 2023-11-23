using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemXiLianTransferHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianTransferRequest, M2C_ItemXiLianTransferResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianTransferRequest request, M2C_ItemXiLianTransferResponse response, Action reply)
        {
            BagInfo bagInfo_1 = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID_1);
            BagInfo bagInfo_2 = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID_2);
            if (bagInfo_1 == null || bagInfo_2 == null)
            {
                reply();
                return;
            }

            //判断品质
            ItemConfig itemConfig_0 = ItemConfigCategory.Instance.Get(bagInfo_1.ItemID);
            ItemConfig itemConfig_1 = ItemConfigCategory.Instance.Get(bagInfo_2.ItemID);

            //绑定装备无法转移(客户端已经给出对应提示)
            if (bagInfo_1.isBinging == true && bagInfo_2.isBinging == false && itemConfig_1.ItemQuality == 4)
            {
                bagInfo_2.isBinging = true;
            }

            //紫色品质以上才可以转移
            if (itemConfig_0.ItemQuality < 4 || itemConfig_1.ItemQuality < 4)
            {
                reply();
                return;
            }

            //相同部位  只有护甲类型相同的装备才能转移
            if (itemConfig_0.EquipType != 99 && itemConfig_1.EquipType != 99)
            {
                //相同部位
                if (itemConfig_0.EquipType != itemConfig_1.EquipType)
                {
                    reply();
                    return;
                }
            }

            if (itemConfig_0.EquipType != 99 && itemConfig_1.EquipType != 99)
            {
                //相同部位  只有相同部位的装备才能转移
                if (itemConfig_0.ItemSubType != itemConfig_1.ItemSubType)
                {
                    reply();
                    return;
                }
            }

            string costItem = GlobalValueConfigCategory.Instance.Get(51).Value;
            if (!unit.GetComponent<BagComponent>().OnCostItemData(costItem))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            bagInfo_2.XiLianHideTeShuProLists.Clear();
            bagInfo_2.XiLianHideProLists.Clear();
            bagInfo_2.HideSkillLists.Clear();
            bagInfo_2.XiLianHideTeShuProLists.AddRange( bagInfo_1.XiLianHideTeShuProLists);
            bagInfo_2.XiLianHideProLists.AddRange(bagInfo_1.XiLianHideProLists);
            bagInfo_2.HideSkillLists.AddRange(bagInfo_1.HideSkillLists);

            bagInfo_1.XiLianHideTeShuProLists.Clear();
            bagInfo_1.XiLianHideProLists.Clear();
            bagInfo_1.HideSkillLists.Clear();

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            //通知客户端背包道具发生改变
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo_1);
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo_2);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
