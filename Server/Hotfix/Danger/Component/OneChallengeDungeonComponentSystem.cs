using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class OneChallengeDungeonComponentSystem
    {
        public static void OnUnitLeave(this OneChallengeDungeonComponent self, Scene scene)
        {
            List<Unit> units = UnitHelper.GetUnitList(scene, UnitType.Player);
            if (units.Count > 0)
            {
                return;
            }
            
            TransferHelper.NoticeFubenCenter(scene, 2).Coroutine();
            scene.Dispose();
        }
    }
}
