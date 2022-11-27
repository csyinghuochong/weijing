using System;
using System.Collections.Generic;

namespace ET
{
	//玩家宠物
	[ActorMessageHandler]
	public class C2M_RolePetJiadianHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetJiadian, M2C_RolePetJiadian>
	{
		protected override async ETTask Run(Unit unit, C2M_RolePetJiadian request, M2C_RolePetJiadian response, Action reply)
		{
			//读取数据库
			RolePetInfo petinfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
			if (petinfo == null)
			{
				Log.Debug($"petinfo == null  {unit.Id} {request.PetInfoId}");
				reply();
				return;
			}

			int allValue = 0;
			petinfo.AddPropretyValue = request.AddPropretyValue[0].ToString();
			allValue += request.AddPropretyValue[0];
			for (int i = 1; i < request.AddPropretyValue.Count; i++)
			{
				allValue += request.AddPropretyValue[i];
				petinfo.AddPropretyValue += ("_" + request.AddPropretyValue[i]);
			}
			petinfo.AddPropretyNum = (petinfo.PetLv - 1) * 5 - allValue;

			Unit unitPet = unit.GetParent<UnitComponent>().Get(request.PetInfoId);
			unit.GetComponent<PetComponent>().UpdatePetAttribute(petinfo, unitPet);
			response.RolePetInfo = petinfo;	

			reply();
			await ETTask.CompletedTask;
		}
	}
}