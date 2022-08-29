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
			long dbCacheId = DBHelper.GetDbCacheId(session.DomainZone());
			D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.AccountId, Component = DBHelper.DBAccountInfo });
			DBAccountInfo newAccount = d2GGetUnit.Component as DBAccountInfo;

			//移除角色
			if (newAccount.UserList.Count - 1 >= request.DeleXuhaoID)
			{
				newAccount.UserList.Remove(request.DeleUserID);
				newAccount.DeleteUserList.Add(request.DeleUserID);
			}
			D2M_SaveComponent d2GSave = (D2M_SaveComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new M2D_SaveComponent() { CharacterId = newAccount.Id, Component = newAccount, ComponentType = DBHelper.DBAccountInfo });

			long mapInstanceId = DBHelper.GetRankServerId(session.DomainZone());
			R2A_DeleteRoleData m2m_TrasferUnitResponse = (R2A_DeleteRoleData)await ActorMessageSenderComponent.Instance.Call
			(mapInstanceId, new A2R_DeleteRoleData()
			{
				DeleUserID = request.DeleUserID,
				AccountId = request.AccountId
			});

			reply();
		}
	}
}