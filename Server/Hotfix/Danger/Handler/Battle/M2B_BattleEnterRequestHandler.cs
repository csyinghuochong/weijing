using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2B_BattleEnterRequestHandler : AMActorRpcHandler<Scene, M2B_BattleEnterRequest, B2M_BattleEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2B_BattleEnterRequest request, B2M_BattleEnterResponse response, Action reply)
        {
            (long fubeninstanceid, int camp)  = scene.GetComponent<BattleSceneComponent>().GetBattleInstanceId(request.UserID, request.SceneId);
            response.FubenInstanceId = fubeninstanceid;
            response.Camp = camp;


            reply();
            await ETTask.CompletedTask;
        }
    }
}
