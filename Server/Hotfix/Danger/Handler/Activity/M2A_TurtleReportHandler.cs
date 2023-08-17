using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_TurtleReportHandler : AMActorRpcHandler<Scene, M2A_TurtleReportRequest, A2M_TurtleReportResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_TurtleReportRequest request, A2M_TurtleReportResponse response, Action reply)
        {
            DBDayActivityInfo dBDayActivityInfo = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo;
            if (dBDayActivityInfo.TurtleWinTimes.Count < 3)
            {
                dBDayActivityInfo.TurtleWinTimes = new List<int> { 0,0,0 };
            }
            
            int index = ConfigHelper.TurtleList.IndexOf( request.TurtleId );
            if (index != -1)
            {
                dBDayActivityInfo.TurtleWinTimes[index]++;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
