using System;

namespace ET
{
	public class C2G_EnterGameHandler : AMRpcHandler<C2G_EnterGame, G2C_EnterGame>
	{
		protected override async ETTask Run(Session session, C2G_EnterGame request, G2C_EnterGame response, Action reply)
		{
			if (session.DomainScene().SceneType != SceneType.Gate)
			{
				Log.Error($"C2G_EnterGame请求的Scene错误，当前Scene为：{session.DomainScene().SceneType}");
				session.Dispose();
				return;
			}

			if (session.GetComponent<SessionLockingComponent>() != null)
			{
				response.Error = ErrorCore.ERR_RequestRepeatedly;
				reply();
				return;
			}
			//没有loginGate
			SessionPlayerComponent sessionPlayerComponent = session.GetComponent<SessionPlayerComponent>();
			if (null == sessionPlayerComponent)
			{
				response.Error = ErrorCore.ERR_SessionPlayerError;
				reply();
				return;
			}
			//连接gate的时候会做记录
			Player player = Game.EventSystem.Get(sessionPlayerComponent.PlayerInstanceId) as Player;

			if (player == null || player.IsDisposed)
			{
				response.Error = ErrorCore.ERR_NonePlayerError;
				reply();
				return;
			}

			long instanceId = session.InstanceId;

			using (session.AddComponent<SessionLockingComponent>())
			{
				using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.LoginGate, player.AccountId.GetHashCode()))
				{

					if (instanceId != session.InstanceId || player.IsDisposed)
					{
						response.Error = ErrorCore.ERR_PlayerSessionError;
						reply();
						return;
					}

					//同一个session不能重复进
					if (session.GetComponent<SessionStateComponent>() != null && session.GetComponent<SessionStateComponent>().State == SessionState.Game)
					{
						response.Error = ErrorCore.ERR_SessionStateError;
						reply();
						return;
					}

					//player可以映射任意一个seesion。 session是唯一的
					if (player.PlayerState == PlayerState.Game && !request.Relink)
					{
						//十秒内重启客户端而非重连
						//通知游戏逻辑服下线Unit角色逻辑，并将数据存入数据库
						Log.Info($"PlayerState.Game && !request.Relink:{player.UnitId}");
						IActorResponse reqEnter = (M2G_RequestEnterGameState)await MessageHelper.CallLocationActor(player.UnitId, new G2M_RequestEnterGameState()
						{
							GateSessionActorId = 0
						});

						player.RemoveComponent<GateMapComponent>();
						player.PlayerState = PlayerState.None;
					}
					if (player.PlayerState == PlayerState.Game)
					{
						try
						{
							//重连
							Log.Debug($"二次登录开始;{player.UnitId}");
							IActorResponse reqEnter =(M2G_RequestEnterGameState) await MessageHelper.CallLocationActor(player.UnitId, new G2M_RequestEnterGameState()
							{
								GateSessionActorId = session.InstanceId
							});
							if (reqEnter.Error == ErrorCode.ERR_Success)
							{
								reply();
								return;
							}
							Log.Error("二次登录失败  " + reqEnter.Error + " | " + reqEnter.Message);
							response.Error = ErrorCore.ERR_ReEnterGameError;
							await DisconnectHelper.KickPlayer(player, true);
							reply();
							session?.Disconnect().Coroutine();
						}
						catch (Exception e)
						{
							Log.Error("二次登录失败  " + e.ToString());
							response.Error = ErrorCore.ERR_ReEnterGameError2;
							await DisconnectHelper.KickPlayer(player, true);
							reply();
							session?.Disconnect().Coroutine();
							throw;
						}
						return;
					}

					try
					{
						GateMapComponent gateMapComponent = player.AddComponent<GateMapComponent>();
						gateMapComponent.Scene = SceneFactory.Create(gateMapComponent, "GateMap", SceneType.GateMap);

						Unit unit = UnitFactory.Create(gateMapComponent.Scene, player.Id, UnitType.Player);
						await DBHelper.AddDataComponent<NumericComponent>(unit, request.UserID, DBHelper.NumericComponent);
						await DBHelper.AddDataComponent<UserInfoComponent>(unit, request.UserID, DBHelper.UserInfoComponent);
						await DBHelper.AddDataComponent<TaskComponent>(unit, request.UserID, DBHelper.TaskComponent);
						await DBHelper.AddDataComponent<ShoujiComponent>(unit, request.UserID, DBHelper.ShoujiComponent);
						await DBHelper.AddDataComponent<BagComponent>(unit, request.UserID, DBHelper.BagComponent);
						await DBHelper.AddDataComponent<ChengJiuComponent>(unit, request.UserID, DBHelper.ChengJiuComponent);
						await DBHelper.AddDataComponent<PetComponent>(unit, request.UserID, DBHelper.PetComponent);
						await DBHelper.AddDataComponent<SkillSetComponent>(unit, request.UserID, DBHelper.SkillSetComponent);
						await DBHelper.AddDataComponent<EnergyComponent>(unit, request.UserID, DBHelper.EnergyComponent);
						await DBHelper.AddDataComponent<ActivityComponent>(unit, request.UserID, DBHelper.ActivityComponent);
						await DBHelper.AddDataComponent<RechargeComponent>(unit, request.UserID, DBHelper.RechargeComponent);
						await DBHelper.AddDataComponent<ReddotComponent>(unit, request.UserID, DBHelper.ReddotComponent);

						unit.AddComponent<UnitGateComponent, long>(player.InstanceId);
						unit.AddComponent<MailComponent>();
						unit.AddComponent<StateComponent>();
						unit.AddComponent<HeroDataComponent>();
						unit.AddComponent<DBSaveComponent>();
						unit.AddComponent<SkillPassiveComponent>().UpdatePassiveSkill();
						unit.GetComponent<UserInfoComponent>().OnLogin(session.RemoteAddress.ToString()).Coroutine();

						long unitId = unit.Id;
						player.UnitId = unitId;
						player.DBCacheId = DBHelper.GetDbCacheId(session.DomainZone());
						player.ChatServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Chat)).InstanceId;
						player.MailServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.EMail)).InstanceId;
						player.RankServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Rank)).InstanceId;
						player.PaiMaiServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.PaiMai)).InstanceId;
						player.ActivityServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Activity)).InstanceId;
						player.TeamServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
						player.FriendServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Friend)).InstanceId;
						player.UnionServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.Union)).InstanceId;
						player.CenterServerID = StartSceneConfigCategory.Instance.CenterConfig.InstanceId;
						//player.ReChargeServerID = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), Enum.GetName(SceneType.ReCharge)).InstanceId;
						response.MyId = unitId;

						reply();
						StartSceneConfig startSceneConfig = StartSceneConfigCategory.Instance.GetBySceneName(session.DomainZone(), "Map1");
						//await TransferHelper.Transfer(unit, startSceneConfig.InstanceId, startSceneConfig.Name);
						await TransferHelper.Transfer(unit, startSceneConfig.InstanceId, (int)SceneTypeEnum.MainCityScene, ComHelp.MainCityID(), 0);

						SessionStateComponent SessionStateComponent = session.GetComponent<SessionStateComponent>();
						if (SessionStateComponent == null)
						{
							SessionStateComponent = session.AddComponent<SessionStateComponent>();
						}
						SessionStateComponent.State = SessionState.Game;

						player.PlayerState = PlayerState.Game;
						player.UserId = request.UserID;
					}
					catch (Exception e)
					{
						Log.Error($"角色进入游戏逻辑服出现问题 账号Id: {player.AccountId}  角色Id: {player.Id}   异常信息： {e.ToString()}");
						response.Error = ErrorCore.ERR_EnterGameError;
						reply();
						await DisconnectHelper.KickPlayer(player, true);
						session.Disconnect().Coroutine();
					}
				}
			}

		}
	}
}