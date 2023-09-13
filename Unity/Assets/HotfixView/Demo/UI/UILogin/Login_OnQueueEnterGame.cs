
namespace ET
{
    public class Login_OnQueueEnterGame : AEventClass<EventType.QueueEnterGame>
    {

        protected override void Run(object cls)
        {
            EventType.QueueEnterGame args = cls as EventType.QueueEnterGame;

            Scene zoneScene = args.ZoneScene;
            zoneScene.GetComponent<SessionComponent>().Session.GetComponent<PingComponent>().DisconnectType = -1;
            zoneScene.GetComponent<SessionComponent>().Session.Dispose();
            AccountInfoComponent PlayerComponent = args.ZoneScene.GetComponent<AccountInfoComponent>();
            LoginHelper.Login(
                args.ZoneScene,
                PlayerComponent.ServerIp,
                PlayerComponent.Account,
                PlayerComponent.Password,
                false,
                args.Token, PlayerComponent.LoginType).Coroutine();
            UIHelper.Remove(args.ZoneScene, UIType.UIQueue);
        }

    }
}
