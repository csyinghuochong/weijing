using System;
using System.Collections.Generic;

namespace ET
{
    [Timer(TimerType.AITimer)]
    public class AITimer : ATimer<AIComponent>
    {
        public override void Run(AIComponent self)
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
    public class AIComponentAwakeSystem: AwakeSystem<AIComponent, int>
    {
        public override void Awake(AIComponent self, int aiConfigId)
        {
            self.TargetID = 0;
            self.StopAI = false;
            self.IsRetreat = false;
            self.LastBeAttack = 0;
            self.BeAttackTime = 0;
            self.AIConfigId = aiConfigId;
            self.AISkillIDList.Clear();
            self.BeAttackList.Clear();
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.AITimer, self);
        }
    }

    [ObjectSystem]
    public class AIComponentDestroySystem: DestroySystem<AIComponent>
    {
        public override void Destroy(AIComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
            self.Current = 0;
        }
    }

    public static class AIComponentSystem
    {
        public static void Check(this AIComponent self)
        {
            if (self.Parent == null)
            {
                TimerComponent.Instance.Remove(ref self.Timer);
                return;
            }
            if (self.StopAI)
            {
                return;
            }

            self.RigidityTime -= 1000;
            UnitInfoComponent unitInfoComponent = self.Parent.GetComponent<UnitInfoComponent>();
            if (unitInfoComponent.Type == UnitType.Pet)
            {
                self.CheckHuiXue();
            }
            if (self.Parent.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                return;
            }

            var oneAI = AIConfigCategory.Instance.AIConfigs[self.AIConfigId];
            foreach (AIConfig aiConfig in oneAI.Values)
            {

                AIDispatcherComponent.Instance.AIHandlers.TryGetValue(aiConfig.Name, out AAIHandler aaiHandler);

                if (aaiHandler == null)
                {
                    Log.Error($"not found aihandler: {aiConfig.Name}");
                    continue;
                }

                bool ret = aaiHandler.Check(self, aiConfig);
                if (ret != true)
                {
                    continue;
                }

                if (self.Current == aiConfig.Id)
                {
                    break;
                }

                self.Cancel(); // 取消之前的行为
                ETCancellationToken cancellationToken = new ETCancellationToken();
                self.CancellationToken = cancellationToken;
                self.Current = aiConfig.Id;

                aaiHandler.Execute(self, aiConfig, cancellationToken).Coroutine();
                return;
            }
        }

        private static void Cancel(this AIComponent self)
        {
            self.CancellationToken?.Cancel();
            self.Current = 0;
            self.CancellationToken = null;
        }

        public static void InitPetFubenMonster(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //初始化AI组件的一些东西
            self.ActInterValTime = MonsterCof.ActInterValTime;
            self.ActRange = 100;        //5-10  与主角距离小于此值时,向主角发动追击
            self.ChaseRange = 100;    //超出会返回到出生点
            self.PatrolRange = MonsterCof.PatrolRange;  //巡逻范围
            self.ActDistance = MonsterCof.ActDistance;  //2    小于转攻击
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        //初始化
        public static void InitMonster(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //初始化AI组件的一些东西
            self.ActInterValTime = MonsterCof.ActInterValTime;

            self.ActRange = MonsterCof.ActRange;        //5-10  与主角距离小于此值时,向主角发动追击
            self.ChaseRange = MonsterCof.ChaseRange;    //超出会返回到出生点
            self.PatrolRange = MonsterCof.PatrolRange;  //巡逻范围
            self.ActDistance = MonsterCof.ActDistance;  //2    小于转攻击
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        public static void InitTeampPet(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //初始化AI组件的一些东西
            self.ActInterValTime = MonsterCof.ActInterValTime;

            self.ActRange = MonsterCof.ActRange;        //5-10  与主角距离小于此值时,向主角发动追击
            self.ChaseRange = MonsterCof.ChaseRange;    //超出会返回到出生点
            self.PatrolRange = MonsterCof.PatrolRange;  //巡逻范围
            self.ActDistance = MonsterCof.ActDistance;  //2    小于转攻击
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        //宠物天梯，需要新的AI
        public static void InitPetFuben(this AIComponent self, int petConfigId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petConfigId);
            self.ChaseRange = 100;
            self.ActRange = 100;
            self.ActDistance = 2;
            self.ActInterValTime = 500L;
            self.AISkillIDList.Add(petConfig.ActSkillID);

            self.StopAI = false;
        }

        /// <summary>
        /// 相关数据也可以传入Unit. 从Unit获取
        /// </summary>
        /// <param name="self"></param>
        /// <param name="petConfigId"></param>
        public static void InitPet(this AIComponent self, int petConfigId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petConfigId);
            self.ChaseRange = 100;
            self.ActRange = 5;
            self.ActDistance = 2;
            self.ActInterValTime = 500L;
            self.AISkillIDList.Add(petConfig.ActSkillID);
        }

        public static void CheckHuiXue(this AIComponent self)
        {
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            if (numericComponent.GetAsLong((int)NumericType.Now_Hp) >= numericComponent.GetAsLong((int)NumericType.Now_MaxHp))
                return;

            self.GetParent<Unit>().GetComponent<NumericComponent>().ApplyChange(null, NumericType.Now_Hp,
                (long)(numericComponent.GetAsLong((int)NumericType.Now_MaxHp) * 0.1f), 0, true);
        }

        public static long GetActInterValTime(this AIComponent self)
        {
            return self.ActInterValTime;
        }

        public static int GetActSkillId(this AIComponent self)        {
            return self.AISkillIDList[RandomHelper.RandomNumber(0, self.AISkillIDList.Count)];
        }

#if SERVER
        public static bool CanChange(this AIComponent self)
        {
            if (self.RigidityTime > 0)
            {
                return false;
            }
            if (self.GetParent<Unit>().GetComponent<StateComponent>().StateTypeGet(StateTypeData.Singing))
            {
                return false;
            }
            return true;
        }

        public static void BeAttack(this AIComponent self, Unit attack)
        {
            if (self.LastBeAttack == attack.Id)
            {
                self.BeAttackTime++;
            }
            else
            {
                self.LastBeAttack = attack.Id;
                self.BeAttackTime = 1;
            }
            if (self.BeAttackTime >= 3 || self.TargetID == 0)
            {
                self.TargetID = attack.Id;
            }
            if (!self.BeAttackList.Contains(attack.Id))
            {
                self.BeAttackList.Add(attack.Id);
            }
        }

        public static void Stop(this AIComponent self)
        {
            self.StopAI = true;
            self.TargetID = 0;
        }
#endif

    }
} 