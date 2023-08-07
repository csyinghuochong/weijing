using System.Collections.Generic;

namespace ET
{

    public partial class EquipSuitConfigCategory
    {

        public Dictionary<int, List<int>> OccSuiList = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {
            foreach (EquipSuitConfig suitConfig in this.GetAll().Values)
            {
                if (suitConfig.Occ == 0)
                {
                    continue;
                }

                if (!OccSuiList.ContainsKey(suitConfig.Occ))
                {
                    OccSuiList.Add(suitConfig.Occ, new List<int>());
                }
                OccSuiList[suitConfig.Occ].Add(suitConfig.Id);
            }
        }
    }
}
