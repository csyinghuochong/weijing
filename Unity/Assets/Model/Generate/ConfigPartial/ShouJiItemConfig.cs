using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class ShouJiItemConfigCategory
    {

        public Dictionary<int, List<int>> TreasureList = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {
            foreach (ShouJiItemConfig shoujiConfig in this.GetAll().Values)
            {
                if (shoujiConfig.StartType != 2)
                {
                    continue;
                }

                List<int> treasures = null;
                TreasureList.TryGetValue(shoujiConfig.Chap, out treasures);
                if (treasures == null)
                {
                    treasures = new List<int>();
                    TreasureList.Add(shoujiConfig.Chap, treasures);
                }
                treasures.Add(shoujiConfig.Id);
            }
        }
    }
}
