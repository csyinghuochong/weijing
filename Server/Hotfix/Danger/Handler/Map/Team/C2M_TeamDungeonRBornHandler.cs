using System;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    [ActorMessageHandler]
    public class C2M_TeamDungeonRBornHandler : AMActorLocationHandler<Unit, C2M_TeamDungeonRBornRequest>
    {
        protected override async ETTask Run(Unit unit, C2M_TeamDungeonRBornRequest request)
        {
            MapComponent mapComponent = unit.DomainScene().GetComponent<MapComponent>();
            SceneConfig sceneConfig = SceneConfigCategory.Instance.Get(mapComponent.SceneId);
            unit.SetBornPosition(new Vector3(sceneConfig.InitPos[0]*0.01f, sceneConfig.InitPos[0] * 0.01f, sceneConfig.InitPos[0] * 0.01f));
            unit.GetComponent<HeroDataComponent>().OnRevive();
            await ETTask.CompletedTask;
        }
    }
}
