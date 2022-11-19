using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_HorseRideHandler : AMActorLocationRpcHandler<Unit, C2M_HorseRideRequest, M2C_HorseRideResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HorseRideRequest request, M2C_HorseRideResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int now_horse = numericComponent.GetAsInt(NumericType.Now_Horse);
            if (now_horse > 0)
            {
                numericComponent.ApplyValue(NumericType.Now_Horse, 0);
            }
            else
            {
                int fight_horse = 10001;
                numericComponent.ApplyValue(NumericType.Now_Horse, fight_horse);
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
