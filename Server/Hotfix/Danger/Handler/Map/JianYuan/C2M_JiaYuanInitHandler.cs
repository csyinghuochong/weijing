using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanInitHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanInitRequest, M2C_JiaYuanInitResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanInitRequest request, M2C_JiaYuanInitResponse response, Action reply)
        {
            response.PlantList = unit.GetComponent<JiaYuanComponent>().JianYuanPlantList_1;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
