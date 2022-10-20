using System;


namespace ET
{

    [ActorMessageHandler]
    public class C2M_CampRankSelectHandler : AMActorLocationRpcHandler<Unit, C2M_CampRankSelectRequest, M2C_CampRankSelectResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_CampRankSelectRequest request, M2C_CampRankSelectResponse response, Action reply)
        {
            unit.GetComponent<NumericComponent>().ApplyValue( NumericType.CampId, request.CampId );
            unit.GetComponent<UserInfoComponent>().UpdateRankInfo().Coroutine();

            reply();
            await ETTask.CompletedTask;
        }
    }
}
