using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2R_IOSPayVerifyHandler : AMActorRpcHandler<Scene, C2R_IOSPayVerifyRequest, R2C_IOSPayVerifyResponse>
    {

        protected override async ETTask Run(Scene scene, C2R_IOSPayVerifyRequest request, R2C_IOSPayVerifyResponse response, Action reply)
        {


            reply();
            await ETTask.CompletedTask;
        }
    }
}
