using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JianYuanPlantHandler : AMActorLocationRpcHandler<Unit, C2M_JianYuanPlantRequest, M2C_JianYuanPlantResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JianYuanPlantRequest request, M2C_JianYuanPlantResponse response, Action reply)
        {
            reply();
            await ETTask.CompletedTask;
        }
    }
}
