using System;
using System.Linq;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_RandomTowerBeginHandler : AMActorLocationRpcHandler<Unit, C2M_RandomTowerBeginRequest, M2C_RandomTowerBeginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_RandomTowerBeginRequest request, M2C_RandomTowerBeginResponse response, Action reply)
        {
            int randomTowerid = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.RandomTowerID);
            if (randomTowerid == 0)
            {
                List<RandomTowerConfig> randomTowerConfigs = RandomTowerConfigCategory.Instance.GetAll().Values.ToList();
                randomTowerid = randomTowerConfigs[0].Id;
            }
            else
            {
                randomTowerid += request.RandomNumber;
            }
            if (!RandomTowerConfigCategory.Instance.Contain(randomTowerid))
            {
                reply();
                return;
            }
            unit.DomainScene().GetComponent<RandomTowerComponent>().TowerId = randomTowerid;
            RandomTowerConfig randowTowerConfig = RandomTowerConfigCategory.Instance.Get(randomTowerid);
            FubenHelp.CreateMonsterList(unit.DomainScene(), randowTowerConfig.MonsterSet, FubenDifficulty.None);

            reply();
            await ETTask.CompletedTask;
        }
    }
}