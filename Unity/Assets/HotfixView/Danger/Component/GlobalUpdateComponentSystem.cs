using System;

namespace ET
{

    [Timer(TimerType.GlobalUpdate)]
    public class GlobalUpdateTimer : ATimer<GlobalUpdateComponent>
    {
        public override void Run(GlobalUpdateComponent self)
        {
            try
            {
                self.OnGlobalUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class GlobalUpdateComponentAwakeSystem : AwakeSystem<GlobalUpdateComponent>
    {
        public override void Awake(GlobalUpdateComponent self)
        {
            self.FrameTimer = TimerComponent.Instance.NewFrameTimer(TimerType.GlobalUpdate, self);
        }
    }

    public class GlobalUpdateComponentDestroySystem : DestroySystem<GlobalUpdateComponent>
    {
        public override void Destroy(GlobalUpdateComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.FrameTimer);
        }
    }

    public static class GlobalUpdateComponentSystem
    {
        public static void OnGlobalUpdate(this GlobalUpdateComponent self)
        {

        }
    }
}
