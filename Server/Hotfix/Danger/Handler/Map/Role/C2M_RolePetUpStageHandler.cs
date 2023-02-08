using System;

namespace ET
{

    //宠物皮肤
    [ActorMessageHandler]
    public class C2M_RolePetUpStageHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetUpStage, M2C_RolePetUpStage>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetUpStage request, M2C_RolePetUpStage response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfo(request.PetInfoId);

            //判断当前宠物是否是进阶中的状态
            if (rolePetInfo.UpStageStatus == 1)
            {
                //判断当前背包是否有宠之晶
                BagComponent bag = unit.GetComponent<BagComponent>();
                if (bag.OnCostItemData("10010086;1"))
                {
                    response.OldPetInfo = ComHelp.DeepCopy<RolePetInfo>(rolePetInfo);
                    petComponent.UpdatePetStage(rolePetInfo);
                    response.NewPetInfo = rolePetInfo;
                }
                else {
                    response.Error = ErrorCore.ERR_ItemNotEnoughError;
                }
            }
            else {
                response.Error = ErrorCore.ERR_Pet_UpStage;
            }

            reply();
            await ETTask.CompletedTask;
        }
    }
}

