using Alipay.AopSdk.Core.Domain;
using System;


namespace ET
{

    [ActorMessageHandler]
    public class M2H_HapplyEnterHandler : AMActorRpcHandler<Scene, M2H_HapplyEnterRequest, H2M_HapplyEnterResponse>
    {
        protected override async ETTask Run(Scene scene, M2H_HapplyEnterRequest request, H2M_HapplyEnterResponse response, Action reply)
        {
            HappySceneComponent happySceneComponent = scene.GetComponent<HappySceneComponent>();
           
            response.FubenInstanceId = happySceneComponent.FubenInstanceId;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
