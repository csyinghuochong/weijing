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

			if (allValue > (petinfo.PetLv - 1) * 5)
			{
				petinfo.AddPropretyValue = "0_0_0_0";
				petinfo.AddPropretyNum = (petinfo.PetLv - 1) * 5;
			}
			unit.GetComponent<PetComponent>().UpdatePetAttribute(petinfo, true);
			response.RolePetInfo = petinfo;	

			reply();
			await ETTask.CompletedTask;
		}
	}
}