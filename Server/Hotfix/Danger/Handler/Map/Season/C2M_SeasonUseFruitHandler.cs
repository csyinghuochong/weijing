using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_SeasonUseFruitHandler : AMActorLocationRpcHandler<Unit, C2M_SeasonUseFruitRequest, M2C_SeasonUseFruitResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_SeasonUseFruitRequest request, M2C_SeasonUseFruitResponse response, Action reply)
        {
            unit.GetComponent<NumericComponent>().ApplyChange( null, NumericType.SeasonBossRefreshTime, -1000, 0 );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
