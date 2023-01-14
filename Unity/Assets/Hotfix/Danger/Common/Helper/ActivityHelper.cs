using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class ActivityHelper
    {

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
