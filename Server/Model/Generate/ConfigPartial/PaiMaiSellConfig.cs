using System.Collections.Generic;


namespace ET
{
    public partial class PaiMaiSellConfigCategory
    {
        public Dictionary<int, int> ItemToSell = new Dictionary<int, int>();

        public override void AfterEndInit()
        {
            foreach (PaiMaiSellConfig firstWinConfig in this.GetAll().Values)
            {
                if (!ItemToSell.ContainsKey(firstWinConfig.ItemID))
                {
                    ItemToSell.Add(firstWinConfig.ItemID, firstWinConfig.Id);
                }
            }
        }
    }
}
