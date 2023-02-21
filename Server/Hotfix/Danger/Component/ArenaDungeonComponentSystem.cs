using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ObjectSystem]
    public class ArenaDungeonComponentAwake : AwakeSystem<ArenaDungeonComponent>
    {

        public override void Awake(ArenaDungeonComponent self)
        {
            self.Timer = 0;
        }
    }

    public static class ArenaDungeonComponentSystem
    {

        public static void OnKillEvent(this ArenaDungeonComponent self, Unit defend, Unit attack)
        {
            if (defend.Type != UnitType.Player)
            {
                return;
            }

        }
    }
}