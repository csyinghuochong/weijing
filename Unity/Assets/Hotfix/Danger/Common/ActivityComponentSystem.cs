using System;

namespace ET
{
    public static class ActivityComponentSystem
    {


#if SERVER
        public static void OnZeroClockUpdate(this ActivityComponent self, int level)
        {
            self.DayTeHui = DayTeHuiHelper.GetDayTeHuiList(level);
            
            //重置每日特惠
            for (int i = self.ActivityReceiveIds.Count -1; i >= 0; i--)
            {
                ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.ActivityReceiveIds[i]);
                if (activityConfig.ActivityType ==2)
                {
                    self.ActivityReceiveIds.RemoveAt(i);
                }
            }
            //self.QuTokenRecvive.Clear();
        }
#endif

#if !SERVER

        public static void OnZeroClockUpdate(this ActivityComponent self, int level)
        {
            //重置每日特惠
            for (int i = self.ActivityReceiveIds.Count - 1; i >= 0; i--)
            {
                ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.ActivityReceiveIds[i]);
                if (activityConfig.ActivityType == 2)
                {
                    self.ActivityReceiveIds.RemoveAt(i);
                }
            }
        }

        public static async ETTask<int> GetActivityReward(this ActivityComponent self, int activityType, int activityId)
        {
            try
            {
                C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = activityType, ActivityId = activityId };
                M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                self.ActivityReceiveIds.Add(activityId);
                return r2c_roleEquip.Error;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return ErrorCore.ERR_NetWorkError;
            }
        }

        public static async ETTask<int> GetZhanQuActivityReward(this ActivityComponent self, int activityType, int activityId)
        {
            if (activityType != 21 && activityType != 22)
            {
                return ErrorCore.ERR_Error;
            }

            try
            {
                C2M_ZhanQuReceiveRequest c2M_ItemHuiShouRequest = new C2M_ZhanQuReceiveRequest() { ActivityType = activityType, ActivityId = activityId };
                M2C_ZhanQuReceiveResponse r2c_roleEquip = (M2C_ZhanQuReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);

                bool have = false;
                self.ZhanQuReceiveIds.Add(activityId);
                for (int i = 0; i < self.ZhanQuReceiveNumbers.Count; i++)
                {
                    if (self.ZhanQuReceiveNumbers[i].ActivityId == activityId)
                    {
                        have = true;
                        self.ZhanQuReceiveNumbers[i].ReceiveNum++;
                    }
                }
                if (!have)
                {
                    self.ZhanQuReceiveNumbers.Add(new ZhanQuReceiveNumber() { ActivityId = activityId, ReceiveNum = 1 });
                }

                return r2c_roleEquip.Error;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return ErrorCore.ERR_NetWorkError;
            }
        }
#endif

    }
}
