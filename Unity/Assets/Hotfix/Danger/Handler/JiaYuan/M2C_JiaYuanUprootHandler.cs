namespace ET
{
    [MessageHandler]
    public class M2C_JiaYuanUprootHandler : AMHandler<M2C_JiaYuanUprootMessage>
    {
        protected override void Run(Session session, M2C_JiaYuanUprootMessage message)
        {
            JiaYuanComponent jiaYuanComponent = session.ZoneScene().GetComponent<JiaYuanComponent>();
            jiaYuanComponent.UprootPlant(message.CellIndex);
            EventType.JiaYuanUproot.Instance.ZoneScene = session.ZoneScene();
            EventType.JiaYuanUproot.Instance.CellIndex = message.CellIndex;
            EventSystem.Instance.PublishClass(EventType.JiaYuanUproot.Instance);
        }
    }
}
