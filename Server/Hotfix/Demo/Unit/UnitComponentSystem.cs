using System.Collections.Generic;
using System.Linq;

namespace ET
{

    [ObjectSystem]
    public class UnitComponentAwakeSystem1 : AwakeSystem<UnitComponent>
    {
        public override void Awake(UnitComponent self)
        {
            self.Units.Clear();
        }
    }

    [ObjectSystem]
    public class UnitComponentDestroySystem : DestroySystem<UnitComponent>
    {
        public override void Destroy(UnitComponent self)
        {
            self.Units.Clear();
        }
    }

    public static class UnitComponentSystem
    {
        public static void Add(this UnitComponent self, Unit unit)
        {
            self.Units.Add(unit);
        }

        public static Unit Get(this UnitComponent self, long id)
        {
            Unit unit = self.GetChild<Unit>(id);
            return unit;
        }

        public static void Remove(this UnitComponent self, long id)
        {
            Unit unit = self.GetChild<Unit>(id);
            self.Units.Remove(unit);
            unit?.Dispose();
        }

        public static List<Unit> GetAll(this UnitComponent self)
        {
            return self.Units;
            //return self.Children.Values.ToArray();
        }
    }
}