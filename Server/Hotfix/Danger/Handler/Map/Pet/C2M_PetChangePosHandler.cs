using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetChangePosHandler: AMActorLocationRpcHandler<Unit, C2M_PetChangePosRequest, M2C_PetChangePosResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetChangePosRequest request, M2C_PetChangePosResponse response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();

            if (request.Index1 < 0 || request.Index1 >= petComponent.RolePetInfos.Count)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (request.Index2 < 0 || request.Index2 >= petComponent.RolePetInfos.Count)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            if (request.Index1 == request.Index2)
            {
                response.Error = ErrorCode.ERR_ModifyData;
                reply();
                return;
            }

            (petComponent.RolePetInfos[request.Index1], petComponent.RolePetInfos[request.Index2]) =
                    (petComponent.RolePetInfos[request.Index2], petComponent.RolePetInfos[request.Index1]);
            reply();

            await ETTask.CompletedTask;
        }
    }
}