using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class M2A_PetMingPlayerInfoHandler : AMActorRpcHandler<Scene, M2A_PetMingPlayerInfoRequest, A2M_PetMingPlayerInfoResponse>
    {

        protected override async ETTask Run(Scene scene, M2A_PetMingPlayerInfoRequest request, A2M_PetMingPlayerInfoResponse response, Action reply)
        {
            List<PetMingPlayerInfo> petMingPlayerInfos = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.PetMingList;
            for (int i = 0; i < petMingPlayerInfos.Count; i++)
            {
                if (petMingPlayerInfos[i].MineType == request.MingType
                 && petMingPlayerInfos[i].Postion == request.Postion)
                { 
                    response.PetMingPlayerInfo = petMingPlayerInfos[i]; 
                }
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
