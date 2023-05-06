using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class ActivityHelper
    {

        public static string GetJieRiReward(UserInfoComponent userInfoComponent)
        {
            ExpConfig expCof = ExpConfigCategory.Instance.Get(userInfoComponent.UserInfo.Lv);
            int gold = expCof.RoseGoldPro * 150;
            int exp = expCof.RoseExpPro * 50;
            return $"1;{gold}@2;{exp}@10010039;1";
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


    }
}
