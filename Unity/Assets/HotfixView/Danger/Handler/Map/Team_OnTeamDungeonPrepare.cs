using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Team_OnTeamDungeonPrepare : AEventClass<EventType.RecvTeamDungeonPrepare>
    {
        protected override void Run(object cls)
        {
            EventType.RecvTeamDungeonPrepare args = (EventType.RecvTeamDungeonPrepare)cls;
            UI uI = UIHelper.GetUI(args.ZoneScene, UIType.UITeamDungeonPrepare);
            if (uI == null)
            {
                return;
            }
            uI.GetComponent<UITeamDungeonPrepareComponent>().OnUpdateUI(args.PrepareResult.TeamInfo, args.PrepareResult.ErrorCode);
        }
    }
}
