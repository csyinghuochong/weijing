using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_MagickaFefreshHandler : AMActorLocationRpcHandler<Unit, C2M_MagickaFefreshRequest, M2C_MagickaFefreshResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_MagickaFefreshRequest request, M2C_MagickaFefreshResponse response, Action reply)
        {

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo beforeequip = bagComponent.GetMagicEquipBySubType(ItemLocType.ItemLocEquip, request.Position);

            if (beforeequip == null)
            {
                response.Error = ErrorCode.ERR_MagicNotOpen;
                reply();
                return; 
            }

            int neednum = ConfigHelper.GetMagitFefreshNeedNum(beforeequip.ItemID);

            if (!bagComponent.OnCostItemData($"{ConfigHelper.MagitFefreshItemId};{neednum}", ItemLocType.ItemLocBag, ItemGetWay.MagicKa))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            beforeequip.ItemPar = RandomHelper.RandomNumber(1, 100).ToString();

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(beforeequip.ItemID);
            List<int> itemSkills = ItemHelper.GetItemSkill(itemConfig.SkillID);
            if (itemSkills.Count > 0)
            {
                unit.GetComponent<SkillPassiveComponent>().UpdateMagicQulity(itemSkills[0], int.Parse(beforeequip.ItemPar));
            }

            //通知客户端背包刷新
            M2C_RoleBagUpdate m2c_bagUpdate = new M2C_RoleBagUpdate();
            m2c_bagUpdate.BagInfoUpdate.Add(beforeequip);
            MessageHelper.SendToClient(unit, m2c_bagUpdate);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
