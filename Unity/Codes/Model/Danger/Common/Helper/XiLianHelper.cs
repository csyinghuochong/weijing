using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public  static class XiLianHelper
    {
        public static int GetXiLianLevel(int xilianDu)
        {
            int xilianid = 0;
            List<EquipXiLianConfig> equipXiLians =  EquipXiLianConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < equipXiLians.Count; i++)
            {
                if (equipXiLians[i].XiLianType != 0)
                {
                    continue;
                }
                if (xilianDu <= equipXiLians[i].NeedShuLianDu)
                {
                    break;
                }
                xilianid = equipXiLians[i].Id;
            }
            return xilianid;
        }
    }
}
