using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetEquipHandler : AMActorLocationRpcHandler<Unit, C2M_PetEquipRequest, M2C_PetEquipResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetEquipRequest request, M2C_PetEquipResponse response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfo(request.PetInfoId);
            if (rolePetInfo == null)
            {
                response.Error = ErrorCode.ERR_Pet_NoExist;
                reply();
                return;
            }

            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            //通知客户端背包道具发生改变
            m2c_bagUpdate.BagInfoUpdate = new List<BagInfo>();

            long takeOffId = 0;
            if (request.OperateType == 1) //穿戴
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoId);
                if (bagInfo == null)
                {
                    response.Error = ErrorCode.ERR_ItemNotExist;
                    reply();
                    return;
                }

                int itemSubType = ItemConfigCategory.Instance.Get(bagInfo.ItemID).ItemSubType;
                for (int i = rolePetInfo.PetEquipList.Count - 1; i >= 0; i--)
                { 
                    BagInfo petequipInfo = bagComponent.GetItemByLoc(ItemLocType.PetLocEquip, rolePetInfo.PetEquipList[i]);
                    if (petequipInfo == null)
                    {
                        rolePetInfo.PetEquipList.RemoveAt(i);   
                    }
                    if(ItemConfigCategory.Instance.Get(petequipInfo.ItemID).ItemSubType == itemSubType)
                    {
                        takeOffId = rolePetInfo.PetEquipList[i];
                        break;
                    }
                }
            }
            if (request.OperateType == 2)
            {
                takeOffId = request.BagInfoId;
            }

            //先卸下
            if (takeOffId != 0)
            {
                BagInfo oldBagInfo = bagComponent.GetItemByLoc(ItemLocType.PetLocEquip, takeOffId);
                if (oldBagInfo != null)
                {
                    bagComponent.OnChangeItemLoc(oldBagInfo, ItemLocType.ItemLocBag, ItemLocType.PetLocEquip);
                    m2c_bagUpdate.BagInfoUpdate.Add(oldBagInfo);
                    rolePetInfo.PetEquipList.Remove(takeOffId);
                }

                petComponent.RemoveEquipSkill(rolePetInfo, 0);
            }

            if (request.OperateType == 1) //穿戴
            {
                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoId);

                //新的装备给宠物
                bagComponent.OnChangeItemLoc(bagInfo, ItemLocType.PetLocEquip, ItemLocType.ItemLocBag);
                m2c_bagUpdate.BagInfoUpdate.Add(bagInfo);
                rolePetInfo.PetEquipList.Add(request.BagInfoId);
            }
            petComponent.UpdatePetAttribute(rolePetInfo, false);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);
            response.RolePetInfo = rolePetInfo;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
