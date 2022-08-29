using System;

namespace ET
{
    //玩家宠物
    [ActorMessageHandler]
	public class C2M_RolePetRNameHandler : AMActorLocationRpcHandler<Unit, C2M_RolePetRName, M2C_RolePetRName>
	{
		protected override async ETTask Run(Unit unit, C2M_RolePetRName request, M2C_RolePetRName response, Action reply)
		{
			//读取数据库
			RolePetInfo petinfo = unit.GetComponent<PetComponent>().GetPetInfo(request.PetInfoId);
			if (petinfo!=null)
			{
				petinfo.PetName = request.PetName;
			}
			reply();
			await ETTask.CompletedTask;
		}
	}
}