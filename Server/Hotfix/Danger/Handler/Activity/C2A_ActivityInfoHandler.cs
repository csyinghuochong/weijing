using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2A_ActivityInfoHandler : AMActorRpcHandler<Scene, C2A_ActivityInfoRequest, A2C_ActivityInfoResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_ActivityInfoRequest request, A2C_ActivityInfoResponse response, Action reply)
        {
            DBDayActivityInfo dBDayActivityInfo = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo;
            switch (request.ActivityType)
            {
                case 1:  //周任务
                    response.ActivityContent = dBDayActivityInfo.WeeklyTask.ToString();
                    break;
                default:
                    break;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
