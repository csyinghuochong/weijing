using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public partial class DungeonSectionConfigCategory
    {
        public Dictionary<int, int> DungeonToChapter = new Dictionary<int, int>();
        
        public override void AfterEndInit()
        {

            foreach (DungeonSectionConfig functionConfig in this.GetAll().Values)
            {
                for (int i = 0; i < functionConfig.RandomArea.Length; i++)
                {
                    DungeonToChapter.Add(functionConfig.RandomArea[i], functionConfig.Id);
                }
            }

        }
    }
}
