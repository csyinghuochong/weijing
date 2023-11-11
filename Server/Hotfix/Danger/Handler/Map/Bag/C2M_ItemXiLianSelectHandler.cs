using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ItemXiLianSelectHandler : AMActorLocationRpcHandler<Unit, C2M_ItemXiLianSelectRequest, M2C_ItemXiLianSelectResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemXiLianSelectRequest request, M2C_ItemXiLianSelectResponse response, Action reply)
        {
            ItemLocType itemLocType = ItemLocType.ItemLocBag;
            BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
            if (bagInfo == null)
            {
                bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, request.OperateBagID);
                itemLocType = ItemLocType.ItemLocEquip;
            }
            if (bagInfo == null)
            {
                bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip_2, request.OperateBagID);
                itemLocType = ItemLocType.ItemLocEquip_2;
            }

            ItemXiLianResult itemXiLian = request.ItemXiLianResult;
            if (itemXiLian != null)
            {
                bagInfo.XiLianHideProLists = itemXiLian.XiLianHideProLists;              //基础属性洗炼
                bagInfo.HideSkillLists = itemXiLian.HideSkillLists;                      //隐藏技能
                bagInfo.XiLianHideTeShuProLists = itemXiLian.XiLianHideTeShuProLists;    //特殊属性洗炼
            }

            if (itemLocType == ItemLocType.ItemLocEquip || itemLocType == ItemLocType.ItemLocEquip_2)
            {
                unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(itemLocType, bagInfo);
                unit.GetComponent<SkillSetComponent>().OnWearEquip(bagInfo);
            }

            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            //通知客户端背包道具发生改变
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
