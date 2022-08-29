
namespace ET
{
    [MessageHandler]
    public class M2C_FubenSettlementHandler : AMHandler<M2C_FubenSettlement>
    {
        protected override  void Run(Session session, M2C_FubenSettlement message)
        {
            session.ZoneScene().GetComponent<CellDungeonComponent>().OnFubenSettlement();
            EventType.FubenSettlement.Instance.Scene = session.DomainScene();
            EventType.FubenSettlement.Instance.m2C_FubenSettlement = message;
            EventSystem.Instance.PublishClass(EventType.FubenSettlement.Instance);
        }
    }
}
