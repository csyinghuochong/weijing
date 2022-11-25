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
                RechargeInfo rechargeInfo = playerInfo.RechargeInfos[i];    
                int zone = UnitIdStruct.GetUnitZone(rechargeInfo.UserId);
                if (zone >= BuChangZone)
                {
                    continue;
                }
                keyValuePairInt.KeyId += rechargeInfo.Amount;
                keyValuePairInt.Value += ComHelp.GetDiamondNumber(rechargeInfo.Amount);
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
