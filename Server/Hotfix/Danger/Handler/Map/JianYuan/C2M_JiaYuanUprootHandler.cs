using System;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_JiaYuanUprootHandler : AMActorLocationRpcHandler<Unit, C2M_JiaYuanUprootRequest, M2C_JiaYuanUprootResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_JiaYuanUprootRequest request, M2C_JiaYuanUprootResponse response, Action reply)
        {
            Unit unitPlan = unit.GetParent<UnitComponent>().Get(request.UnitId);
            if (unitPlan == null)
            {
                reply();
                return;
            }
           
            switch (request.OperateType)
            {
                case 1:
                    unit.GetComponent<JiaYuanComponent>().UprootPlant(request.CellIndex);
                    break;
                case 2:
                    JiaYuanPastureConfig jiaYuanPastureConfig = JiaYuanPastureConfigCategory.Instance.Get(unitPlan.ConfigId);
                    unit.GetComponent<BagComponent>().OnAddItemData($"13;{jiaYuanPastureConfig.SellGold}", $"{ItemGetWay.JiaYuan}_{TimeHelper.ServerFrameTime()}");
                    unit.GetComponent<JiaYuanComponent>().UprootPasture(request.UnitId);
                    break;
            }

            unit.GetParent<UnitComponent>().Remove(request.UnitId);

            reply();
            await ETTask.CompletedTask;
        }
    }
}
