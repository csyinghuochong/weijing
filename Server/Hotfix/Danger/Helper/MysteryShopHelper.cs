using System.Collections.Generic;

namespace ET
{
    public static class MysteryShopHelper
    {
		public static List<MysteryItemInfo> InitMysteryItemInfos(Scene domainScene, long openSerTime = 0)
		{
			List<MysteryItemInfo> mysteryItemInfos = new List<MysteryItemInfo>();

			GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(11);
			int totalNumber = int.Parse(globalValueConfig.Value);

			long serverNow = TimeHelper.ServerNow();
			int openserverDay = ComHelp.DateDiff_Time(serverNow, openSerTime);

			List<int> weightList = new List<int>();
			List<int> mystIdList = new List<int>();

			Dictionary<int, MysteryConfig> keyValuePairs = MysteryConfigCategory.Instance.GetAll();
			foreach (var item in keyValuePairs)
			{
				if (openserverDay < item.Value.ShowServerDay)
				{
					continue;
				}

				weightList.Add(item.Value.ShowPro);
				mystIdList.Add(item.Key);
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

	}
}
