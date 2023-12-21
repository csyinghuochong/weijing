namespace ET
{

    public static class BattleMessageComponentSystem
    {

        public static void CancelRideTargetUnit(this BattleMessageComponent self, long targetid)
        {
            if (targetid == 0 || targetid == self.RideTargetUnit)
            {
                self.SetRideTargetUnit(0);
            }
        }

        public static void ShowRolePetAdd(this BattleMessageComponent self)
        {
            if (self.RolePetAdds.Count == 0)
            {
                return;
            }
            EventSystem.Instance.PublishClass(self.RolePetAdds[0]);
            self.RolePetAdds.RemoveAt(0);
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

        public static bool CanShout(this BattleMessageComponent self)
        {
            // 组队喊话设置频率，一分钟一次
            long oldTime = self.ShoutInterval;
            long nowTime = TimeHelper.ServerNow();
            if (nowTime - oldTime >= 60000)
            {
                self.ShoutInterval = nowTime;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}