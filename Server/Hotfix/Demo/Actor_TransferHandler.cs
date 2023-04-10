using System;

namespace ET
{
    [ActorMessageHandler]
	public class Actor_TransferHandler : AMActorLocationRpcHandler<Unit, Actor_TransferRequest, Actor_TransferResponse>
	{
		protected override async ETTask Run(Unit unit, Actor_TransferRequest request, Actor_TransferResponse response, Action reply)
		{
			//long unitId = unit.Id;
			//// 先在location锁住unit的地址
			//await Game.Scene.GetComponent<LocationProxyComponent>().Lock(unitId, unit.InstanceId);
			//// 删除unit,让其它进程发送过来的消息找不到actor，重发
			//Game.EventSystem.Remove(unitId);
			//long instanceId = unit.InstanceId;
			//int mapIndex = request.MapIndex;
			//StartConfigComponent startConfigComponent = StartConfigComponent.Instance;
			//// 传送到map
			//StartConfig mapConfig = startConfigComponent.MapConfigs[mapIndex];
			//IPEndPoint address = mapConfig.GetComponent<InnerConfig>().IPEndPoint;
			//Session session = Game.Scene.GetComponent<NetInnerComponent>().Get(address);
			//// 只删除不disponse否则M2M_TrasferUnitRequest无法序列化Unit
			//Game.Scene.GetComponent<UnitComponent>().RemoveNoDispose(unitId);
			//M2M_TrasferUnitResponse m2m_TrasferUnitResponse = (M2M_TrasferUnitResponse)await session.Call(new M2M_TrasferUnitRequest() { Unit = unit });
			//unit.Dispose();
			//// 解锁unit的地址,并且更新unit的instanceId
			//await Game.Scene.GetComponent<LocationProxyComponent>().UnLock(unitId, instanceId, m2m_TrasferUnitResponse.InstanceId);
			try
			{
				using (await CoroutineLockComponent.Instance.Wait(CoroutineLockType.Transfer, unit.Id))
				{
					int oldScene = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
					if (oldScene == request.SceneType && request.SceneType != SceneTypeEnum.LocalDungeon && request.SceneType != SceneTypeEnum.JiaYuan)
					{
						Log.Debug($"LoginTest1  Actor_Transfer unitId{unit.Id} oldScene:{oldScene}  requestscene{request.SceneType}");
						response.Error = ErrorCore.ERR_RequestRepeatedly;
						reply();
						return;
					};
					if (oldScene != request.SceneType && oldScene > SceneTypeEnum.MainCityScene && request.SceneType > SceneTypeEnum.MainCityScene)
					{
						Log.Debug($"LoginTest2  Actor_Transfer unitId{unit.Id} oldScene:{oldScene}  requestscene{request.SceneType}");
						response.Error = ErrorCore.ERR_RequestRepeatedly;
						reply();
						return;
					}
					UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
					if (SceneConfigHelper.UseSceneConfig(request.SceneType) && request.SceneId > 0)
					{
						SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(request.SceneId);
						if (sceneConfig.DayEnterNum > 0 && sceneConfig.DayEnterNum <= userInfoComponent.GetSceneFubenTimes(request.SceneId))
						{
							response.Error = ErrorCore.ERR_TimesIsNot;
							reply();
							return;
						}
						userInfoComponent.AddSceneFubenTimes(request.SceneId);
					}

					if (oldScene == SceneTypeEnum.MainCityScene && request.SceneType > SceneTypeEnum.MainCityScene)
					{
						unit.RecordPostion(request.SceneType, request.SceneId);
					}
					switch (request.SceneType)
					{
						case (int)SceneTypeEnum.MainCityScene:
							await TransferHelper.MainCityTransfer(unit);
							break;
						case (int)SceneTypeEnum.CellDungeon:
							break;
						//宠物闯关
						case (int)SceneTypeEnum.PetDungeon:
							int petfubenid = int.Parse(request.paramInfo);
							if (!PetFubenConfigCategory.Instance.Contain(petfubenid))
							{
								reply();
								return;
							}
							long fubenid = IdGenerater.Instance.GenerateId();
							long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
							Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "PetFuben" + fubenid.ToString(), SceneType.Fuben);
							fubnescene.AddComponent<PetFubenSceneComponent>();
							fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.PetDungeon, request.SceneId,int.Parse(request.paramInfo) );
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.PetDungeon, request.SceneId, FubenDifficulty.None, request.paramInfo);
							TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
							break;
						case (int)SceneTypeEnum.BaoZang:
						case (int)SceneTypeEnum.MiJing:
							int mapType = SceneConfigCategory.Instance.Get(request.SceneId).MapType;
							TransferHelper.BeforeTransfer(unit);

							F2M_YeWaiSceneIdResponse f2M_YeWaiSceneIdResponse = (F2M_YeWaiSceneIdResponse)await ActorMessageSenderComponent.Instance.Call(
							DBHelper.GetFubenCenterId(unit.DomainZone()), new M2F_YeWaiSceneIdRequest() { SceneId = request.SceneId });

							await TransferHelper.Transfer(unit, f2M_YeWaiSceneIdResponse.FubenInstanceId, mapType, request.SceneId, 0, "0");
							break;
						case (int)SceneTypeEnum.TrialDungeon:
							fubenid = IdGenerater.Instance.GenerateId();
							fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
							fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "TrialDungeon" + fubenid.ToString(), SceneType.Fuben);
							fubnescene.AddComponent<TrialDungeonComponent>();
							MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
							mapComponent.SetMapInfo((int)SceneTypeEnum.TrialDungeon, request.SceneId, int.Parse(request.paramInfo));
							mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.TrialDungeon, request.SceneId, FubenDifficulty.None, request.paramInfo);
							TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
							break;
						case (int)SceneTypeEnum.RandomTower:
							//2200001
							fubenid = IdGenerater.Instance.GenerateId();
							fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
							fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "RandomTower" + fubenid.ToString(), SceneType.Fuben);
							fubnescene.AddComponent<RandomTowerComponent>();
							mapComponent = fubnescene.GetComponent<MapComponent>();
							mapComponent.SetMapInfo((int)SceneTypeEnum.RandomTower, request.SceneId, 0);
							mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.RandomTower, request.SceneId, 0, "0");
							TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
							break;
						case (int)SceneTypeEnum.JiaYuan:
							//动态创建副本
							Scene scene = unit.DomainScene();
							long mapInstanceId = DBHelper.GetJiaYuanServerId(unit.DomainZone());
							J2M_JiaYuanEnterResponse j2M_JianYuanEnterResponse = (J2M_JiaYuanEnterResponse)await ActorMessageSenderComponent.Instance.Call(
							mapInstanceId, new M2J_JiaYuanEnterRequest() { MasterId =  long.Parse(request.paramInfo), UnitId = unit.Id, SceneId = request.SceneId });
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, j2M_JianYuanEnterResponse.FubenInstanceId, (int)SceneTypeEnum.JiaYuan, request.SceneId, request.Difficulty, "0");

							if (oldScene == SceneTypeEnum.JiaYuan)
							{
								JiaYuanSceneComponent jiayuanSceneComponent = scene.GetParent<JiaYuanSceneComponent>();
								jiayuanSceneComponent.OnUnitLeave(scene);
							}
							break;
						case (int)SceneTypeEnum.Tower:
							//动态创建副本
							fubenid = IdGenerater.Instance.GenerateId();
							fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
							fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Tower" + fubenid.ToString(), SceneType.Fuben);
							fubnescene.AddComponent<TowerComponent>().FubenDifficulty = request.Difficulty;
							mapComponent = fubnescene.GetComponent<MapComponent>();
							mapComponent.SetMapInfo((int)SceneTypeEnum.Tower, request.SceneId, 0);
							mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.Tower, request.SceneId, request.Difficulty, "0");
							TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
							break;
						case (int)SceneTypeEnum.PetTianTi:
							////动态创建副本
							long enemyId = long.Parse(request.paramInfo);
							fubenid = IdGenerater.Instance.GenerateId();
							fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
							fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Fuben" + fubenid.ToString(), SceneType.Fuben);
							fubnescene.AddComponent<PetTianTiComponent>().EnemyId = enemyId;
							fubnescene.GetComponent<MapComponent>().SetMapInfo((int)SceneTypeEnum.PetTianTi, request.SceneId, 0);
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.PetTianTi, request.SceneId, 0, "0");
							TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
							break;
						case (int)SceneTypeEnum.LocalDungeon:
							LocalDungeonComponent localDungeon = unit.DomainScene().GetComponent<LocalDungeonComponent>();
							request.Difficulty = localDungeon != null ? localDungeon.FubenDifficulty : request.Difficulty;
							unit.GetComponent<SkillManagerComponent>()?.OnFinish(false);
							await TransferHelper.LocalDungeonTransfer(unit, request.SceneId, int.Parse(request.paramInfo), request.Difficulty);
							break;
						case (int)SceneTypeEnum.Battle:
							mapComponent = unit.DomainScene().GetComponent<MapComponent>();
							int sceneTypeEnum = mapComponent.SceneTypeEnum;
							mapInstanceId = DBHelper.GetBattleServerId(unit.DomainZone());
							B2M_BattleEnterResponse battleEnter = (B2M_BattleEnterResponse)await ActorMessageSenderComponent.Instance.Call(
							mapInstanceId, new M2B_BattleEnterRequest() { UserID = unit.Id, SceneId = request.SceneId });
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, battleEnter.FubenInstanceId, (int)SceneTypeEnum.Battle, request.SceneId, FubenDifficulty.Normal, battleEnter.Camp.ToString());
							break;
						case SceneTypeEnum.Arena:
							mapInstanceId = DBHelper.GetArenaServerId(unit.DomainZone());
							Arena2M_ArenaEnterResponse areneEnter = (Arena2M_ArenaEnterResponse)await ActorMessageSenderComponent.Instance.Call(
							mapInstanceId, new M2Arena_ArenaEnterRequest() { UserID = unit.Id, SceneId = request.SceneId });
							if (areneEnter.Error != ErrorCore.ERR_Success || areneEnter.FubenInstanceId == 0)
							{
								reply();
								return;
							}
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, areneEnter.FubenInstanceId, (int)SceneTypeEnum.Arena, request.SceneId, FubenDifficulty.Normal, "0");
							break;
						case (int)SceneTypeEnum.TeamDungeon:
							mapComponent = unit.DomainScene().GetComponent<MapComponent>();
							sceneTypeEnum = mapComponent.SceneTypeEnum;
							mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
							//[创建副本Scene]
							T2M_TeamDungeonEnterResponse createUnit = (T2M_TeamDungeonEnterResponse)await ActorMessageSenderComponent.Instance.Call(
							mapInstanceId, new M2T_TeamDungeonEnterRequest() { UserID = unit.GetComponent<UserInfoComponent>().UserInfo.UserId });
							if (createUnit.Error != ErrorCore.ERR_Success)
							{
								reply();
								return;
							}
							TransferHelper.BeforeTransfer(unit);
							await TransferHelper.Transfer(unit, createUnit.FubenInstanceId, (int)SceneTypeEnum.TeamDungeon, createUnit.FubenId, createUnit.FubenType, "0");
							break;
						default:
							break;
					}
					reply();
					await ETTask.CompletedTask;
				}
			}
			catch (Exception ex)
			{
				Log.Error(ex);
			}
		}
	}
}