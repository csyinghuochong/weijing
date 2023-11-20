namespace ET
{

    [MessageHandler]
    public class M2C_PetListMessageHandler : AMHandler<M2C_PetListMessage>
    {
        protected override void Run(Session session, M2C_PetListMessage message)
        {
            PetComponent petComponent = session.ZoneScene().GetComponent<PetComponent>();
            petComponent.RolePetInfos = message.PetList;


        }
    }
}
