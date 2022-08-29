using System;

namespace ET
{

    [ObjectSystem]
    public class BehaviourDispatcherComponentAwakeSystem : AwakeSystem<BehaviourDispatcherComponent>
    {
        public override void Awake(BehaviourDispatcherComponent self)
        {
            BehaviourDispatcherComponent.Instance = self;
            self.Load();
        }
    }

    [ObjectSystem]
    public class BehaviourDispatcherComponentLoadSystem : LoadSystem<BehaviourDispatcherComponent>
    {
        public override void Load(BehaviourDispatcherComponent self)
        {
            self.Load();
        }
    }

    [ObjectSystem]
    public class BehaviourDispatcherComponentDestroySystem : DestroySystem<BehaviourDispatcherComponent>
    {
        public override void Destroy(BehaviourDispatcherComponent self)
        {
            self.AIHandlers.Clear();
            AIDispatcherComponent.Instance = null;
        }
    }

    public static class BehaviourDispatcherComponentSystem
    {

        public static void Load(this BehaviourDispatcherComponent self)
        {
            self.AIHandlers.Clear();

            var types = Game.EventSystem.GetTypes(typeof(BehaviourHandlerAttribute));
            foreach (Type type in types)
            {
                BehaviourHandler aaiHandler = Activator.CreateInstance(type) as BehaviourHandler;
                if (aaiHandler == null)
                {
                    Log.Error($"robot behaviour is not AAIHandler: {type.Name}");
                    continue;
                }
                self.AIHandlers.Add(type.Name, aaiHandler);
            }
        }
    }
}
