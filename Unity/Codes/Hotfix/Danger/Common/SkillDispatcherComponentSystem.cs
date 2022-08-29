using System;

namespace ET
{

    [ObjectSystem]
    public class SkillDispatcherComponentAwakeSystem : AwakeSystem<SkillDispatcherComponent>
    {
        public override void Awake(SkillDispatcherComponent self)
        {
            SkillDispatcherComponent.Instance = self;
            self.Load();
        }
    }


    [ObjectSystem]
    public class SkillDispatcherComponentLoadSystem : LoadSystem<SkillDispatcherComponent>
    {
        public override void Load(SkillDispatcherComponent self)
        {
            self.Load();
        }
    }

    [ObjectSystem]
    public class SkillDispatcherComponentDestroySystem : DestroySystem<SkillDispatcherComponent>
    {
        public override void Destroy(SkillDispatcherComponent self)
        {
            SkillDispatcherComponent.Instance = null;
        }
    }

    public static class SkillDispatcherComponentSystem
    {
        public static void Load(this SkillDispatcherComponent self)
        {
            self.SkillTypes.Clear();

            var types = Game.EventSystem.GetTypes(typeof(SkillHandlerAttribute));
            foreach (Type type in types)
            {
                self.SkillTypes.Add(type.Name, type);
            }
        }
    }
}
