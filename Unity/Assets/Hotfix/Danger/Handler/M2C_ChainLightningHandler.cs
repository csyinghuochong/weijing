namespace ET
{

    [MessageHandler]
    public class M2C_ChainLightningHandler : AMHandler<M2C_ChainLightning>
    {
        protected override void Run(Session session, M2C_ChainLightning message)
        {
            EventType.SkillChainLight.Instance.M2C_ChainLightning = message;
            EventType.SkillChainLight.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.SkillChainLight.Instance);
        }
    }
}
