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
            MapComponent mapComponent = args.ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.TeamDungeon)
            {
                Scene zoneScene = args.ZoneScene;
                EnterFubenHelp.RequestQuitFuben(zoneScene);
                zoneScene.GetComponent<BehaviourComponent>().TargetID = 0;
                zoneScene.GetComponent<BehaviourComponent>().ChangeBehaviour(BehaviourType.Behaviour_TeamDungeon);
            }
        }
    }
}
