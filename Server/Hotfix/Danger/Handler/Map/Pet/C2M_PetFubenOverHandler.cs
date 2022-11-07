using System;
using System.Collections.Generic;

namespace ET
{
    [ActorMessageHandler]
    public class C2M_PetFubenOverHandler : AMActorLocationHandler<Unit, C2M_PetFubenOverRequest>
    {
        protected override async ETTask Run(Unit unit, C2M_PetFubenOverRequest request)
        {
            await ETTask.CompletedTask;
            Scene domainScene = unit.DomainScene();
            MapComponent mapComponent = domainScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetDungeon)
            {
                domainScene.GetComponent<PetFubenSceneComponent>().OnGameOver(CombatResultEnum.Fail);
            }
            if (mapComponent.SceneTypeEnum == SceneTypeEnum.PetTianTi)
            {
                domainScene.GetComponent<PetTianTiComponent>().OnGameOver(CombatResultEnum.Fail);
            }
        }
    }
}
