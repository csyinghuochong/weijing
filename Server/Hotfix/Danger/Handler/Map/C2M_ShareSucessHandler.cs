using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_ShareSucessHandler : AMActorLocationRpcHandler<Unit, C2M_ShareSucessRequest, M2C_ShareSucessResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ShareSucessRequest request, M2C_ShareSucessResponse response, Action reply)
        {
            if (request.ShareType != 1 && request.ShareType != 2)
            {
                reply();
                return;
            }
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            long shareSet = numericComponent.GetAsLong(NumericType.FenShangSet);
            if ((shareSet & request.ShareType) > 0)
            {
                reply();
                return;
            }
            shareSet = shareSet | (long)request.ShareType;
            numericComponent.ApplyValue(NumericType.FenShangSet, shareSet);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
