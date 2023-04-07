using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class M2Center_SerialReardHandler : AMActorRpcHandler<Scene, M2Center_SerialReardRequest, Center2M_SerialReardResponse>
    {
        protected override async ETTask Run(Scene scene, M2Center_SerialReardRequest request, Center2M_SerialReardResponse response, Action reply)
        {

            reply();
            await ETTask.CompletedTask;
        }
    }
}