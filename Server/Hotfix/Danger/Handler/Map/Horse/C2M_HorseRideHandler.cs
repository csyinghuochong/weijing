using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_HorseRideHandler : AMActorLocationRpcHandler<Unit, C2M_HorseRideRequest, M2C_HorseRideResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HorseRideRequest request, M2C_HorseRideResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();   
            if(userInfoComponent.UserInfo.HorseIds.Count == 0)
            {
                response.Error = ErrorCore.ERR_HoreseNotActive;
                reply();
                return;
            }

            int now_horse = numericComponent.GetAsInt(NumericType.HorseRide);
            if (now_horse > 0)
            {
                numericComponent.ApplyValue(NumericType.HorseRide, 0);
                reply();
                return;
            }

            int horseFightID = 0;
            string svalue = userInfoComponent.GetGameSettingValue( GameSettingEnum.RandomHorese);
            if (svalue == "0")
            {
                horseFightID = numericComponent.GetAsInt(NumericType.HorseFightID);
                if (horseFightID == 0)
                {
                    response.Error = ErrorCore.ERR_HoreseNotActive;
                    reply();
                    return;
                }
            }
            else
            {
                int randomIndex = RandomHelper.RandomNumber(0, userInfoComponent.UserInfo.HorseIds.Count);
                horseFightID = userInfoComponent.UserInfo.HorseIds[randomIndex];
            }
            numericComponent.ApplyValue(NumericType.HorseRide, horseFightID);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
