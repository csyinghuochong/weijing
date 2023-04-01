using System.Collections.Generic;

namespace ET
{
    public static class PopularizeHelper
    {
        public static List<RewardItem> GetRewardList(List<PopularizeInfo> popularizeInfos)
        {
            //30 100000金币
            //40 500钻石
            //50 500钻石
            List<RewardItem> rewardlist = new List<RewardItem>();
            for (int i = 0; i < popularizeInfos.Count; i++)
            {
                if (popularizeInfos[i].Level >= 30 && !popularizeInfos[i].Rewards.Contains(30))
                {
                    popularizeInfos[i].Rewards.Add(30);
                    rewardlist.Add( new RewardItem() { ItemID = (int)UserDataType.Gold, ItemNum = 100000 });
                }
                if (popularizeInfos[i].Level >= 40 && !popularizeInfos[i].Rewards.Contains(40))
                {
                    popularizeInfos[i].Rewards.Add(40);
                    rewardlist.Add(new RewardItem() { ItemID = (int)UserDataType.Diamond, ItemNum = 500 });
                }
                if (popularizeInfos[i].Level >= 50 && !popularizeInfos[i].Rewards.Contains(50))
                {
                    popularizeInfos[i].Rewards.Add(50);
                    rewardlist.Add(new RewardItem() { ItemID = (int)UserDataType.Diamond, ItemNum = 500 });
                }
            }
            return rewardlist;   
        }
    }
}
