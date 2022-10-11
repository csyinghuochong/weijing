using System;

namespace ET
{

    [ActorMessageHandler]
    public class G2M_RechargeRequestHandler : AMActorRpcHandler<Unit, G2M_RechargeResultRequest, M2G_RechargeResultResponse>
    {
        protected override async ETTask Run(Unit unit, G2M_RechargeResultRequest request, M2G_RechargeResultResponse response, Action reply)
        {
            RechargeHelp.SendDiamondToUnit(unit, request.RechargeNumber);
            await ETTask.CompletedTask;
            reply();
        }
    }
}
