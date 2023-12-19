using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ActivityChouKaHandler : AMActorLocationRpcHandler<Unit, C2M_ActivityChouKaRequest, M2C_ActivityChouKaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ActivityChouKaRequest request, M2C_ActivityChouKaResponse response, Action reply)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetLeftSpace() < 1)
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }
            if (!bagComponent.CheckCostItem(ActivityConfigHelper.ChouKaCostItem))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyChange( null,NumericType.V1ChouKaNumber, 1, 0 );

            reply();
            await ETTask.CompletedTask;
        }
    }
}
