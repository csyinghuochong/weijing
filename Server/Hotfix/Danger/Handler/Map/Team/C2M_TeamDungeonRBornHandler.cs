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
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.Born_X, (long)(sceneConfig.InitPos[0] * 100));
            numericComponent.ApplyValue(NumericType.Born_Y, (long)(sceneConfig.InitPos[1] * 100));
            numericComponent.ApplyValue(NumericType.Born_Z, (long)(sceneConfig.InitPos[2] * 100));
            unit.GetComponent<HeroDataComponent>().OnRevive();
            await ETTask.CompletedTask;
        }
    }
}
