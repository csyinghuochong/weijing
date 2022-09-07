using System;

namespace ET
{
    //卸下宠物蛋
    [ActorMessageHandler]
    public class C2M_RolePetEggPutOutHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetEggPutOut, M2C_RolePetEggPutOut>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetEggPutOut request, M2C_RolePetEggPutOut response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetEgg rolePetEgg = petComponent.RolePetEggs[request.Index];
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            bagComponent.OnAddItemData($"{rolePetEgg.ItemId};1", $"{ItemGetWay.PetEggDuiHuan}_{TimeHelper.ServerNow()}");
            rolePetEgg.ItemId = 0;
            rolePetEgg.EndTime = 0;
            response.RolePetEgg = rolePetEgg;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
