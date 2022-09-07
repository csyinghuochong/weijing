using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_PetHeXinHeChengHandler : AMActorLocationRpcHandler<Unit, C2M_PetHeXinHeChengRequest, M2C_PetHeXinHeChengResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_PetHeXinHeChengRequest request, M2C_PetHeXinHeChengResponse response, Action reply)
        {
            BagInfo bagInfo_1 = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemPetHeXinBag, request.BagInfoID_1);
            BagInfo bagInfo_2 = unit.GetComponent<BagComponent>().GetItemByLoc(ItemLocType.ItemPetHeXinBag, request.BagInfoID_2);
            if (bagInfo_1.ItemID != bagInfo_2.ItemID)
            {
                reply();
                return;
            }
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfo_1.ItemID);
            if (itemConfig.PetHeXinHeChengID==0)
            {
                reply();
                return;
            }

            using ListComponent<long> costids = new ListComponent<long>() { bagInfo_1.BagInfoID,bagInfo_2.BagInfoID };
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            bagComponent.OnAddItemData($"{itemConfig.PetHeXinHeChengID};1", $"{ItemGetWay.PetHeXinHeCheng}_{TimeHelper.ServerNow()}");
            bagComponent.OnCostItemData(costids,ItemLocType.ItemPetHeXinBag);

            reply();
            await ETTask.CompletedTask;
        }

    }
}
