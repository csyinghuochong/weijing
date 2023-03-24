using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanUprootHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanUprootRequest, M2C_JiaYuanUprootResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanUprootRequest request, M2C_JiaYuanUprootResponse response, Action reply)
        {
            unit.GetComponent<JiaYuanComponent>().UprootPlant(request.CellIndex);

            M2C_JiaYuanUprootMessage m2C_JiaYuanGatherMessage = new M2C_JiaYuanUprootMessage();
            m2C_JiaYuanGatherMessage.UnitId = unit.Id;
            m2C_JiaYuanGatherMessage.CellIndex = request.CellIndex;
            MessageHelper.SendToClient(unit, m2C_JiaYuanGatherMessage);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
