using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public static class ActivityHelper
    {

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
