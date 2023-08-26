using UnityEngine;

namespace ET
{

    [Event]
    public class Turtle_OnTurtleReward : AEventClass<EventType.TurtleReward>
    {
        protected override void Run(object cls)
        {
            EventType.TurtleReward args = cls as EventType.TurtleReward;

            Unit unit = args.ZoneScene.CurrentScene().GetComponent<UnitComponent>().Get(args.m2C_TurtleReward.UnitID);
            if (unit == null) 
            {
                return;
            }
            unit.GetComponent<NpcHeadBarComponent>().UpdateRewardName(args.m2C_TurtleReward.PlayerName);
        }
    }
}
