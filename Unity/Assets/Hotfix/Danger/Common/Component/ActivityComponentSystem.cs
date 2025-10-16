using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{
    public static class ActivityComponentSystem
    {

        /// <summary>
        /// 取到当前可以领取的最小等级
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static int GetCurActivityId(this ActivityComponent self, int rechargeNumb)
        {
            int activityId = 0;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 101)
                {
                    continue;
                }
                activityId = activityConfigs[i].Id;
                int needNumber = int.Parse(activityConfigs[i].Par_2);
                if (rechargeNumb < needNumber)
                {
                    break;
                }
                if (rechargeNumb >= needNumber && !self.ActivityReceiveIds.Contains(activityId))
                {
                    break;
                }
            }
            return activityId;
        }

#if SERVER
        public static int GetMaxActivityId(this ActivityComponent self, int rechargeNumb)
        {
            int activityId = 0;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 101)
                {
                    continue;
                }
                int needNumber = int.Parse(activityConfigs[i].Par_2);
                if (rechargeNumb < needNumber)
                {
                    break;
                }
                activityId = activityConfigs[i].Id;
            }
            return activityId;
        }

        public static void OnLogin(this ActivityComponent self, int level)
        {
            if (self.DayTeHui.Count == 0)
            {
                self.DayTeHui = DayTeHuiHelper.GetDayTeHuiList(2, level);
            }
            if (self.ActivityV1Info.LiBaoAllIds.Count == 0)
            {
                self.ActivityV1Info.LiBaoAllIds = ActivityConfigHelper.GetLiBaoList( );
            }
            if (string.IsNullOrEmpty(self.ActivityV1Info.ChouKa2ItemList))
            {
                self.ActivityV1Info.ChouKa2ItemList = ActivityConfigHelper.GetChouKa2RewardList();
            }
        }

        public static void ClearJieRiActivty(this ActivityComponent self)
        {
            for (int i = self.ActivityReceiveIds.Count - 1; i >= 0; i--)
            {
                ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.ActivityReceiveIds[i]);
                if (activityConfig.ActivityType == 33)
                {
                    self.ActivityReceiveIds.RemoveAt(i);
                }
            }
        }

        public static void Check(this ActivityComponent self)
        {
            self.LastTimerChouKaPassTime += TimeHelper.Second;
        }

        public static void OnZeroClockUpdate(this ActivityComponent self, int level)
        {
            self.DayTeHui = DayTeHuiHelper.GetDayTeHuiList(2, level);
            
            //重置每日特惠 和 新春活动
            for (int i = self.ActivityReceiveIds.Count -1; i >= 0; i--)
            {
                ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.ActivityReceiveIds[i]);
                if (activityConfig.ActivityType ==2 || activityConfig.ActivityType == 32)
                {
                    self.ActivityReceiveIds.RemoveAt(i);
                }
            }

            if (self.TotalSignNumber >= 30)
            {
                self.TotalSignNumber = 0;
                for (int i = self.ActivityReceiveIds.Count - 1; i >= 0; i--)
                {
                    ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.ActivityReceiveIds[i]);
                    if (activityConfig.ActivityType == 23)
                    {
                        self.ActivityReceiveIds.RemoveAt(i);
                    }
                }
            }

            self.ActivityV1Info.LiBaoAllIds = ActivityConfigHelper.GetLiBaoList();
            self.ActivityV1Info.LiBaoBuyIds.Clear();
            self.ActivityV1Info.LastGuessReward.Clear();
            self.ActivityV1Info.ChouKaNumberReward.Clear(); 
            self.ActivityV1Info.ConsumeDiamondReward.Clear();

            //self.LastTimerChouKaPassTime = 0;
            //self.TimerChouKaReceiveIndex = 0;
    }
#endif

#if !SERVER
        public static bool HaveLoginReward(this ActivityComponent self)
        {
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Lv < 10)
            {
                return false;
            }

            int unGetId = 0;
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 31)
                {
                    continue;
                }
                if (!self.ActivityReceiveIds.Contains(activityConfigs[i].Id))
                {
                    unGetId = activityConfigs[i].Id;
                    break;
                }
            }
            if (unGetId == 0)
            {
                return false;
            }
            return ComHelp.GetDayByTime(TimeHelper.ServerNow()) != ComHelp.GetDayByTime(self.LastLoginTime);
        }

        public static void OnZeroClockUpdate(this ActivityComponent self)
        {
            //重置每日特惠
            for (int i = self.ActivityReceiveIds.Count - 1; i >= 0; i--)
            {
                ActivityConfig activityConfig = ActivityConfigCategory.Instance.Get(self.ActivityReceiveIds[i]);
                if (activityConfig.ActivityType == 2 || activityConfig.ActivityType == 32)
                {
                    self.ActivityReceiveIds.RemoveAt(i);
                }
            }

            //self.LastTimerChouKaPassTime = 0;
            //self.TimerChouKaReceiveIndex = 0;

            HintHelp.GetInstance().DataUpdate(DataType.UpdateTimerChouKa);
        }

        public static void OnRecvActivityInfo(this ActivityComponent self, M2C_ActivityInfoResponse r2c_roleEquip)
        {
            self.ActivityReceiveIds = r2c_roleEquip.ReceiveIds;
            self.LastSignTime = r2c_roleEquip.LastSignTime;
            self.TotalSignNumber = r2c_roleEquip.TotalSignNumber;
            self.QuTokenRecvive = r2c_roleEquip.QuTokenRecvive;
            self.LastLoginTime = r2c_roleEquip.LastLoginTime;
            self.DayTeHui = r2c_roleEquip.DayTeHui;
            self.ActivityV1Info = r2c_roleEquip.ActivityV1Info;
            self.TimerChouKaReceiveIndex = r2c_roleEquip.TimerChouKaReceiveIndex;
            self.LastTimerChouKaPassTime = r2c_roleEquip.LastTimerChouKaPassTime;

            HintHelp.GetInstance().DataUpdate(DataType.UpdateTimerChouKa);
        }


        public static async ETTask<int> SendTimerChouKaRequest(this ActivityComponent self)
        { 
            C2M_TimerChouKaRequest c2M_TimerChouKaRequest = new C2M_TimerChouKaRequest();
            M2C_TimerChouKaResponse m2C_TimerChouKaResponse = (M2C_TimerChouKaResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_TimerChouKaRequest);
            if (m2C_TimerChouKaResponse == null)
            {
                return ErrorCode.ERR_NetWorkError;
            }
            if (m2C_TimerChouKaResponse.Error!= ErrorCode.ERR_Success)
            {
                return m2C_TimerChouKaResponse.Error;
            }

            self.LastTimerChouKaPassTime = m2C_TimerChouKaResponse.LastTimerChouKaPassTime;
            self.TimerChouKaReceiveIndex = m2C_TimerChouKaResponse.TimerChouKaReceiveIndex;

            HintHelp.GetInstance().DataUpdate(DataType.UpdateTimerChouKa);
            return ErrorCode.ERR_Success;
        }

        public static async ETTask<int> GetActivityReward(this ActivityComponent self, int activityType, int activityId)
        {
            try
            {
                C2M_ActivityReceiveRequest c2M_ItemHuiShouRequest = new C2M_ActivityReceiveRequest() { ActivityType = activityType, ActivityId = activityId };
                M2C_ActivityReceiveResponse r2c_roleEquip = (M2C_ActivityReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);
                if (activityType == 31)
                {
                    self.LastLoginTime = TimeHelper.ServerNow();

                }
                if (r2c_roleEquip.Error == ErrorCode.ERR_Success)
                {
                    self.ActivityReceiveIds.Add(activityId);
                }
                return r2c_roleEquip.Error;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
                return ErrorCode.ERR_NetWorkError;
            }
        }

        public static async ETTask<int> GetZhanQuActivityReward(this ActivityComponent self, int activityType, int activityId)
        {
            if (activityType != 21 && activityType != 22)
            {
                return ErrorCode.ERR_Error;
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
                return ErrorCode.ERR_NetWorkError;
            }
        }
#endif

    }
}
