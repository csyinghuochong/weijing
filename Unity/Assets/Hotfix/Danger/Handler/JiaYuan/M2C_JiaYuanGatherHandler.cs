namespace ET
{
    [MessageHandler]
    public class M2C_JiaYuanGatherHandler : AMHandler<M2C_JiaYuanGatherMessage>
    {
        protected override void Run(Session session, M2C_JiaYuanGatherMessage message)
        {
            JiaYuanComponent jiaYuanComponent = session.ZoneScene().GetComponent<JiaYuanComponent>();
            jiaYuanComponent.UpdatePlant(message.PlantItem);
            EventType.JiaYuanUpdate.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.JiaYuanUpdate.Instance);
        }
    }
}
