using System;

namespace ET
{
    //玩家宠物
    [ActorMessageHandler]
	public class C2M_RolePetListHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetList, M2C_RolePetList>
	{
		protected override async ETTask Run(Unit unit, C2M_RolePetList request, M2C_RolePetList response, Action reply)
		{
			PetComponent petComponent = unit.GetComponent<PetComponent>();
			petComponent.InitPetInfo();
			if (petComponent.TeamPetList.Count > 3)
			{
				petComponent.TeamPetList.Clear();
			}
			response.RolePetInfos = petComponent.GetAllPets();
			response.TeamPetList = petComponent.TeamPetList;
			response.RolePetEggs = petComponent.RolePetEggs;
			response.PetFormations = petComponent.PetFormations;
			response.PetFubenInfos = petComponent.PetFubenInfos;
			response.PetFubeRewardId = petComponent.PetFubeRewardId;
			response.PetSkinList = petComponent.PetSkinList;
			reply();
			await ETTask.CompletedTask;
		}

	}
}