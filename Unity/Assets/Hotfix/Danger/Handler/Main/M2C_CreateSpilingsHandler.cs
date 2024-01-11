using UnityEngine;

namespace ET
{

    [MessageHandler]
    public class M2C_CreateSpilingsHandler : AMHandler<M2C_CreateSpilings>
    {
        protected override void  Run(Session session, M2C_CreateSpilings message)
        {
            foreach (SpilingInfo spilings in message.Spilings)
            {
                UnitFactory.CreateSpiling(session.ZoneScene().CurrentScene(), spilings);
            }
        }
    }

}
