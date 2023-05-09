using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionHandler : AMActorLocationRpcHandler<Unit, C2M_UnionLeaveRequest, M2C_UnionLeaveResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_UnionLeaveRequest request, M2C_UnionLeaveResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetUnionServerId(unit.DomainZone());
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();  
            U2M_UnionLeaveResponse d2GGetUnit = (U2M_UnionLeaveResponse)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2U_UnionLeaveRequest()
            {
                UnionId = numericComponent.GetAsLong(NumericType.UnionId_0),
                UserId = userInfoComponent.UserInfo.UserId,
            });

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionLeader, 0);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionId_0, 0);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionIdLeaveTime, TimeHelper.ServerNow());
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.UnionName, "");
            unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.UnionName, "");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
