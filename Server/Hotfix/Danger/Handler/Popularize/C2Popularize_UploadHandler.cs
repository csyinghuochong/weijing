using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ActorMessageHandler]
    public class C2Popularize_UploadHandler : AMActorRpcHandler<Scene, C2Popularize_UploadRequest, Popularize2C_UploadResponse>
    {
        protected override async ETTask Run(Scene scene, C2Popularize_UploadRequest request, Popularize2C_UploadResponse response, Action reply)
        {
            Log.Warning(  request.MemoryInfo );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
