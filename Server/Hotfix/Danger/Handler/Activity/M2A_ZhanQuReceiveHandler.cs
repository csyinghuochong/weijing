using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_ZhanQuReceiveHandler : AMActorRpcHandler<Scene, M2A_ZhanQuReceiveRequest, A2M_ZhanQuReceiveResponse>
    {

        protected override async ETTask Run(Scene scene, M2A_ZhanQuReceiveRequest request, A2M_ZhanQuReceiveResponse response, Action reply)
        {
            List<ZhanQuReceiveNumber> zhanQuReceiveNumbers =  scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.ZhanQuReveives;

            int receiveNum = 0;
            for (int i = 0; i < zhanQuReceiveNumbers.Count; i++)
            {
                if ( zhanQuReceiveNumbers[i].ActivityId == request.ActivityId )
                {
                    receiveNum = zhanQuReceiveNumbers[i].ReceiveNum;
                }
            }

            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(request.ActivityId);
            if (int.Parse(activityConfig.Par_2) <= receiveNum)
            {
                response.Error = ErrorCore.ERR_AlreadyFinish;
                reply();
                return;
            }

            if (receiveNum == 0)
            {
                zhanQuReceiveNumbers.Add(new ZhanQuReceiveNumber() { ActivityId = request.ActivityId, ReceiveNum = 1 });
            }
            else
            {
                for (int i = 0; i < zhanQuReceiveNumbers.Count; i++)
                {
                    if (zhanQuReceiveNumbers[i].ActivityId == request.ActivityId)
                    {
                        zhanQuReceiveNumbers[i].ReceiveNum++;
                    }
                }
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
