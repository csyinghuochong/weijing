using System.Collections.Generic;

namespace ET
{
    public static class MysteryShopHelper
    {

		public static List<int> GetMysteryList(int shopValue)
		{
			List<int> itemList = new List<int>();
			while (shopValue != 0)
			{
				itemList.Add(shopValue);
				MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(shopValue);
				shopValue = mysteryConfig.NextId;
			}

			return itemList;
		}

		public static List<MysteryItemInfo> InitMysteryTypeItems(int openserverDay , int shopValue, int totalNumber)
		{
			List<MysteryItemInfo> mysteryItemInfos = new List<MysteryItemInfo>();
			if (openserverDay == 0)
			{
				return mysteryItemInfos;
			}

			List<int> mysteryids = GetMysteryList(shopValue);
			List<int> weightList = new List<int>();
			List<int> mystIdList = new List<int>();

			for(int i = 0; i < mysteryids.Count; i++)
			{
				MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mysteryids[i]);
				if (openserverDay < mysteryConfig.ShowServerDay)
				{
					continue;
				}

				weightList.Add(mysteryConfig.ShowPro);
				mystIdList.Add(mysteryConfig.Id);
			}

			while (mysteryItemInfos.Count < totalNumber)
			{
				int index = RandomHelper.RandomByWeight(weightList);
				int mystId = mystIdList[index];
				MysteryConfig mysteryConfig = MysteryConfigCategory.Instance.Get(mystId);
				mysteryItemInfos.Add(new MysteryItemInfo()
				{
					MysteryId = mystId,
					ItemID = mysteryConfig.SellItemID,
					ItemNumber = RandomHelper.RandomNumber(mysteryConfig.NumberLimit[0], mysteryConfig.NumberLimit[1])
				});

				weightList.RemoveAt(index);
				mystIdList.RemoveAt(index);
			}

			return mysteryItemInfos;
		}

		public static List<MysteryItemInfo> InitMysteryItemInfos(int openserverDay)
		{
			List<MysteryItemInfo> mysteryItemInfos = new List<MysteryItemInfo>();

			GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(11);
			string[] itemList =  globalValueConfig.Value.Split('@');

			for (int i = 0; i < itemList.Length; i++)
			{
				string[] iteminfo = itemList[i].Split(';');
				mysteryItemInfos.AddRange(InitMysteryTypeItems(openserverDay,int.Parse(iteminfo[0]), int.Parse(iteminfo[1])));
			}

			return mysteryItemInfos;
		}

	}
}
