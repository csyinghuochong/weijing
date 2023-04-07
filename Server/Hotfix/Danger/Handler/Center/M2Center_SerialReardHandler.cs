using System;
using System.Collections.Generic;


namespace ET
{

    [ActorMessageHandler]
    public class M2Center_SerialReardHandler : AMActorRpcHandler<Scene, M2Center_SerialReardRequest, Center2M_SerialReardResponse>
    {
        protected override async ETTask Run(Scene scene, M2Center_SerialReardRequest request, Center2M_SerialReardResponse response, Action reply)
        {
            AccountCenterComponent accountCenterComponent = scene.GetComponent<AccountCenterComponent>();
            response.Error = accountCenterComponent.GetSerialReward(request.SerialNumber);
            response.Message = accountCenterComponent.GetSerialKeyId(request.SerialNumber).ToString();

            reply();
            await ETTask.CompletedTask;
        }
    }
}