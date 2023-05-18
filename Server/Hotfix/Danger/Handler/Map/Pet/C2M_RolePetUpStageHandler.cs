using System;

namespace ET
{

    //宠物进化
    [ActorMessageHandler]
    public class C2M_RolePetUpStageHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetUpStage, M2C_RolePetUpStage>
    {
        protected override async ETTask Run(Unit unit, C2M_RolePetUpStage request, M2C_RolePetUpStage response, Action reply)
        {
            PetComponent petComponent = unit.GetComponent<PetComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfo(request.PetInfoId);

            if (request.PetInfoXianJiId <= 0) {
                response.Error = ErrorCore.ERR_Pet_UpStage;
                reply();
            }

            //神兽不能进化
            PetConfig petCof = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            if (petCof.PetType == 2) {
                response.Error = ErrorCore.ERR_Pet_UpStage;
                reply();
            }

            RolePetInfo rolePetInfoXianJi = petComponent.GetPetInfo(request.PetInfoXianJiId);

            //判断当前宠物是否是进阶中的状态
            if (rolePetInfo.UpStageStatus == 1 || rolePetInfo.UpStageStatus == 0 && rolePetInfo.PetLv >= 70)
            {
                if (rolePetInfo.UpStageStatus == 2) {
                    response.Error = ErrorCore.ERR_Pet_UpStage;
                    reply();
                }

                //判断当前宠物是否有献祭
                //BagComponent bag = unit.GetComponent<BagComponent>();
                if (rolePetInfoXianJi != null)
                {
                    //移除宠物
                    petComponent.RemovePet(request.PetInfoXianJiId);
                    response.OldPetInfo = ComHelp.DeepCopy<RolePetInfo>(rolePetInfo);

                    //获取评分
                    int pingfen = ComHelp.PetPingJia(rolePetInfoXianJi);
                    petComponent.UpdatePetStage(rolePetInfo, pingfen);

                    petComponent.CheckPetPingFen();
                    petComponent.CheckPetZiZhi();

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

