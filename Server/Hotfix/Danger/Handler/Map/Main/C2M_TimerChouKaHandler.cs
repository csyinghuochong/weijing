
using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TimerChouKaHandler : AMActorLocationRpcHandler<Unit, C2M_TimerChouKaRequest, M2C_TimerChouKaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TimerChouKaRequest request, M2C_TimerChouKaResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetBagLeftCell() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            
            ActivityComponent activityComponent = unit.GetComponent<ActivityComponent>();
            int receNum = activityComponent.TimerChouKaReceiveIndex;
            if (receNum >= ConfigHelper.TimerChouKaRewardList.Count)
            {
                response.Error = ErrorCode.ERR_AlreadyFinish;
                reply();
                return;
            }

            long passtime = activityComponent.LastTimerChouKaPassTime;
            long validTime =  ConfigHelper.TimerChouKaRewardList[receNum].Interval * TimeHelper.Minute;

            if (passtime < validTime)
            {
                response.Error = ErrorCode.ERR_NotTimeToGet;
                reply();
                return;
            }

            //List<int> validids = new List<int>();
            //List<int> weights = new List<int>();
            //for (int i = 0; i < ConfigHelper.TimerChouKaRewardList.Count; i++)
            //{
            //    if (!activityComponent.TimerChouKaReceiveIds.Contains(i))
            //    {
            //        validids.Add(i);
            //        weights.Add(ConfigHelper.TimerChouKaRewardList[i].Weight);
            //    }
            //}
            //int index = RandomHelper.RandomByWeight(weights);
            //int recvid = validids[index];

            int recvid = activityComponent.TimerChouKaReceiveIndex;
            string getitem = ConfigHelper.TimerChouKaRewardList[recvid].ItemInfo;
            bagComponent.OnAddItemData(getitem, $"{ItemGetWay.ChouKa}_{TimeHelper.ServerNow()}");
            activityComponent.TimerChouKaReceiveIndex++;
            activityComponent.LastTimerChouKaPassTime = 0;


            response.LastTimerChouKaPassTime = activityComponent.LastTimerChouKaPassTime;
            response.TimerChouKaReceiveIndex = activityComponent.TimerChouKaReceiveIndex;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
