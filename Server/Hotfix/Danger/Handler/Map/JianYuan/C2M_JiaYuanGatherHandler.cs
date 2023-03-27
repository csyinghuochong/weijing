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

            JiaYuanPlant jiaYuanPlan = unit.GetComponent<JiaYuanComponent>().GetCellPlant(request.CellIndex);
            response.Error = JiaYuanHelper.GetShouHuoItem(jiaYuanPlan.ItemId, jiaYuanPlan.StartTime, jiaYuanPlan.GatherNumber, jiaYuanPlan.GatherLastTime);
            if (response.Error != ErrorCore.ERR_Success)
            {
                reply();
                return;
            }

            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            unit.GetComponent<BagComponent>().OnAddItemData($"{jiaYuanFarmConfig.GetItemID};1", $"{ItemGetWay.JiaYuan}_{TimeHelper.ServerNow()}");

            jiaYuanPlan.GatherNumber += 1;
            jiaYuanPlan.GatherLastTime = TimeHelper.ServerNow();
            response.PlantItem = jiaYuanPlan;

            M2C_JiaYuanGatherMessage m2C_JiaYuanGatherMessage = new M2C_JiaYuanGatherMessage();
            m2C_JiaYuanGatherMessage.UnitId = unit.Id;
            m2C_JiaYuanGatherMessage.PlantItem = jiaYuanPlan;
            MessageHelper.SendToClient( unit, m2C_JiaYuanGatherMessage);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
