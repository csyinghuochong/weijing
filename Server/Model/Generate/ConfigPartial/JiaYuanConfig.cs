using System.Collections.Generic;

namespace ET
{
    public partial class JiaYuanConfigCategory
    {
        public Dictionary<int, JiaYuanConfig> JiaYuanLvConfig = new Dictionary<int, JiaYuanConfig>();

        public override void AfterEndInit()
        {
            foreach (JiaYuanConfig functionConfig in this.GetAll().Values)
            {
                JiaYuanLvConfig.Add(functionConfig.Lv, functionConfig);
            }
        }
    }
}
