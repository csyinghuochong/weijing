using System;

namespace ET
{

    [ActorMessageHandler]
    public class U2M_UnionApplyHandler : AMActorRpcHandler<Unit, U2M_UnionApplyRequest, M2U_UnionApplyResponse>
    {
        protected override async ETTask Run(Unit unit, U2M_UnionApplyRequest request, M2U_UnionApplyResponse response, Action reply)
        {
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionLeader, 0);
            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.UnionId_0, request.UnionId);
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.UnionName, request.UnionName);
            unit.GetComponent<UserInfoComponent>().UpdateRoleDataBroadcast(UserDataType.UnionName, request.UnionName);
            unit.GetComponent<TaskComponent>().TriggerTaskEvent(TaskTargetType.JoinUnion_9, 0, 1);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
