using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class M2Center_SerialQueryHandler : AMActorRpcHandler<Scene, M2Center_SerialQueryRequest, Center2M_SerialQueryResponse>
    {
        protected override async ETTask Run(Scene scene, M2Center_SerialQueryRequest request, Center2M_SerialQueryResponse response, Action reply)
        {
            AccountCenterComponent accountCenterComponent = scene.GetComponent<AccountCenterComponent>();
            (int , int) itemvalue = accountCenterComponent.GetSerialKeyId(request.SerialNumber);
            response.SerialIndex = itemvalue.Item1;
            response.IsRewarded = itemvalue.Item2;

            reply();
            await ETTask.CompletedTask;
        }
    }
}