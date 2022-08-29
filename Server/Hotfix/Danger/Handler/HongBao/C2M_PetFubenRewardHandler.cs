using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_HongBaoOpenRequestHandler : AMActorLocationRpcHandler<Unit, C2M_HongBaoOpenRequest, M2C_HongBaoOpenResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_HongBaoOpenRequest request, M2C_HongBaoOpenResponse response, Action reply)
        {
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.HongBao) == 0)
            {
                int hongbaoAmount = RandomHelper.RandomNumber(1, 100);
                unit.GetComponent<NumericComponent>().ApplyValue(NumericType.HongBao, 1);
                unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Gold, hongbaoAmount.ToString()).Coroutine();
                response.HongbaoAmount = hongbaoAmount;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
