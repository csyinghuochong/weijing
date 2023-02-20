using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2B_BattleEnterRequestHandler : AMActorRpcHandler<Scene, M2B_BattleEnterRequest, B2M_BattleEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2B_BattleEnterRequest request, B2M_BattleEnterResponse response, Action reply)
        {
            BattleInfo battleInfo = scene.GetComponent<BattleSceneComponent>().GetBattleInstanceId(request.SceneId);
            battleInfo.PlayerNumber++;
            response.FubenInstanceId = battleInfo.FubenInstanceId;
            response.Camp = battleInfo.PlayerNumber % 2 + 1;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
