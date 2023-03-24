namespace ET
{
    [MessageHandler]
    public class M2C_JiaYuanPlantHandler : AMHandler<M2C_JiaYuanPlantMessage>
    {

        protected override void Run(Session session, M2C_JiaYuanPlantMessage message)
        {
            JiaYuanComponent jiaYuanComponent = session.ZoneScene().GetComponent<JiaYuanComponent>();
            jiaYuanComponent.UpdatePlant(message.PlantItem);
            EventType.JiaYuanUpdate.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.JiaYuanUpdate.Instance);
        }
    }
}
