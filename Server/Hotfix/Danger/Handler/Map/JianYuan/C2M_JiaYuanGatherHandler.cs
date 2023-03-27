using System;


namespace ET
{

    /// <summary>
    /// 家园收获
    /// </summary>
    [ActorMessageHandler]
    public class C2M_JiaYuanGatherHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanGatherRequest, M2C_JiaYuanGatherResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanGatherRequest request, M2C_JiaYuanGatherResponse response, Action reply)
        {
            if (unit.GetComponent<BagComponent>().GetLeftSpace() < 1)
            {
                response.Error = ErrorCore.ERR_BagIsFull;
                reply();
                return;
            }

            Unit unitplan = unit.GetParent<UnitComponent>().Get(request.UnitId);
            if (unitplan == null)
            {
                reply();
                return;
            }
          
            JiaYuanPlant jiaYuanPlan = unit.GetComponent<JiaYuanComponent>().GetCellPlant(request.CellIndex);
            response.Error = JiaYuanHelper.GetPlanShouHuoItem(jiaYuanPlan.ItemId, jiaYuanPlan.StartTime, jiaYuanPlan.GatherNumber, jiaYuanPlan.GatherLastTime);
            if (response.Error != ErrorCore.ERR_Success)
            {
                reply();
                return;
            }

            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(unitplan.ConfigId);
            unit.GetComponent<BagComponent>().OnAddItemData($"{jiaYuanFarmConfig.GetItemID};1", $"{ItemGetWay.JiaYuan}_{TimeHelper.ServerNow()}");


            unitplan.GetComponent<NumericComponent>().ApplyValue(NumericType.GatherLastTime, TimeHelper.ServerNow());
            unitplan.GetComponent<NumericComponent>().ApplyChange(null, NumericType.GatherNumber, 1, 0);

            jiaYuanPlan.GatherNumber += 1;
            jiaYuanPlan.GatherLastTime = TimeHelper.ServerNow();
            response.PlantItem = jiaYuanPlan;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
