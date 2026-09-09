using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetTupoHandler : AMActorLocationRpcHandler<Unit, C2M_PetTupoRequest, M2C_PetTupoResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetTupoRequest request, M2C_PetTupoResponse response, Action reply)
        {
            int numerType = PetTupoHelper.GetTupoNumericType(request.Position);
            if (numerType == 0)
            {
                reply();
                return;
            }

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int tupoId = numericComponent.GetAsInt(numerType);
            if (!PetTupoConfigCategory.Instance.Contain(tupoId))
            {
                reply();
                return;
            }

            PetTupoConfig petTupoConfig = PetTupoConfigCategory.Instance.Get(tupoId);
            if (petTupoConfig.NextID == 0)
            {
                response.Error = ErrorCode.ERR_PetTupoMax;
                reply();
                return;
            }

            if (petTupoConfig.UpLvLimit > 0 && unit.GetComponent<UserInfoComponent>().UserInfo.Lv < petTupoConfig.UpLvLimit)
            {
                response.Error = ErrorCode.ERR_EquipLvLimit;
                reply();
                return;
            }

            if (unit.GetComponent<UserInfoComponent>().UserInfo.Gold < petTupoConfig.CostGold)
            {
                response.Error = ErrorCode.ERR_GoldNotEnoughError;
                reply();
                return;
            }

            string costItems = petTupoConfig.CostItem;
            if (petTupoConfig.CostGold > 0)
            {
                if (ComHelp.IfNull(costItems) || costItems == "0")
                {
                    costItems = $"1;{petTupoConfig.CostGold}";
                }
                else
                {
                    costItems += $"@1;{petTupoConfig.CostGold}";
                }
            }

            if (!ComHelp.IfNull(costItems) && costItems != "0")
            {
                if (!unit.GetComponent<BagComponent>().OnCostItemData(costItems, ItemLocType.ItemLocBag, ItemGetWay.PetTupo))
                {
                    response.Error = ErrorCode.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
            }

            int failType = PetTupoHelper.GetTupoFailNumericType(request.Position);
            int failCount = numericComponent.GetAsInt(failType);
            double addPro = petTupoConfig.AdditionPro * failCount;
            if ((float)petTupoConfig.SuccessPro + addPro < RandomHelper.RandFloat01())
            {
                numericComponent.ApplyValue(failType, failCount + 1);
                response.Error = ErrorCode.ERR_PetTupoFail;
                reply();
                return;
            }

            numericComponent.ApplyValue(failType, 0);
            numericComponent.ApplyValue(numerType, petTupoConfig.NextID);

            Function_Fight.GetInstance().UnitUpdateProperty_Base(unit, true, true);
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            for (int i = petComponent.RolePetInfos.Count - 1; i >= 0; i--)
            {
                petComponent.UpdatePetAttribute(petComponent.RolePetInfos[i], false);
            }

            response.RolePetInfos = petComponent.RolePetInfos;

            reply();
            await ETTask.CompletedTask;
        }
    }
}
