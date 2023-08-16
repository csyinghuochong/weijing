using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_TurtleSupportHandler : AMActorLocationRpcHandler<Unit, C2M_TurtleSupportRequest, M2C_TurtleSupportResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TurtleSupportRequest request, M2C_TurtleSupportResponse response, Action reply)
        {
            //只能竞猜一次

            //扣除金币 



            reply();
            await ETTask.CompletedTask;
        }
    }
}
