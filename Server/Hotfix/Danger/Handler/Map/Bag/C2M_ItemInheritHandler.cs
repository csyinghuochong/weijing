using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemInheritHandler : AMActorLocationRpcHandler<Unit, C2M_ItemInheritRequest, M2C_ItemInheritResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemInheritRequest request, M2C_ItemInheritResponse response, Action reply)
        {
            BagInfo bagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocBag, request.OperateBagID);
            if (bagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemNotExist;
                reply();
                return;
            }
            if (bagInfo.InheritTimes >= 1)
            {
                response.Error = ErrorCore.ERR_TimesIsNot;
                reply();
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            string costitem = GlobalValueConfigCategory.Instance.Get(88).Value;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (!bagComponent.CheckCostItem(costitem))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }


            unit.GetComponent<BagComponent>().OnCostItemData(costitem);
            ItemXiLianResult itemXiLianResult = new ItemXiLianResult() { };
            
            int subtype = itemConfig.ItemSubType;
            int skillid = XiLianHelper.XiLianChuanChengJianDing(itemConfig, unit.GetComponent<UserInfoComponent>().UserInfo.Occ, unit.GetComponent<UserInfoComponent>().UserInfo.OccTwo);

            if (skillid == 0) {
                response.Error = ErrorCore.ERR_EquipChuanChengFail;
                reply();
            }

            response.InheritSkills.Add(skillid);

            bagInfo.InheritTimes += 1;

            //通知客户端背包道具发生改变
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();
            m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
