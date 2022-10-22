using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2B_BattleEnterRequestHandler : AMActorRpcHandler<Scene, M2B_BattleEnterRequest, B2M_BattleEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2B_BattleEnterRequest request, B2M_BattleEnterResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
