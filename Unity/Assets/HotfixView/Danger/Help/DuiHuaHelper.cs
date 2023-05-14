using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public static class DuiHuaHelper
    {
        public static void MoveToNpcDialog(Scene zoneScene)
        {
            float distance = 20f;
            Unit npc = null;
            Unit main = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            List<Unit> units = zoneScene.CurrentScene().GetComponent<UnitComponent>().GetAll();
            UnitInfoComponent unitInfoComponent;
            for (int i = 0; i < units.Count; i++)
            {
                unitInfoComponent = units[i].GetComponent<UnitInfoComponent>();
                if (units[i].Type != UnitType.Npc)
                {
                    continue;
                }

                float t_distance = PositionHelper.Distance2D(main, units[i] );
                if (t_distance < distance)
                {
                    distance = t_distance;
                    npc = units[i];
                }
            }

            if (npc == null)
            {
                return;
            }
            zoneScene.CurrentScene().GetComponent<OperaComponent>().OnClickNpc(npc.ConfigId).Coroutine();
        }


    }
}
