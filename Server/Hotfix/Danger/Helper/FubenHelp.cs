
using System.Collections.Generic;
using UnityEngine;

namespace ET
{ 
    public static class FubenHelp
	{

		public static M2C_SyncChatInfo m2C_SyncChatInfo = new M2C_SyncChatInfo();

		/// <summary>
		/// 寻找一个可通行的随机位置
		/// </summary>
		/// <param name="unit"></param>
		/// <param name="from"></param>
		/// <param name="target"></param>
		/// <returns></returns>
		public static bool GetCanReachPath(Scene scene, int navMeshId, Vector3 from, Vector3 target)
		{
			var list = ListComponent<Vector3>.Create();
			//scene.GetComponent<PathfindingComponent>().Find(from, target, list);
			List<Vector3> path = list;
			if (path.Count >= 2)
				return true;

			return false;
		}

		public static void CreateMonsterList(Scene scene, int[] monsterPos)
		{
			if (monsterPos == null || monsterPos.Length == 0)
			{
				return;
			}
			for (int i = 0; i < monsterPos.Length;i++)
			{
				int monsterId = monsterPos[i];

				while (monsterId != 0)
				{
					monsterId = CreateMonsterByPos(scene, monsterId);
				}
			}
		}

		public static int CreateMonsterByPos(Scene scene, int monsterPos)
		{
			if (monsterPos == 0)
			{
				return 0;
			}
			//Id      NextID  Type Position             MonsterID CreateRange CreateNum Create    Par(3代表刷新时间)
			//10001   10002   2    - 71.46,0.34,-5.35   81000002       0           1       90    30,60
			MonsterPositionConfig monsterPosition = MonsterPositionConfigCategory.Instance.Get(monsterPos);
			int mtype = monsterPosition.Type;
			int monsterid = monsterPosition.MonsterID;
			string[] position = monsterPosition.Position.Split(',');
			if (mtype == 1)    //固定位置刷怪
			{
				for (int c = 0; c < monsterPosition.CreateNum; c++)
				{
					MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
					Vector3 vector3 = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));

					//51 场景怪 有AI 不显示名称
					//52 能量台子 无AI
					//54 场景怪 有AI 显示名称
					//55 宝箱类(一次) 无AI
					//56 宝箱类(无限) 无AI
					if (monsterConfig.MonsterSonType != 52)
					{
						UnitFactory.CreateMonster(scene, monsterConfig.Id, vector3, new CreateMonsterInfo()
						{
							Camp = monsterConfig.MonsterCamp,
							Rotation = monsterPosition.Create,
						});
					}
				}
			}
			if (mtype == 2)
			{
				for (int c = 0; c < monsterPosition.CreateNum; c++)
				{
					float range = (float)monsterPosition.CreateRange;
					MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterPosition.MonsterID);
					Vector3 vector3 = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
					UnitFactory.CreateMonster(scene, monsterPosition.MonsterID, vector3, new CreateMonsterInfo()
					{
						Camp = monsterConfig.MonsterCamp,
						Rotation = monsterPosition.Create,
					});
				}
			}
			if (mtype == 3)
			{
				//定时刷新  YeWaiRefreshComponent
				scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterByPos(monsterPosition.Id);
			}
			if (mtype == 4)
			{
				//4; 0,0,0; 71020001; 2,2; 2, 2
				int playerLv = 1;
				if (scene.GetComponent<MapComponent>().SceneTypeEnum == SceneTypeEnum.Tower)
				{
					Unit mainUnit = scene.GetComponent<TowerComponent>().MainUnit;
					playerLv = mainUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
				}
				for (int c = 0; c < monsterPosition.CreateNum; c++)
				{
					float range = (float)monsterPosition.CreateRange;
					MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterPosition.MonsterID);
					Vector3 vector3 = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
					UnitFactory.CreateMonster(scene, monsterPosition.MonsterID, vector3, new CreateMonsterInfo()
					{
						PlayerLevel = playerLv,
						AttributeParams = monsterPosition.Par,
						Camp = monsterConfig.MonsterCamp,
						Rotation = monsterPosition.Create,
					});
				}
			}
			if (mtype == 5 || mtype == 6)
			{
				//固定时间刷新  YeWaiRefreshComponent
				scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterByPos_2(monsterPosition.Id);
			}

			return monsterPosition.NextID;
		}

		public static  void CreateMonsterList(Scene scene, string createMonster)
		{
			if (ComHelp.IfNull(createMonster))
            {
				return;
            }
			
			MapComponent mapComponent = scene.GetComponent<MapComponent>();
			int sceneType = mapComponent.SceneTypeEnum;
			string[] monsters = createMonster.Split('@');
			//1;37.65,0,3.2;70005005;1@138.43,0,0.06;70005010;1
			for (int i = 0; i < monsters.Length; i++)
			{
				if (ComHelp.IfNull(monsters[i]))
				{
					continue;
				}
				//2;37.65,0,3.2;70005005;1,2
				string[] mondels = monsters[i].Split(';');
				string[] mtype = mondels[0].Split(',');
				string[] position = mondels[1].Split(',');
				int monsterid =  int.Parse(mondels[2]);
				string[] mcount = mondels[3].Split(',');
				if (!MonsterConfigCategory.Instance.Contain(monsterid))
				{
					Log.Error($"monsterid==null {monsterid}");
					continue;
				}

				MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
				if (sceneType == SceneTypeEnum.LocalDungeon && monsterConfig.MonsterType == MonsterTypeEnum.Normal)
				{
					Unit mainUnit = scene.GetComponent<LocalDungeonComponent>().MainUnit;
					monsterid = mainUnit.GetComponent<UserInfoComponent>().GetRandomMonsterId(monsterid);
				}
				if (mapComponent.SceneTypeEnum == SceneTypeEnum.LocalDungeon && monsterConfig.MonsterSonType == 55)
				{
					Unit mainUnit = scene.GetComponent<LocalDungeonComponent>().MainUnit;
					UserInfoComponent userInfoComponent = mainUnit.GetComponent<UserInfoComponent>();
					if (userInfoComponent.IsCheskOpen(mapComponent.SceneId, monsterid))
					{
						return;
					}
				}

				if (mtype[0] == "1")    //固定位置刷怪
				{
					for (int c = 0; c < int.Parse(mcount[0]); c++)
					{
						
						Vector3 vector3 = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));

						//51 场景怪 有AI 不显示名称
						//52 能量台子 无AI
						//54 场景怪 有AI 显示名称
						//55 宝箱类 无AI
						if (monsterConfig.MonsterSonType == 52)
						{
							CellDungeonComponent cellDungeonComponent = scene.GetComponent<CellDungeonComponent>();
							if (cellDungeonComponent!=null)
							{
								List<int> EnergySkills = cellDungeonComponent.EnergySkills;
								int skillId = EnergySkills[RandomHelper.RandomNumber(0, EnergySkills.Count)];
								EnergySkills.Remove(skillId);
								UnitFactory.CreateMonster(scene, monsterConfig.Id, vector3, new CreateMonsterInfo()
								{
									SkillId = skillId,
									Camp = monsterConfig.MonsterCamp
								});
							}
						}
						else
						{
							UnitFactory.CreateMonster(scene, monsterid, vector3,  new CreateMonsterInfo()
							{
								Camp = monsterConfig.MonsterCamp
							});
						}
					}
				}
				if (mtype[0] == "2")
				{
					int cmcount = int.Parse(mcount[0]);
					for (int c = 0; c < cmcount; c++)
					{
						float range = float.Parse(mcount[1]);
						Vector3 vector3 = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
						UnitFactory.CreateMonster(scene, monsterid, vector3, new CreateMonsterInfo()
						{ 
							Camp = monsterConfig.MonsterCamp
						});
					}
				}
				if (mtype[0] == "3")
				{
					//野外场景定时刷新
					//scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterList(createMonster);
					scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterList(monsters[i]);
				}
				if (mtype[0] == "4")
				{
					//4; 0,0,0; 71020001; 2,2; 2, 2  //是随机塔附加属性
					int playerLv = 1;
					if (scene.GetComponent<MapComponent>().SceneTypeEnum == SceneTypeEnum.Tower)
					{
						Unit mainUnit = scene.GetComponent<TowerComponent>().MainUnit;
						playerLv = mainUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
					}
					int cmcount = int.Parse(mcount[0]);
					for (int c = 0; c < cmcount; c++)
					{
						float range = float.Parse(mcount[1]);
						Vector3 vector3 = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
						UnitFactory.CreateMonster(scene, monsterid, vector3,  new CreateMonsterInfo() {
							PlayerLevel = playerLv, AttributeParams = mondels[4] + ";" + mondels[5],
							Camp = monsterConfig.MonsterCamp
						});
					}
				}
				//固定时间刷新
				if (mtype[0] == "5" || mtype[0] == "6")
				{
					//scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterList_2(createMonster);
					scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterList_2(monsters[i]);
				}
			}
		}

		public static bool IsAllMonsterDead(Scene scene, Unit main)
		{
			List<Unit> units = scene.GetComponent<UnitComponent>().GetAll();
			for(int i = 0; i < units.Count; i++)
			{
				if (units[i].Type == UnitType.Monster && main.IsCanAttackUnit(units[i]))
				{
					return false;
				}
			}

			return true;
		}

		public static int GetAlivePetNumber(Scene scene)
		{
			int petNumber = 0;
			List<Unit> units = scene.GetComponent<UnitComponent>().GetAll();
			for(int i = 0; i < units.Count; i++)
			{
				if (units[i].Type == UnitType.Pet && units[i].GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 0)
				{
					petNumber++;
				}
			}

			return petNumber;
		}

		public static List<Unit> GetUnitListByCamp(Scene scene, int unitType, int camp)
		{
			List<Unit> units = new List<Unit>();
			List<Unit> allunits = scene.GetComponent<UnitComponent>().GetAll();
			for (int i = 0; i < allunits.Count; i++)
			{
				if (allunits[i].Type == unitType && allunits[i].GetBattleCamp() == camp)
				{
					units.Add(allunits[i]);
				}
			}
			return units;
		}

		public static List<Unit> GetAliveUnitList(Scene scene, int unitType)
		{
			List<Unit> units = new List<Unit>();
			List<Unit> allunits = scene.GetComponent<UnitComponent>().GetAll();
			for (int i = 0; i < allunits.Count; i++)
			{
				if (allunits[i].Type == unitType && allunits[i].GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 0)
				{
					units.Add(allunits[i]);
				}
			}
			return units;
		}

		public static List<Unit> GetUnitList(Scene scene, int unitType)
		{
			List<Unit> units = new List<Unit>();
			List<Unit> allunits = scene.GetComponent<UnitComponent>().GetAll();
			for (int i = 0; i < allunits.Count; i++)
			{
				if (allunits[i].Type == unitType)
				{
					units.Add(allunits[i]);
				}
			}
			return units;
		}

		public static void SendTeamPickMessage(Unit unit, DropInfo dropInfo,List<long> ids,  List<int> points)
		{
			m2C_SyncChatInfo.ChatInfo = new ChatInfo();
			m2C_SyncChatInfo.ChatInfo.PlayerLevel = unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
			m2C_SyncChatInfo.ChatInfo.Occ = unit.GetComponent<UserInfoComponent>().UserInfo.Occ;
			m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.Pick;

			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(dropInfo.ItemID);
			string numShow = "";
			if (itemConfig.Id == 1)
			{
				numShow = dropInfo.ItemNum.ToString();
			}
			string colorValue = ComHelp.QualityReturnColor(itemConfig.ItemQuality);
			m2C_SyncChatInfo.ChatInfo.ChatMsg = $"<color=#FDD376>{unit.GetComponent<UserInfoComponent>().UserInfo.Name}</color>拾取<color=#{colorValue}>{numShow}{itemConfig.ItemName}</color>";

			for (int p = 0; p < points.Count; p++)
			{
				Unit player = unit.GetParent<UnitComponent>().Get(ids[p]);
				if (player == null)
				{
					continue;
				}
				
				m2C_SyncChatInfo.ChatInfo.ChatMsg += $"{player.GetComponent<UserInfoComponent>().UserInfo.Name}:{points[p]}点";
				m2C_SyncChatInfo.ChatInfo.ChatMsg += (p == points.Count - 1 ? "" : "  ");
			}

			MessageHelper.SendToClient(GetUnitList(unit.DomainScene(), UnitType.Player), m2C_SyncChatInfo);
		}

		public static void SendFubenPickMessage(Unit unit, DropInfo dropInfo)
		{
			UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
			m2C_SyncChatInfo.ChatInfo = new ChatInfo();
			m2C_SyncChatInfo.ChatInfo.PlayerLevel = userInfoComponent.UserInfo.Lv;
			m2C_SyncChatInfo.ChatInfo.Occ = userInfoComponent.UserInfo.Occ;
			m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.Pick;

			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(dropInfo.ItemID);
			string numShow = "";
			if (itemConfig.Id == 1)
			{
				numShow = dropInfo.ItemNum.ToString();
			}
			string colorValue = ComHelp.QualityReturnColor(itemConfig.ItemQuality);
			m2C_SyncChatInfo.ChatInfo.ChatMsg = $"<color=#FDD376>{unit.GetComponent<UserInfoComponent>().UserInfo.Name}</color>拾取<color=#{colorValue}>{numShow}{itemConfig.ItemName}</color>";
			//MessageHelper.SendToClient(GetUnitList(unit.DomainScene(), UnitType.Player), m2C_SyncChatInfo);
			Log.Warning($"SendFubenPickMessage: {unit.Id} {dropInfo.ItemID}");
			MessageHelper.SendToClient(unit, m2C_SyncChatInfo);
		}
	}
}
