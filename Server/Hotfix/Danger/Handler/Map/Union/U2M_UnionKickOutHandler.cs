using System;

namespace ET
{

    [ActorMessageHandler]
    public class U2M_UnionKickOutHandler : AMActorRpcHandler<Unit, U2M_UnionKickOutRequest, M2U_UnionKickOutResponse>
    {
        protected override async ETTask Run(Unit unit, U2M_UnionKickOutRequest request, M2U_UnionKickOutResponse response, Action reply)
        {
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionLeader,0);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Union, "0").Coroutine();
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.UnionName, "").Coroutine();
            unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.UnionName, "");

            reply();
            await ETTask.CompletedTask;
        }
    }
}
