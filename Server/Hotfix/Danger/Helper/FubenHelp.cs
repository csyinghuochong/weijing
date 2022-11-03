
using System.Collections.Generic;
using UnityEngine;

namespace ET
{ 
    public static class FubenHelp
	{
		public static List<int> energySkills = new List<int>() { };

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

		public static void CreateMonsterList(Scene scene, int[] monsterPos, int fubenDifficulty)
		{
			energySkills = new List<int>() { 64000001, 64000002, 64000003, 64000004, 64000005, 64000006, 64000007, 64000008 };
			if (monsterPos == null || monsterPos.Length == 0)
			{
				return;
			}
			for (int i = 0; i < monsterPos.Length;i++)
			{
				int monsterId = monsterPos[i];

				while (monsterId != 0)
				{
					monsterId = CreateMonsterByPos(scene, monsterId, fubenDifficulty);
				}
			}
		}

		public static int CreateMonsterByPos(Scene scene, int monsterPos, int fubenDifficulty)
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
			Vector3 initpos = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));

			if (mtype == 1)    //固定位置刷怪
			{
				for (int c = 0; c < monsterPosition.CreateNum; c++)
				{
					MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterid);
					Vector3 vector3 = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));

					//51 场景怪 有AI 不显示名称
					//52 能量台子 无AI
					//54 场景怪 有AI 显示名称
					//55 宝箱类 无AI
					if (monsterConfig.MonsterSonType == 52)
					{
						int skillId = energySkills[RandomHelper.RandomNumber(0, energySkills.Count)];
						energySkills.Remove(skillId);
						UnitFactory.CreateMonster(scene, monsterConfig.Id, vector3, new CreateMonsterInfo()
						{
							SkillId = skillId,
							FubenDifficulty = fubenDifficulty,
							Camp = monsterConfig.MonsterCamp,
							Rotation = monsterPosition.Create,
						});
					}
					else
					{
						UnitFactory.CreateMonster(scene, monsterConfig.Id, vector3, new CreateMonsterInfo()
						{
							FubenDifficulty = fubenDifficulty,
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
					Vector3 form = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
					Vector3 to = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
					Vector3 vector3 = scene.GetComponent<MapComponent>().GetCanReachPath(form, to);
					UnitFactory.CreateMonster(scene, monsterPosition.MonsterID, vector3, new CreateMonsterInfo()
					{
						FubenDifficulty = fubenDifficulty,
						Camp = monsterConfig.MonsterCamp,
						Rotation = monsterPosition.Create,
					});
				}
			}
			if (mtype == 3)
			{
				//定时刷新  YeWaiRefreshComponent
				scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterByPos(monsterPosition.Id, fubenDifficulty);
			}
			if (mtype == 4)
			{
				//4; 0,0,0; 71020001; 2,2; 2, 2
				int playerLv = 1;
				if (fubenDifficulty == FubenDifficulty.Tower)
				{
					Unit mainUnit = scene.GetComponent<TowerComponent>().MainUnit;
					playerLv = mainUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
				}
				for (int c = 0; c < monsterPosition.CreateNum; c++)
				{
					float range = (float)monsterPosition.CreateRange;
					MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(monsterPosition.MonsterID);
					Vector3 form = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
					Vector3 to = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
					Vector3 vector3 = scene.GetComponent<MapComponent>().GetCanReachPath(form, to);
					UnitFactory.CreateMonster(scene, monsterPosition.MonsterID, vector3, new CreateMonsterInfo()
					{
						PlayerLevel = playerLv,
						AttributeParams = monsterPosition.Par,
						FubenDifficulty = fubenDifficulty,
						Camp = monsterConfig.MonsterCamp,
						Rotation = monsterPosition.Create,
					});
				}
			}

			return monsterPosition.NextID;
		}

		public static  void CreateMonsterList(Scene scene, string createMonster, int fubenDifficulty)
		{
			if (ComHelp.IfNull(createMonster))
            {
				return;
            }
			energySkills = new List<int>() { 64000001, 64000002, 64000003, 64000004, 64000005, 64000006, 64000007, 64000008 };
			long instanceId = scene.InstanceId;
			string[] monsters = createMonster.Split('@');
			//1;37.65,0,3.2;70005005;1@138.43,0,0.06;70005010;1
			for (int i = 0; i < monsters.Length; i++)
			{
				if (monsters[i] == "0")
				{
					continue;
				}
				//1;37.65,0,3.2;70005005;1
				string[] mondels = monsters[i].Split(';');
				string[] mtype = mondels[0].Split(',');
				string[] position = mondels[1].Split(',');
				string[] monsterid = mondels[2].Split(',');
				string[] mcount = mondels[3].Split(',');

				if (mtype[0] == "1")    //固定位置刷怪
				{
					for (int c = 0; c < int.Parse(mcount[0]); c++)
					{
						if (instanceId != scene.InstanceId)
						{
							return;
						}

						MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(int.Parse(monsterid[0]));
						Vector3 vector3 = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));

						//51 场景怪 有AI 不显示名称
						//52 能量台子 无AI
						//54 场景怪 有AI 显示名称
						//55 宝箱类 无AI
						if (monsterConfig.MonsterSonType == 52)
						{
							int skillId = energySkills[RandomHelper.RandomNumber(0, energySkills.Count)];
							energySkills.Remove(skillId);
							UnitFactory.CreateMonster(scene, monsterConfig.Id, vector3, new CreateMonsterInfo() 
							{ 
								SkillId = skillId, FubenDifficulty = fubenDifficulty,
								Camp   = monsterConfig.MonsterCamp
							});
						}
						else
						{
							UnitFactory.CreateMonster(scene, monsterConfig.Id, vector3,  new CreateMonsterInfo()
							{
								FubenDifficulty = fubenDifficulty,
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
						if (instanceId != scene.InstanceId)
						{
							return;
						}
						MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(int.Parse(monsterid[0]));
						float range = float.Parse(mcount[1]);
						Vector3 form = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
						Vector3 to = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
						Vector3 vector3 = scene.GetComponent<MapComponent>().GetCanReachPath(form, to);
						UnitFactory.CreateMonster(scene, int.Parse(monsterid[0]), vector3, new CreateMonsterInfo()
						{ 
							FubenDifficulty = fubenDifficulty,
							Camp = monsterConfig.MonsterCamp
						});
					}
				}
				if (mtype[0] == "3")
				{
					//野外场景定时刷新
					scene.GetComponent<YeWaiRefreshComponent>().CreateMonsterList(createMonster, fubenDifficulty);
				}
				if (mtype[0] == "4")
				{
					//4; 0,0,0; 71020001; 2,2; 2, 2
					int playerLv = 1;
					if (fubenDifficulty == FubenDifficulty.Tower)
					{
						Unit mainUnit = scene.GetComponent<TowerComponent>().MainUnit;
						playerLv = mainUnit.GetComponent<UserInfoComponent>().UserInfo.Lv;
					}
					int cmcount = int.Parse(mcount[0]);
					for (int c = 0; c < cmcount; c++)
					{
						float range = float.Parse(mcount[1]);
						Vector3 form = new Vector3(float.Parse(position[0]), float.Parse(position[1]), float.Parse(position[2]));
						Vector3 to = new Vector3(float.Parse(position[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), float.Parse(position[1]), float.Parse(position[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
						Vector3 vector3 = scene.GetComponent<MapComponent>().GetCanReachPath(form, to);
						MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(int.Parse(monsterid[0]));
						UnitFactory.CreateMonster(scene, int.Parse(monsterid[0]), vector3,  new CreateMonsterInfo() {
							PlayerLevel = playerLv, AttributeParams = mondels[4] + ";" + mondels[5] , FubenDifficulty = fubenDifficulty,
							Camp = monsterConfig.MonsterCamp
						});
					}
				}
			}
		}

		public static bool IsAllMonsterDead(Scene scene)
		{
			List<Unit> units = scene.GetComponent<UnitComponent>().GetAll();
			for(int i = 0; i < units.Count; i++)
			{
				if (units[i].Type == UnitType.Monster
				&& units[i].GetComponent<UnitInfoComponent>().IsCanBeAttack()
				&& units[i].GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 0)
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

		public static void SendPickMessage(Unit unit, DropInfo dropInfo, M2C_SyncChatInfo m2C_SyncChatInfo)
		{
			UserInfoComponent userInfoComponent = unit.GetComponent<UserInfoComponent>();
			m2C_SyncChatInfo.ChatInfo = new ChatInfo();
			m2C_SyncChatInfo.ChatInfo.PlayerLevel = userInfoComponent.UserInfo.Lv;
			m2C_SyncChatInfo.ChatInfo.Occ = userInfoComponent.UserInfo.Occ;
			m2C_SyncChatInfo.ChatInfo.ChannelId = (int)ChannelEnum.System;

			ItemConfig itemConfig = ItemConfigCategory.Instance.Get(dropInfo.ItemID);
			string numShow = "";
			if (itemConfig.Id == 1)
			{
				numShow = dropInfo.ItemNum.ToString();
			}
			string colorValue = ComHelp.QualityReturnColor(itemConfig.ItemQuality);
			m2C_SyncChatInfo.ChatInfo.ChatMsg = $"<color=#FDD376>{unit.GetComponent<UserInfoComponent>().UserInfo.Name}</color>拾取<color=#{colorValue}>{numShow}{itemConfig.ItemName}</color>";
			MessageHelper.Broadcast(unit, m2C_SyncChatInfo);
		}
	}
}
