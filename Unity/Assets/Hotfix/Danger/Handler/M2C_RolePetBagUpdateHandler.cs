using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    public class M2C_RolePetBagUpdateHandler : AMHandler<M2C_RolePetBagUpdate>
    {
        protected override void Run(Session session, M2C_RolePetBagUpdate message)
        {
            session.ZoneScene().GetComponent<PetComponent>().RolePetBag = message.RolePetBag;   

            //抛出事件。 刷新UI
        }
    }
}
