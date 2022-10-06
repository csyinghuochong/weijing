namespace ET
{
    [Event]
    public class LoadingFinishEvent_RemoveLoadingUI : AEventClass<EventType.LoadingFinish>
    {
        protected override  void Run(object cls)
        {
            //EventType.LoadingFinish args = cls as EventType.LoadingFinish;
            //UIHelper.Remove(args.Scene, UIType.UILoading).Coroutine();
        }
    }
}
