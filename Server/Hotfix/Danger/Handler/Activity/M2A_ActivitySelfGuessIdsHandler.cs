using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_ActivitySelfGuessIdsHandler : AMActorRpcHandler<Scene, M2A_ActivitySelfGuessIds, A2M_ActivitySelfGuessIds>
    {
        protected override async ETTask Run(Scene scene, M2A_ActivitySelfGuessIds request, A2M_ActivitySelfGuessIds response, Action reply)
        {
            List<int> guessIds = new List<int>();
            List<int> lastGuessRewatd = new List<int>();
            Dictionary<int, List<long>> guessplayers = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.GuessPlayerList;

            foreach ( ( int guessindex, List<long> players  ) in guessplayers)
            {
                if (players.Contains(request.UnitId))
                {
                    guessIds.Add( guessindex ); 
                }
            }


            response.GuessIds = guessIds;
            response.LastGuessRewatd = lastGuessRewatd;   
            reply();
            await ETTask.CompletedTask;
        }
    }
}
