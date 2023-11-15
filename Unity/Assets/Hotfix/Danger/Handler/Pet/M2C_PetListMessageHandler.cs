namespace ET
{

    [MessageHandler]
    public class M2C_PetListMessageHandler : AMHandler<M2C_PetListMessage>
    {
        protected override void Run(Session session, M2C_PetListMessage message)
        {
            session.ZoneScene().GetComponent<PetComponent>().RolePetInfos = message.PetList;
        }
    }
}
