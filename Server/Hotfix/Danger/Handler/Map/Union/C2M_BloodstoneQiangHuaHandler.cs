using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_BloodstoneQiangHuaHandler: AMActorLocationRpcHandler<Unit, C2M_BloodstoneQiangHuaRequest, M2C_BloodstoneQiangHuaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_BloodstoneQiangHuaRequest request, M2C_BloodstoneQiangHuaResponse response, Action reply)
        {
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            PublicQiangHuaConfig publicQiangHuaConfig = PublicQiangHuaConfigCategory.Instance.Get(numericComponent.GetAsInt(NumericType.Bloodstone));

            if (publicQiangHuaConfig.NextID == 0)
            {
                response.Error = ErrorCode.ERR_UnionXiuLianMax;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Lv < publicQiangHuaConfig.UpLvLimit)
            {
                response.Error = ErrorCode.ERR_LvNoHigh;
                reply();
                return;
            }

            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            string costItems = publicQiangHuaConfig.CostItem;
            costItems += $"@1;{publicQiangHuaConfig.CostGold}";
            if (!bagComponent.OnCostItemData(costItems))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            int level = 0;
            double addPro = publicQiangHuaConfig.AdditionPro * numericComponent.GetAsInt(NumericType.BloodstoneFail);
            if ((float)publicQiangHuaConfig.SuccessPro + addPro >= RandomHelper.RandFloat01())
            {
                level = publicQiangHuaConfig.NextID;
                numericComponent.ApplyValue(NumericType.Bloodstone, level);
                numericComponent.ApplyValue(NumericType.BloodstoneFail, 0);
            }
            else
            {
                level = publicQiangHuaConfig.Id;
                numericComponent.ApplyChange(null, NumericType.BloodstoneFail, 1, 0);
            }

            response.Level = level;
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

            reply();
            await ETTask.CompletedTask;
        }
    }
}