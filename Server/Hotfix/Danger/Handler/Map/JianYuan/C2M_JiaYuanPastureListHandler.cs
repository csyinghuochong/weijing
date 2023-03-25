using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanPastureListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPastureListRequest, M2C_JiaYuanPastureListResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPastureListRequest request, M2C_JiaYuanPastureListResponse response, Action reply)
        {
            response.MysteryItemInfos = unit.GetComponent<JiaYuanComponent>().PastureItems;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
