using System.Collections.Generic;


namespace ET
{
    public partial class FirstWinConfigCategory
    {


        public Dictionary<int, List<int>> FirstWinList = new Dictionary<int, List<int>>();

        public Dictionary<int, List<int>> BossToChapter = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {
            foreach (FirstWinConfig firstWinConfig in this.GetAll().Values)
            {
                if (!FirstWinList.ContainsKey(firstWinConfig.BossID))
                {
                    FirstWinList.Add(firstWinConfig.BossID, new List<int>());
                }
                FirstWinList[firstWinConfig.BossID].Add(firstWinConfig.Id);

                if (!BossToChapter.ContainsKey(firstWinConfig.ChatperId))
                {
                    BossToChapter.Add(firstWinConfig.ChatperId, new List<int>());
                }
                BossToChapter[firstWinConfig.ChatperId].Add(firstWinConfig.BossID);
            }
        }

        public KeyValuePairInt  GetBossChapter(int bossId)
        {
            foreach (var item in BossToChapter)
            {
                if (item.Value.Contains(bossId))
                {
                    return new KeyValuePairInt() { KeyId = item.Key, Value = item.Value.IndexOf(bossId) };
                }
            }
            return null;
        }
    }
}
