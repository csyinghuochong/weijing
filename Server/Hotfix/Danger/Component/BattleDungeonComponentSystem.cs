using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [ObjectSystem]
    public class BattleDungeonComponentAwakeSystem : AwakeSystem<BattleDungeonComponent>
    {

        public override void Awake(BattleDungeonComponent self)
        {
            self.CampKillNumber_1 = 0;
            self.CampKillNumber_2 = 0;
        }
    }

    public static class BattleDungeonComponentSystem
    {
    }
}
