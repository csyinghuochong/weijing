using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    [Timer(TimerType.ReviveTimer)]
    public class ReviveTimer : ATimer<ReviveTimeComponent>
    {
        public override void Run(ReviveTimeComponent self)
        {
            try
            {
                if (self.Parent.IsDisposed)
                {
                    return;
                }
                self.Parent.GetComponent<HeroDataComponent>().OnRevive();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class ReviveTimeComponentAwakeSystem : AwakeSystem<ReviveTimeComponent, long>
    {
        public override void Awake(ReviveTimeComponent self, long aliveTime)
        {
            self.Timer = TimerComponent.Instance.NewOnceTimer(aliveTime, TimerType.ReviveTimer, self);
        }
    }

    [ObjectSystem]
    public class ReviveTimeComponentDestroySystem : DestroySystem<ReviveTimeComponent>
    {
        public override void Destroy(ReviveTimeComponent self)
        {
            TimerComponent.Instance.Remove(ref self.Timer);
        }
    }

    public static class ReviveTimeComponentSystem
    {
    }
}
