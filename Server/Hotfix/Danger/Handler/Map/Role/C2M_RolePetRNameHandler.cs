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
			if (petinfo==null)
			{
				reply();
				return;
			}

			petinfo.PetName = request.PetName;

			//通知客户端
			MessageHelper.SendToClient(unit, new M2C_PetDataUpdate() { UpdateType = (int)UserDataType.Name, PetId = request.PetInfoId, UpdateTypeValue = request.PetName });
			MessageHelper.SendToClient(unit, new M2C_PetDataBroadcast() { UnitId = unit.Id, UpdateType = (int)UserDataType.Name, PetId = request.PetInfoId, UpdateTypeValue = request.PetName });
			reply();
			await ETTask.CompletedTask;
		}
	}
}