using System;

namespace ET
{
    [ObjectSystem]
    public class BuffDispatcherComponentAwakeSystem : AwakeSystem<BuffDispatcherComponent>
    {
        public override void Awake(BuffDispatcherComponent self)
        {
            BuffDispatcherComponent.Instance = self;
            self.Load();
        }
    }


    [ObjectSystem]
    public class BuffDispatcherComponentLoadSystem : LoadSystem<BuffDispatcherComponent>
    {
        public override void Load(BuffDispatcherComponent self)
        {
            self.Load();
        }
    }

    [ObjectSystem]
    public class BuffDispatcherComponentDestroySystem : DestroySystem<BuffDispatcherComponent>
    {
        public override void Destroy(BuffDispatcherComponent self)
        {
            BuffDispatcherComponent.Instance = null;
        }
    }

    public static class BuffDispatcherComponentSystem
    {
        public static void Load(this BuffDispatcherComponent self)
        {
            self.BuffTypes.Clear();

            var types = Game.EventSystem.GetTypes(typeof(BuffHandlerAttribute));
            foreach (Type type in types)
            {
                if (self.BuffTypes.ContainsKey(type.Name))
                {
                    self.BuffTypes.Remove(type.Name);
                }
                self.BuffTypes.Add(type.Name, type);
            }
        }
    }
}
