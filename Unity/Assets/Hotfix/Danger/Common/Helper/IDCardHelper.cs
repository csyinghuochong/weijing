using System;

namespace ET
{
    public static class IDCardHelper
    {
        public static int GetBirthdayAgeSex(string identityCard)
        {
            if (string.IsNullOrEmpty(identityCard))
            {
                return 0;
            }
            else
            {
                if (identityCard.Length != 15 && identityCard.Length != 18)//身份证号码只能为15位或18位其它不合法
                {
                    return 0;
                }
            }

            string birthday = "";
            if (identityCard.Length == 18)//处理18位的身份证号码从号码中得到生日和性别代码
            {
                birthday = identityCard.Substring(6, 4) + "-" + identityCard.Substring(10, 2) + "-" + identityCard.Substring(12, 2);
            }
            if (identityCard.Length == 15)
            {
                birthday = "19" + identityCard.Substring(6, 2) + "-" + identityCard.Substring(8, 2) + "-" + identityCard.Substring(10, 2);
            }

            return CalculateAge(birthday);//根据生日计算年龄
        }

        /// <summary>
        /// 根据出生日期，计算精确的年龄
        /// </summary>
        /// <param name="birthDate">生日</param>
        /// <returns></returns>
        public static int CalculateAge(string birthDay)
        {
            string[] times = birthDay.Split('-');
            DateTime nowDateTime = DateTime.Now;
            int age = nowDateTime.Year - int.Parse(times[0]);
            //再考虑月、天的因素
            if (nowDateTime.Month < int.Parse(times[1]) || (nowDateTime.Month == int.Parse(times[1]) && nowDateTime.Day < int.Parse(times[2])))
            {
                age--;
            }
            return age;
        }

    }
}
