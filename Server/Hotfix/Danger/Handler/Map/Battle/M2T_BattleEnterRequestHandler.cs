using System;

namespace ET
{
    [ActorMessageHandler]
    public class M2T_BattleEnterRequestHandler : AMActorRpcHandler<Scene, M2T_BattleEnterRequest, T2M_BattleEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2T_BattleEnterRequest request, T2M_BattleEnterResponse response, Action reply)
        {
            

            reply();
            await ETTask.CompletedTask;
        }
    }
}
