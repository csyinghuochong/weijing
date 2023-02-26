namespace ET
{

    [Event]
    public class Relink_OnBeginRelink : AEventClass<EventType.BeginRelink>
    {

        protected override void Run(object cls)
        {
            EventType.BeginRelink args = (EventType.BeginRelink)cls;
           
            RobotManagerComponent robotManager = args.ZoneScene.GetParent<RobotManagerComponent>();
            Log.Debug("robotManager == null_222");
            robotManager.RemoveRobot(args.ZoneScene, "掉线退出").Coroutine();
        }
    }
}
