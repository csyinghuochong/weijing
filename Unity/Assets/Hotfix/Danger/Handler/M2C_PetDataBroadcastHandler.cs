namespace ET
{

    [MessageHandler]
    public class M2C_PetDataBroadcastHandler : AMHandler<M2C_PetDataBroadcast>
    {
        protected override void Run(Session session, M2C_PetDataBroadcast message)
        {
            Unit unit = session.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(message.PetId);
            if (unit == null)
            {
                return;
            }
            
            switch (message.UpdateType)
            {
                case (int)UserDataType.Name:
                    unit.GetComponent<UnitInfoComponent>().StallName = message.UpdateTypeValue;
                    break;
            }
            EventType.RolePetUpdate.Instance.ZoneScene = session.ZoneScene();
            EventType.RolePetUpdate.Instance.UpdateType = message.UpdateType;
            EventType.RolePetUpdate.Instance.PetId = message.PetId;
            EventType.RolePetUpdate.Instance.UpdateValue = message.UpdateTypeValue;
            EventSystem.Instance.PublishClass(EventType.RolePetUpdate.Instance);
        }

    }
}
