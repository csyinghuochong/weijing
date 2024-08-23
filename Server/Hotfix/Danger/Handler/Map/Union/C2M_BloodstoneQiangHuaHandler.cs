using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_BloodstoneQiangHuaHandler: AMActorLocationRpcHandler<Unit, C2M_BloodstoneQiangHuaRequest, M2C_BloodstoneQiangHuaResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_BloodstoneQiangHuaRequest request, M2C_BloodstoneQiangHuaResponse response, Action reply)
        {
           
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            if (!PublicQiangHuaConfigCategory.Instance.Contain(numericComponent.GetAsInt(request.QiangHuaType)))
            {
                Console.WriteLine($"C2M_BloodstoneQiangHuaError: {request.QiangHuaType}   {numericComponent.GetAsInt(request.QiangHuaType)}");
                reply();
                return;
            }

            PublicQiangHuaConfig publicQiangHuaConfig = PublicQiangHuaConfigCategory.Instance.Get(numericComponent.GetAsInt(request.QiangHuaType));

            if (publicQiangHuaConfig.NextID == 0)
            {
                response.Error = ErrorCode.ERR_UnionXiuLianMax;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Lv < 60)
            {
                response.Error = ErrorCode.ERR_LevelIsNot;
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
            if (!bagComponent.OnCostItemData(costItems, ItemLocType.ItemLocBag, ItemGetWay.UnionXiuLian ))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }

            int level = 0;

            int failType = 0;
            switch (request.QiangHuaType)
            {
                case NumericType.Bloodstone:
                    failType = NumericType.BloodstoneFail;
                    break;
                case NumericType.UnionAttribute_1:
                    failType = NumericType.UnionAttributeFail_1;
                    break;
                case NumericType.UnionAttribute_2:
                    failType = NumericType.UnionAttributeFail_2;
                    break;
                default:
                    response.Error = ErrorCode.ERR_ModifyData;
                    reply();
                    return;
            }

            double addPro = publicQiangHuaConfig.AdditionPro * numericComponent.GetAsInt(failType);
            if ((float)publicQiangHuaConfig.SuccessPro + addPro >= RandomHelper.RandFloat01())
            {
                level = publicQiangHuaConfig.NextID;
                numericComponent.ApplyValue(request.QiangHuaType, level);
                numericComponent.ApplyValue(failType, 0);
            }
            else
            {
                level = publicQiangHuaConfig.Id;
                numericComponent.ApplyChange(null, failType, 1, 0);
            }

            response.Level = level;
            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);

            reply();
            await ETTask.CompletedTask;
        }
    }
}