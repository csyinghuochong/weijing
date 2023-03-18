using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class WorldLvHelper
    {

        public static int GetWorldLvLastDay()
        {
            int lastDay = 0;
            string[] lvlist = GlobalValueConfigCategory.Instance.Get(42).Value.Split('@');
            for (int i = 0; i < lvlist.Length; i++)
            {
                string[] levelinfo = lvlist[i].Split(';');
                int day = int.Parse(levelinfo[0]);
                if (day > lastDay)
                {
                    lastDay = day;
                }
            }
            return lastDay;
        }

        public static int GetWorldLv(int openserverDay)
        {
            int worldLv = 0;
            string[] lvlist = GlobalValueConfigCategory.Instance.Get(42).Value.Split('@');
            for (int i = 0; i < lvlist.Length; i++)
            {
                string[] levelinfo = lvlist[i].Split(';');
                worldLv = int.Parse(levelinfo[1]);
                if (openserverDay <= int.Parse(levelinfo[0]))
                {
                    return worldLv;
                }
            }
            return worldLv;
        }

    }
}
