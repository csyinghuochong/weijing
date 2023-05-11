using System;
using System.Collections.Generic;

namespace ET
{
    public static class FunctionHelp
    {

        public static long BossOpenTime()
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1043);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            return (openTime_1 * 60 + openTime_2) * 60 + 0;
        }

        public static long RaceOpenTime()
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1044);

            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int openday = int.Parse(openTimes[2]);
            if (openday != (int)dateTime.DayOfWeek)
            {
                return -1;
            }
            return (openTime_1 * 60 + openTime_2) * 60 + 0;
        }


        public static bool IsInUnionRaceTime()
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;

            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(1044);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            int openday = int.Parse(openTimes[2]);
            long startTime = (openTime_1 * 60 + openTime_2) * 60 + 10;
            long endTime = (closeTime_1 * 60 + closeTime_2) * 60 - 10;
            return curTime > startTime && curTime < endTime && (int)dateTime.DayOfWeek == openday;
        }

        public static bool IsInTime(string openTime)
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            string[] openTimes = openTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            long startTime = (openTime_1 * 60 + openTime_2) * 60 + 10;
            long endTime = (closeTime_1 * 60 + closeTime_2) * 60 - 20;
           
            bool inTime = curTime >= startTime && curTime <= endTime;
            return inTime;
        }

        public static long GetSoloBeginTime()
        {
            return GetOpenTime(1045);
        }

        public static long GetSoloOverTime()
        {
            return GetCloseTime(1045);
        }

        public static long GetAuctionBeginTime()
        {
            return GetOpenTime(1040);
        }


        public static long GetAuctionOverTime()
        {
            return GetCloseTime(1040);
        }

        /// <summary>
        /// 返回 秒
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public static long GetOpenTime(int function)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            long startTime = (openTime_1 * 60 + openTime_2) * 60;
            return startTime;
        }

        /// <summary>
        /// 返回 秒
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public static long GetCloseTime(int function)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            long endTime = (closeTime_1 * 60 + closeTime_2) * 60;
            return endTime;
        }

        public static float[] DoubleArrToFloatArr(Double[] arr)
        {
            float[] nowFloat = new float[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                nowFloat[i] = (float)arr[i];
            }
            return nowFloat;

        }
        public static bool DonotCheck()
        {
            return true;
        }

#if SERVER
        //检测函数也可以放在对应的功能模块
        public static bool CheckPlayerLv(Unit unit, int parame)
        {
            return unit.GetComponent<UserInfoComponent>().UserInfo.Lv >= parame;
        }

        public static bool CheckTaskID(Unit unit, int parame)
        {
            return unit.GetComponent<TaskComponent>().IsTaskComplete(parame);
        }

        public static bool CheckTaskOn(Unit unit, TaskConfig taskConfig)
        {
            bool open = false;
            switch (taskConfig.TriggerType)
            {
                case FunctionContionEnum.None:
                    open = DonotCheck();
                    break;
                case FunctionContionEnum.PlayerLv:
                    open = CheckPlayerLv(unit, taskConfig.TriggerValue);
                    break;
                case FunctionContionEnum.TaskId:
                    open = CheckTaskID(unit, taskConfig.TriggerValue);
                    break;
            }
            return open;   
        }
#else
        public static bool CheckPlayerLv(Scene zongScene, int parame)
        {
            return zongScene.GetComponent<UserInfoComponent>().UserInfo.Lv >= parame;
        }

        public static bool CheckTaskID(Scene zongScene, int parame)
        {
            return zongScene.GetComponent<TaskComponent>().IsTaskFinished(parame);
        }

        public static bool CheckFuncitonOn(Scene zongScene, FuntionConfig funtionOpenConfig)
        {
            int[] contion_1 = funtionOpenConfig.ConditionType;
            int[] contion_2 = funtionOpenConfig.ConditionParam;
            for (int i = 0; i < contion_1.Length; i++)
            {
                if (!CheckTaskOn(zongScene, contion_1[i], contion_2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool CheckTaskOn(Scene scene, int triggerType, int triggerValue)
        {
            bool open = false;
            switch (triggerType)
            {
                case FunctionContionEnum.None:
                    open = DonotCheck();
                    break;
                case FunctionContionEnum.PlayerLv:
                    open = CheckPlayerLv(scene, triggerValue);
                    break;
                case FunctionContionEnum.TaskId:
                    open = CheckTaskID(scene, triggerValue);
                    break;
            }
            return open;

        }
#endif
    }
}
