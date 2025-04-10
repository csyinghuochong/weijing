using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    [Event]
    public class Team_OnTeamDungeonSettlement : AEventClass<EventType.TeamDungeonSettlement>
    {
        protected override void Run(object cls)
        {
            EventType.TeamDungeonSettlement args = cls as EventType.TeamDungeonSettlement;
        }
    }
}
