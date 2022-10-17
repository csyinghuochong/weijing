using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_GMCommandHandler : AMActorLocationHandler<Unit, C2M_GMCommandRequest>
    {
		protected override async ETTask Run(Unit unit, C2M_GMCommandRequest message)
		{
			try
			{
				if (!GMHelp.GmAccount.Contains(message.Account)
					&& !ComHelp.IsBanHaoZone(unit.DomainZone()))
				{
					return;
				}

				string[] commands = message.GMMsg.Split('#');
				if (commands.Length == 0)
				{
					return;
				}
				if (message.GMMsg == "#allmonster")
				{
					List<MonsterConfig> monsterConfigs = MonsterConfigCategory.Instance.GetAll().Values.ToList();
					for (int i = 0; i < monsterConfigs.Count; i++)
					{
						await TimerComponent.Instance.WaitAsync(1);
						Vector3 pos = unit.Position;
						Vector3 vector3 = new Vector3(pos.x + RandomHelper.RandFloat01() * 1, pos.y, pos.z + RandomHelper.RandFloat01() * 1);
						Unit monster = UnitFactory.CreateMonster(unit.DomainScene(), monsterConfigs[i].Id, vector3,  new CreateMonsterInfo()
						{ 
							FubenDifficulty = FubenDifficulty.None,
							Camp = 2,
						});
					}
					return;
				}
				if (message.GMMsg == "#mianshang")
				{
					BuffData buffData_1 = new BuffData();
					buffData_1.BuffConfig = SkillBuffConfigCategory.Instance.Get(90106002);
					buffData_1.BuffClassScript = buffData_1.BuffConfig.BuffScript;
					unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_1, unit, null);
					return;
				}
				if (message.GMMsg == "#wudi")
				{
					BuffData buffData_2 = new BuffData();
					buffData_2.BuffConfig = SkillBuffConfigCategory.Instance.Get(90106003);
					buffData_2.BuffClassScript = buffData_2.BuffConfig.BuffScript;
					unit.GetComponent<BuffManagerComponent>().BuffFactory(buffData_2, unit, null);
					return;
				}
				if (message.GMMsg == "#openall")
				{
					unit.GetComponent<UserInfoComponent>().OpenAll();
					return;
				}
				if (message.GMMsg == "#resetlv")
				{
					int level = unit.GetComponent<UserInfoComponent>().UserInfo.Lv - 1;
					unit.GetComponent<UserInfoComponent>().UpdateRoleData( UserDataType.Lv, (level*-1).ToString()).Coroutine();
					return;
				}
				if (message.GMMsg == "#killall")
				{
					List<Entity> units = unit.GetParent<UnitComponent>().Children.Values.ToList();
					for(int i = units.Count - 1; i >= 0; i--)
					{
						if (units[i].GetComponent<UnitInfoComponent>().Type != UnitType.Monster)
						{
							continue;
						}
						units[i].GetComponent<NumericComponent>().ApplyChange(unit, NumericType.Now_Hp, -1000000000, 0);
					}
					return;
				}
				if (message.GMMsg == "#killmonster")
				{
					List<Entity> units = unit.GetParent<UnitComponent>().Children.Values.ToList();
					for (int i = units.Count - 1; i >= 0; i--)
					{
						UnitInfoComponent unitInfoComponent = units[i].GetComponent<UnitInfoComponent>();
						if (unitInfoComponent.Type != UnitType.Monster)
						{
							continue;
						}
						if (unitInfoComponent.GetMonsterType() == (int)MonsterTypeEnum.Boss)
						{
							continue;
						}
						units[i].GetComponent<NumericComponent>().ApplyChange(unit, NumericType.Now_Hp, -1000000000, 0);
					}
					return;
				}
				if (message.GMMsg == "#resetguide")
				{
					unit.GetComponent<UserInfoComponent>().UserInfo.CompleteGuideIds.Clear();
					return;
				}
				if (message.GMMsg == "#resetfuben")
				{
					unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.TeamDungeonTimes, "0").Coroutine();
					return;
				}
				if (message.GMMsg == "#completetask")
				{
					unit.GetComponent<TaskComponent>().CompletCurrentTask();
					return;
				}
				switch (int.Parse(commands[0]))
				{
					case 1:             //新增道具1#12000003#200 【添加道具/道具id/道具数量】
						int itemId = int.Parse(commands[1]);
						int itemNumber = int.Parse(commands[2]);

						List<RewardItem> rewardItems = new List<RewardItem>();
						rewardItems.Add(new RewardItem() { ItemID = itemId, ItemNum = itemNumber });
						unit.GetComponent<BagComponent>().OnAddItemData(rewardItems, 0, $"{ItemGetWay.GM}_{TimeHelper.ServerNow()}", true, true);
						break;
					case 2:             //新增怪物2#7.2#1.27#-2.57#72001013#1
						float posX = float.Parse(commands[1]);
						float posY = float.Parse(commands[2]);
						float posZ = float.Parse(commands[3]);
						int monsterId = int.Parse(commands[4]);
						int number = int.Parse(commands[5]);
					
						for (int c = 0; c < number; c++)
						{
							await TimerComponent.Instance.WaitAsync(1);
							Vector3 vector3 = new Vector3(posX + RandomHelper.RandFloat01() * 1, posY, posZ + RandomHelper.RandFloat01() * 1);
							Unit monster = UnitFactory.CreateMonster(unit.DomainScene(), monsterId, vector3, new CreateMonsterInfo()
							{ 
								FubenDifficulty = FubenDifficulty.None,
								Camp = 2
							});

							//M2C_CreateSpilings createSpilings = new M2C_CreateSpilings();
							//SpilingInfo spilingInfo = UnitHelper.CreateSpilingInfo(monster);
							//createSpilings.Spilings.Add(spilingInfo);
							//MessageHelper.Broadcast(unit, createSpilings);
						}
						break;
					case 4: //直接接取某个任务      4#30030009
						unit.GetComponent<TaskComponent>().OnGMGetTask(int.Parse(commands[1]));
						break;
					case 5: //直接获得某个宠物      5#1000101
						unit.GetComponent<PetComponent>().OnAddPet(int.Parse(commands[1]));
						break;
					case 6:
						int newLevel = int.Parse(commands[1]);
						int level = newLevel - unit.GetComponent<UserInfoComponent>().UserInfo.Lv;
						unit.GetComponent<UserInfoComponent>().UpdateRoleData(UserDataType.Lv, level.ToString()).Coroutine();
						break;
					case 7:
						long userID = long.Parse(commands[1]);
						long dbCacheId = DBHelper.GetDbCacheId(unit.DomainZone());

						List<string> componentList = new List<string>();
						componentList.Add(DBHelper.BagComponent);
						componentList.Add(DBHelper.TaskComponent);

						D2G_GetComponent d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = userID, Component = DBHelper.UserInfoComponent });
						UserInfoComponent userInfoComponent = d2GGetUnit.Component as UserInfoComponent;
						for (int i = 0; i < componentList.Count; i++)
						{
							d2GGetUnit = (D2G_GetComponent)await ActorMessageSenderComponent.Instance.Call(dbCacheId, new G2D_GetComponent() { CharacterId = userID, Component = componentList[i] });
							if (d2GGetUnit.Component == null)
							{
								continue;
							}
						}
						break;
					case 8:
						unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Ling_DiLv, int.Parse(commands[1]));
						unit.GetComponent<NumericComponent>().ApplyValue(NumericType.Ling_DiExp, 0);
						break;
				}
			}
			catch (Exception ex)
			{
				Log.Debug(ex.ToString());
			}

			await ETTask.CompletedTask;
		}
	}
}
