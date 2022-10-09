using System;
using UnityEngine;
using System.Linq;

namespace ET
{
	[ActorMessageHandler]
	public class M2M_UnitTransferRequestHandler : AMActorRpcHandler<Scene, M2M_UnitTransferRequest, M2M_UnitTransferResponse>
	{
		protected override async ETTask Run(Scene scene, M2M_UnitTransferRequest request, M2M_UnitTransferResponse response, Action reply)
		{
			try
			{
				await ETTask.CompletedTask;
				scene.GetComponent<MapComponent>().SetMapInfo((int)request.SceneType, request.ChapterId, request.SonId);
				UnitComponent unitComponent = scene.GetComponent<UnitComponent>();
				if (unitComponent.Get(request.Unit.Id) != null)
				{
					Log.Error($"LoginTest M2M_UnitTransfer   unitComponent.Get(unit.Id)!=null:  {request.Unit.Id} {request.SceneType}");
					response.Error = ErrorCore.ERR_OperationOften;
					reply();
					return;
				}
				else
				{
					Log.Debug($"LoginTest M2M_UnitTransfer {request.Unit.Id}  {request.SceneType}");
				}
				Unit unit = request.Unit;
				unitComponent.AddChild(unit);
				unitComponent.Add(unit);
				foreach (Entity entity in request.Entitys)
				{
					unit.AddComponent(entity);
				}
				unit.AddComponent<MoveComponent>();
				unit.AddComponent<MailBoxComponent>();
				unit.AddComponent<ObjectWait>();
				unit.AddComponent<SkillManagerComponent>();
				unit.AddComponent<BuffManagerComponent>();
				//添加消息类型, GateSession邮箱在收到消息的时候会立即转发给客户端，MessageDispatcher类型会再次对Actor消息进行分发到具体的Handler处理，默认的MailboxComponent类型是MessageDispatcher。
				//await unit.AddLocation();                     
				//注册消息机制的ID,可以通过消息ID让其他玩家对自己进行消息发送
				//客户端收到创建Unit之后会请求数据。 不用通知
				switch (request.SceneType)
				{
					case (int)SceneTypeEnum.CellDungeon:
						unit.ResetPostion();
						int sonid = scene.GetComponent<CellDungeonComponent>().CurrentFubenCell.sonid;
						ChapterSonConfig chapterSon = ChapterSonConfigCategory.Instance.Get(sonid);
						unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId.ToString());
						Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(scene.GetComponent<MapComponent>().NavMeshId));
						scene.GetComponent<CellDungeonComponent>().MainUnit = unit;
						//更新unit坐标
						unit.Position = new Vector3(chapterSon.BornPosLeft[0] * 0.01f, chapterSon.BornPosLeft[1] * 0.01f, chapterSon.BornPosLeft[2] * 0.01f);
						unit.Rotation = Quaternion.identity;

						// 通知客户端创建My Unit
						M2C_CreateMyUnit m2CCreateUnits = new M2C_CreateMyUnit();
						m2CCreateUnits.Unit = UnitHelper.CreateUnitInfo(unit);
						MessageHelper.SendToClient(unit, m2CCreateUnits);
						// 加入aoi
						unit.AddComponent<AOIEntity, int, Vector3>(40 * 1000, unit.Position);
						scene.GetComponent<CellDungeonComponent>().GenerateFubenScene(false);
						RolePetInfo fightId = unit.GetComponent<PetComponent>().GetFightPet();
						if (fightId != null)
						{
							UnitFactory.CreatePet(unit, fightId);
						}
						break;
					case (int)SceneTypeEnum.PetDungeon:
					case (int)SceneTypeEnum.PetTianTi:
						SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(request.ChapterId);
						scene.GetComponent<MapComponent>().NavMeshId = sceneConfig.MapID.ToString();
						unit.AddComponent<PathfindingComponent, string>(sceneConfig.MapID.ToString());
						Game.Scene.GetComponent<RecastPathComponent>().Update(sceneConfig.MapID);

						//更新unit坐标
						unit.Position = new Vector3(sceneConfig.InitPos[0] * 0.01f, sceneConfig.InitPos[1] * 0.01f, sceneConfig.InitPos[2] * 0.01f);
						unit.Rotation = Quaternion.identity;

						m2CCreateUnits = new M2C_CreateMyUnit();
						m2CCreateUnits.Unit = UnitHelper.CreateUnitInfo(unit);
						MessageHelper.SendToClient(unit, m2CCreateUnits);
						// 加入aoi
						unit.AddComponent<AOIEntity, int, Vector3>(40 * 1000, unit.Position);
						if (request.SceneType == (int)SceneTypeEnum.PetDungeon)
						{
							scene.GetComponent<PetFubenSceneComponent>().MainUnit = unit;
							scene.GetComponent<PetFubenSceneComponent>().GeneratePetFuben(unit, request.SonId);
						}
						if (request.SceneType == (int)SceneTypeEnum.PetTianTi)
						{
							scene.GetComponent<PetTianTiComponent>().MainUnit = unit;
							scene.GetComponent<PetTianTiComponent>().GeneratePetFuben().Coroutine();
						}
						break;
					case (int)SceneTypeEnum.LocalDungeon:
						unit.GetComponent<NumericComponent>().ApplyValue(NumericType.TaskDungeonID, request.ChapterId, false);
						DungeonConfig dungeonConfig = DungeonConfigCategory.Instance.Get(request.ChapterId);
						scene.GetComponent<MapComponent>().NavMeshId = dungeonConfig.MapID.ToString();
						unit.ResetPostion();

						unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId.ToString());
						Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(scene.GetComponent<MapComponent>().NavMeshId));
						//更新unit坐标
						if (request.TransferId != 0)
						{
							DungeonTransferConfig transferConfig = DungeonTransferConfigCategory.Instance.Get(request.TransferId);
							unit.Position = new Vector3(transferConfig.BornPos[0] * 0.01f, transferConfig.BornPos[1] * 0.01f, transferConfig.BornPos[2] * 0.01f);
						}
						else
						{
							unit.Position = new Vector3(dungeonConfig.BornPosLeft[0] * 0.01f, dungeonConfig.BornPosLeft[1] * 0.01f, dungeonConfig.BornPosLeft[2] * 0.01f);
						}
						unit.Rotation = Quaternion.identity;
						// 通知客户端创建My Unit
						m2CCreateUnits = new M2C_CreateMyUnit();
						m2CCreateUnits.Unit = UnitHelper.CreateUnitInfo(unit);
						MessageHelper.SendToClient(unit, m2CCreateUnits);
						// 加入aoi
						unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
						fightId = unit.GetComponent<PetComponent>().GetFightPet();
						if (fightId != null)
						{
							UnitFactory.CreatePet(unit, fightId);
						}

						scene.GetComponent<LocalDungeonComponent>().MainUnit = unit;
						scene.GetComponent<LocalDungeonComponent>().GenerateFubenScene(request.ChapterId);
						break;
					case (int)SceneTypeEnum.TeamDungeon:
					case (int)SceneTypeEnum.YeWaiScene:
					case (int)SceneTypeEnum.RandomTower:
					case (int)SceneTypeEnum.Tower:
						unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId.ToString());
						sceneConfig = SceneConfigCategory.Instance.Get(request.ChapterId);
						unit.Position = new Vector3(sceneConfig.InitPos[0] * 0.01f, sceneConfig.InitPos[1] * 0.01f, sceneConfig.InitPos[2] * 0.01f);
						unit.Rotation = Quaternion.identity;

						// 通知客户端创建My Unit
						m2CCreateUnits = new M2C_CreateMyUnit();
						m2CCreateUnits.Unit = UnitHelper.CreateUnitInfo(unit);
						MessageHelper.SendToClient(unit, m2CCreateUnits);
						// 加入aoi
						unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);

						if (request.SceneType == (int)SceneTypeEnum.Tower)
						{
							Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(scene.GetComponent<MapComponent>().NavMeshId));
							unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Tower_ID, 0, true);
							scene.GetComponent<TowerComponent>().MainUnit = unit;
							scene.GetComponent<TowerComponent>().BeginTower(request.ChapterId);
							//FubenHelp.CreateMonsterList(scene, FubenDifficulty.Normal, sceneConfig.CreateMonster).Coroutine();
						}
						if (request.SceneType == (int)SceneTypeEnum.RandomTower)
						{
							Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(scene.GetComponent<MapComponent>().NavMeshId));
							scene.GetComponent<RandomTowerComponent>().MainUnit = unit;
							//RandomTowerConfig randowTowerConfig = RandomTowerConfigCategory.Instance.GetAll().Values.ToList()[0];
							//FubenHelp.CreateMonsterList(scene, randowTowerConfig.MonsterSet, FubenDifficulty.None).Coroutine();
						}
						if (request.SceneType == (int)SceneTypeEnum.TeamDungeon && scene.GetComponent<UnitComponent>().Children.Values.Count == 1)
						{
							Game.Scene.GetComponent<RecastPathComponent>().Update(int.Parse(scene.GetComponent<MapComponent>().NavMeshId));
							FubenHelp.CreateMonsterList(scene, sceneConfig.CreateMonster, FubenDifficulty.Teamdungeon);
						}
						fightId = unit.GetComponent<PetComponent>().GetFightPet();
						if (fightId != null)
						{
							UnitFactory.CreatePet(unit, fightId);
						}
						break;
					case (int)SceneTypeEnum.MainCityScene:
						sceneConfig = SceneConfigCategory.Instance.Get(ComHelp.MainCityID());
						NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
						if (numericComponent.GetAsFloat(NumericType.MainCity_X) == 0)
						{
							unit.Position = new Vector3(sceneConfig.InitPos[0] * 0.01f, sceneConfig.InitPos[1] * 0.01f, sceneConfig.InitPos[2] * 0.01f);
						}
						else
						{
							unit.Position = new Vector3(numericComponent.GetAsFloat(NumericType.MainCity_X), numericComponent.GetAsFloat(NumericType.MainCity_Y), numericComponent.GetAsFloat(NumericType.MainCity_Z));
						}
						unit.ResetPostion();
						unit.AddComponent<PathfindingComponent, string>(scene.GetComponent<MapComponent>().NavMeshId);
						unit.GetComponent<HeroDataComponent>().OnReturn();
						// 通知客户端创建My Unit
						m2CCreateUnits = new M2C_CreateMyUnit();
						m2CCreateUnits.Unit = UnitHelper.CreateUnitInfo(unit);
						MessageHelper.SendToClient(unit, m2CCreateUnits);

						// 加入aoi
						unit.AddComponent<AOIEntity, int, Vector3>(9 * 1000, unit.Position);
						fightId = unit.GetComponent<PetComponent>().GetFightPet();
						if (fightId != null)
						{
							UnitFactory.CreatePet(unit, fightId);
						}
						break;
				}

				unit.GetComponent<BuffManagerComponent>().InitBuff();
				unit.GetComponent<DBSaveComponent>().Activeted();
				unit.GetComponent<SkillPassiveComponent>().Activeted();
				unit.SingleScene = request.SceneType == SceneTypeEnum.LocalDungeon || request.SceneType == SceneTypeEnum.PetDungeon;
				response.NewInstanceId = unit.InstanceId;
				reply();
			}
			catch (Exception ex)
			{
				Log.Debug($"LoginTest M2M_UnitTransfer Exception  {request.Unit.Id} {ex.ToString()}");
			}
		}
	}
}