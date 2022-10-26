using System;
using System.Collections.Generic;


namespace ET
{
    [ActorMessageHandler]
    public class C2M_TeamPickHandlerr : AMActorLocationRpcHandler<Unit, C2M_TeamPickRequest, M2C_TeamPickResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamPickRequest request, M2C_TeamPickResponse response, Action reply)
        {
            TeamDungeonComponent teamDungeonComponent = unit.DomainScene().GetComponent<TeamDungeonComponent>();
            List<TeamDropItem> teamDropItems = teamDungeonComponent.TeamDropItems;
            TeamDropItem teamDropItem = null;
            for (int i = 0; i < teamDropItems.Count; i++)
            {
                if (teamDropItems[i].DropInfo.UnitId == request.DropItem.UnitId)
                {
                    teamDropItem = teamDropItems[i];
                    break;
                }
            }
            if (teamDropItem == null)
            {
                reply();
                return;
            }
            if (request.Need == 1 && !teamDropItem.NeedPlayers.Contains(unit.Id))
            {
                teamDropItem.NeedPlayers.Add(unit.Id);
            }
            if (request.Need == 2 && !teamDropItem.GivePlayers.Contains(unit.Id))
            {
                teamDropItem.GivePlayers.Add(unit.Id);
            }
            reply();
            await ETTask.CompletedTask;
        }
    }
}
