namespace ET
{

    [MessageHandler]
    public class M2C_PetRankSettlementHandler : AMHandler<M2C_PetRankSettlement>
    {
        protected override  void Run(Session session, M2C_PetRankSettlement message)
        {
            EventType.PetRankSettlement.Instance.Scene = session.DomainScene();
            EventType.PetRankSettlement.Instance.m2C_PetRankSettlement = message;
            EventSystem.Instance.PublishClass(EventType.PetRankSettlement.Instance);
        }
    }
}
