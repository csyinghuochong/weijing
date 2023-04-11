using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]

    public class C2M_JiaYuanRecordListHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanRecordListRequest, M2C_JiaYuanRecordListResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanRecordListRequest request, M2C_JiaYuanRecordListResponse response, Action reply)
        {
            JiaYuanComponent jiaYuanComponent_2 = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), unit.Id);

            response.JiaYuanRecordList.AddRange( jiaYuanComponent_2.JiaYuanRecordList_1 );
            jiaYuanComponent_2.JiaYuanRecordList_1.Clear();

            await DBHelper.SaveComponent(unit.DomainZone(), unit.Id, jiaYuanComponent_2);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
