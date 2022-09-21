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
                EventType.NumericChangeEvent args = new EventType.NumericChangeEvent();
                self.Parent.GetComponent<HeroDataComponent>().OnDead(args);
                //self.Parent.GetParent<UnitComponent>().Remove(self.Parent.Id);
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
