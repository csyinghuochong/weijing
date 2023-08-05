namespace ET
{
    [MessageHandler]
    public class M2C_FashionUpdateHandler : AMHandler<M2C_FashionUpdate>
    {
        protected override void Run(Session session, M2C_FashionUpdate message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.UnitID);
            if (unit == null)
            {
                return;
            }

            if (unit.MainHero)
            {
                session.ZoneScene().GetComponent<BagComponent>().FashionEquipList = message.FashionEquipList;   
            }
            unit.GetComponent<UnitInfoComponent>().FashionEquipList = message.FashionEquipList;

            EventType.FashionUpdate.Instance.Unit = unit;
            EventSystem.Instance.PublishClass(EventType.FashionUpdate.Instance);
        }
    }
}