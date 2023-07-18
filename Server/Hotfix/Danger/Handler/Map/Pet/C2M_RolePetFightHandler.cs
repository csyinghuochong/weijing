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
			if (petinfo == null)
			{
                response.Error = ErrorCore.ERR_Pet_NoExist;
				reply();
				return;
			}
            if (petinfo.PetStatus == 2 || petinfo.PetStatus == 3)
            {
                reply();
                return;
            }

            if (request.PetStatus == 1)
            {
                //出战要清掉之前的
                RolePetInfo fightpet =  unit.GetComponent<PetComponent>().GetFightPet();
                if (fightpet != null)
                {
                    fightpet.PetStatus = 0;
                    unit.GetParent<UnitComponent>().Remove(fightpet.Id);
                }
                if (unit.GetParent<UnitComponent>().Get(petinfo.Id) == null)
                {
                    UnitFactory.CreatePet(unit, petinfo);
                }

                petinfo.PetStatus = request.PetStatus;
            }
            else
            {
                //休息
                petinfo.PetStatus = request.PetStatus;
                unit.GetParent<UnitComponent>().Remove(petinfo.Id);
            }




            ///移除有问题的宠物
            //List<Unit> entities = unit.GetParent<UnitComponent>().GetAll();
            //{
            //	for (int i = entities.Count - 1; i >= 0; i--)
            //	{
            //                    if (entities[i].Id == petinfo.Id)
            //                    {
            //                        continue;
            //                    }
            //                    if (entities[i].Type != UnitType.Pet)
            //		{
            //			continue;
            //		}
            //		if (entities[i].GetMasterId() != unit.Id)
            //		{
            //                        continue;
            //                    }

            //                    unit.GetParent<UnitComponent>().Remove(entities[i].Id);
            //                }
            //}

            reply();
			await ETTask.CompletedTask;
		}
	}
}