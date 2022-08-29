using System;

namespace ET
{
    //宠物蛋放入孵化池
    [ActorMessageHandler]
    public class C2M_RolePetEggPutHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetEggPut, M2C_RolePetEggPut>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetEggPut request, M2C_RolePetEggPut response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetEgg rolePetEgg = petComponent.RolePetEggs[request.Index];
            if (rolePetEgg.ItemId != 0)
            {
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            BagInfo useBagInfo = bagComponent.GetItemByLoc(ItemLocType.ItemLocBag, request.BagInfoId);
            if (useBagInfo == null)
            {
                reply();
                return;
            }
            
            bagComponent.OnCostItemData(request.BagInfoId, 1);
            rolePetEgg.ItemId = useBagInfo.ItemID;
            rolePetEgg.EndTime = 0;
            response.RolePetEgg = rolePetEgg;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
