using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_GuideUpdateHandler : AMActorLocationRpcHandler<Unit, C2M_GuideUpdateRequest, M2C_GuideUpdateResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_GuideUpdateRequest request, M2C_GuideUpdateResponse response, Action reply)
        { 
            await ETTask.CompletedTask;
            unit.GetComponent<UserInfoComponent>().UserInfo.CompleteGuideIds.Add(request.GuideId);
            reply();
        }
    }
}
