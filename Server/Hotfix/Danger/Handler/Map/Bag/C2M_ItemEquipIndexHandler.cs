using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    /// <summary>
    /// 猎人切换武器
    /// </summary>
    [ActorMessageHandler]
    public class C2M_ItemEquipIndexHandler : AMActorLocationRpcHandler<Unit, C2M_ItemEquipIndexRequest, M2C_ItemEquipIndexResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemEquipIndexRequest request, M2C_ItemEquipIndexResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo equip_0 = bagComponent.GetEquipBySubType(ItemLocType.ItemLocEquip, (int)ItemSubTypeEnum.Wuqi);
            BagInfo equip_1 = bagComponent.GetEquipBySubType(ItemLocType.ItemLocEquip_2, (int)ItemSubTypeEnum.Wuqi);
            if (equip_0 == null || equip_1 == null)
            {
                response.Error = ErrorCode.ERR_EquipType;
                reply();
                return;
            }

            //0远程 1近战
            int equipIndex = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.EquipIndex);

            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            //交换装备位置
            unit.GetComponent<BagComponent>().OnChangeItemLoc(equip_0, ItemLocType.ItemLocEquip_2, ItemLocType.ItemLocEquip);
            unit.GetComponent<BagComponent>().OnChangeItemLoc(equip_1, ItemLocType.ItemLocEquip, ItemLocType.ItemLocEquip_2);

            unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(ItemLocType.ItemLocEquip, equip_0);
            unit.GetComponent<SkillSetComponent>().OnWearEquip(equip_1);

            
            m2c_bagUpdate.BagInfoUpdate.Add(equip_0);
            m2c_bagUpdate.BagInfoUpdate.Add(equip_1);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.EquipIndex, request.EquipIndex);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Weapon, unit.GetComponent<BagComponent>().GetWuqiItemId());

            reply();
            await ETTask.CompletedTask;
        }
    }
}
