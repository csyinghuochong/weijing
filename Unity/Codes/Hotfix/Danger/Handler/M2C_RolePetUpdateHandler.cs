namespace ET
{

    [MessageHandler]
    public class M2C_RolePetUpdateHandler : AMHandler<M2C_RolePetUpdate>
    {
        protected override void  Run(Session session, M2C_RolePetUpdate message)
        {
            session.ZoneScene().GetComponent<PetComponent>().OnRecvRolePetUpdate(message);
        }
    }
}
