using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_EquipmentIncreaseHandler: AMActorLocationRpcHandler<Unit, C2M_EquipmentIncreaseRequest, M2C_EquipmentIncreaseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_EquipmentIncreaseRequest request, M2C_EquipmentIncreaseResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo reelBagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.ReelBagInfo.BagInfoID);
            if (reelBagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            
            BagInfo equipmentBagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.EquipmentBagInfo.BagInfoID);
            if (equipmentBagInfo == null)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            // 装备增幅
            equipmentBagInfo.IncreaseProLists.Clear();
            equipmentBagInfo.IncreaseSkillLists.Clear();
            equipmentBagInfo.IncreaseProLists.AddRange(reelBagInfo.IncreaseProLists);
            equipmentBagInfo.IncreaseSkillLists.AddRange(reelBagInfo.IncreaseSkillLists);
            
            
            // 消耗卷轴
            bagComponent.OnCostItemData(reelBagInfo.BagInfoID, 1);
            
            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate.Add(equipmentBagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            
            // 更新角色属性
            // Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
            
            reply();
            await ETTask.CompletedTask;
        }
    }
}