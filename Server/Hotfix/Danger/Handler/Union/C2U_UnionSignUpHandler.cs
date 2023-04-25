using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2U_UnionSignUpHandler : AMActorRpcHandler<Scene, C2U_UnionSignUpRequest, U2C_UnionSignUpResponse>
    {
        protected override async ETTask Run(Scene scene, C2U_UnionSignUpRequest request, U2C_UnionSignUpResponse response, Action reply)
        {
            UnionSceneComponent rankComponent = scene.GetComponent<UnionSceneComponent>();
            if (!rankComponent.DBUnionManager.SignupUnions.Contains(request.UnionId))
            {
                rankComponent.DBUnionManager.SignupUnions.Add(request.UnionId);
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
