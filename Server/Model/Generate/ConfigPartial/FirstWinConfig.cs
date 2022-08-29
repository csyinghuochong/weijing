using System.Collections.Generic;


namespace ET
{
    public partial class FirstWinConfigCategory
    {
        public Dictionary<int, List<int>> FirstWinList = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {
            foreach (FirstWinConfig firstWinConfig in this.GetAll().Values)
            {
                if (!FirstWinList.ContainsKey(firstWinConfig.BossID))
                {
                    FirstWinList.Add(firstWinConfig.BossID, new List<int>());
                }
                FirstWinList[firstWinConfig.BossID].Add(firstWinConfig.Id);
            }
        }
    }
}
