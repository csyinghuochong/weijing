namespace ET
{

    [MessageHandler]
    public class M2C_ChengJiuActiveHandler : AMHandler<M2C_ChengJiuActiveMessage>
    {
        protected override void Run(Session session, M2C_ChengJiuActiveMessage message)
        {
            EventType.ChengJiuActive.Instance.m2C_ChengJiu = message;
            EventType.ChengJiuActive.Instance.ZoneScene = session.ZoneScene();    
            EventSystem.Instance.PublishClass(EventType.ChengJiuActive.Instance);
        }
    }
}
