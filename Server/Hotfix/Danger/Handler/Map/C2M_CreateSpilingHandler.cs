
using UnityEngine;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_CreateSpilingHandler : AMActorLocationHandler<Unit, C2M_CreateSpiling>
    {
        protected override async ETTask Run(Unit entity, C2M_CreateSpiling message)
        {
            Unit unit = UnitFactory.CreateMonster(entity.DomainScene(), Vector3.zero, FubenDifficulty.None, 70001960, new CreateMonsterInfo());

            // 广播创建的木桩unit
            //M2C_CreateSpilings createSpilings = new M2C_CreateSpilings();
            //SpilingInfo spilingInfo = UnitHelper.CreateSpilingInfo(unit);
            //createSpilings.Spilings.Add(spilingInfo);  
            //MessageHelper.Broadcast(unit, createSpilings);

            await ETTask.CompletedTask;
        }
    }
}
