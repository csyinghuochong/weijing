using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanPetPositionHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPetPositionRequest, M2C_JiaYuanPetPositionResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPetPositionRequest request, M2C_JiaYuanPetPositionResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
