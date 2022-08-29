using System;
using System.Collections.Generic;


namespace ET
{
	//玩家宠物
	[ActorMessageHandler]
	public class C2M_RolePetFightHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetFight, M2C_RolePetFight>
	{
		protected override async ETTask Run(Unit unit, C2M_RolePetFight request, M2C_RolePetFight response, Action reply)
		{
			
			RolePetInfo petinfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
			petinfo.PetStatus = request.PetStatus;

			if (request.PetStatus == 1)
			{
				UnitFactory.CreatePet(unit, petinfo);
			}
			else
			{
				unit.GetParent<UnitComponent>().Remove(petinfo.Id);
			}

			reply();
			await ETTask.CompletedTask;
		}
	}
}