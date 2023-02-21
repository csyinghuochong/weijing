using System;

namespace ET
{
    public static class AreneHelper
    {
        public static bool IsInTime(string openTime)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            string[] openTimes = openTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            int startTime = openTime_1 * 60 + openTime_2;
            int endTime = closeTime_1 * 60 + closeTime_2 - 2;
            int curTime = dateTime.Hour * 60 + dateTime.Minute;
            bool inTime = curTime >= startTime && curTime <= endTime;
            return inTime;
        }
    }
}
