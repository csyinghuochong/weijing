using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class M2U_UnionTransferHandler : AMActorRpcHandler<Scene, M2U_UnionTransferRequest, U2M_UnionTransferResponse>
    {
        protected override async ETTask Run(Scene scene, M2U_UnionTransferRequest request, U2M_UnionTransferResponse response, Action reply)
        {
            DBUnionInfo dBUnionInfo = await DBHelper.GetComponentCache<DBUnionInfo>(scene.DomainZone(), request.UnionId );
            if (dBUnionInfo == null)
            {
                response.Error = ErrorCore.ERR_Union_Not_Exist;
                reply();
                return;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
