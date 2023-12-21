using System.Collections.Generic;

namespace ET
{

    [MessageHandler]
    public class M2C_RolePetBagUpdateHandler : AMHandler<M2C_RolePetBagUpdate>
    {
        protected override void Run(Session session, M2C_RolePetBagUpdate message)
        {
            session.ZoneScene().GetComponent<PetComponent>().RolePetBag = message.RolePetBag;
            List<KeyValuePair> oldPetSkin = session.ZoneScene().GetComponent<PetComponent>().GetPetSkinCopy();
            //抛出事件。 刷新UI
            EventType.RolePetAdd.Instance.ZoneScene = session.ZoneScene();
            EventType.RolePetAdd.Instance.OldPetSkin = oldPetSkin;
            EventType.RolePetAdd.Instance.RolePetInfo = message.RolePetBag[message.RolePetBag.Count - 1];
            EventSystem.Instance.PublishClass(EventType.RolePetAdd.Instance);
        }
    }
}
