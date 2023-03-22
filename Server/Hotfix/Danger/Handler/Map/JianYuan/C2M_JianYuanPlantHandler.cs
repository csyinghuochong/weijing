using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JianYuanPlantHandler : AMActorLocationRpcHandler<Unit, C2M_JianYuanPlantRequest, M2C_JianYuanPlantResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JianYuanPlantRequest request, M2C_JianYuanPlantResponse response, Action reply)
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
            jianYuanComponent.JianYuanPlants.Add( new JianYuanPlant() { 
                CellIndex = request.CellIndex,
                ItemId = request.ItemId ,
                StartTime = TimeHelper.ServerNow()
            } );

            response.PlantItem = jianYuanComponent.JianYuanPlants;
            reply();
            await ETTask.CompletedTask;
        }
    }
}
