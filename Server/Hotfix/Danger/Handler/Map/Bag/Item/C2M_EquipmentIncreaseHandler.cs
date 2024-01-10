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
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            BagInfo equipmentBagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.EquipmentBagInfo.BagInfoID);
            if(equipmentBagInfo == null)
            {
                equipmentBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip, request.EquipmentBagInfo.BagInfoID);
            }
            if (equipmentBagInfo == null)
            {
                equipmentBagInfo = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemLocEquip_2, request.EquipmentBagInfo.BagInfoID);
            }

            if (equipmentBagInfo == null)
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equipmentBagInfo.ItemID);

            if (itemConfig.EquipType == 101 || itemConfig.EquipType == 201)
            {
                response.Error = ErrorCode.ERR_ItemUseError;
                reply();
                return;
            }

            // 装备增幅
            List<HideProList> noTransfHideProLists = new List<HideProList>();
            List<HideProList> canTransfHideProLists = new List<HideProList>();
            foreach (HideProList var in reelBagInfo.IncreaseProLists)
            {
                HideProListConfig reelHide = HideProListConfigCategory.Instance.Get(var.HideID);
                if (reelHide.IfMove == 0)
                {
                    noTransfHideProLists.Add(var);
                }
                else
                {
                    canTransfHideProLists.Add(var);
                }
            }

            List<int> noTransfSkillLists = new List<int>();
            List<int> canTransfSkillLists = new List<int>();
            foreach (int var in reelBagInfo.IncreaseSkillLists)
            {
                HideProListConfig reelHide = HideProListConfigCategory.Instance.Get(var);
                if (reelHide.IfMove == 0)
                {
                    noTransfSkillLists.Add(var);
                }
                else
                {
                    canTransfSkillLists.Add(var);
                }
            }

            // 装备已经存在非传承属性或技能
            if (noTransfHideProLists.Count > 0 || noTransfSkillLists.Count > 0)
            {
                // 倒序删除已经存在的非传承属性！
                for (int i = equipmentBagInfo.IncreaseProLists.Count - 1; i >= 0; i--)
                {
                    HideProListConfig equipHide = HideProListConfigCategory.Instance.Get(equipmentBagInfo.IncreaseProLists[i].HideID);
                    if (equipHide.IfMove == 0)
                    {
                        equipmentBagInfo.IncreaseProLists.RemoveAt(i);
                    }
                }
                // 添加新的非传承属性
                equipmentBagInfo.IncreaseProLists.AddRange(noTransfHideProLists);

                // 倒叙删除已经存在的非传承技能
                for (int i = equipmentBagInfo.IncreaseSkillLists.Count - 1; i >= 0; i--)
                {
                    HideProListConfig equipHide = HideProListConfigCategory.Instance.Get(equipmentBagInfo.IncreaseSkillLists[i]);
                    if (equipHide.IfMove == 0)
                    {
                        equipmentBagInfo.IncreaseSkillLists.RemoveAt(i);
                    }
                }
                // 添加新的非传承技能
                equipmentBagInfo.IncreaseSkillLists.AddRange(noTransfSkillLists);
            }
            
            // 装备已经存在传承属性或技能
            if (canTransfHideProLists.Count > 0 || canTransfSkillLists.Count > 0)
            {
                // 倒叙删除已经存在的传承属性
                for (int i = equipmentBagInfo.IncreaseProLists.Count - 1; i >= 0; i--)
                {
                    HideProListConfig equipHide = HideProListConfigCategory.Instance.Get(equipmentBagInfo.IncreaseProLists[i].HideID);
                    if (equipHide.IfMove == 1)
                    {
                        equipmentBagInfo.IncreaseProLists.RemoveAt(i);
                    }
                }
                // 添加新的传承属性
                equipmentBagInfo.IncreaseProLists.AddRange(canTransfHideProLists);

                // 倒叙删除已经存在的传承技能
                for (int i = equipmentBagInfo.IncreaseSkillLists.Count - 1; i >= 0; i--)
                {
                    HideProListConfig equipHide = HideProListConfigCategory.Instance.Get(equipmentBagInfo.IncreaseSkillLists[i]);
                    if (equipHide.IfMove == 1)
                    {
                        equipmentBagInfo.IncreaseSkillLists.RemoveAt(i);
                    }
                }
                // 添加新的传承技能
                equipmentBagInfo.IncreaseSkillLists.AddRange(canTransfSkillLists);
            }
            
            // 消耗卷轴
            bagComponent.OnCostItemData(reelBagInfo.BagInfoID, 1);

            string increaseProLists = string.Empty;
            for (int i = 0; i < increaseProLists.Length; i++)
            {
                increaseProLists += $"{increaseProLists}_";
            }
            Log.Warning($"增幅消耗: {unit.Id}  {reelBagInfo.ItemID}   获得属性:{increaseProLists}");

            //通知客户端背包刷新
            equipmentBagInfo.isBinging = true;  
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate.Add(equipmentBagInfo);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            // 更新角色属性
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

            reply();
            await ETTask.CompletedTask;
        }
    }
}