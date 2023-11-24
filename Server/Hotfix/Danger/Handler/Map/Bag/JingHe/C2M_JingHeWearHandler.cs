using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JingHeWearHandler : AMActorLocationRpcHandler<Unit, C2M_JingHeWearRequest, M2C_JingHeWearResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JingHeWearRequest request, M2C_JingHeWearResponse response, Action reply)
        {
            ItemLocType locType = request.OperateType == 1 ? ItemLocType.ItemLocBag : ItemLocType.SeasonJingHe;
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo useBagInfo = bagComponent.GetItemByLoc(locType, request.OperateBagID);
            if (useBagInfo == null)
            {
                response.Error = ErrorCode.ERR_ItemNotExist;
                reply();
                return;
            }

            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();

            if (request.OperateType == 1)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(useBagInfo.ItemID);
                if (itemConfig.ItemType != ItemTypeEnum.Equipment || itemConfig.EquipType != 201)
                {
                    response.Error = ErrorCode.ERR_EquipType;
                    reply();
                    return;
                }

                //穿戴 获取当前位置是否有装备
                BagInfo beforeequip = bagComponent.GetJingHeByWeiZhi(itemConfig.ItemSubType);
                if (beforeequip != null)
                {
                    unit.GetComponent<BagComponent>().OnChangeItemLoc(beforeequip, ItemLocType.ItemLocBag, ItemLocType.SeasonJingHe);
                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.SeasonJingHe, ItemLocType.ItemLocBag);

                    unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(ItemLocType.SeasonJingHe, beforeequip);
                    unit.GetComponent<SkillSetComponent>().OnWearEquip(useBagInfo);
                    m2c_bagUpdate.BagInfoUpdate.Add(beforeequip);
                }
                else
                {
                    unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.SeasonJingHe, ItemLocType.ItemLocBag);
                    unit.GetComponent<SkillSetComponent>().OnWearEquip(useBagInfo);
                }

                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
                useBagInfo.isBinging = true;
                m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
            }
            if (request.OperateType == 2)
            {

                //卸下  判断背包格子是否足够
                bool full = unit.GetComponent<BagComponent>().IsBagFull();
                if (full)
                {
                    response.Error = ErrorCode.ERR_BagIsFull;
                    reply();
                    return;
                }
                unit.GetComponent<BagComponent>().OnChangeItemLoc(useBagInfo, ItemLocType.ItemLocBag, ItemLocType.SeasonJingHe);
                unit.GetComponent<SkillSetComponent>().OnTakeOffEquip(ItemLocType.SeasonJingHe, useBagInfo);
                Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
                m2c_bagUpdate.BagInfoUpdate.Add(useBagInfo);
            }

            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            //通知客户端属性刷新

            reply();
            await ETTask.CompletedTask;
        }
    }
}
