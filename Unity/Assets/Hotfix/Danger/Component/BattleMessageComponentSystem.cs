namespace ET
{



    public static class BattleMessageComponentSystem
    {

        public static void CancelRideTargetUnit(this BattleMessageComponent self, long targetid)
        {
            if (targetid == self.RideTargetUnit)
            {
                self.SetRideTargetUnit(0);
            }
        }

        public static void SetRideTargetUnit(this BattleMessageComponent self, long targetid)
        {
            self.RideTargetUnit = targetid;
            if (targetid > 0)
            {
                self.RideForbidTime = TimeHelper.ClientNow() + TimeHelper.Second * 6; 
            }
            else
            { 
                self.RideForbidTime = 0;    
            }
        }

        public static bool IsCanRideHorse(this BattleMessageComponent self)
        {
            if (self.RideForbidTime == 0)
            {
                return true;
            }
            return TimeHelper.ClientNow() > self.RideForbidTime;    
        }

    }

}