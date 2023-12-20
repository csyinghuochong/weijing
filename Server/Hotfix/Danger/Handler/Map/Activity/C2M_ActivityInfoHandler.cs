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

            ActivityV1Info activityV1Info = activityComponent.ActivityV1Info;
            activityV1Info.ChouKaDropId = unit.DomainScene().GetComponent<ServerInfoComponent>().ServerInfo.ChouKaDropId;
            activityV1Info.GuessIds.Clear();

            long activitySceneid = DBHelper.GetActivityServerId(  unit.DomainZone() );
            A2M_ActivitySelfGuessIds r_GameStatusResponse = (A2M_ActivitySelfGuessIds)await ActorMessageSenderComponent.Instance.Call
                   (activitySceneid, new M2A_ActivitySelfGuessIds()
                   {
                        UnitId = unit.Id,   
                   });
            activityV1Info.GuessIds = r_GameStatusResponse.GuessIds;
            activityV1Info.LastGuessRewatd = r_GameStatusResponse.LastGuessRewatd;  
            response.ActivityV1Info = activityV1Info;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
