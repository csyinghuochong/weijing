using System;
using System.Collections.Generic;

namespace ET
{
    public static class DropHelper
    {
		public struct DropItemInfo
		{
			public int Weight;
			public int ItemID;
			public int MinNumber;
			public int MaxNumber;

			public DropItemInfo(int weight, int itemid, int min, int max)
			{
				this.Weight = weight;
				this.ItemID = itemid;
				this.MinNumber = min;
				this.MaxNumber = max;
			}
		}

		public static int randomSet;  //记录货币数量的随机值

		//随机权重1
		public static int GetRandomBoxItem_1(string itemUsePar)
		{
			string[] randomItems = itemUsePar.Split('@');
			int totalWeight = 0;
			for (int i = 0; i < randomItems.Length; i++)
			{
				string[] itemInfo = randomItems[i].Split(';');
				totalWeight += int.Parse(itemInfo[1]);
			}

			int randomWeight = RandomHelper.RandomNumber(0, totalWeight);
			int curentWeight = 0;
			for (int i = 0; i < randomItems.Length; i++)
			{
				string[] itemInfo = randomItems[i].Split(';');
				curentWeight += int.Parse(itemInfo[1]);
				if (curentWeight >= randomWeight)
				{
					return int.Parse(itemInfo[0]);
				}
			}
			return int.Parse(randomItems[0].Split(';')[0]);
		}

		//随机权重2
		public static int GetRandomBoxItem_2(string itemUsePar)
		{
			string[] randomItems = itemUsePar.Split('@');
			int totalWeight = 0;
			for (int i = 0; i < randomItems.Length; i++)
			{
				string[] itemInfo = randomItems[i].Split(';');
				totalWeight += int.Parse(itemInfo[1]);
			}

			List<int> WeightList = new List<int>();
			int maxWeight = 0;
			for (int i = 0; i < randomItems.Length; i++)
			{
				string[] itemInfo = randomItems[i].Split(';');
				int curWeight = int.Parse(itemInfo[1]) + RandomHelper.RandomNumber(0, totalWeight);
				WeightList.Add(curWeight);
				if (curWeight > maxWeight)
				{
					maxWeight = curWeight;
				}
			}
			int maxIndex = WeightList.IndexOf(maxWeight);
			return int.Parse(randomItems[maxIndex].Split(';')[0]);
		}

		/// <summary>
		/// 只掉落一个道具
		/// </summary>
		/// <param name="dropID"></param>
		/// <param name="dropItemList"></param>
		public static void  DropIDToDropItem_2(int dropID, List<RewardItem> dropItemList)
		{
			int totalWeight = 0;
			List<DropItemInfo> totalItemId = new List<DropItemInfo>();
			while (dropID != 0)
			{
				DropConfig dropconf = DropConfigCategory.Instance.Get(dropID);

				totalWeight += dropconf.DropChance1;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance1, ItemID = dropconf.DropItemID1, MinNumber = dropconf.DropItemMinNum1, MaxNumber = dropconf.DropItemMaxNum1 });

				totalWeight += dropconf.DropChance2;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance2, ItemID = dropconf.DropItemID2, MinNumber = dropconf.DropItemMinNum2, MaxNumber = dropconf.DropItemMaxNum2 });

				totalWeight += dropconf.DropChance3;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance3, ItemID = dropconf.DropItemID3, MinNumber = dropconf.DropItemMinNum3, MaxNumber = dropconf.DropItemMaxNum3 });

				totalWeight += dropconf.DropChance4;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance4, ItemID = dropconf.DropItemID4, MinNumber = dropconf.DropItemMinNum4, MaxNumber = dropconf.DropItemMaxNum4 });

				totalWeight += dropconf.DropChance5;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance5, ItemID = dropconf.DropItemID5, MinNumber = dropconf.DropItemMinNum5, MaxNumber = dropconf.DropItemMaxNum5 });

				totalWeight += dropconf.DropChance6;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance6, ItemID = dropconf.DropItemID6, MinNumber = dropconf.DropItemMinNum6, MaxNumber = dropconf.DropItemMaxNum6 });

				totalWeight += dropconf.DropChance7;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance7, ItemID = dropconf.DropItemID7, MinNumber = dropconf.DropItemMinNum7, MaxNumber = dropconf.DropItemMaxNum7 });

				totalWeight += dropconf.DropChance8;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance8, ItemID = dropconf.DropItemID8, MinNumber = dropconf.DropItemMinNum8, MaxNumber = dropconf.DropItemMaxNum8 });

				totalWeight += dropconf.DropChance9;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance9, ItemID = dropconf.DropItemID9, MinNumber = dropconf.DropItemMinNum9, MaxNumber = dropconf.DropItemMaxNum9 });

				totalWeight += dropconf.DropChance10;
				totalItemId.Add(new DropItemInfo() { Weight = dropconf.DropChance10, ItemID = dropconf.DropItemID10, MinNumber = dropconf.DropItemMinNum10, MaxNumber = dropconf.DropItemMaxNum10 });

				dropID = dropconf.DropSonID;
			}

			int sum_temp = 0;
			int number_rand = RandomHelper.RandomNumber(1, totalWeight + 1);
			DropItemInfo dropItemInfo = totalItemId[0];
			for (int i = 0; i < totalItemId.Count; i++)
			{
				sum_temp += totalItemId[i].Weight;
				if (number_rand <= sum_temp)
				{
					dropItemInfo = totalItemId[i];
					break;
				}
			}
			int newNumber = RandomHelper.RandomNumber(dropItemInfo.MinNumber, dropItemInfo.MaxNumber + 1);
			dropItemList.Add(new RewardItem() { ItemID = dropItemInfo.ItemID, ItemNum = newNumber });
		}

		public static List<RewardItem> AI_DropByPlayerLv(int monsterID, int playerLv, float dropProValue, bool all)
		{
			MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterID);
			//最小等级;最大等级;掉落ID1,掉落ID2
			string LvDropID = monsterCof.LvDropID;
			if (ComHelp.IfNull(LvDropID))
			{
				return null;
			}
			//最小等级; 最大等级; 掉落ID1,掉落ID2 @最小等级; 最大等级; 掉落ID1,掉落ID2
			string[] lvdropList = LvDropID.Split('@');
			for (int i = 0; i < lvdropList.Length; i++)
			{
				string[] lvDropInfos = lvdropList[i].Split(';');
				if (playerLv < int.Parse(lvDropInfos[0]) || playerLv > int.Parse(lvDropInfos[1]))
				{
					continue;
				}

				List<int> dropIds = new List<int>();
				string[] dropList = lvDropInfos[2].Split(',');
				for (int d = 0; d < dropList.Length; d++)
				{
					dropIds.Add(int.Parse(dropList[d]));
				}

				List<RewardItem> dropItemList = new List<RewardItem>();
				for (int d = 0; d < dropIds.Count; d++)
				{
					DropIDToDropItem(dropIds[d], dropItemList, monsterID, dropProValue, all);
				}
				return dropItemList;
			}
			return null;
		}

		/// <summary>
		/// dropProValue 掉落概率多个道具
		/// </summary>
		/// <param name="monsterID"></param>
		/// <param name="dropProValue"></param>
		/// <returns></returns>
		public static List<RewardItem> AI_MonsterDrop(int monsterID, float dropProValue, bool all)
		{
			//根据怪物ID获得掉落ID
			MonsterConfig monsterCof = MonsterConfigCategory.Instance.Get(monsterID);
			int[] dropID = monsterCof.DropID;
			List<RewardItem> dropItemList = new List<RewardItem>();

			for (int i = 0; i < dropID.Length; i++)
			{
				if (dropID[i] == 0)
					continue;
				DropIDToDropItem(dropID[i], dropItemList, monsterID, dropProValue, all);
			}
			return dropItemList;
		}


		//传入ID判定是否是特殊掉落ID
		public static bool IfTeShuDropItemID(int itemID)
		{
			//钥匙类 返回1
			return (itemID == 10010034);
		}

		//传入掉落ID，生成掉落数据
		public static bool DropIDToDropItem(int dropID, List<RewardItem> dropItemList, int monsterID = 0, float dropProValue = 1, bool all = false)
		{
			DropConfig dropconf = DropConfigCategory.Instance.Get(dropID);
			int dropLimit = dropconf.DropLimit;
			//Debug.Log("DropIDToDropItemDropIDToDropItemDropIDToDropItem");
			//是否有子掉落
			bool DropSonStatus = false;

			//设置掉落最大数量
			int dropNumNow = 0;                     //当前掉落道具的数量
			int dropLoopNum = 0;                    //掉落循环次数
			int dropIDInitial = dropID;          //设置初始掉落
			int oldNumber = dropItemList.Count;

			do
			{
				DropSonStatus = true;
				//传入当前掉落数量和最大掉落数量给行掉落数据
				//Debug.Log("dropID = " + dropID);
				//生成每行掉落数据
				dropNumNow = RowDrop(dropID, dropItemList, monsterID, dropNumNow, dropLimit, dropProValue, all);
				//获取子掉落
				dropID = DropConfigCategory.Instance.Get(dropID).DropSonID;
				//没有子掉落循环取消（因为掉落ID里面可以套掉落ID）
				if (dropID == 0)
				{
					DropSonStatus = false;
					//如果掉落数量没达到指定数量再次随机
					if (dropLimit != 0)
					{
						//子级为空时,判定当前数量是否已达到掉落上线,不足上线则再次执行一边
						if (dropNumNow < dropLimit)
						{
							dropLoopNum = dropLoopNum + 1;
							dropID = dropIDInitial;
							DropSonStatus = true;
							//Debug.Log("22222222");
						}
					}
					//循环10次强制结束循环
					if (dropLoopNum > 100)
					{
						DropSonStatus = false;
						//return true;
					}
				}
				else
				{
					//当掉落数量已达上线时,自动取消掉落
					if (dropLimit != 0)
					{
						if (dropNumNow >= dropLimit)
						{
							DropSonStatus = false;
						}
					}
				}
			}
			while (DropSonStatus);

			//掉落为空在默认第一个
			if (monsterID == 0 && dropItemList.Count == oldNumber)
			{
				dropItemList.Add(new RewardItem() { ItemID = dropconf.DropItemID1, ItemNum = 1 });
			}
			return true;
		}


		//传入掉落ID，生成掉落数据
		public static List<RewardItem> DropIDToShowItem(int dropID, int needQuality = 4)
		{
			List<RewardItem> dropItemList = new List<RewardItem>();
			List<int> showID = new List<int>();
			DropConfig dropconf = DropConfigCategory.Instance.Get(dropID);
			int dropLimit = dropconf.DropLimit;

			//是否有子掉落
			bool DropSonStatus = false;

			//设置掉落最大数量
			int dropLoopNum = 0;                 //掉落循环次数
			int dropIDInitial = dropID;          //设置初始掉落

			do
			{
				DropSonStatus = true;

				//获取子掉落
				dropconf = DropConfigCategory.Instance.Get(dropID);

				for (int i = 1; i <= 10; i++)
				{
					//Debug.Log("Str1111 = " + i);
					//获取掉落道具的ID
					int dropItemID = 0;
					int dropChance = 0;
					int dropMinNum = 0;
					int dropMaxNum = 0;
					switch (i)
					{
						case 1:
							dropItemID = dropconf.DropItemID1;
							dropChance = dropconf.DropChance1;
							dropMinNum = dropconf.DropItemMinNum1;
							dropMaxNum = dropconf.DropItemMaxNum1;
							break;
						case 2:
							dropItemID = dropconf.DropItemID2;
							dropChance = dropconf.DropChance2;
							dropMinNum = dropconf.DropItemMinNum2;
							dropMaxNum = dropconf.DropItemMaxNum2;
							break;
						case 3:
							dropItemID = dropconf.DropItemID3;
							dropChance = dropconf.DropChance3;
							dropMinNum = dropconf.DropItemMinNum3;
							dropMaxNum = dropconf.DropItemMaxNum3;
							break;
						case 4:
							dropItemID = dropconf.DropItemID4;
							dropChance = dropconf.DropChance4;
							dropMinNum = dropconf.DropItemMinNum4;
							dropMaxNum = dropconf.DropItemMaxNum4;
							break;
						case 5:
							dropItemID = dropconf.DropItemID5;
							dropChance = dropconf.DropChance5;
							dropMinNum = dropconf.DropItemMinNum5;
							dropMaxNum = dropconf.DropItemMaxNum5;
							break;
						case 6:
							dropItemID = dropconf.DropItemID6;
							dropChance = dropconf.DropChance6;
							dropMinNum = dropconf.DropItemMinNum6;
							dropMaxNum = dropconf.DropItemMaxNum6;
							break;
						case 7:
							dropItemID = dropconf.DropItemID7;
							dropChance = dropconf.DropChance7;
							dropMinNum = dropconf.DropItemMinNum7;
							dropMaxNum = dropconf.DropItemMaxNum7;
							break;
						case 8:
							dropItemID = dropconf.DropItemID8;
							dropChance = dropconf.DropChance8;
							dropMinNum = dropconf.DropItemMinNum8;
							dropMaxNum = dropconf.DropItemMaxNum8;
							break;
						case 9:
							dropItemID = dropconf.DropItemID9;
							dropChance = dropconf.DropChance9;
							dropMinNum = dropconf.DropItemMinNum9;
							dropMaxNum = dropconf.DropItemMaxNum9;
							break;
						case 10:
							dropItemID = dropconf.DropItemID10;
							dropChance = dropconf.DropChance10;
							dropMinNum = dropconf.DropItemMinNum10;
							dropMaxNum = dropconf.DropItemMaxNum10;
							break;
					}
					if (dropItemID >= 100000)
					{
						ItemConfig itemCof = ItemConfigCategory.Instance.Get(dropItemID);
						if (itemCof.ItemQuality >= needQuality && showID.Contains(dropItemID) == false)
						{
							showID.Add(dropItemID);
							dropItemList.Add(new RewardItem() { ItemID = dropItemID, ItemNum = 1 });
						}
					}
				}

				dropID = dropconf.DropSonID;

				//没有子掉落循环取消（因为掉落ID里面可以套掉落ID）
				if (dropID == 0)
				{
					DropSonStatus = false;

					//循环100次强制结束循环
					if (dropLoopNum > 1000)
					{
						DropSonStatus = false;
					}
				}

			}
			while (DropSonStatus);

			return dropItemList;
		}

		//行掉落ID数据
		public static int RowDrop(int dropID, List<RewardItem> dropItemList, int monsterID, int dropNumNow = 0, int dropNumMax = 0, float dropProValue = 1, bool all = false)
		{
			try
			{
				//根据掉落ID获取掉落
				DropConfig dropconf = DropConfigCategory.Instance.Get(dropID);
				//int dropNum
				int dropType = dropconf.DropType;

				for (int i = 1; i <= 10; i++)
				{
					//Debug.Log("Str1111 = " + i);
					//获取掉落道具的ID
					int dropItemID = 0;
					int dropChance = 0;
					int dropMinNum = 0;
					int dropMaxNum = 0;
					switch (i)
					{
						case 1:
							dropItemID = dropconf.DropItemID1;
							dropChance = dropconf.DropChance1;
							dropMinNum = dropconf.DropItemMinNum1;
							dropMaxNum = dropconf.DropItemMaxNum1;
							break;
						case 2:
							dropItemID = dropconf.DropItemID2;
							dropChance = dropconf.DropChance2;
							dropMinNum = dropconf.DropItemMinNum2;
							dropMaxNum = dropconf.DropItemMaxNum2;
							break;
						case 3:
							dropItemID = dropconf.DropItemID3;
							dropChance = dropconf.DropChance3;
							dropMinNum = dropconf.DropItemMinNum3;
							dropMaxNum = dropconf.DropItemMaxNum3;
							break;
						case 4:
							dropItemID = dropconf.DropItemID4;
							dropChance = dropconf.DropChance4;
							dropMinNum = dropconf.DropItemMinNum4;
							dropMaxNum = dropconf.DropItemMaxNum4;
							break;
						case 5:
							dropItemID = dropconf.DropItemID5;
							dropChance = dropconf.DropChance5;
							dropMinNum = dropconf.DropItemMinNum5;
							dropMaxNum = dropconf.DropItemMaxNum5;
							break;
						case 6:
							dropItemID = dropconf.DropItemID6;
							dropChance = dropconf.DropChance6;
							dropMinNum = dropconf.DropItemMinNum6;
							dropMaxNum = dropconf.DropItemMaxNum6;
							break;
						case 7:
							dropItemID = dropconf.DropItemID7;
							dropChance = dropconf.DropChance7;
							dropMinNum = dropconf.DropItemMinNum7;
							dropMaxNum = dropconf.DropItemMaxNum7;
							break;
						case 8:
							dropItemID = dropconf.DropItemID8;
							dropChance = dropconf.DropChance8;
							dropMinNum = dropconf.DropItemMinNum8;
							dropMaxNum = dropconf.DropItemMaxNum8;
							break;
						case 9:
							dropItemID = dropconf.DropItemID9;
							dropChance = dropconf.DropChance9;
							dropMinNum = dropconf.DropItemMinNum9;
							dropMaxNum = dropconf.DropItemMaxNum9;
							break;
						case 10:
							dropItemID = dropconf.DropItemID10;
							dropChance = dropconf.DropChance10;
							dropMinNum = dropconf.DropItemMinNum10;
							dropMaxNum = dropconf.DropItemMaxNum10;
							break;
					}

					//string dropItemID = "1";
					//string dropType = "1";
					//Debug.Log("dropItemID = " + dropItemID);
					//如果道具ID不为空则触发掉落概率
					//Debug.Log("Str2222 = " + i);
					if (dropItemID != 0)
					{
						//每个掉落
						//获取每个掉落的概率
						//string dropChance = "100000";
						float randomdrop = RandomHelper.RandomNumberFloat(0, 1000000);
						float dropChanceData = dropChance * dropProValue;     //概率附加

						if (all)
						{
							dropChanceData = randomdrop + 1f;
						}

						//怪物ID
						if (monsterID != 0)
						{
							//特殊道具概率降低
							//钥匙类
							if (IfTeShuDropItemID(dropItemID))
							{
								//获取当前等级差
								int roseLv = 1; //临时
								int aiLv = 0;  //// int.Parse(function_DataSet.DataSet_ReadData("Lv", "ID", monsterID, "Monster_Template"));
											   //最低保障前两章是正常掉落
								if (aiLv < 40)
								{
									int lvCha = roseLv - aiLv;
									//超过10级不再执行掉落
									if (lvCha >= 10)
									{
										dropChanceData = 0;
									}
								}
							}
						}

						//Debug.Log("Str3333 = " + i);
						//当随机值小于掉落概率值判定为掉落成功
						if (randomdrop <= dropChanceData)
						{
							//Debug.Log("掉落成功！掉落成功！掉落成功！掉落成功！掉落成功！掉落成功！ dropID = " + dropID);
							//掉落成功
							//获取掉落数量
							//判定概率是否大于100%,大于100则掉落数量变多（此处触发BUG不能直接成掉落系数,要加算法）
							if (dropChanceData > 1000000)
							{
								//dropMinNum_Int = (int)(dropMinNum_Int * dropProValue);
								//dropMaxNum_Int = (int)(dropMaxNum_Int * dropProValue);

								//如果需要此处应该是这样的
								dropMinNum = (int)(dropMinNum * (dropChance / 1000000 * dropProValue));
								dropMaxNum = (int)(dropMaxNum * (dropChance / 1000000 * dropProValue));
							}
							//随机掉落数量
							int itemDropNum = RandomHelper.RandomNumber(dropMinNum, dropMaxNum);
							randomSet = itemDropNum;

							//读取掉落道具ID
							//string itemID = function_DataSet.DataSet_ReadData("DropItemID" + i.ToString(), "ID", dropID,"Drop_Template");
							//Debug.Log("Str4444 = " + i);
							switch (dropType)
							{
								//发送道具到地上实体
								case 1:

									//如果是金币掉落显示掉落数量为1
									if (dropItemID == 1)
									{
										//金币数量
										itemDropNum = 1;
										dropItemList.Add(new RewardItem() { ItemID = 1, ItemNum = randomSet });
									}
									else
									{
										//当掉落数量不为0时,循环实例化每个掉落
										if (itemDropNum != 0)
										{
											for (int n = 1; n <= itemDropNum; n++)
											{
												//执行掉落
												dropItemList.Add(new RewardItem() { ItemID = dropItemID, ItemNum = 1 });
											}
										}

									}
									break;
								//发送道具到背包
								case 2:
									//Debug.Log("Str5555 = " + i);
									//获取道具的极品值
									/*
									float HideDropPro = 0;
									if (monsterID != 0)
									{
										HideDropPro = 0; /// float.Parse(function_DataSet.DataSet_ReadData("HideDropPro", "ID", monsterID, "Monster_Template"));
									}
									*/
									//Debug.Log("Str6666 = " + i);
									//Debug.Log("HideDropPro = " + HideDropPro);
									//Debug.Log("itemID = " + itemID + "itemDropNum = " + itemDropNum + "HideDropPro = " + HideDropPro);
									bool ifDrop = true;   // Function_Role.GetInstance().SendRewardToBag(itemID, itemDropNum, "0", HideDropPro, "0", true, "12");
														  //Debug.Log("Str7777 = " + i);
														  //背包满了的话直接掉落到地上
									if (!ifDrop)
									{
										//背包满了执行掉落地上
										//dropItemList.Add(itemID);
										if (itemDropNum != 0)
										{
											for (int n = 1; n <= itemDropNum; n++)
											{
												//执行掉落
												dropItemList.Add(new RewardItem() { ItemID = dropItemID, ItemNum = 1 });
											}
										}
										//Debug.Log("Str8888 = " + i);
									}
									break;
							}
							//累计掉落数量
							//dropNum = dropNum + 1;
							if (dropNumMax != 0)
							{
								//Debug.Log("掉落1");
								dropNumNow = dropNumNow + 1;
								if (dropNumNow >= dropNumMax)
								{
									//Debug.Log("掉落2");
									return dropNumNow;
								}
							}
						}
						else
						{
							//掉落失败
						}
					}
					else
					{
						i = 10; //因为一条掉落最大支持10个道具数据
					}
				}

			}
			catch (Exception ex)
			{
				Log.Error("DropHelp " + ex.ToString());
			}
			return dropNumNow;
		}

	}
}
