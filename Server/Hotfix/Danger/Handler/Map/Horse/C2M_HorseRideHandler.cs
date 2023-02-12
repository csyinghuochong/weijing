using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_HorseRideHandler : AMActorLocationRpcHandler<Unit, C2M_HorseRideRequest, M2C_HorseRideResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HorseRideRequest request, M2C_HorseRideResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            if (numericComponent.GetAsInt(NumericType.HorseFightID) == 0)
            {
                response.Error = ErrorCore.ERR_HoreseNotActive;
                reply();
                return;
            }

            int now_horse = numericComponent.GetAsInt(NumericType.HorseRide);
            if (now_horse > 0)
            {
                numericComponent.ApplyValue(NumericType.HorseRide, 0);
            }
            else
            {
                numericComponent.ApplyValue(NumericType.HorseRide, 1);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
