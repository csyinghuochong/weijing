using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class JiaYuanHelper
    {

        public static string GetPlanStageName(int state)
        {
            if (state == 0)
            {
                return "发芽期";
            }
            if (state == 1)
            {
                return "发芽期11";
            }
            if (state == 2)
            {
                return "发芽期22";
            }
            if (state == 3)
            {
                return "发芽期33";
            }
            return "发芽期44";
        }

        public static long GetNextStateTime(JiaYuanPlant jiaYuanPlan)
        {
            long stageTime = 0;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < jiaYuanFarmConfig.UpTime.Length; i++)
            {
                stageTime = jiaYuanPlan.StartTime + jiaYuanFarmConfig.UpTime[i] * 1000;
                if (serverTime < stageTime)
                {
                    break;
                }
            }
            return stageTime;
        }

        public static long GetNextShouHuoTime(JiaYuanPlant jiaYuanPlan)
        {
            long stageTime = 0;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < jiaYuanFarmConfig.UpTime.Length; i++)
            {
                stageTime = jiaYuanPlan.StartTime + jiaYuanFarmConfig.UpTime[i] * 1000;
                if (serverTime < stageTime)
                {
                    break;
                }
            }
            return stageTime;
        }

        public static int GetPlanStage(JiaYuanPlant jiaYuanPlan)
        {
            int stage = 0;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long passTime = TimeHelper.ServerNow() - jiaYuanPlan.StartTime;
            for (int i = 0; i < jiaYuanFarmConfig.UpTime.Length; i++)
            {
                if (passTime >= jiaYuanFarmConfig.UpTime[i] * 1000)
                {
                    stage = i + 1;
                    break;
                }
            }

            //收货上限才为第四个阶段 0[种子] 1 2 3 4[废柴]
            if (stage < 3)
            {
                return stage;
            }
            if (jiaYuanPlan.GatherNumber >= jiaYuanFarmConfig.GetItemNum)
            {
                return stage;
            }
            else
            {
                return 3;
            }
        }

    }
}
