using System;
using System.Collections.Generic;

namespace ET
{
    public static  class UserHorseHelper
    {
        public static void OnUpdateHorseRide(this Unit self, int oldHorse)
        {
            if (oldHorse > 0)
            {
                ZuoQiShowConfig zuoqiCof = ZuoQiShowConfigCategory.Instance.Get(oldHorse);
                self.GetComponent<BuffManagerComponent>().BuffRemove(zuoqiCof.MoveBuffID);
            }
            int horseRide = self.GetComponent<NumericComponent>().GetAsInt(NumericType.HorseRide);
            if (horseRide > 1)
            {
                ZuoQiShowConfig zuoqiCof = ZuoQiShowConfigCategory.Instance.Get(horseRide);
                BuffData buffData_2 = new BuffData();
                buffData_2.SkillId = 67000278;
                buffData_2.BuffId = zuoqiCof.MoveBuffID;
                self.GetComponent<BuffManagerComponent>().BuffFactory(buffData_2, self, null);
            }
        }

        public static List<HideProList> GetZuoQiPro(this UserInfoComponent self)
        {
            List<HideProList> proList = new List<HideProList>();

            for (int i = self.UserInfo.HorseIds.Count - 1; i >= 0; i--)
            {
                ZuoQiShowConfig titleConfig = ZuoQiShowConfigCategory.Instance.Get(self.UserInfo.HorseIds[i]);
                string[] attributeInfoList = titleConfig.AddProperty.Split('@');
                for (int a = 0; a < attributeInfoList.Length; a++)
                {
                    if (ComHelp.IfNull(attributeInfoList[a]))
                    {
                        continue;
                    }
                    string[] attributeInfo = attributeInfoList[a].Split(',');
                    int numericType = int.Parse(attributeInfo[0]);

                    if (NumericHelp.GetNumericValueType(numericType) == 2)
                    {
                        float fvalue = float.Parse(attributeInfo[1]);
                        proList.Add(new HideProList() { HideID = numericType, HideValue = (long)(fvalue * 10000) });
                    }
                    else
                    {
                        long lvalue = 0;
                        try
                        {
                            lvalue = long.Parse(attributeInfo[1]);
                        }
                        catch (Exception ex)
                        {
                            Log.Debug(ex.ToString() + $"坐骑称号: {self.UserInfo.HorseIds[i]}");
                        }
                        proList.Add(new HideProList() { HideID = numericType, HideValue = lvalue });
                    }
                }
            }
            return proList;
        }

        public static void OnHorseActive(this UserInfoComponent self, int horseId, bool active)
        {
            if (active && !self.UserInfo.HorseIds.Contains(horseId))
            {
                self.UserInfo.HorseIds.Add(horseId);
            }
            if (!active && self.UserInfo.HorseIds.Contains(horseId))
            {
                self.UserInfo.HorseIds.Remove(horseId);
            }
        }

    }
}
