using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanPlantHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPlantRequest, M2C_JiaYuanPlantResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPlantRequest request, M2C_JiaYuanPlantResponse response, Action reply)
        {
            JianYuanComponent jianYuanComponent = unit.GetComponent<JianYuanComponent>();
            if (jianYuanComponent.HavePlant(request.CellIndex))
            {
                response.Error = ErrorCore.ERR_AlreadyPlant;
                reply();
                return;
            }
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.GetItemNumber(request.ItemId) < 1)
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            bagComponent.OnCostItemData($"{request.ItemId};1");
            JiaYuanPlant jiaYuanPlant = new JiaYuanPlant()
            {
                CellIndex = request.CellIndex,
                ItemId = request.ItemId,
                StartTime = TimeHelper.ServerNow()
            };

            jianYuanComponent.JianYuanPlants.Add(jiaYuanPlant);
            response.PlantItem = jiaYuanPlant;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
