using System;
using System.Globalization;

namespace ET
{
    public static class TimeHelper
    {
        public const long OneDay = 86400000;
        public const long Hour = 3600000;
        public const long Minute = 60000;
        
        /// <summary>
        /// 客户端时间
        /// </summary>
        /// <returns></returns>
        public static long ClientNow()
        {
            return TimeInfo.Instance.ClientNow();
        }

        public static long ClientNowSeconds()
        {
            return ClientNow() / 1000;
        }

        public static DateTime DateTimeNow()
        {
            return DateTime.Now;
        }

        public static long ServerNow()
        {
            return TimeInfo.Instance.ServerNow();
        }

        public static long ClientFrameTime()
        {
            return TimeInfo.Instance.ClientFrameTime();
        }
        
        public static long ServerFrameTime()
        {
            return TimeInfo.Instance.ServerFrameTime();
        }

        public static string ShowTimeDifferenceStr(DateTime dt1, DateTime dt2)
        {
            //Log.Info("dt1 = " + dt1.ToString() + " dt2 = " + dt2.ToString());
            TimeSpan dt = dt1 - dt2;
            string returnStr = "";
            if (dt.Days >= 1)
            {
                returnStr = dt.Days + "天";
            }
            if (dt.Hours >= 1)
            {
                returnStr += dt.Hours + "时";
            }
            if (dt.Minutes >= 1)
            {
                returnStr += dt.Minutes + "分";
            }
            return returnStr;
        }

        public static string TimeToShowCostTimeStr(long time, int addHours)
        {
            DateTime dt1 = TimeInfo.Instance.ToDateTime(time);
            dt1 = dt1.AddHours(addHours);
            DateTime dt2 = TimeHelper.DateTimeNow();
            //TimeSpan dt = dt1 - dt2;
            //Log.Info("dt1 = " + dt1.ToString() + " dt2 = " + dt2.ToString());
            return ShowTimeDifferenceStr(dt1, dt2);
        }

        public static string ShowLeftTime(long time)
        {
            string str = "";
            time = time / 1000;

            if (time > 24 *60 * 60)
            {
                str += $"{time / (24 * 60 * 60)}天";
                time %= 24 * 60 * 60;
            }
            str += $"{time / (60 * 60)}时";
            time %= 60 * 60;
            str += $"{time / 60}分";
            str += $"{time % 60}秒";
            return str;
        }

        public static bool IsInTime(string openTime)
        {
            DateTime dateTime = TimeHelper.DateTimeNow();
            string[] openTimes = openTime.Split('@');
            int openTime_1 = int.Parse(openTimes[0].Split(';')[0]);
            int openTime_2 = int.Parse(openTimes[0].Split(';')[1]);
            int closeTime_1 = int.Parse(openTimes[1].Split(';')[0]);
            int closeTime_2 = int.Parse(openTimes[1].Split(';')[1]);
            int startTime = openTime_1 * 100 + openTime_2;
            int endTime = closeTime_1 * 100 + closeTime_2;
            int curTime = dateTime.Hour * 100 + dateTime.Minute;
            bool inTime = curTime >= startTime && curTime <= endTime;
            return inTime;
        }
    }
}