using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2Arena_ArenaEnterHandler : AMActorRpcHandler<Scene, M2Arena_ArenaEnterRequest, Arena2M_ArenaEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2Arena_ArenaEnterRequest request, Arena2M_ArenaEnterResponse response, Action reply)
        {
            BattleInfo battleInfo = scene.GetComponent<BattleSceneComponent>().GetBattleInstanceId(request.SceneId);
            battleInfo.PlayerNumber++;
            response.FubenInstanceId = battleInfo.FubenInstanceId;
           
            reply();
            await ETTask.CompletedTask;
        }
    }
}
