using System;

namespace ET
{

    [ActorMessageHandler]
    public class G2Union_EnterUnionHandler : AMActorRpcHandler<Scene, G2Union_EnterUnion, Union2G_EnterUnion>
    {
        protected override async ETTask Run(Scene scene, G2Union_EnterUnion request, Union2G_EnterUnion response, Action reply)
        {
            UnionSceneComponent rankSceneComponent = scene.GetComponent<UnionSceneComponent>();
            response.DonationRankId = rankSceneComponent.GetDonationRank(request.UnitId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
