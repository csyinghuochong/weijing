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

        public static List<Vector3> PlanPositionList = new List<Vector3>()
        {
             new Vector3(4.23f - 0.75f, 0f, -31.24f - 0.7f),
             new Vector3(4.23f - 0.75f, 0f, -33.32f - 0.7f),
             new Vector3(4.23f - 0.75f, 0f, -35.39f - 0.7f),
             new Vector3(4.23f - 0.75f, 0f, -37.58f - 0.7f),

             new Vector3(1.48f - 0.75f, 0f, -31.24f - 0.7f),
             new Vector3(1.48f - 0.75f, 0f, -33.32f - 0.7f),
             new Vector3(1.48f - 0.75f, 0f, -35.39f - 0.7f),
             new Vector3(1.48f - 0.75f, 0f, -37.58f - 0.7f),

             new Vector3(-1.27f - 0.75f, 0f, -31.24f - 0.7f),
             new Vector3(-1.27f - 0.75f, 0f, -33.32f - 0.7f),
             new Vector3(-1.27f - 0.75f, 0f, -35.39f - 0.7f),
             new Vector3(-1.27f - 0.75f, 0f, -37.58f - 0.7f),

             new Vector3(-4.02f - 0.75f, 0f, -31.24f - 0.7f),
             new Vector3(-4.02f - 0.75f, 0f, -33.32f - 0.7f),
             new Vector3(-4.02f - 0.75f, 0f, -35.39f - 0.7f),
             new Vector3(-4.02f - 0.75f, 0f, -37.58f - 0.7f),

             new Vector3(-6.77f - 0.75f, 0f, -31.24f - 0.7f),
             new Vector3(-6.77f - 0.75f, 0f, -33.32f - 0.7f),
             new Vector3(-6.77f - 0.75f, 0f, -35.39f - 0.7f),
             new Vector3(-6.77f - 0.75f, 0f, -37.58f - 0.7f),
        };

        public static Vector3 GetRandomPos()
        {
            return new Vector3
                (
                    RandomHelper.RandomNumberFloat(-2.5f, 2.5f) + PastureInitPos.x,
                    PastureInitPos.y,
                    RandomHelper.RandomNumberFloat(-5f, 5f) + PastureInitPos.z
                );
        }

        public static List<JiaYuanPurchaseItem> InitPurchaseItemList()
        {

            int jiayuanID = 10001;
            JiaYuanConfig jiayuanCof = JiaYuanConfigCategory.Instance.Get(jiayuanID);

            List<JiaYuanPurchaseItem> jiaYuanPurchases = new List<JiaYuanPurchaseItem>();
            int[] dest =  RandomHelper.GetRandoms(4, 0, ConfigHelper.JiaYuanPurchaseList.Count);
            long serverTime = TimeHelper.ServerNow();
            for (int i = 0; i < dest.Length; i++)
            {
                JiaYuanPurchase jiaYuanPurchase = ConfigHelper.JiaYuanPurchaseList[dest[i]];
                ItemConfig itemCof = ItemConfigCategory.Instance.Get(jiaYuanPurchase.ItemID);
                //家园订单只给大的
                if (itemCof.UseLv <= jiayuanCof.Lv) {
                    JiaYuanPurchaseItem jiaYuanPurchaseItem = new JiaYuanPurchaseItem();
                    jiaYuanPurchaseItem.ItemID = jiaYuanPurchase.ItemID;
                    jiaYuanPurchaseItem.LeftNum = jiaYuanPurchase.ItemNum;
                    jiaYuanPurchaseItem.BuyZiJin = RandomHelper.RandomNumber(jiaYuanPurchase.BuyMinZiJin, jiaYuanPurchase.BuyMaxZiJin + 1);
                    jiaYuanPurchaseItem.EndTime = serverTime + TimeHelper.Hour * 12;        //设置时间
                    jiaYuanPurchases.Add(jiaYuanPurchaseItem);
                }
            }
            return jiaYuanPurchases;
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

        public static string GetPastureStageName(int state)
        {
            if (state == 0)
            {
                return "幼年期";
            }
            if (state == 1)
            {
                return "成年期";
            }
            if (state == 2)
            {
                return "壮年期";
            }
            if (state == 3)
            {
                return "衰老期";
            }

            return "老年期";
        }

        /// <summary>
        /// 动物缩放
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static float GetPastureStageScale(int state)
        {
            if (state == 0)
            {
                return 1f;
            }
            if (state == 1)
            {
                return 2f;
            }
            if (state == 2)
            {
                return 3f;
            }
            if (state == 3)
            {
                return 4f;
            }

            return 4f;
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
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(itemId);
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

        public static long GetPastureNextShouHuoTime(int itemid, long StartTime, int GatherNumber, long GatherLastTime)
        {
            JiaYuanPastureConfig jiaYuanFarmConfig = JiaYuanPastureConfigCategory.Instance.Get(itemid);
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

            return GatherLastTime + jiaYuanFarmConfig.DropTime * 1000;
        }

        public static long GetPlanNextShouHuoTime(int itemid, long StartTime, int GatherNumber, long GatherLastTime)
        {
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(itemid);
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

        public static int GetPastureShouHuoItem(int itemId, long StartTime, int GatherNumber, long GatherLastTime)
        {
            JiaYuanPastureConfig jiaYuanFarmConfig = JiaYuanPastureConfigCategory.Instance.Get(itemId);
            long serverTime = TimeHelper.ServerNow();

            long firstTime = (long)(jiaYuanFarmConfig.UpTime[2]) * 1000 + StartTime;
            if (serverTime < firstTime)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            if (GatherNumber > 0 && serverTime < GatherLastTime + jiaYuanFarmConfig.DropTime * 1000)
            {
                return ErrorCore.ERR_CanNotGather;
            }
            return ErrorCore.ERR_Success;
        }

        public static int GetPlanShouHuoItem(int itemId, long StartTime, int GatherNumber, long GatherLastTime)
        {
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(itemId);
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

        public static int GetPastureState(int itemId, long StartTime, int GatherNumber)
        {
            int stage = 0;
            JiaYuanPastureConfig jiaYuanFarmConfig = JiaYuanPastureConfigCategory.Instance.Get(itemId);
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
            return 3;
        }

        public static int GetPlanStage(int itemId, long StartTime, int GatherNumber)
        {
            int stage = 0;
            JiaYuanFarmConfig jiaYuanFarmConfig = JiaYuanFarmConfigCategory.Instance.Get(itemId);
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
