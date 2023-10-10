
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public static class UIMapHelper
    {

        public static void OnMainHeroMove(Unit self)
        {
            float curTime = Time.time;
            List<Unit> units = self.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (curTime <= unit.UpdateUITime)
                {
                    continue;
                }
                if (unit.Type == UnitType.Npc)
                {
                    unit.UpdateUITime = curTime;
                    NpcHeadBarComponent npcHeadBarComponent = unit.GetComponent<NpcHeadBarComponent>();
                    npcHeadBarComponent?.OnUpdateNpcTalk(self);
                    continue;
                }
                if (unit.Type == UnitType.Pasture)
                {
                    unit.UpdateUITime = curTime;
                    JiaYuanPastureUIComponent npcHeadBarComponent = unit.GetComponent<JiaYuanPastureUIComponent>();
                    npcHeadBarComponent?.OnUpdateNpcTalk(self);
                    continue;
                }
                if (unit.Type == UnitType.Chuansong)
                {
                    unit.UpdateUITime = curTime;
                    unit.GetComponent<TransferUIComponent>()?.OnCheckChuanSong(self);
                    continue;
                }
            }
        }

    }

}