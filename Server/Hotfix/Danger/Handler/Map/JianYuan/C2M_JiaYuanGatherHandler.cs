using System;


namespace ET
{
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
            response.Error = JiaYuanHelper.GetShouHuoItem(jiaYuanPlan);
            if (response.Error == ErrorCore.ERR_Success)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
                JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
                unit.GetComponent<BagComponent>().OnAddItemData($"{jiaYuanFarmConfig.GetItemID};1",$"{ItemGetWay.JiaYuan}_{TimeHelper.ServerNow()}");

                jiaYuanPlan.GatherNumber += 1;
                jiaYuanPlan.GatherLastTime = TimeHelper.ServerNow();
            }
            response.JiaYuanPlant = jiaYuanPlan;    
            reply();
            await ETTask.CompletedTask;
        }
    }
}
