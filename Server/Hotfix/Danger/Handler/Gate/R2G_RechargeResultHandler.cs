using System;

namespace ET
{

    [ActorMessageHandler]
    public class R2G_RechargeResultHandler : AMActorRpcHandler<Scene, R2G_RechargeResultRequest, G2R_RechargeResultResponse>
    {
        protected override async ETTask Run(Scene scene, R2G_RechargeResultRequest request, G2R_RechargeResultResponse response, Action reply)
        {
            RechargeHelp.OnPaySucessToUnit(scene, request.UserID, request.RechargeNumber).Coroutine();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
