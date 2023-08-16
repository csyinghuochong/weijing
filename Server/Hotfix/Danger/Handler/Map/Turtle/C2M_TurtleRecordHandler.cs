using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TurtleRecordHandler : AMActorLocationRpcHandler<Unit, C2M_TurtleRecordRequest, M2C_TurtleRecordResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TurtleRecordRequest request, M2C_TurtleRecordResponse response, Action reply)
        {
            response.WinTimes = new List<int>() {2,0,1 };    

            reply();
            await ETTask.CompletedTask;
        }
    }
}
