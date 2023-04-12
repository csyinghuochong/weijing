using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMakeComponent : Entity, IAwake
    {

    }


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