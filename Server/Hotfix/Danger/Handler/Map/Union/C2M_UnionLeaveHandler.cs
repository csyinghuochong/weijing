using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_UnionLeaveHandler : AMActorLocationRpcHandler<Unit, C2M_UnionLeaveRequest, M2C_UnionLeaveResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_UnionLeaveRequest request, M2C_UnionLeaveResponse response, Action reply)
        {
            long dbCacheId = DBHelper.GetUnionServerId(unit.DomainZone());
            UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
            U2M_UnionLeaveResponse d2GGetUnit = (U2M_UnionLeaveResponse)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2U_UnionLeaveRequest()
            {
                UnionId = userInfoComponent.UserInfo.UnionId,
                UserId = userInfoComponent.UserInfo.UserId,
            });

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionLeader, 0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Union, "0").Coroutine();
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.UnionName, "").Coroutine();
            unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.UnionName, "");
            reply();
            await ETTask.CompletedTask;
        }
    }
}
