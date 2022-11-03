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
    public class BehaviourComponentAwakeSystem : AwakeSystem<BehaviourComponent,int>
    {
        public override void Awake(BehaviourComponent self, int robotId)
        {
            self.TargetID = 0;
            self.Behaviours.Clear();

            //1   任务机器人
            //2   组队副本机器人
            //3   战场机器人
            RobotConfig robotConfig = RobotConfigCategory.Instance.Get(robotId);
            switch (robotConfig.Behaviour)
            {
                case 1:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Stroll, Value = "Behaviour_Stroll" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Task, Value = "Behaviour_Task" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    break;
                case 2:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Stroll, Value = "Behaviour_Stroll" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_TeamDungeon, Value = "Behaviour_TeamDungeon" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    break;
                case 3:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Stroll, Value = "Behaviour_Stroll" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Battle, Value = "Behaviour_Battle" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    break;
            }
            self.NewBehaviour = BehaviourType.Behaviour_Stroll;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(10000, TimerType.BehaviourTimer, self);
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
            self.Current = 0;
        }
    }

    public static class BehaviourComponentSystem
    {
        public static void ChangeBehaviour(this BehaviourComponent self, int behaviour)
        {
            Log.ILog.Debug($"ChangeBehaviour: {behaviour}");
            self.NewBehaviour = behaviour;
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
                BehaviourDispatcherComponent.Instance.AIHandlers.TryGetValue(self.Behaviours[i].Value, out BehaviourHandler aaiHandler);
                if (aaiHandler == null)
                {
                    Log.Error($"not found aihandler: {self.Behaviours[i].Value}");
                    continue;
                }

                bool ret = aaiHandler.Check(self, null);
                if (!ret)   //不满足条件
                {
                    continue;
                }

                if (self.Current == aaiHandler.BehaviourId())
                {
                    break;
                }
                self.NewBehaviour = 0;
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
            self.CancellationToken = null;
            self.Current = 0;
        }
    }
}
