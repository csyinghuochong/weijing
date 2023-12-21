using System;

namespace ET
{
    //玩家宠物
    [ActorMessageHandler]
	public class C2M_RolePetFenjieHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetFenjie, M2C_RolePetFenjie>
	{
		protected override async ETTask Run(Unit unit, C2M_RolePetFenjie request, M2C_RolePetFenjie response, Action reply)
		{
			//判断背包是否满
			if (unit.GetComponent<BagComponent>().GetLeftSpace() <= 1)
			{
				response.Error = ErrorCode.ERR_BagIsFull;       //提示背包已满
				reply();
				return;
			}


			int petType = 1;
			RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);

			if (rolePetInfo == null)
			{
				petType = 2;
                rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfoByBag(request.PetInfoId);
            }

			if (rolePetInfo == null)
			{
				response.Error = ErrorCode.ERR_Pet_NoExist;
				reply();
				return;
			}
            if (rolePetInfo.PetStatus != 0)
			{
                response.Error = ErrorCode.ERR_Pet_Hint_4;
                reply();
                return;
            }

            //获取宠物碎片
            PetConfig petCof = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
			if (petCof.ReleaseReward != null && petCof.ReleaseReward.Length == 2)
			{
				unit.GetComponent<BagComponent>().OnAddItemData($"{petCof.ReleaseReward[0]};{petCof.ReleaseReward[1]}", $"{ItemGetWay.PetFenjie}_{TimeHelper.ServerNow()}");
			}

			if (petType == 1)
			{
                unit.GetComponent<PetComponent>().OnRolePetFenjie(request.PetInfoId);
            }
			else
			{
                unit.GetComponent<PetComponent>().RemovePetBag(request.PetInfoId);
            }

			
			unit.GetComponent<JiaYuanComponent>().OnJiaYuanPetWalk(rolePetInfo, 0, -1);

			if (unit.GetParent<UnitComponent>().Get(rolePetInfo.Id) != null)
			{
				Log.Warning($"宠物还在出战中！！");
				unit.GetParent<UnitComponent>().Remove(rolePetInfo.Id);
			}

			Function_Fight.GetInstance().UnitUpdateProperty_Base( unit, true, true );

            reply();
			await ETTask.CompletedTask;
		}
	}
}