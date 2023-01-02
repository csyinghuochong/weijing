using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityInfoHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityInfoRequest, M2C_ActivityInfoResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_ActivityInfoRequest request, M2C_ActivityInfoResponse response, Action reply)
        {
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            if (activityComponent.TotalSignNumber == 0)
            {
                for (int i = activityComponent.ActivityReceiveIds.Count - 1; i >= 0; i--)
                {
                    ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(activityComponent.ActivityReceiveIds[i]);
                    if (activityConfig.ActivityType == 23)
                    {
                        activityComponent.ActivityReceiveIds.RemoveAt(i);
                    }
                }
            }
            response.ReceiveIds = activityComponent.ActivityReceiveIds;
            response.LastSignTime = activityComponent.LastSignTime;
            response.TotalSignNumber = activityComponent.TotalSignNumber;
            response.QuTokenRecvive = activityComponent.QuTokenRecvive;
            response.LastLoginTime = activityComponent.LastLoginTime;
            response.DayTeHui = activityComponent.DayTeHui;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
