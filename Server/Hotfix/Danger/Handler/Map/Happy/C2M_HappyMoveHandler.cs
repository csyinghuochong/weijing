using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_HappyMoveHandler : AMActorLocationRpcHandler<Unit, C2M_HappyMoveRequest, M2C_HappyMoveResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HappyMoveRequest request, M2C_HappyMoveResponse response, Action reply)
        {

           // int newCell = 

            reply();
            await ETTask.CompletedTask;
        }
    }
}