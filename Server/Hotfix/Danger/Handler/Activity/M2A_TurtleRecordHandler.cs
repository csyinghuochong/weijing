using System;
using System.Collections.Generic;
using System.Dynamic;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_TurtleRecordHandler : AMActorRpcHandler<Scene, M2A_TurtleRecordRequest, A2M_TurtleRecordResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_TurtleRecordRequest request, A2M_TurtleRecordResponse response, Action reply)
        {
            ActivitySceneComponent activitySceneComponent= scene.GetComponent<ActivitySceneComponent>();
            DBDayActivityInfo dBDayActivityInfo = activitySceneComponent.DBDayActivityInfo;
            if (dBDayActivityInfo.TurtleWinTimes.Count < 3)
            {
                dBDayActivityInfo.TurtleWinTimes = new List<int> { 0, 0, 0 };
            }

            for (int i = 0; i < ConfigHelper.TurtleList.Count; i++)
            {
                List<KeyValuePair<long, long>> playerids = null;
                activitySceneComponent.TurtleSupportList.TryGetValue(ConfigHelper.TurtleList[i], out playerids);
                if (playerids != null )
                {
                    for (int p = 0; p < playerids.Count; p++)
                    {
                        if (playerids[p].Key == request.AccountId)
                        {
                            response.SupportId = ConfigHelper.TurtleList[i];
                            break;
                        }
                    }
                }
            }

            response.WinTimes = dBDayActivityInfo.TurtleWinTimes;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
