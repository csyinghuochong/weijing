
namespace ET
{

    [MessageHandler]
    public class M2C_SyncMiJingDamageHandler : AMHandler<M2C_SyncMiJingDamage>
    {
        protected override void Run(Session session, M2C_SyncMiJingDamage message)
        {
            EventType.SyncMiJingDamage.Instance.M2C_SyncMiJingDamage = message;
            EventType.SyncMiJingDamage.Instance.ZoneScene = session.ZoneScene();
            EventSystem.Instance.PublishClass(EventType.SyncMiJingDamage.Instance);
        }
    }
}
