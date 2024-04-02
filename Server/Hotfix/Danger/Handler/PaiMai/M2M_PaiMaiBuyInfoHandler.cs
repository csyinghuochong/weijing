using Alipay.AopSdk.F2FPay.Business;
using System;


namespace ET
{
    
    [ActorMessageHandler]
    public class M2M_PaiMaiBuyInfoHandler: AMActorLocationRpcHandler<Unit, M2M_PaiMaiBuyInfoRequest, M2M_PaiMaiBuyInfoResponse>
    {
        protected override async ETTask Run(Unit unit, M2M_PaiMaiBuyInfoRequest request, M2M_PaiMaiBuyInfoResponse response, Action reply)
        {
            unit.GetComponent<DataCollationComponent>().UpdateBuySelfPlayerList( request.CostGold,request.PlayerId, true );

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.PaiMaiTodayGold, unit.GetComponent<DataCollationComponent>().PaiMaiTodayGold, true);

            await ETTask.CompletedTask;
        }
    }
}