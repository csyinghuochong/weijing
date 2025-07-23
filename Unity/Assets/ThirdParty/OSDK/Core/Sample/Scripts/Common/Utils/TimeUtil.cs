using System;

namespace Douyin.Game
{
    public static class TimeUtil
    {
        // 获取系统时间戳
        public static string GetTimeStamp()
        {
            return GetTimeStampLong().ToString();
        }

        public static long GetTimeStampLong()
        {
            var ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds);
        }

        // 时间戳转化为日期格式
        public static string TimeStampToFormatDate(long timeStamp, string dateFormat)
        {
            return GetDateTime(timeStamp).ToString(dateFormat);
        }

        // 时间戳转换成日期  
        private static DateTime GetDateTime(long timeStamp)
        {
#pragma warning disable 618
            var dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
#pragma warning restore 618
            var lTime = timeStamp * 10000000;
            var toNow = new TimeSpan(lTime);
            var targetDt = dtStart.Add(toNow);
            return targetDt;
        }
    }
}