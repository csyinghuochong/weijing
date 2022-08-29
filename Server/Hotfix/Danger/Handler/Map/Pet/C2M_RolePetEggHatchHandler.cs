using System;

namespace ET
{

    //开始孵化
    [ActorMessageHandler]
    public class C2M_RolePetEggHatchHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetEggHatch, M2C_RolePetEggHatch>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetEggHatch request, M2C_RolePetEggHatch response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetEgg rolePetEgg = petComponent.RolePetEggs[request.Index];

            string[] useparams = ItemConfigCategory.Instance.Get(rolePetEgg.ItemId).ItemUsePar.Split('@');
            long needTime = long.Parse(useparams[0]);
            rolePetEgg.EndTime = TimeHelper.ServerNow() + needTime  * 1000;
            response.RolePetEgg = rolePetEgg;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
