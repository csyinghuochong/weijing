using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_ItemQiangHuaHandler : AMActorLocationRpcHandler<Unit, C2M_ItemQiangHuaRequest, M2C_ItemQiangHuaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_ItemQiangHuaRequest request, M2C_ItemQiangHuaResponse response, Action reply)
        {
            int maxLevel = QiangHuaHelper.GetQiangHuaMaxLevel(request.WeiZhi);
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (bagComponent.QiangHuaLevel[request.WeiZhi] >= maxLevel - 1)
            {
                reply();
                return;
            }
            
            EquipQiangHuaConfig equipQiangHuaConfig =QiangHuaHelper.GetQiangHuaConfig(request.WeiZhi, bagComponent.QiangHuaLevel[request.WeiZhi]);
            string costItems = equipQiangHuaConfig.CostItem;
            costItems += $"@1;{equipQiangHuaConfig.CostGold}";
            bagComponent.OnCostItemData(costItems);
            double addPro = equipQiangHuaConfig.AdditionPro * bagComponent.QiangHuaFails[request.WeiZhi];
            if ((float)equipQiangHuaConfig.SuccessPro + addPro >= RandomHelper.RandFloat01())
            {
                bagComponent.QiangHuaLevel[request.WeiZhi]++;
                bagComponent.QiangHuaFails[request.WeiZhi]=0;
            }
            else
            {
                bagComponent.QiangHuaFails[request.WeiZhi]++;
            }
            response.QiangHuaLevel = bagComponent.QiangHuaLevel[request.WeiZhi];
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
