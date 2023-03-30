using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class ItemConfigCategory
    {

        public List<int> FoodList = new List<int> { };

        public override void AfterEndInit()
        {
            foreach (ItemConfig itemConfig in this.GetAll().Values)
            {
                if (itemConfig.ItemType == 1 && itemConfig.ItemSubType == 131 && itemConfig.ItemQuality > 2)
                {
                    FoodList.Add(itemConfig.Id);
                }
            }
        }
    }
}
