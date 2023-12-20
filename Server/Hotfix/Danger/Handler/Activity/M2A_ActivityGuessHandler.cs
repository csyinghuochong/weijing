using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_ActivityGuessHandler : AMActorRpcHandler<Scene, M2A_ActivityGuessRequest, A2M_ActivityGuessResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_ActivityGuessRequest request, A2M_ActivityGuessResponse response, Action reply)
        {
            Dictionary<int, List<long>> guessplayers = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.GuessPlayerList;

            if (!guessplayers.ContainsKey(request.GuessId))
            {
                guessplayers.Add(request.GuessId, new List<long>());
            }

            if (!guessplayers[request.GuessId].Contains(request.UnitId))
            {
                guessplayers[request.GuessId].Add(request.UnitId);
            }
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
