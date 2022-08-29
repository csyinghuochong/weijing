using System;
using System.Collections.Generic;

namespace ET
{
    public static class DayTeHuiHelper
    {

        public static List<int> GetDayTeHuiList(int level)
        { 
            List<int> sour = new List<int>();
            List<int> dest = new List<int>();
            //2
            Dictionary<int, ActivityConfig> keyValuePairs = ActivityConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.ActivityType != 2)
                {
                    continue;
                }
                string[] levelinfo = item.Value.Par_1.Split(',');
                if (level >= int.Parse(levelinfo[0]) && level <= int.Parse(levelinfo[1]))
                {
                    sour.Add(item.Key);
                }
            }

            RandomHelper.GetRandListByCount(sour, dest, 4);
            return dest;
        }

    }
}
