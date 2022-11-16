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
				int oldScene = unit.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
				if (oldScene == request.SceneType && request.SceneType != SceneTypeEnum.LocalDungeon)
				{
					Log.Error($"LoginTest1  Actor_Transfer unitId{unit.Id} oldScene:{oldScene}  requestscene{request.SceneType}");
					response.Error = ErrorCore.ERR_RequestRepeatedly;
					reply();
					return;
				};
				if (oldScene != request.SceneType && oldScene > SceneTypeEnum.MainCityScene && request.SceneType > SceneTypeEnum.MainCityScene)
				{
					Log.Error($"LoginTest2  Actor_Transfer unitId{unit.Id} oldScene:{oldScene}  requestscene{request.SceneType}");
					response.Error = ErrorCore.ERR_RequestRepeatedly;
					reply();
					return;
				}

				switch (request.SceneType)
				{
					case (int)SceneTypeEnum.MainCityScene:
						TransferHelper.MainCityTransfer(unit).Coroutine();
						break;
					case (int)SceneTypeEnum.CellDungeon:
						break;
						//宠物闯关
					case (int)SceneTypeEnum.PetDungeon:
						long fubenid = IdGenerater.Instance.GenerateId();
						long fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
						Scene fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "PetFuben" + fubenid.ToString(), SceneType.Fuben);
						fubnescene.AddComponent<PetFubenSceneComponent>();
						TransferHelper.BeforeTransfer(unit);
						await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.PetDungeon, BattleHelper.GetSceneIdByType(SceneTypeEnum.PetDungeon), request.SceneId);
						TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
						break;
					case (int)SceneTypeEnum.YeWaiScene:
						TransferHelper.BeforeTransfer(unit);

						F2M_YeWaiSceneIdResponse f2M_YeWaiSceneIdResponse = (F2M_YeWaiSceneIdResponse)await ActorMessageSenderComponent.Instance.Call(
						DBHelper.GetFubenCenterId(unit.DomainZone()), new M2F_YeWaiSceneIdRequest() { SceneId = request.SceneId });

						await TransferHelper.Transfer(unit, f2M_YeWaiSceneIdResponse.FubenInstanceId, (int)SceneTypeEnum.YeWaiScene, request.SceneId, 0);
						break;
					case (int)SceneTypeEnum.TrialDungeon:
						break;
					case (int)SceneTypeEnum.RandomTower:
						//2200001
						fubenid = IdGenerater.Instance.GenerateId();
						fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
						fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "RandomTower" + fubenid.ToString(), SceneType.Fuben);
						fubnescene.AddComponent<RandomTowerComponent>();
						MapComponent mapComponent = fubnescene.GetComponent<MapComponent>();
						mapComponent.SetMapInfo((int)SceneTypeEnum.RandomTower, request.SceneId, request.SceneSonId);
						mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
						TransferHelper.BeforeTransfer(unit);
						await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.RandomTower, request.SceneId, 0);
						TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
						break;
					case (int)SceneTypeEnum.Tower:
						//动态创建副本
						fubenid = IdGenerater.Instance.GenerateId();
						fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
						fubnescene = SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Tower" + fubenid.ToString(), SceneType.Fuben);
						fubnescene.AddComponent<TowerComponent>();
						mapComponent = fubnescene.GetComponent<MapComponent>();
						mapComponent.SetMapInfo((int)SceneTypeEnum.Tower, request.SceneId, request.SceneSonId);
						mapComponent.NavMeshId = SceneConfigCategory.Instance.Get(request.SceneId).MapID.ToString();
						unit.GetComponent<UserInfoComponent>().AddSceneFubenTimes(request.SceneId);
						TransferHelper.BeforeTransfer(unit);
						await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.Tower, request.SceneId, 0);
						TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
						break;
					case (int)SceneTypeEnum.PetTianTi:
						////动态创建副本
						long enemyId = long.Parse(request.paramInfo);
						fubenid = IdGenerater.Instance.GenerateId();
                        fubenInstanceId = IdGenerater.Instance.GenerateInstanceId();
                        fubnescene =  SceneFactory.Create(Game.Scene, fubenid, fubenInstanceId, unit.DomainZone(), "Fuben" + fubenid.ToString(), SceneType.Fuben);
                        fubnescene.AddComponent<PetTianTiComponent>().EnemyId = enemyId;
                        TransferHelper.BeforeTransfer(unit);
						await TransferHelper.Transfer(unit, fubenInstanceId, (int)SceneTypeEnum.PetTianTi, request.SceneId, 0);
						TransferHelper.NoticeFubenCenter(fubnescene, 1).Coroutine();
						break;
					case (int)SceneTypeEnum.LocalDungeon:
						LocalDungeonComponent localDungeon = unit.DomainScene().GetComponent<LocalDungeonComponent>();
						request.Difficulty = localDungeon != null ? localDungeon.FubenDifficulty : request.Difficulty;
						TransferHelper.LocalDungeonTransfer( unit, request.SceneId, request.TransferId, request.Difficulty );
						break;
					case (int)SceneTypeEnum.Battle:
						mapComponent = unit.DomainScene().GetComponent<MapComponent>();
						int sceneTypeEnum = mapComponent.SceneTypeEnum;
						long mapInstanceId = DBHelper.GetBattleServerId(unit.DomainZone());
						B2M_BattleEnterResponse battleEnter = (B2M_BattleEnterResponse)await ActorMessageSenderComponent.Instance.Call(
						mapInstanceId, new M2B_BattleEnterRequest() { UserID = unit.Id, SceneId = request.SceneId });
						TransferHelper.BeforeTransfer(unit);
						await TransferHelper.Transfer(unit, battleEnter.FubenInstanceId, (int)SceneTypeEnum.Battle, request.SceneId, battleEnter.Camp);
						break;
					case (int)SceneTypeEnum.TeamDungeon:
						mapComponent = unit.DomainScene().GetComponent<MapComponent>();
						sceneTypeEnum = mapComponent.SceneTypeEnum;
						mapInstanceId = StartSceneConfigCategory.Instance.GetBySceneName(unit.DomainZone(), Enum.GetName(SceneType.Team)).InstanceId;
						//[创建副本Scene]
						T2M_TeamDungeonEnterResponse createUnit = (T2M_TeamDungeonEnterResponse)await ActorMessageSenderComponent.Instance.Call(
						mapInstanceId, new M2T_TeamDungeonEnterRequest() { UserID = unit.GetComponent<UserInfoComponent>().UserInfo.UserId });
						TransferHelper.BeforeTransfer(unit);
						await TransferHelper.Transfer(unit, createUnit.FubenInstanceId, (int)SceneTypeEnum.TeamDungeon, createUnit.FubenId, 0);
						break;
					default:
						break;
				}
				reply();
				await ETTask.CompletedTask;
			}
			catch (Exception ex)
			{ 
				Log.Error(ex);
			}
		}
	}
}