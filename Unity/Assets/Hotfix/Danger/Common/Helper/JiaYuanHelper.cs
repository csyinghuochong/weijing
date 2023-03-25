using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class JiaYuanHelper
    {

        public static List<int> GetJiaYuanPastureList(int jiayuanLv)
        {
            return new List<int>();
        }

        public static string GetPlanStageName(int state)
        {
            if (state == 0)
            {
                return "出苗期";
            }
            if (state == 1)
            {
                return "成长期";
            }
            if (state == 2)
            {
                return "成熟期";
            }
            if (state == 3)
            {
                return "收获期";
            }

            return "枯萎期";
        }

        public static string TimeToShow(string timeStr) {
            Log.Info("timeStr = " + timeStr);
            string retuenStr = timeStr.Substring(5, timeStr.Length - 5);
            return retuenStr;
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
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();

            long firstTime = (long)(jiaYuanFarmConfig.UpTime[2]) * 1000 + jiaYuanPlan.StartTime;
            if (serverTime < firstTime)
            {
                return firstTime;
            }
            if (jiaYuanPlan.GatherNumber == 0)
            {
                return firstTime;
            }

            return jiaYuanPlan.GatherLastTime + jiaYuanFarmConfig.GetItemTime * 1000;
        }

        public static int GetShouHuoItem(JiaYuanPlant jiaYuanPlan)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(jiaYuanPlan.ItemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();

            long firstTime = (long)(jiaYuanFarmConfig.UpTime[2]) * 1000 + jiaYuanPlan.StartTime;
            if (serverTime < firstTime)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            if (jiaYuanPlan.GatherNumber >= jiaYuanFarmConfig.GetItemNum)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            if (jiaYuanPlan.GatherNumber > 0 && serverTime < jiaYuanPlan.GatherLastTime + jiaYuanFarmConfig.GetItemTime * 1000)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            return ErrorCore.ERR_Success;
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

        //获取家园开启仓库格子消耗
        public static string GetOpenJiaYuanWarehouse(int page) {

            string costItems = GlobalValueConfigCategory.Instance.Get(86).Value;
            string[] costItemsList = costItems.Split('@');
            return costItemsList[page - 1];
            
        }

    }
}
