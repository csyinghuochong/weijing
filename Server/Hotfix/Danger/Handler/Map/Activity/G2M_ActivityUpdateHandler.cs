
namespace ET
{

    [ActorMessageHandler]
    public class G2M_ActivityUpdateHandler : AMActorLocationHandler<Unit, G2M_ActivityUpdate>
    {

        protected override async ETTask Run(Unit unit, G2M_ActivityUpdate message)
        {
            switch (message.ActivityType)
            {
                case 0:
                    Log.Debug($"OnZeroClockUpdate true: {unit.Id}");
                    UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
                    unit.GetComponent<EnergyComponent>().OnZeroClockUpdate();
                    unit.GetComponent<UserInfoComponent>().OnHourUpdate(0, true);
                    unit.GetComponent<UserInfoComponent>().OnZeroClockUpdate(true);
                    unit.GetComponent<TaskComponent>().OnZeroClockUpdate(true);
                    unit.GetComponent<HeroDataComponent>().OnZeroClockUpdate(true);
                    unit.GetComponent<ActivityComponent>().OnZeroClockUpdate(userInfo.Lv);
                    break;
                default:
                    unit.GetComponent<UserInfoComponent>().OnHourUpdate(message.ActivityType, true);
                    break;
            }
   
            await ETTask.CompletedTask;
        }
    }
}
