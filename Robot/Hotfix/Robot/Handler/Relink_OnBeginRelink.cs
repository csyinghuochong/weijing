namespace ET
{

    [Event]
    public class Relink_OnBeginRelink : AEventClass<EventType.BeginRelink>
    {

        protected override void Run(object cls)
        {
            EventType.BeginRelink args = (EventType.BeginRelink)cls;
           
            RobotManagerComponent robotManager = args.ZoneScene.GetParent<RobotManagerComponent>();
            robotManager.RemoveRobot_2(args.ZoneScene, "掉线退出").Coroutine();
        }
    }
}
