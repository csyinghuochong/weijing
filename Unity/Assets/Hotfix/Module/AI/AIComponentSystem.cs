using System;
using System.Collections.Generic;
using UnityEngine;

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
            self.TargetIndex = -1;
            self.AIConfigId = aiConfigId;
            self.AISkillIDList.Clear();
            self.BeAttackList.Clear();
            self.TargetPoint.Clear();
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
            self.ActRange = 100;        //5-10  与主角距离小于此值时,向主角发动追击
            self.ChaseRange = 100;    //超出会返回到出生点
            self.ActDistance = (float)MonsterCof.ActDistance;  //2    小于转攻击
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        //初始化
        public static void InitMonster(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //初始化AI组件的一些东西
            self.ActRange = (float)MonsterCof.ActRange + self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MonsterDis);        //5-10  与主角距离小于此值时,向主角发动追击
            self.ChaseRange = (float)MonsterCof.ChaseRange;    //超出会返回到出生点
            self.ActDistance = (float)MonsterCof.ActDistance;  //2    小于转攻击
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
            self.TargetPoint.Clear();
            self.InitTargetPoints(MonsterCof);
        }

        public static void InitTargetPoints(this AIComponent self, MonsterConfig MonsterCof)
        {
            if (MonsterCof.AIParameter == null || MonsterCof.AIParameter.Length == 0)
            {
                return;
            }
            string[] targetpoints = MonsterCof.AIParameter.Split('@');
            for (int i = 0; i < targetpoints.Length; i++)
            {
                string[] potioninfo = targetpoints[i].Split(';');
                float x = int.Parse(potioninfo[0]) * 0.01f;
                float y = int.Parse(potioninfo[1]) * 0.01f;
                float z = int.Parse(potioninfo[2]) * 0.01f;
                aiComponent.TargetPoint.Add(new Vector3(x, y, z));
            }
            aiComponent.TargetIndex = 0;
        }

        public static void InitTeampPet(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //初始化AI组件的一些东西
            self.ActRange = (float)MonsterCof.ActRange;        //5-10  与主角距离小于此值时,向主角发动追击
            self.ChaseRange = (float)MonsterCof.ChaseRange;    //超出会返回到出生点
            self.ActDistance = (float)MonsterCof.ActDistance;  //2    小于转攻击
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        //宠物天梯，需要新的AI
        public static void InitPetFubenPet(this AIComponent self, int petConfigId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petConfigId);
            self.ChaseRange = 100;
            self.ActRange = 100;
            self.ActDistance = 2;
            self.AISkillIDList.Add(petConfig.ActSkillID);
            self.StopAI = false;
        }

        /// <summary>
        /// 相关数据也可以传入Unit. 从Unit获取
        /// </summary>
        /// <param name="self"></param>
        /// <param name="petConfigId"></param>
        /// 
        public static void InitPet(this AIComponent self, int petConfigId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petConfigId);
            self.ChaseRange = 100;
            self.ActRange = petConfig.ChaseRange;
            self.ActDistance = 2;
            self.AISkillIDList.Add(petConfig.ActSkillID);
        }

        public static int GetActSkillId(this AIComponent self)        {
            return self.AISkillIDList[RandomHelper.RandomNumber(0, self.AISkillIDList.Count)];
        }

#if SERVER
        public static bool IsCanZhuiJi(this AIComponent self)
        {
            StateComponent stateComponent = self.GetParent<Unit>().GetComponent<StateComponent>();
            if (!stateComponent.CanMove())
            {
                return false;
            }
            if (stateComponent.StateTypeGet(StateTypeEnum.Singing))
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
            if ((self.BeAttackTime >= 3 || self.TargetID == 0) &&!self.IsRetreat)
            {
                self.TargetID = attack.Id;
            }
            if (!self.BeAttackList.Contains(attack.Id))
            {
                self.BeAttackList.Add(attack.Id);
            }
        }

        public static void OnChaoFeng(this AIComponent self)
        { 
            
        }

        public static void Begin(this AIComponent self)
        {
            self.StopAI = false;
        }

        public static void Stop(this AIComponent self)
        {
            self.StopAI = true;
            self.TargetID = 0;
        }
#endif

    }
} 