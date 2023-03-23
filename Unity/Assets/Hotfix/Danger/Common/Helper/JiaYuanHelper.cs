using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class JiaYuanHelper
    {

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
