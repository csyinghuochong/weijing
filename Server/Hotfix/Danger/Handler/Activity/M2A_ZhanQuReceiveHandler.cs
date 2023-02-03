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

            ZhanQuReceiveNumber zhanQuReceive = null;
            for (int i = 0; i < zhanQuReceiveNumbers.Count; i++)
            {
                if (zhanQuReceiveNumbers[i].ActivityId != request.ActivityId)
                {
                    continue;
                }
                if (zhanQuReceiveNumbers[i].ReceiveUnitIds.Contains(request.UnitId))
                {
                    response.Error = ErrorCore.ERR_AlreadyReceived;
                    reply();
                    return;
                }
                zhanQuReceive = zhanQuReceiveNumbers[i];
                zhanQuReceiveNumbers[i].ReceiveNum++;
                zhanQuReceiveNumbers[i].ReceiveUnitIds.Add(request.UnitId);
                break;
            }
            if (zhanQuReceive==null)
            {
                ZhanQuReceiveNumber zhanQuReceiveNumber = new ZhanQuReceiveNumber();
                zhanQuReceiveNumber.ActivityId = request.ActivityId;
                zhanQuReceiveNumber.ReceiveNum = 1;
                zhanQuReceiveNumber.ReceiveUnitIds.Add(request.UnitId);
                zhanQuReceiveNumbers.Add(zhanQuReceiveNumber);
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
