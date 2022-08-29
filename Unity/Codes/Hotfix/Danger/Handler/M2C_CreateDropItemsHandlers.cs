using ET;
using UnityEngine;

namespace ET
{

    [MessageHandler]
    public class M2C_CreateDropItemsHandlers : AMHandler<M2C_CreateDropItems>
    {
        protected override  void Run(Session session, M2C_CreateDropItems message)
        {
            for(int i = 0; i < message.Drops.Count; i++)
            {
                UnitFactory.CreateDropItem(session.ZoneScene().CurrentScene(), message.Drops[i]);
            }
        }
    }
}
