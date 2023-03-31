using System.Collections.Generic;


namespace ET
{
    public partial class ItemConfigCategory
    {

        public  Dictionary<int, List<int>> FoodLevelList = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {
            foreach (ItemConfig itemConfig in this.GetAll().Values)
            {
                if (itemConfig.ItemType!= 1 || itemConfig.ItemSubType!= 131)
                {
                    continue;
                }
                List<int> foodlist = null;
                FoodLevelList.TryGetValue(itemConfig.UseLv, out foodlist);
                if (foodlist == null)
                {
                    foodlist = new List<int>();
                    FoodLevelList.Add(itemConfig.UseLv, foodlist);
                }
                foodlist.Add(itemConfig.Id);
            }
        }

        public int GetFoodId(int lv)
        {
            int templv = 0;

            List<int> foodlist = null;
            FoodLevelList.TryGetValue( lv, out foodlist);

            if (foodlist == null)
            {
                foreach ((int level, List<int> ids) in FoodLevelList)
                {
                    templv = level;
                    if (level >= lv)
                    {
                        foodlist = ids;
                    }
                }
            }
            if (foodlist == null)
            {
                foodlist = FoodLevelList[templv];
            }

            return foodlist[RandomHelper.RandomNumber(0, foodlist.Count)];
        }
    }
}
