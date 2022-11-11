using System;
using System.Collections.Generic;

namespace ET
{

    public static class FunctionHelp
    {

        public static bool IsInTime(List<int> openTime)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            int openTime_1 = openTime[0];
            int openTime_2 = openTime[1];
            int closeTime_1 = openTime[2];
            int closeTime_2 = openTime[3];
            int startTime = openTime_1 * 100 + openTime_2;
            int endTime = closeTime_1 * 100 + closeTime_2;
            int curTime = dateTime.Hour * 100 + dateTime.Minute;
            bool inTime = curTime >= startTime && curTime <= endTime;
            return inTime;
        }
        public static int GetOpenTime(int function)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int startTime = openTime_1 * 60 + openTime_2;
            return startTime;
        }

        public static int GetCloseTime(int function)
        {
            FuntionConfig funtionConfig = FuntionConfigCategory.Instance.Get(function);
            string[] openTimes = funtionConfig.OpenTime.Split('@');
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            int endTime = closeTime_1 * 60 + closeTime_2;
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
