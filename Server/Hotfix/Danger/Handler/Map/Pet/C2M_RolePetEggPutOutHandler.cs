using System;

namespace ET
{
    //卸下宠物蛋
    [ActorMessageHandler]
    public class C2M_RolePetEggPutOutHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetEggPutOut, M2C_RolePetEggPutOut>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetEggPutOut request, M2C_RolePetEggPutOut response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetEgg rolePetEgg = petComponent.RolePetEggs[request.Index];
            
            bagComponent.OnAddItemData($"{rolePetEgg.ItemId};1", $"{ItemGetWay.PetEggPutOut}_{TimeHelper.ServerNow()}_{rolePetEgg.FuLing}");
            rolePetEgg.ItemId = 0;
            rolePetEgg.EndTime = 0;
            rolePetEgg.FuLing = 0;
            response.RolePetEgg = rolePetEgg;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
