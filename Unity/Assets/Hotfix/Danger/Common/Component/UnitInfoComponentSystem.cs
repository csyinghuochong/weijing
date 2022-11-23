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

        public static int GetZhaoHuanNumber(this UnitInfoComponent self)
        {
            int number = 0;
            for (int i = self.ZhaohuanIds.Count - 1; i >= 0; i--)
            {
                Unit zhaohuan = self.DomainScene().GetComponent<UnitComponent>().Get(self.ZhaohuanIds[i]);
                if (zhaohuan == null)
                {
                    continue;
                }
                number++;
            }
            return number;
        }

    }
}
