namespace ET
{
    public class Login_OnReturnLogin : AEventClass<EventType.ReturnLogin>
    {
        protected override void Run(object cls)
        {
            EventType.ReturnLogin args = (EventType.ReturnLogin)cls;

            RobotManagerComponent robotManager = args.ZoneScene.GetParent<RobotManagerComponent>();
            if (robotManager == null)
            {
                Log.Debug("robotManager == null_111");
                return;
            }
            robotManager.RemoveRobot(args.ZoneScene, "掉线退出").Coroutine();
        }
    }
}
