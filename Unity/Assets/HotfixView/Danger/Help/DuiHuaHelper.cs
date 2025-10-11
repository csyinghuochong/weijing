using System.Collections.Generic;

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
                if (units[i].Type == UnitType.Npc || units[i].IsChest() || units[i].IsJingLingMonster())
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

            OperaComponent operaComponent = zoneScene.CurrentScene().GetComponent<OperaComponent>();
            if (npc.Type == UnitType.Npc)
            {
                operaComponent.OnClickNpc(npc.ConfigId).Coroutine();
            }

            if (npc.IsChest())
            {
                operaComponent.OnClickChest(npc.Id);
            }

            if (npc.IsJingLingMonster())
            {
                operaComponent.OnClickMonsterItem(npc.Id).Coroutine();
                operaComponent.OnMoveToJingLing(npc.Id);
            }
        }
    }
}
