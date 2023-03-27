using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanPlantHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanPlantRequest, M2C_JiaYuanPlantResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanPlantRequest request, M2C_JiaYuanPlantResponse response, Action reply)
        {
            JiaYuanComponent jianYuanComponent = unit.GetComponent<JiaYuanComponent>();
            if (jianYuanComponent.GetCellPlant(request.CellIndex)!=null)
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
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(request.ItemId);
            JiaYuanPlant jiaYuanPlant = new JiaYuanPlant()
            {
                CellIndex = request.CellIndex,
                ItemId = int.Parse(itemConfig.ItemUsePar),
                StartTime = TimeHelper.ServerNow()
            };

            jianYuanComponent.JianYuanPlantList.Add(jiaYuanPlant);
            Unit plan = UnitFactory.CreatePlan( unit.DomainScene(), jiaYuanPlant, unit.Id);
            jiaYuanPlant.UnitId = plan.Id;
            response.PlantItem = jiaYuanPlant;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
