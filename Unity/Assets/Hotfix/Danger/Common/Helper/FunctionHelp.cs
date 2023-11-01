using System;

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

        /// <summary>
        /// 1044 家族战
        /// </summary>
        /// <param name="day"></param>
        /// <param name="functionid"></param>
        /// <returns></returns>
        public static bool IsFunctionDayOpen(int day, int functionid)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(functionid);
            //string[] openTimes = funtionConfig.OpenTime.Split('@');
            //return int.Parse(openTimes[2]);

            if (funtionConfig.IfOpen == "1")
            {
                return false;
            }

            if (day == 7)
            {
                day = 0;
            }

            for (int i = 0; i < funtionConfig.OpenDay.Length; i++)
            {
                if (funtionConfig.OpenDay[i] == -1 || funtionConfig.OpenDay[i] ==day)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool IsInUnionRaceTime()
        {
            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;

            bool isopen = IsFunctionDayOpen((int)dateTime.DayOfWeek, 1044);
            long startTime = GetOpenTime(1044);
            long endTime = GetCloseTime(1044) - 10;
            return isopen && curTime > startTime && curTime < endTime;
        }

        public static bool IsInTime(int functionid)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(functionid);
            if (funtionConfig.IfOpen == "1")
            {
                return false;
            }

            long serverTime = TimeHelper.ServerNow();
            DateTime dateTime = TimeInfo.Instance.ToDateTime(serverTime);
          
            bool isopen = IsFunctionDayOpen( (int)dateTime.DayOfWeek,  functionid);
            if (!isopen)
            {
                return false;
            }

            string openTime = funtionConfig.OpenTime;
            long curTime = (dateTime.Hour * 60 + dateTime.Minute) * 60 + dateTime.Second;
            string[] openTimes = openTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            long startTime = (openTime_1 * 60 + openTime_2) * 60;
            long endTime = (closeTime_1 * 60 + closeTime_2) * 60;
           
            bool inTime = curTime >= startTime && curTime <= endTime;
            return inTime;
        }


        /// <summary>
        /// 返回 秒
        /// </summary>
        /// <param name="function"></param>
        /// <returns></returns>
        public static long GetOpenTime(int function)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
            if (ComHelp.IfNull(funtionConfig.OpenTime))
            {
                return 0;
            }

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
            if (ComHelp.IfNull(funtionConfig.OpenTime))
            {
                return (23 * 60 + 59) * 60;
            }

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

        public static string GetFunctionContion(Scene zongScene, FuntionConfig funtionOpenConfig)
        {
            string tip = string.Empty;
            int[] contion_1 = funtionOpenConfig.ConditionType;
            int[] contion_2 = funtionOpenConfig.ConditionParam;
            for (int i = 0; i < contion_1.Length; i++)
            {
                int triggerType = contion_1[i];
                int triggerValue = contion_2[i];
                bool open = true;
                switch (triggerType)
                {
                    case FunctionContionEnum.None:
                        open = DonotCheck();
                        break;
                    case FunctionContionEnum.PlayerLv:
                        open = CheckPlayerLv(zongScene, triggerValue);
                        tip = $"请提升等级至: {triggerValue}";
                        break;
                    case FunctionContionEnum.TaskId:
                        open = CheckTaskID(zongScene, triggerValue);
                        TaskConfig taskConfig = TaskConfigCategory.Instance.Get(triggerValue);
                        tip = $"请完成任务: {taskConfig.TaskName}";
                        break;
                }
                if (!open)
                {
                    break;
                }
            }
            return tip;
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
