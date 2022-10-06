

namespace ET
{

    [MessageHandler]
    public class M2C_CreateRolePetHandler : AMHandler<M2C_CreateRolePet>
    {
        protected override void Run(Session session, M2C_CreateRolePet message)
        {
            foreach (RolePetInfo rolepetinfo in message.RolePets)
            {
                UnitFactory.CreateRolePet(session.ZoneScene().CurrentScene(), rolepetinfo);
            }
        }

    }

}
