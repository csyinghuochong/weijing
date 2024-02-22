using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2B_BattleEnterRequestHandler : AMActorRpcHandler<Scene, M2B_BattleEnterRequest, B2M_BattleEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2B_BattleEnterRequest request, B2M_BattleEnterResponse response, Action reply)
        {
            KeyValuePairInt keyValuePairInt  = scene.GetComponent<BattleSceneComponent>().GetBattleInstanceId(request.UserID, request.SceneId);
            if (keyValuePairInt != null)
            {
                response.FubenInstanceId = keyValuePairInt.Value;
                response.Camp = keyValuePairInt.KeyId;
                reply();
            }
            else
            {
                using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Battle, scene.DomainZone()))
                {
                    keyValuePairInt = await scene.GetComponent<BattleSceneComponent>().GenerateBattleInstanceId(request.UserID, request.SceneId);
                    if (keyValuePairInt != null)
                    {
                        response.FubenInstanceId = keyValuePairInt.Value;
                        response.Camp = keyValuePairInt.KeyId;
                    }
                }
                reply();
            }
           
            await ETTask.CompletedTask;
        }
    }
}
