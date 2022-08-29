//using System;


//namespace ET
//{
//	[MessageHandler]
//	public class C2G_EnterMapHandler : AMRpcHandler<C2G_EnterMap, G2C_EnterMap>
//	{
	
//		protected override async ETTask Run(Session session, C2G_EnterMap request, G2C_EnterMap response, Action reply)
//		{
//			Player player = session.GetComponent<SessionPlayerComponent>().GetMyPlayer();

//			long dbCacheId = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.DBCache)).InstanceId;
//			D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = request.AccountId, Component = DBHelper.DBAccountInfo });
//			DBAccountInfo userAccountInfo = d2GGetUnit.Component as DBAccountInfo;

//			if (userAccountInfo.UserList.Contains(request.UserID) == false)
//			{
//				response.Error = ErrorCore.ERR_ConnectGateKeyError;
//				response.Message = "角色不存在,登陆失败!";
//				reply();
//				return;
//			}

//			GateUnitInfo gateUnitInfo = null;
//			session.Domain.GetComponent<GateUnitComponent>().GateUnitList.TryGetValue(request.UserID, out gateUnitInfo);
//			//踢下线
//			if (gateUnitInfo != null && gateUnitInfo.SceneInstanceId != 0)
//			{
//				M2G_ReCreateUnit createUnit1 = (M2G_ReCreateUnit)await ActorMessageSenderComponent.Instance.Call(
//				  gateUnitInfo.SceneInstanceId, new G2M_ReCreateUnit()
//				  {
//					  GateSessionId = 0,
//					  UserID = request.UserID
//				  });
//				session.Domain.GetComponent<GateUnitComponent>().GateUnitList.Remove(request.UserID);
//			}

//			// 在Gate上动态创建一个Map Scene，把Unit从DB中加载放进来，然后传送到真正的Map中，这样登陆跟传送的逻辑就完全一样了
//			GateMapComponent gateMapComponent = player.AddComponent<GateMapComponent>();
//			gateMapComponent.Scene = await SceneFactory.Create(gateMapComponent, "GateMap", SceneType.GateMap);

//			Scene scene = gateMapComponent.Scene;
			
//			// 这里可以从DB中加载Unit
//			Unit unit = UnitFactory.Create(scene, player.Id, UnitType.Player);
//			unit.AddComponent<UnitGateComponent, long>(session.InstanceId);

//			await DBHelper.AddDataComponent<UserInfoComponent>(unit, request.UserID, DBHelper.UserInfoComponent);
//			await DBHelper.AddDataComponent<BagComponent>(unit, request.UserID, DBHelper.BagComponent);
//			await DBHelper.AddDataComponent<TaskComponent>(unit, request.UserID, DBHelper.TaskComponent);
//			await DBHelper.AddDataComponent<ChengJiuComponent>(unit, request.UserID, DBHelper.ChengJiuComponent);
//			await DBHelper.AddDataComponent<PetComponent>(unit, request.UserID, DBHelper.PetComponent);
//			await DBHelper.AddDataComponent<SkillSetComponent>(unit, request.UserID, DBHelper.SkillSetComponent);
//			await DBHelper.AddDataComponent<EnergyComponent>(unit, request.UserID, DBHelper.EnergyComponent);
//			await DBHelper.AddDataComponent<ActivityComponent>(unit, request.UserID, DBHelper.ActivityComponent);
//			//await DBHelper.AddDataComponent<NumericComponent>(unit, request.UserID, DBHelper.NumericComponent);
//			await DBHelper.AddDataComponent<RechargeComponent>(unit, request.UserID, DBHelper.RechargeComponent);
//			unit.GetComponent<UserInfoComponent>().OnLogin().Coroutine();

//			StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), "Map1");

//			player.UnitId = unit.Id;
//			player.DBCacheId = dbCacheId;
//			player.ChatServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;
//			player.MailServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
//			player.ChargetServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.ReCharge)).InstanceId;
//			player.RankServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Rank)).InstanceId;
//			player.PaiMaiServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
//			player.ActivityServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
//			player.TeamServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
//			player.FriendServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Friend)).InstanceId;
//			player.UnionServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Union)).InstanceId;
//			player.CenterServerID = StartSceneConfigCategory.Instance.GetBySceneName(10001, Enum.GetName(SceneType.Center)).InstanceId;
//			response.UnitId = player.Id;
		
//			reply();
//			// 开始传送
//			await TransferHelper.Transfer(unit, startSceneConfig.InstanceId, (int)SceneTypeEnum.MainCityScene, 1, -1);
//		}
//	}
//}