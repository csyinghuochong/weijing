using System;

namespace ET
{
    public static class BuChangHelper
    {
        public static int BuChangZone = 5;

        public static int BuChangEnd = 20221130;

        public static KeyValuePairInt GetBuChangRecharge(PlayerInfo playerInfo)
        {
            int number = 0;
            KeyValuePairInt keyValuePairInt = new KeyValuePairInt();
            for (int i = 0; i < playerInfo.RechargeInfos.Count; i++)
            {
                int zone = UnitIdStruct.GetUnitZone(playerInfo.RechargeInfos[i].UserId);
                if (zone >= BuChangZone)
                {
                    continue;
                }
                number += playerInfo.RechargeInfos[i].Amount;
                keyValuePairInt.KeyId += number;
                keyValuePairInt.Value += ComHelp.GetDiamondNumber(number);
            }
            return keyValuePairInt;  
        }

        public static int ShowNewBuChang(PlayerInfo playerInfo, long unitid)
        {
            int zone = UnitIdStruct.GetUnitZone(unitid);
            if (zone != BuChangZone)
            {
                return 0;
            }
            if (playerInfo.BuChangZone.Contains(zone))
            {
                return 0;
            }

            DateTime dateTime = TimeHelper.DateTimeNow();
            int time = dateTime.Year * 10000 + dateTime.Month * 100 + dateTime.Day;
            if (time >= BuChangEnd)
            {
                return 0;
            }

            return GetBuChangRecharge(playerInfo).KeyId;
        }
    }
}
