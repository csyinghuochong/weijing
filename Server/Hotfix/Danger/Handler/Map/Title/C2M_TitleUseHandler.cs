using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TitleUseHandler : AMActorLocationRpcHandler<Unit, C2M_TitleUseRequest, M2C_TitleUseResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TitleUseRequest request, M2C_TitleUseResponse response, Action reply)
        {
            if (!unit.GetComponent<TitleComponent>().IsHaveTitle(request.TitleId))
            {
                response.Error = ErrorCore.ERR_TitleNoActived;
                reply();
                return;
            }

            unit.GetComponent<NumericComponent>().ApplyValue(NumericType.TitleID, request.TitleId);
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit,true, true);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
