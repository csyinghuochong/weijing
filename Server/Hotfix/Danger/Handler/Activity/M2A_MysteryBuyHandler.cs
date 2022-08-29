using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2A_MysteryBuyHandler : AMActorRpcHandler<Scene, M2A_MysteryBuyRequest, A2M_MysteryBuyResponse>
    {
        protected override async ETTask Run(Scene scene, M2A_MysteryBuyRequest request, A2M_MysteryBuyResponse response, Action reply)
        {
            response.Error = scene.GetComponent<ActivitySceneComponent>().OnMysteryBuyRequest(request.MysteryItemInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
