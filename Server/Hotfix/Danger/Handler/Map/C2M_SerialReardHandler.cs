using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_SerialReardHandler : AMActorLocationRpcHandler<Unit, C2M_SerialReardRequest, M2C_SerialReardResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_SerialReardRequest request, M2C_SerialReardResponse response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}
