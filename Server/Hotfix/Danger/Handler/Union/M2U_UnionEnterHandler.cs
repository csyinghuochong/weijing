using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [ActorMessageHandler]
    public class M2U_UnionEnterHandler : AMActorRpcHandler<Scene, M2U_UnionEnterRequest, U2M_UnionEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionEnterRequest request, U2M_UnionEnterResponse response, Action reply)
        {
            response.FubenInstanceId = scene.GetComponent<UnionSceneComponent>().GetUnionFubenId( request.MasterId, request.UnitId );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
