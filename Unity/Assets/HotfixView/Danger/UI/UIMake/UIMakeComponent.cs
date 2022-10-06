using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMakeComponent : Entity, IAwake
    {

    }


    [ObjectSystem]
    public class UIMakeComponentAwakeSystem : AwakeSystem<UIMakeComponent>
    {
        public override void Awake(UIMakeComponent self)
        {

        }
    }

    public static class UIMakeComponentSystem
    {
    }
}