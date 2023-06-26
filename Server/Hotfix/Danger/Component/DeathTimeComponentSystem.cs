using System;

namespace ET
{

    [Timer(TimerType.DeathTimer)]
    public class DeathTimer : ATimer<DeathTimeComponent>
    {
        public override void Run(DeathTimeComponent self)
        {
            try
            {
                if (self.Parent.IsDisposed)
                {
                    return;
                }

                Unit unit = self.GetParent<Unit>(); 
                EventType.NumericChangeEvent.Instance.Parent = unit;
                unit.GetComponent<HeroDataComponent>().OnKillZhaoHuan(EventType.NumericChangeEvent.Instance);
                unit.GetComponent<HeroDataComponent>().OnDead(EventType.NumericChangeEvent.Instance);
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class DeathTimeComponentAwakeSystem : AwakeSystem<DeathTimeComponent, long>
    {
        public override void Awake(DeathTimeComponent self, long aliveTime)
        {
            self.Timer = TimerComponent.Instance.NewOnceTimer(TimeHelper.ServerNow() + aliveTime, TimerType.DeathTimer, self);
            self.StartTime = TimeHelper.ServerNow();
        }
    }

    [ObjectSystem]
    public class DeathTimeComponentDestroySystem : DestroySystem<DeathTimeComponent>
    {
        public override void Destroy(DeathTimeComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class DeathTimeComponentSystem
    {
    }
}
