
namespace ET
{
    public class Login_OnQueueEnterGame : AEventClass<EventType.QueueEnterGame>
    {

        protected override void Run(object cls)
        {
            Log.ILog.Debug("Login_OnQueueEnterGame");
            EventType.QueueEnterGame args = cls as EventType.QueueEnterGame;
            AccountInfoComponent PlayerComponent = args.ZoneScene.GetComponent<AccountInfoComponent>();
            LoginHelper.Login(
                args.ZoneScene,
                PlayerComponent.ServerIp,
                PlayerComponent.Account,
                PlayerComponent.Password,
                false,
                args.Token).Coroutine();
            UIHelper.Remove(args.ZoneScene, UIType.UIQueue).Coroutine();
        }

    }
}
