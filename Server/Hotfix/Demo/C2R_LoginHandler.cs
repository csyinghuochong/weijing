//using System;
//using System.Collections.Generic;

//namespace ET
//{
//    [MessageHandler]
//	public class C2R_LoginHandler : AMRpcHandler<C2R_Login, R2C_Login>
//	{
//		protected override async ETTask Run(Session session, C2R_Login request, R2C_Login response, Action reply)
//		{
//			List<DBAccountInfo> result = await Game.Scene.GetComponent<DBComponent>().Query<DBAccountInfo>(session.DomainZone(), d => d.Account == request.Account);
//			if (result.Count == 0)
//			{
//				Log.Warning("登陆失败,请确认自己的账户ID和密码是否正确...");
//				response.Error = ErrorCore.ERR_AccountOrPasswordError;
//				reply();
//				return;
//			}

//			//获取当前的角色列表信息
//			DBAccountInfo acc = result[0];
//			if (acc.PlayerInfo.RealName == 0)
//			{
//				response.AccountId = acc.Id;
//				response.Error = ErrorCore.ERR_NotRealName;
//				reply();
//				acc.Dispose();
//				return;
//			}

//			// 随机分配一个Gate
//			StartSceneConfig config = RealmGateAddressHelper.GetGate(session.DomainZone(), acc.Id);
//			Log.Debug($"gate address: {MongoHelper.ToJson(config)}");

//			// 向gate请求一个key,客户端可以拿着这个key连接gate
//			G2R_GetLoginKey g2RGetLoginKey = (G2R_GetLoginKey)await ActorMessageSenderComponent.Instance.Call(
//				config.InstanceId, new R2G_GetLoginKey() { Account = request.Account });

//			long dbCacheId = DBHelper.GetDbCacheId(session.DomainZone());
//			for (int i = 0; i < acc.UserList.Count; i++)
//			{
//				CreateRoleListInfo roleList = new CreateRoleListInfo();

//				D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = acc.UserList[i], Component = DBHelper.UserInfoComponent });
//				UserInfoComponent userinfo = d2GGetUnit.Component as UserInfoComponent;

//				roleList = Function_Role.GetInstance().GetRoleListInfo(userinfo.UserInfo, i, acc.UserList[i]);
//				response.RoleLists.Add(roleList);
//			}

//			response.Address = config.OuterIPPort.ToString();
//			response.Key = g2RGetLoginKey.Key;
//			response.GateId = g2RGetLoginKey.GateId;
//			response.PlayerInfo = acc.PlayerInfo;
//			response.AccountId = acc.Id;
//			reply();
//		}
//	}
//}