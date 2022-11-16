using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class UnitInfoComponentAwakeSystem : AwakeSystem<UnitInfoComponent>
    {
        public override void Awake(UnitInfoComponent self)
        {
            self.ZhaohuanIds.Clear();
        }
    }

    [ObjectSystem]
    public class UnitInfoComponentDestroySystem : DestroySystem<UnitInfoComponent>
    {
        public override void Destroy(UnitInfoComponent self)
        {
            self.ZhaohuanIds.Clear();
        }
    }

    public static class UnitInfoComponentSystem
    {
    }
}
