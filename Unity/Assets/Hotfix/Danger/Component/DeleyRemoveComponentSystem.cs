using System;

namespace ET
{

    [Timer(TimerType.DelayRemoveTimer)]
    public class DelayRemoveTimer : ATimer<DeleyRemoveComponent>
    {
        public override void Run(DeleyRemoveComponent self)
        {
            try
            {
                if (self.Parent == null || self.Parent.IsDisposed)
                {
                    return;
                }

                Unit unit = self.GetParent<Unit>();
                unit.GetParent<UnitComponent>().Remove(unit.Id);
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class DeathTimeComponentAwakeSystem : AwakeSystem<DeleyRemoveComponent, long>
    {
        public override void Awake(DeleyRemoveComponent self, long aliveTime)
        {
            self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + aliveTime, TimerType.DelayRemoveTimer, self);
            self.StartTime = TimeHelper.ServerNow();
        }
    }

    [ObjectSystem]
    public class DeathTimeComponentDestroySystem : DestroySystem<DeleyRemoveComponent>
    {
        public override void Destroy(DeleyRemoveComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class DeathTimeComponentSystem
    {
    }
}
