using System;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_RolePetChouKaHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetChouKaRequest, M2C_RolePetChouKaResponse>
    {

        protected override async ETTask Run(Unit unit, C2M_RolePetChouKaRequest request, M2C_RolePetChouKaResponse response, Action reply)
        {
            if (request.ChouKaType == 1)
            {
                string needItems = GlobalValueConfigCategory.Instance.Get(16).Value;
                bool  sucess = unit.GetComponent<BagComponent>().OnCostItemData(needItems);
                if (!sucess)
                {
                    response.Error = ErrorCore.ERR_ItemNotEnoughError;
                    reply();
                    return;
                }
            }
            else if(request.ChouKaType == 2)
            {
                int choukaTim = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.PetChouKa);
                if (choukaTim >= 20)
                {
                    reply();
                    return;
                }
                UserInfo userInfo = unit.GetComponent<UserInfoComponent>().UserInfo;
                int needDimanond = int.Parse(GlobalValueConfigCategory.Instance.Get(17).Value);
                if (userInfo.Diamond < needDimanond)
                {
                    response.Error = ErrorCore.ERR_DiamondNotEnoughError;
                    reply();
                    return;
                }
                unit.GetComponent<UserInfoComponent>().UpdateRoleMoneySub(UserDataType.Diamond, (-1 * needDimanond).ToString(), true,ItemGetWay.ChouKa);
                unit.GetComponent<NumericComponent>().ApplyChange(null, NumericType.PetChouKa, 1, 0);
            }

            List<int> petList = new List<int>() { 1000101, 1000201, 1000301 };

            float rand = RandomHelper.RandFloat();
            bool randStatus = false;
            if (rand <= 0.55 && !randStatus)
            {
                petList = new List<int>() { 1000101, 1000201, 1000301 };
                randStatus = true;
            }
            if (rand <= 0.8 && !randStatus)
            {
                petList = new List<int>() { 1000201, 1000301, 1000401 };
                randStatus = true;
            }
            if (rand <= 0.94 && !randStatus)
            {
                petList = new List<int>() { 1000301, 1000401, 1000501 };
                randStatus = true;
            }
            if (rand <= 0.99 && !randStatus)
            {
                petList = new List<int>() { 1000401, 1000501, 1000601 };
                randStatus = true;
            }
            if (rand <= 1 && !randStatus)
            {
                petList = new List<int>() { 1000501, 1000601, 1000701 };
                randStatus = true;
            }

            int petId = petList[RandomHelper.RandomNumber(0, petList.Count)];
            PetConfig petConfig = PetConfigCategory.Instance.Get(petId);
            List<int> weight = new List<int>(petConfig.SkinPro);
            int index = RandomHelper.RandomByWeight(weight);
            int skinId = petConfig.Skin[index];
            response.RolePetInfo = unit.GetComponent<PetComponent>().OnAddPet(petId, skinId);
            reply();
            await ETTask.CompletedTask;
        }
    }
}
