using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanMysteryListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanMysteryListRequest, M2C_JiaYuanMysteryListResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanMysteryListRequest request, M2C_JiaYuanMysteryListResponse response, Action reply)
        {
            response.MysteryItemInfos = unit.GetComponent<JiaYuanComponent>().MysteryItems;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
