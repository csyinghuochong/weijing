using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2A_PetMingListHandler : AMActorRpcHandler<Scene, C2A_PetMingListRequest, A2C_PetMingListResponse>
    {
        protected override async ETTask Run(Scene scene, C2A_PetMingListRequest request, A2C_PetMingListResponse response, Action reply)
        {
            List<KeyValuePairInt> minglist = scene.GetComponent<ActivitySceneComponent>().DBDayActivityInfo.PetMingList;



            reply();
            await ETTask.CompletedTask;
        }
    }
}
