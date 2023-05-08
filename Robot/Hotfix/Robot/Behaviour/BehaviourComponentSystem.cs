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
            self.MessageValue = string.Empty;

            //1   任务机器人
            //2   组队副本机器人
            //3   战场机器人
            //4   世界boos机器人
            //5   角斗场机器人
            //6   solo场机器人
            RobotConfig robotConfig = RobotConfigCategory.Instance.Get(robotId);
            self.RobotConfig = robotConfig;
            switch (robotConfig.Behaviour)
            {
                case 1:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Stroll, Value = "Behaviour_Stroll" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Task, Value = "Behaviour_Task" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    self.NewBehaviour = BehaviourType.Behaviour_Stroll;
                    break;
                case 2:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Stroll, Value = "Behaviour_Stroll" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_TeamDungeon, Value = "Behaviour_TeamDungeon" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Target, Value = "Behaviour_Target" });
                    self.NewBehaviour = BehaviourType.Behaviour_TeamDungeon;
                    break;
                case 3:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Battle, Value = "Behaviour_Battle" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Target, Value = "Behaviour_Target" });
                    self.NewBehaviour = BehaviourType.Behaviour_Battle;
                    break;
                case 4:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_YeWaiBoss, Value = "Behaviour_YeWaiBoss" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Target, Value = "Behaviour_Target" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    self.NewBehaviour = BehaviourType.Behaviour_YeWaiBoss;
                    break;
                case 5:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Arena, Value = "Behaviour_Arena" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Target, Value = "Behaviour_Target" });
                    self.NewBehaviour = BehaviourType.Behaviour_Arena;
                    break;
                case 6:
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Solo, Value = "Behaviour_Solo" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_ZhuiJi, Value = "Behaviour_ZhuiJi" });
                    self.Behaviours.Add(new KeyValuePair() { KeyId = BehaviourType.Behaviour_Attack, Value = "Behaviour_Attack" });
                    self.NewBehaviour = BehaviourType.Behaviour_Solo;
                    break;
                default:
                    break;
            }

            if (!ComHelp.IfNull(robotConfig.AIParameter))
            {
                string[] positionList = robotConfig.AIParameter.Split('@');
                string[] positions = positionList[RandomHelper.RandomNumber(0, positionList.Length)].Split(';');
                float range  = float.Parse(positions[3]);
                self.TargetPosition = new UnityEngine.Vector3(
                    float.Parse(positions[0]) + RandomHelper.RandomNumberFloat(-1 * range, range), 
                    float.Parse(positions[1]),
                    float.Parse(positions[2]) + RandomHelper.RandomNumberFloat(-1 * range, range));
            }

            self.ActDistance = self.ZoneScene().GetComponent<AttackComponent>().AttackDistance;
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(500, TimerType.BehaviourTimer, self);
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
        public static int GetBehaviour(this BehaviourComponent self)
        {
            return self.RobotConfig != null ? self.RobotConfig.Behaviour : 0;
        }

        public static void ChangeBehaviour(this BehaviourComponent self, int behaviour)
        {
            for (int i = 0; i < self.Behaviours.Count; i++)
            {
                if (self.Behaviours[i].KeyId == behaviour)
                {
                    Log.Debug($"ChangeBehaviour: {self.Behaviours[i].Value}");
                }
            }
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

        public static void Start(this BehaviourComponent self)
        {
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(500, TimerType.BehaviourTimer, self);
        }

        public static void Stop(this BehaviourComponent self)
        {
            self.TargetID = 0;
            self.NewBehaviour = 0;
            self.Cancel();
        }

        private static void Cancel(this BehaviourComponent self)
        {
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
            self.Current = 0;
        }

        public static void Exit(this BehaviourComponent self, string btype)
        {
            Scene zoneScene = self.ZoneScene();
            zoneScene.GetParent<RobotManagerComponent>().RemoveRobot(zoneScene, btype).Coroutine();
        }
    }
}
