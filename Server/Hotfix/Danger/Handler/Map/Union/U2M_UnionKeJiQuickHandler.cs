using System;

namespace ET
{
    [ActorMessageHandler]
    public class U2M_UnionKeJiQuickHandler : AMActorRpcHandler<Unit, U2M_UnionKeJiQuickRequest, M2U_UnionKeJiQuickResponse>
    {
        protected override async ETTask Run(Unit unit, U2M_UnionKeJiQuickRequest request, M2U_UnionKeJiQuickResponse response, Action reply)
        {
            if (unit.GetComponent<UserInfoComponent>().UserInfo.Diamond <= 200)
            {
                response.Error = ErrorCode.ERR_DiamondNotEnoughError;
                reply();
                return;
            }
            unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(  UserDataType.Diamond, "-200", true, ItemGetWay.UnionXiuLian );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
