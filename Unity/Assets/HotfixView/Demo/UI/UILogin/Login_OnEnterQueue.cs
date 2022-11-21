namespace ET
{
    public class Login_OnEnterQueue : AEventClass<EventType.EnterQueue>
    {
        protected override void Run(object cls)
        {
            RunAsync(cls as EventType.EnterQueue).Coroutine();
        }

        private async ETTask RunAsync(EventType.EnterQueue args)
        {
            UI ui = await UIHelper.Create(args.ZoneScene, UIType.UIQueue);
            ui.GetComponent<UIQueueComponent>().ShowQueueNumber(args.Value);
        }

    }
}
