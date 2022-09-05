using System;
using System.Collections.Generic;


namespace ET
{
    public partial class EquipXiLianConfigCategory
    {
        public List<EquipXiLianConfig> EquipXiLianLevelList = new List<EquipXiLianConfig>();

        public override void AfterEndInit()
        {
            foreach (EquipXiLianConfig  equipXiLianConfig in this.GetAll().Values)
            {
                if (equipXiLianConfig.XiLianType == 0)
                {
                    EquipXiLianLevelList.Add(equipXiLianConfig);
                }
            }
        }
    }
}
