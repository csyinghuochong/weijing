using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class FsmDispatchComponentAwakeSystem : AwakeSystem<FsmDispatchComponent>
    {
        public override void Awake(FsmDispatchComponent self)
        {
            FsmDispatchComponent.Instance = self;
            self.Load();
        }

    }

    [ObjectSystem]
    public class FsmDispatcherComponentLoadSystem : LoadSystem<FsmDispatchComponent>
    {
        public override void Load(FsmDispatchComponent self)
        {
            self.Load();
        }
    }

    [ObjectSystem]
    public class FsmDispatcherComponentDestroySystem : DestroySystem<FsmDispatchComponent>
    {
        public override void Destroy(FsmDispatchComponent self)
        {
            self.FsmTypes.Clear();
            FsmDispatchComponent.Instance = null;
        }
    }

    public static class FsmDispatchComponentSystem
    {
        public static void Load(this FsmDispatchComponent self)
        {
            self.FsmTypes.Clear();

            var types = Game.EventSystem.GetTypes(typeof(FsmHandlerAttribute));
            foreach (Type type in types)
            {
                self.FsmTypes.Add(GetFsmType(type.Name), type);
            }
        }

        public static int GetFsmType(string name)
        {
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            keyValuePairs.Add("FsmNullState", FsmStateEnum.FsmNullState);
            keyValuePairs.Add("FsmIdleState", FsmStateEnum.FsmIdleState);
            keyValuePairs.Add("FsmRunState", FsmStateEnum.FsmRunState);
            keyValuePairs.Add("FsmDeathState", FsmStateEnum.FsmDeathState);
            keyValuePairs.Add("FsmSkillState", FsmStateEnum.FsmSkillState);
            keyValuePairs.Add("FsmComboState", FsmStateEnum.FsmComboState);
            keyValuePairs.Add("FsmShiQuItem", FsmStateEnum.FsmShiQuItem);
            keyValuePairs.Add("FsmNpcSpeak", FsmStateEnum.FsmNpcSpeak);
            keyValuePairs.Add("FsmSinging", FsmStateEnum.FsmSinging);
            keyValuePairs.Add("FsmOpenBox", FsmStateEnum.FsmOpenBox);
            keyValuePairs.Add("FsmHui", FsmStateEnum.FsmHui);

            if (keyValuePairs.ContainsKey(name))
            {
                return keyValuePairs[name];
            }
            else
            {
                Log.Error($"未注册:  {name}");
                return FsmStateEnum.FsmNullState;
            }
        }

        public static AFsmHandler SkillFactory(this FsmDispatchComponent self, int aFsmStateBase)
        {
            return Activator.CreateInstance(self.FsmTypes[aFsmStateBase]) as AFsmHandler;
        }

    }

}
