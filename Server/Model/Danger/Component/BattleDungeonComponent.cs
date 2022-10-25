using System;

namespace ET
{
    public class BattleDungeonComponent : Entity, IAwake
    {
        public int CampKillNumber_1;
        public int CampKillNumber_2;
        public bool SendReward;
           
        public M2C_BattleInfoResult m2C_BattleInfoResult = new M2C_BattleInfoResult();  
    }
}
