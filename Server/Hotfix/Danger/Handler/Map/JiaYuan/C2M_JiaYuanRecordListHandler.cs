using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]

    public class C2M_JiaYuanRecordListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanRecordListRequest, M2C_JiaYuanRecordListResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanRecordListRequest request, M2C_JiaYuanRecordListResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
            response.JiaYuanRecordList = jiaYuanComponent.JiaYuanRecordList_1;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
