using System;
using System.Globalization;
using System.Collections.Generic;
using System.Reflection;

namespace ET
{

    public static class FunctionHelp
    {
        public static bool DonotCheck(Unit unit, int parame)
        {
            return true;
        }

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
                    open = DonotCheck(unit, taskConfig.TriggerValue);
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
    }
}
