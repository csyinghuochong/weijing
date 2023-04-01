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

            switch (request.OperateType)
            {
                case 1:
                    JiaYuanPlant jiaYuanPlan = unit.GetComponent<JiaYuanComponent>().GetCellPlant(request.CellIndex);
                    if (jiaYuanPlan == null)
                    {
                        Log.Error($"jiaYuanPlan == null  {unit.Id}  {request.CellIndex}");
                        reply();
                        return;
                    }

                    response.Error = JiaYuanHelper.GetPlanShouHuoItem(jiaYuanPlan.ItemId, jiaYuanPlan.StartTime, jiaYuanPlan.GatherNumber, jiaYuanPlan.GatherLastTime);
                    if (response.Error != ErrorCore.ERR_Success)
                    {
                        reply();
                        return;
                    }

                    JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(unitplan.ConfigId);
                    unit.GetComponent<BagComponent>().OnAddItemData($"{jiaYuanFarmConfig.GetItemID};1", $"{ItemGetWay.JiaYuanGather}_{TimeHelper.ServerNow()}");

                    unitplan.GetComponent<NumericComponent>().ApplyValue(NumericType.GatherLastTime, TimeHelper.ServerNow());
                    unitplan.GetComponent<NumericComponent>().ApplyChange(null, NumericType.GatherNumber, 1, 0);

                    jiaYuanPlan.GatherNumber += 1;
                    jiaYuanPlan.GatherLastTime = TimeHelper.ServerNow();

                    break;
                case 2:
                    JiaYuanPastures jiaYuanPasture = unit.GetComponent<JiaYuanComponent>().GetJiaYuanPastures(request.UnitId);
                    response.Error = JiaYuanHelper.GetPastureShouHuoItem(jiaYuanPasture.ConfigId, jiaYuanPasture.StartTime, jiaYuanPasture.GatherNumber, jiaYuanPasture.GatherLastTime);
                    if (response.Error != ErrorCore.ERR_Success)
                    {
                        reply();
                        return;
                    }

                    JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(jiaYuanPasture.ConfigId);
                    unit.GetComponent<BagComponent>().OnAddItemData($"{jiaYuanPastureConfig.GetItemID};1", $"{ItemGetWay.JiaYuanGather}_{TimeHelper.ServerNow()}");


                    unitplan.GetComponent<NumericComponent>().ApplyValue(NumericType.GatherLastTime, TimeHelper.ServerNow());
                    unitplan.GetComponent<NumericComponent>().ApplyChange(null, NumericType.GatherNumber, 1, 0);

                    jiaYuanPasture.GatherNumber += 1;
                    jiaYuanPasture.GatherLastTime = TimeHelper.ServerNow();

                    break;
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
