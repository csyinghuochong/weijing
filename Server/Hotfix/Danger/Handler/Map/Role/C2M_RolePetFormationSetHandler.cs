using System;

namespace ET
{
    //宠物出战设置
    [ActorMessageHandler]
    public class C2M_RolePetFormationSetHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetFormationSet, M2C_RolePetFormationSet>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetFormationSet request, M2C_RolePetFormationSet response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            petComponent.OnFormationSet(request.PetId, request.Index, request.OperateType);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
