using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_PetMingBattleWinHandler : AMActorRpcHandler<Scene, M2A_PetMingBattleWinRequest, A2M_PetMingBattleWinResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_PetMingBattleWinRequest request, A2M_PetMingBattleWinResponse response, Action reply)
        {
            Log.Console($"M2A_PetMingBattleWinRequest: {request}");

            List<PetMingPlayerInfo> petMingPlayerInfos = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.PetMingList;
            for (int i = petMingPlayerInfos.Count - 1; i >= 0; i--)
            {
                if (petMingPlayerInfos[i].MineType == request.MingType
                 && petMingPlayerInfos[i].Postion == request.Postion)
                {
                    petMingPlayerInfos.RemoveAt(i);
                    break;
                }
            }
            if (request.UnitID != 0)
            {
                petMingPlayerInfos.Add(new PetMingPlayerInfo()
                {
                    MineType = request.MingType,
                    Postion = request.Postion,
                    UnitId = request.UnitID,
                    TeamId = request.TeamId,
                });
            }
  
            reply();
            await ETTask.CompletedTask;
        }
    }
}
