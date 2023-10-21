using System;

namespace ET
{

    [ActorMessageHandler]
    public class A2M_PetMingLoginHandler : AMActorRpcHandler<Unit, A2M_PetMingLoginRequest, M2A_PetMingLoginResponse>
    {
        protected override async ETTask Run(Unit unit, A2M_PetMingLoginRequest request, M2A_PetMingLoginResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (1 == numericComponent.GetAsInt(NumericType.PetMineLogin))
            {
                reply();
                return;
            }
            //numericComponent.ApplyValue(NumericType.PetMineLogin, 1);
            unit.GetComponent<TaskComponent>().OnPetMineLogin(request.PetMineList, request.PetMingExtend);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
