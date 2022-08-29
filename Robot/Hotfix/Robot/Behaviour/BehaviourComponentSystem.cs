using System;

namespace ET
{
    [Timer(TimerType.BehaviourTimer)]
    public class BehaviourTimer : ATimer<BehaviourComponent>
    {
        public override void Run(BehaviourComponent self)
        {
            try
            {
                self.Check();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class BehaviourComponentAwakeSystem : AwakeSystem<BehaviourComponent>
    {
        public override void Awake(BehaviourComponent self)
        {
            self.TargetID = 0;
            self.Behaviours.Clear();
            self.NewBehaviour = BehaviourType.Behaviour_Task;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(10000, TimerType.BehaviourTimer, self);
            self.Behaviours.Add(BehaviourType.Behaviour_Task);
            self.Behaviours.Add(BehaviourType.Behaviour_Stroll);
            self.Behaviours.Add(BehaviourType.Behaviour_ZhuiJi);
            self.Behaviours.Add(BehaviourType.Behaviour_Attack);
            //self.Behaviours.Add(BehaviourType.Behaviour_TeamDungeon);
        }
    }

    [ObjectSystem]
    public class BehaviourComponentDestroySystem : DestroySystem<BehaviourComponent>
    {
        public override void Destroy(BehaviourComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
            self.Current = null;
        }
    }

    public static class BehaviourComponentSystem
    {
        public static void ChangeBehaviour(this BehaviourComponent self, string behaviour)
        {
            Log.ILog.Debug($"ChangeBehaviour: {behaviour}");
            self.NewBehaviour = behaviour;
        }

        public static bool RandomBehaviour(this BehaviourComponent self, string behaviour)
        {
            string target = self.Behaviours[RandomHelper.RandomNumber(0, self.Behaviours.Count)];
            if (target == behaviour)
            {
                return false;
            }
            self.ChangeBehaviour(target);
            return true;
        }

        public static void Check(this BehaviourComponent self)
        {
            if (self.Parent == null)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
                return;
            }

            for (int i = 0; i < self.Behaviours.Count; i++)
            {
                BehaviourDispatcherComponent.Instance.AIHandlers.TryGetValue(self.Behaviours[i], out BehaviourHandler aaiHandler);

                if (aaiHandler == null)
                {
                    Log.Error($"not found aihandler: {self.Behaviours[i]}");
                    continue;
                }

                int ret = aaiHandler.Check(self, null);
                if (ret != 0)   //不满足条件
                {
                    continue;
                }

                if (self.Current == aaiHandler.BehaviourId())
                {
                    break;
                }
                self.NewBehaviour = "";
                self.Cancel(); // 取消之前的行为
                ETCancellationToken cancellationToken = new ETCancellationToken();
                self.CancellationToken = cancellationToken;
                self.Current = aaiHandler.BehaviourId();

                aaiHandler.Execute(self, null, cancellationToken).Coroutine();
                return;
            }
        }

        private static void Cancel(this BehaviourComponent self)
        {
            self.CancellationToken?.Cancel();
            self.Current = null;
            self.CancellationToken = null;
        }
    }
}
