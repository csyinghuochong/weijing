using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_JiaYuanWatchHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanWatchRequest, M2C_JiaYuanWatchResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanWatchRequest request, M2C_JiaYuanWatchResponse response, Action reply)
        {
            Unit boxUnit = unit.GetParent<UnitComponent>().Get(request.OperateId);
            if (boxUnit == null)
            {
                response.Error = ErrorCore.ERR_PlantNotExist;
                reply();
                return;
            }
            if (boxUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                response.Error = ErrorCore.ERR_PlantNotExist;
                reply();
                return;
            }

            if (unit.Id == request.MasterId)
            {
                JiaYuanComponent jiaYuanComponent = unit.GetComponent<JiaYuanComponent>();
                JiaYuanPlant jiaYuanPlant = jiaYuanComponent.GetJiaYuanPlant(request.OperateId);

                response.JiaYuanRecord = jiaYuanPlant.GatherRecord;
            }
            else
            {
                JiaYuanComponent jiaYuanComponent_2 = await DBHelper.GetComponentCache<JiaYuanComponent>(unit.DomainZone(), request.MasterId);
                JiaYuanPlant jiaYuanPlant_2 = jiaYuanComponent_2.GetJiaYuanPlant(request.OperateId);

                response.JiaYuanRecord = jiaYuanPlant_2.GatherRecord;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}
