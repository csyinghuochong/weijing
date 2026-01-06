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

            TaskComponent taskComponent = unit.GetComponent<TaskComponent>();   
            if (ConfigData.V1ActivityList.Contains(ActivityConfigHelper.ActivityV1_WeeklyTask)
                && taskComponent.GetTaskCountryByType(TaskCountryType.ActivityWeekly).Count == 0)
            {
                taskComponent.InitActivityWeekTask(true);
            }

            response.ReceiveIds = activityComponent.ActivityReceiveIds;
            response.LastSignTime = activityComponent.LastSignTime;
            response.TotalSignNumber = activityComponent.TotalSignNumber;
            response.QuTokenRecvive = activityComponent.QuTokenRecvive;
            response.LastLoginTime = activityComponent.LastLoginTime;
            response.DayTeHui = activityComponent.DayTeHui;
            response.TimerChouKaReceiveIndex = activityComponent.TimerChouKaReceiveIndex;
            response.LastTimerChouKaPassTime = activityComponent.LastTimerChouKaPassTime;

            ActivityV1Info activityV1Info = activityComponent.ActivityV1Info;
            long servertime = TimeHelper.ServerNow();
            if (servertime - activityV1Info.OrderLastFefreshTime >= ActivityConfigHelper.ActivityOrderRefreshTime)
            {
                activityV1Info.OrderLastFefreshTime = TimeHelper.ServerNow();
                activityV1Info.OrderId  = ActivityConfigHelper.GenerateActivityOrderId();
            }

            ServerInfo dBServerInfo = unit.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo;
            activityV1Info.ChouKaDropId = dBServerInfo.ChouKaDropId;
            activityV1Info.V1ActivityList = ConfigData.V1ActivityList;
            activityV1Info.GuessIds.Clear();

            long activitySceneid = DBHelper.GetActivityServerId(  unit.DomainZone() );
            A2M_ActivitySelfInfo r_GameStatusResponse = (A2M_ActivitySelfInfo)await ActorMessageSenderComponent.Instance.Call
                   (activitySceneid, new M2A_ActivitySelfInfo()
                   {
                        UnitId = unit.Id,   
                   });
            activityV1Info.GuessIds = r_GameStatusResponse.GuessIds;
            activityV1Info.LastGuessReward = r_GameStatusResponse.LastGuessReward;
            activityV1Info.BaoShiDu = r_GameStatusResponse.BaoShiDu;
            activityV1Info.OpenGuessIds = r_GameStatusResponse.OpenGuessIds;
            response.ActivityV1Info = activityV1Info;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
