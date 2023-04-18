using System;
using System.Collections.Generic;

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
				response.Error = ErrorCore.ERR_BagIsFull;       //提示背包已满
				reply();
				return;
			}

			RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
			if (rolePetInfo == null)
			{
				reply();
				return;
			}

			//获取宠物碎片
			PetConfig petCof = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
			if (petCof.ReleaseReward != null && petCof.ReleaseReward.Length == 2)
			{
				unit.GetComponent<BagComponent>().OnAddItemData($"{petCof.ReleaseReward[0]};{petCof.ReleaseReward[1]}", $"{ItemGetWay.PetFenjie}_{TimeHelper.ServerNow()}");
			}

			//移除宠物之核
			unit.GetComponent<BagComponent>().OnCostItemData(rolePetInfo.PetHeXinList, ItemLocType.ItemPetHeXinEquip);

			unit.GetComponent<PetComponent>().OnRolePetFenjie(request.PetInfoId);

			unit.GetComponent<JiaYuanComponent>().OnJiaYuanPetWalk(rolePetInfo, 0, -1);

			reply();
			await ETTask.CompletedTask;
		}
	}
}