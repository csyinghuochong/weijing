using System;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetDuiHuanHandler : AMActorLocationRpcHandler<Unit, C2M_PetDuiHuanRequest, M2C_PetDuiHuanResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetDuiHuanRequest request, M2C_PetDuiHuanResponse response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            int userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            if (PetHelper.GetBagPetNum(petComponent.RolePetInfos) >= PetHelper.GetPetMaxNumber(unit, userLv))
            {
                response.Error = ErrorCode.ERR_BagIsFull;
                reply();
                return;
            }

            int configId = request.OperateId;
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(configId);
            string[] configInfo = globalValueConfig.Value.Split('@');
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (!bagComponent.OnCostItemData(configInfo[0]))
            {
                response.Error = ErrorCode.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            response.RolePetInfo = petComponent.OnAddPet(ItemGetWay.PetEggDuiHuan, int.Parse(configInfo[1]));
            unit.GetComponent<DataCollationComponent>().OnPetDuiHuan();
            reply();
            await ETTask.CompletedTask;
        }
    }
}
