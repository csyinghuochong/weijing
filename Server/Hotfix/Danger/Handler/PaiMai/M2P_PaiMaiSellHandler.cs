using System;

namespace ET
{

    [ActorMessageHandler]
    public class M2P_PaiMaiSellHandler : AMActorRpcHandler<Scene, M2P_PaiMaiSellRequest, P2M_PaiMaiSellResponse>
    {

        protected override async ETTask Run(Scene scene, M2P_PaiMaiSellRequest request, P2M_PaiMaiSellResponse response, Action reply)
        {
            scene.GetComponent<PaiMaiSceneComponent>().dBPaiMainInfo.PaiMaiItemInfos.Add(request.PaiMaiItemInfo);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
