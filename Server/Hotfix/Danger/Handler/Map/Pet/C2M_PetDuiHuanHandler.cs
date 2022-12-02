using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetDuiHuanHandler : AMActorLocationRpcHandler<Unit, C2M_PetDuiHuanRequest, M2C_PetDuiHuanResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_PetDuiHuanRequest request, M2C_PetDuiHuanResponse response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            int userLv = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
            if (petComponent.RolePetInfos.Count >= ComHelp.GetPetMaxNumber(unit, userLv))
            {
                reply();
                return;
            }

            int configId = request.OperateId;
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(configId);
            string[] configInfo = globalValueConfig.Value.Split('@');
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if (!bagComponent.OnCostItemData(configInfo[0]))
            {
                response.Error = ErrorCore.ERR_ItemNotEnoughError;
                reply();
                return;
            }
            petComponent.OnAddPet(int.Parse(configInfo[1]));
            reply();
            await ETTask.CompletedTask;
        }
    }
}
