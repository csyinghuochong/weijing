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
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i].Type == UnitType.Npc || units[i].IsChest())
                {
                    float t_distance = PositionHelper.Distance2D(main, units[i]);
                    if (t_distance < distance)
                    {
                        distance = t_distance;
                        npc = units[i];
                    }
                }
            }

            if (npc == null)
            {
                return;
            }

            if (npc.Type == UnitType.Npc)
            {
                zoneScene.CurrentScene().GetComponent<OperaComponent>().OnClickNpc(npc.ConfigId).Coroutine();
            }

            if (npc.Type == UnitType.Monster)
            {
                zoneScene.CurrentScene().GetComponent<OperaComponent>().OnClickChest(npc.Id);
            }
        }
    }
}
