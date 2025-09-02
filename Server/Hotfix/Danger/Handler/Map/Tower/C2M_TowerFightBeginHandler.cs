using System;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TowerFightBeginHandler : AMActorLocationRpcHandler<Unit, C2M_TowerFightBeginRequest, M2C_TowerFightBeginResponse>
    {
        protected override async ETTask Run(Unit unit, C2M_TowerFightBeginRequest request, M2C_TowerFightBeginResponse response, Action reply)
        {
            switch (request.SceneType)
            {
                case SceneTypeEnum.SeasonTower:
                    unit.DomainScene().GetComponent<SeasonTowerComponent>()?.BeginTower();
                    break;
                case SceneTypeEnum.Tower:
                    unit.DomainScene().GetComponent<TowerComponent>()?.BeginTower();
                    break;
                default:
                    Log.Error("C2M_TowerFightBeginRequest request.SceneType=null");
                    break;
            }
          
            reply();
            await ETTask.CompletedTask;
        }
    }
}
