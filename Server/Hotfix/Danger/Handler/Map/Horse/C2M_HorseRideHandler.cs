using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_HorseRideHandler : AMActorLocationRpcHandler<Unit, C2M_HorseRideRequest, M2C_HorseRideResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HorseRideRequest request, M2C_HorseRideResponse response, Action reply)
        {
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Horse, request.HorseId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
