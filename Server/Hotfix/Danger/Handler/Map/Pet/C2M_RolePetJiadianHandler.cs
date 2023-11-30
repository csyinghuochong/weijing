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
			RolePetInfo rolePetInfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
			if (rolePetInfo == null)
			{
				reply();
				return;
			}

			int allValue = 0;
			int maxPoint = (rolePetInfo.PetLv - 1) * 5;
			rolePetInfo.AddPropretyValue = request.AddPropretyValue[0].ToString();
			allValue += request.AddPropretyValue[0];
			for (int i = 1; i < request.AddPropretyValue.Count; i++)
			{
				allValue += request.AddPropretyValue[i];
				rolePetInfo.AddPropretyValue += ("_" + request.AddPropretyValue[i]);
			}
			rolePetInfo.AddPropretyNum = maxPoint - allValue;
			if (allValue > maxPoint 
				|| rolePetInfo.AddPropretyNum < 0 
                || request.AddPropretyValue[0] > maxPoint
				|| request.AddPropretyValue[1] > maxPoint 
				|| request.AddPropretyValue[2] > maxPoint
				|| request.AddPropretyValue[3] > maxPoint)
			{
				rolePetInfo.AddPropretyValue = ItemHelper.DefaultGem;
                rolePetInfo.AddPropretyNum = (rolePetInfo.PetLv - 1) * 5;
			}
			unit.GetComponent<PetComponent>().UpdatePetAttribute(rolePetInfo, true);
			response.RolePetInfo = rolePetInfo;	

			reply();
			await ETTask.CompletedTask;
		}
	}
}