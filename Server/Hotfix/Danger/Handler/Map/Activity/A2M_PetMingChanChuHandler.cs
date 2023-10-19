using System;

namespace ET
{

    [ActorMessageHandler]
    public class A2M_PetMingChanChuHandler : AMActorRpcHandler<Unit, A2M_PetMingChanChuRequest, M2A_PetMingChanChuResponse>
    {
        protected override async ETTask Run(Unit unit, A2M_PetMingChanChuRequest request, M2A_PetMingChanChuResponse response, Action reply)
        {
            unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, request.ChanChu.ToString());
            reply();
            await ETTask.CompletedTask;
        }
    }
}
