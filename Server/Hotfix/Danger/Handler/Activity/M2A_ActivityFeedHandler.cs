using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_ActivityFeedHandler : AMActorRpcHandler<Scene, M2A_ActivityFeedRequest, A2M_ActivityFeedResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_ActivityFeedRequest request, A2M_ActivityFeedResponse response, Action reply)
        {
            ActivitySceneComponent activitySceneComponent = scene.GetComponent<ActivitySceneComponent>();
            if (!activitySceneComponent.DBDayActivityInfo.FeedPlayerList.ContainsKey(request.UnitID))
            {
                activitySceneComponent.DBDayActivityInfo.FeedPlayerList.Add( request.UnitID, 0 );
            }
            activitySceneComponent.DBDayActivityInfo.FeedPlayerList[request.UnitID]++;
            activitySceneComponent.DBDayActivityInfo.BaoShiDu++;

            response.BaoShiDu = activitySceneComponent.DBDayActivityInfo.BaoShiDu;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
