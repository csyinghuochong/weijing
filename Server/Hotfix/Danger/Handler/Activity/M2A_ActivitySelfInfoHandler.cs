using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_ActivitySelfInfoHandler : AMActorRpcHandler<Scene, M2A_ActivitySelfInfo, A2M_ActivitySelfInfo>
    {
        protected override async ETTask Run(Scene scene, M2A_ActivitySelfInfo request, A2M_ActivitySelfInfo response, Action reply)
        {
            List<int> guessIds = new List<int>();
            List<int> lastGuessRewatd = new List<int>();
            DBDayActivityInfo dBDayActivityInfo = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo;
            Dictionary<int, List<long>> guessplayers = dBDayActivityInfo.GuessPlayerList;
            Dictionary<int, List<long>> guessRewards = dBDayActivityInfo.GuessRewardList;

            foreach ( ( int guessindex, List<long> players  ) in guessplayers)
            {
                if (players.Contains(request.UnitId))
                {
                    guessIds.Add( guessindex );  //当前竞猜id(0,1,2,3,4,5)
                }
            }
            foreach ((int guessindex, List<long> players) in guessRewards)
            {
                if (players.Contains(request.UnitId))
                {
                    lastGuessRewatd.Add(guessindex);  //竞猜历史获奖时间断(0, 14, 18 , 21)
                }
            }


            response.GuessIds = guessIds;
            response.LastGuessReward = lastGuessRewatd;   
            reply();
            await ETTask.CompletedTask;
        }
    }
}
