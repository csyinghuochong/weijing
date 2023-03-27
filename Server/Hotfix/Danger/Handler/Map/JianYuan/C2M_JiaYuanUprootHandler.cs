using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanUprootHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanUprootRequest, M2C_JiaYuanUprootResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanUprootRequest request, M2C_JiaYuanUprootResponse response, Action reply)
        {
            unit.GetComponent<JiaYuanComponent>().UprootPlant(request.CellIndex);

            Unit plan =  unit.GetParent<UnitComponent>().Get(request.UnitId);
            if (plan != null)
            {
                unit.GetParent<UnitComponent>().Remove(request.UnitId);
            }
         
            reply();
            await ETTask.CompletedTask;
        }
    }
}
