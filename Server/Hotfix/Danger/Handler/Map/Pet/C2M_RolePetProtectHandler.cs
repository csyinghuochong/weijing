using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_RolePetProtectHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetProtect, M2C_RolePetProtect>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetProtect request, M2C_RolePetProtect response, Action reply)
        {
            RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
            if (rolePetInfo == null)
            {
                response.Error = ErrorCore.ERR_Pet_NoExist;
                reply();
                return;
            }

            rolePetInfo.IsProtect = request.IsProtect;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
