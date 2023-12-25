using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class ActivityHelper
    {

        public static bool ShowLieOpen = false;  

        public static bool IsShowLieOpen()
        {
            //long serverTime = TimeHelper.ServerNow();
            //DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            //return dateTime.Hour == 19 && dateTime.Minute >= 30 && dateTime.Minute <= 44;
            return ShowLieOpen;
        }

        public static string GetJieRiReward(UserInfoComponent userInfoComponent)
        {
            ExpConfig expCof = ExpConfigCategory.Instance.Get(userInfoComponent.UserInfo.Lv);
            int gold = expCof.RoseGoldPro * 300;
            int exp = expCof.RoseExpPro * 100;

            string rewardStr = $"1;{gold}@2;{exp}";

            if (userInfoComponent.UserInfo.Lv >= 20) {
                rewardStr = $"1;{gold}@2;{exp}@10010039;1@10010088;2@10010046;1";
            }

            return rewardStr;
        }

        public static int GetJieRiActivityId()
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            int activityId = 0;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 33)
                {
                    continue;
                }
                string[] dayInfo = activityConfigs[i].Par_1.Split(';');
                if (dateTime.Month == int.Parse(dayInfo[0]) && dateTime.Day == int.Parse(dayInfo[1]))
                {
                    activityId = activityConfigs[i].Id;
                    break;
                }
            }
            return activityId;
        }

        public static int GetNextRiActivityId()
        {
            List<KeyValuePairInt> jirRiList = new List<KeyValuePairInt>();
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            int curDay = dateTime.Month * 100 + dateTime.Day;

            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 33)
                {
                    continue;
                }
                string[] dayInfo = activityConfigs[i].Par_1.Split(';');
                KeyValuePairInt keyValuePair = new KeyValuePairInt() { KeyId = activityConfigs[i].Id, Value = int.Parse(dayInfo[0]) * 100 + int.Parse(dayInfo[1]) };
                jirRiList.Add(keyValuePair);
            }
            jirRiList.Sort(delegate (KeyValuePairInt a, KeyValuePairInt b)
            {
                return (int)a.Value - (int)b.Value;
            });

            for (int i = 0; i < jirRiList.Count;i++)
            {
                if (jirRiList[i].Value >= curDay)
                {
                    return jirRiList[i].KeyId;
                }
            }

            return jirRiList[0].KeyId;
        }

        public static bool IsJieRiActivityId(int activityId)
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            ActivityConfig activityConfigs = ActivityConfigCategory.Instance.Get(activityId);
            string[] dayInfo = activityConfigs.Par_1.Split(';');
            return dateTime.Month == int.Parse(dayInfo[0]) && dateTime.Day == int.Parse(dayInfo[1]);
        }

        public static bool HaveReceiveTimes(List<int> receiveIds, int receiveId)
        {
            ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(receiveId);
            if (activityConfig.ActivityType != 32)
            { 
                return !receiveIds.Contains(receiveId);
            }
            int receiveNumber = 0;
            for (int i = 0; i < receiveIds.Count; i++)
            {
                if (receiveIds[i] == receiveId)
                {
                    receiveNumber++;
                }
            }
            return receiveNumber < int.Parse(activityConfig.Par_1);
        }

        public static int GetMaxActivityId(int activityType)
        {
            int activityId = 0;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != activityType)
                {
                    continue;
                }
                activityId = activityConfigs[i].Id;
            }
            return activityId;
        }

        public static int GetMinActivityId(int activityType)
        {
            int activityId = 0;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != activityType)
                {
                    continue;
                }
                activityId = activityConfigs[i].Id;
                break;
            }
            return activityId;
        }



        public static List<string> WelfareChouKaList = new List<string>()
        {
            "15305001;1@10024002;1",
            "15305001;1@15305002;1",
            "15305001;1",
            "10045105;1",
            "15305001;1@10024002;1",
            "15305001;1@15305002;1",
            "15305001;1",
            "10045105;1",
        };

        /// <summary>
        /// 每个格子对应一个列表。 如果是装备该格子会有多个道具，非装备该格子只有一个道具
        /// </summary>
        /// <param name="bagInfos">已拥有的道具列表(穿戴+背包+仓库)</param>
        /// <returns>返回可以抽奖的道具</returns>
        /// NumericType.WelfareChouKaNumber 
        public static List<string> GetWelfareChouKaReward(List<BagInfo> bagInfos)
        {
            List<string> rewardList = new   List<string>();

            List<int> haveItems = new List<int>();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                if (itemConfig.ItemType ==3 && !haveItems.Contains(bagInfos[i].ItemID))
                {
                    haveItems.Add(bagInfos[i].ItemID);
                }
            }

            ///如果是材料。就用第一个道具。
            ///如果是装备，就用自身不拥有的第一个道具
            for (int i = 0; i < WelfareChouKaList.Count; i++)
            {
                string[] rewardItem = WelfareChouKaList[i].Split('@');

                if (rewardItem.Length == 1)
                {
                    rewardList.Add(rewardItem[0]);
                }
                else
                {
                    for (int reward = 0; reward < rewardItem.Length; reward++)
                    {
                        int itemId = int.Parse(rewardItem[reward].Split(';')[0]);
                        if (!haveItems.Contains(itemId))
                        {
                            rewardList.Add(rewardItem[reward]);
                        }
                    }
                    if (rewardList.Count <= i)
                    {
                        rewardList.Add(rewardItem[0]);
                    }
                }
            }

            return  rewardList;
        }

    }
}
