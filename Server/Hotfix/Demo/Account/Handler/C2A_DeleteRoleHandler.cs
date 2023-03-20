using System;
using System.Collections.Generic;

namespace ET
{
	[MessageHandler]
	public class C2A_DeleteRoleHandler : AMRpcHandler<C2A_DeleteRoleData, A2C_DeleteRoleData>
	{
		protected override async ETTask Run(Session session, C2A_DeleteRoleData request, A2C_DeleteRoleData response, Action reply)
		{
			//存储账号信息
			int zone = session.DomainZone();
			DBAccountInfo newAccount = await DBHelper.GetComponentCache<DBAccountInfo>(zone, request.AccountId);
			//移除角色
			if (newAccount.UserList.Count - 1 >= request.DeleXuhaoID)
			{
				newAccount.UserList.Remove(request.DeleUserID);
				newAccount.DeleteUserList.Add(request.DeleUserID);
			}
			DBHelper.SaveComponent(zone, newAccount.Id, newAccount).Coroutine();

			long mapInstanceId = DBHelper.GetRankServerId(session.DomainZone());
			R2A_DeleteRoleData deleteResponse = (R2A_DeleteRoleData)await ActorMessageSenderComponent.Instance.Call
			(mapInstanceId, new A2R_DeleteRoleData()
			{
				DeleUserID = request.DeleUserID,
				AccountId = request.AccountId
			});
			DBHelper.DeleteUnitCache(session.DomainZone(), request.DeleUserID).Coroutine();
			UserInfoComponent userInfoComponent = await DBHelper.GetComponentCache<UserInfoComponent>(zone, request.DeleUserID);
			NumericComponent numericComponent = await DBHelper.GetComponentCache<NumericComponent>(zone, request.DeleUserID);
			if (userInfoComponent.UserInfo.Lv <= 10 && numericComponent.GetAsInt(NumericType.RechargeNumber) <= 0)
			{
				List<string> allComponets = DBHelper.GetAllUnitComponent();
				for (int i = 0; i < allComponets.Count; i++)
				{
					Game.Scene.GetComponent<DBComponent>().Remove<Entity>(zone, request.DeleUserID, allComponets[i]).Coroutine();
				}
			}
			reply();
		}
	}
}