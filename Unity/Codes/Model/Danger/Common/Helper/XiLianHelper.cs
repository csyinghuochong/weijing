using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public  static class XiLianHelper
    {


        public static List<int> GetLevelSkill(int xilianLevel)
        {
            List<int> skills = new List<int>();
            int hideProId = 2011;
            while (hideProId != 0)
            {
                HideProListConfig proListConfig = HideProListConfigCategory.Instance.Get(hideProId);
                if (xilianLevel == proListConfig.NeedXiLianLv && !skills.Contains(proListConfig.PropertyType))
                {
                    skills.Add(proListConfig.PropertyType);
                }
                hideProId = proListConfig.NtxtID;
            }
            return skills;
        }

        public static int GetXiLianId(int xilianDu)
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
