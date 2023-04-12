using System;
using System.Collections.Generic;

namespace ET
{

    public class EffectDispatcherComponentAwakeSystem : AwakeSystem<EffectDispatcherComponent>
    {
        public override void Awake(EffectDispatcherComponent self)
        {
            EffectDispatcherComponent.Instance = self;
            self.Load();
        }
    }


    public class EffectDispatcherComponentLoadSystem : LoadSystem<EffectDispatcherComponent>
    {
        public override void Load(EffectDispatcherComponent self)
        {
            self.Load();
        }
    }

    public class EffectDispatcherComponentDestroySystem : DestroySystem<EffectDispatcherComponent>
    {
        public override void Destroy(EffectDispatcherComponent self)
        {
            self.EffectHandlers.Clear();
            EffectDispatcherComponent.Instance = null;
        }
    }

    public static class EffectDispatcherComponentSystem
    {

        public static void Load(this EffectDispatcherComponent self)
        {
            self.EffectTypes.Clear();

            var types = Game.EventSystem.GetTypes(typeof(EffectHandlerAttribute));
            foreach (Type type in types)
            {
                if (self.EffectTypes.ContainsKey(type.Name))
                {
                    self.EffectTypes.Remove(type.Name);
                }
                self.EffectTypes.Add(type.Name, type);
            }
        }
    }
}
