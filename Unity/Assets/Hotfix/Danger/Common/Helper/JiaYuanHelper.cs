using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public static class JiaYuanHelper
    {

        public static Vector3 PastureInitPos = new Vector3(-15f, 0f, -20f);


        public static Vector3 GetRandomPos()
        {
            return new Vector3
                (
                    RandomHelper.RandomNumberFloat(-2.5f, 2.5f) + PastureInitPos.x,
                    PastureInitPos.y,
                    RandomHelper.RandomNumberFloat(-5f, 5f) + PastureInitPos.z
                );
        }

        public static List<MysteryItemInfo> InitJiaYuanPastureList(int jiayuanLv)
        {
            List<MysteryItemInfo> mysteryItemInfos = new List<MysteryItemInfo>();
            JiaYuanConfig jiaYuanConfig = JiaYuanConfigCategory.Instance.JiaYuanLvConfig[jiayuanLv];
            int totalNumber = jiaYuanConfig.PeopleNumMax;

            List<int> weightList = new List<int>();
            List<int> mystIdList = new List<int>();

            Dictionary<int, JiaYuanPastureConfig> keyValuePairs = JiaYuanPastureConfigCategory.Instance.GetAll();
            foreach(var item in keyValuePairs)
            {
                if (jiayuanLv < item.Value.BuyJiaYuanLv)
                {
                    continue;
                }

                mystIdList.Add(item.Key);
                weightList.Add(item.Value.BuyJiaYuanPro);
            }

            while (mysteryItemInfos.Count < totalNumber && weightList.Count > 0)
            {
                int index = RandomHelper.RandomByWeight(weightList);
                int mystId = mystIdList[index];
                JiaYuanPastureConfig mysteryConfig = JiaYuanPastureConfigCategory.Instance.Get(mystId);
                mysteryItemInfos.Add(new MysteryItemInfo()
                {
                    MysteryId = mystId,
                    ItemID = mysteryConfig.GetItemID,
                    ItemNumber = 1
                });
                weightList.RemoveAt(index);
                mystIdList.RemoveAt(index);
            }

            return mysteryItemInfos;
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

        public static long GetNextStateTime(int itemId, long StartTime)
        {
            long stageTime = 0;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < jiaYuanFarmConfig.UpTime.Length; i++)
            {
                stageTime = StartTime + jiaYuanFarmConfig.UpTime[i] * 1000;
                if (serverTime < stageTime)
                {
                    break;
                }
            }
            return stageTime;
        }

        public static long GetNextShouHuoTime(int itemid, long StartTime, int GatherNumber, long GatherLastTime)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemid);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();

            long firstTime = (long)(jiaYuanFarmConfig.UpTime[2]) * 1000 + StartTime;
            if (serverTime < firstTime)
            {
                return firstTime;
            }
            if (GatherNumber == 0)
            {
                return firstTime;
            }

            return GatherLastTime + jiaYuanFarmConfig.GetItemTime * 1000;
        }

        public static int GetShouHuoItem(int itemId, long StartTime, int GatherNumber, long GatherLastTime)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long serverTime = TimeHelper.ServerNow();

            long firstTime = (long)(jiaYuanFarmConfig.UpTime[2]) * 1000 + StartTime;
            if (serverTime < firstTime)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            if (GatherNumber >= jiaYuanFarmConfig.GetItemNum)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            if (GatherNumber > 0 && serverTime < GatherLastTime + jiaYuanFarmConfig.GetItemTime * 1000)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            return ErrorCore.ERR_Success;
        }

        public static int GetPlanStage(int itemId, long StartTime, int GatherNumber)
        {
            int stage = 0;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(itemId);
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(int.Parse(itemConfig.ItemUsePar));
            long passTime = TimeHelper.ServerNow() - StartTime;
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
            if (GatherNumber >= jiaYuanFarmConfig.GetItemNum)
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

        public static Unit GetUnitByCellIndex(Scene curScene, int cellIndex)
        {
            List<Unit> allunits = UnitHelper.GetUnitList(curScene, UnitType.Plant);
            for (int i = 0; i < allunits.Count; i++)
            {
                if (allunits[i].GetComponent<NumericComponent>().GetAsInt(NumericType.CellIndex) == cellIndex)
                {
                   return allunits[i];
                }
            }
            return null;

        }
    }
}
