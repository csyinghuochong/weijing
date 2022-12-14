using System;
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
            self.AIConfigId = aiConfigId;
            self.AISkillIDList.Clear();
            self.BeAttackList.Clear();
            self.TargetPoint.Clear();
            self.TargetZhuiJi = Vector3.zero;

            int time = 1000;
            int sceneType = self.DomainScene().GetComponent<MapComponent>().SceneTypeEnum;
            switch (sceneType)
            {
                case SceneTypeEnum.PetDungeon:
                case SceneTypeEnum.PetTianTi:
                    time = 200;
                    break;
                default:
                    time = 1000;
                    break;
            }
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(time, TimerType.AITimer, self);
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

            Unit unit = self.GetParent<Unit>();
            var oneAI = AIConfigCategory.Instance.AIConfigs[self.AIConfigId];
            foreach (AIConfig aiConfig in oneAI.Values)
            {
                //if (unit.ConfigId == 70002003)  //????????????
                //{
                //    ;
                //}
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
                self.Cancel(); // ?????????????????????
                ETCancellationToken cancellationToken = new ETCancellationToken();
                self.CancellationToken = cancellationToken;
                self.Current = aiConfig.Id;
                //NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
                //numericComponent.ApplyValue(NumericType.Now_AI, aiConfig.Id);
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
            //?????????AI?????????????????????
            self.ActRange = 100;        //5-10  ??????????????????????????????,?????????????????????
            self.ChaseRange = 100;    //???????????????????????????
            self.ActDistance = (float)MonsterCof.ActDistance;  //2    ???????????????
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        //?????????
        public static void InitMonster(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //?????????AI?????????????????????
            self.ActRange = (float)MonsterCof.ActRange + self.GetParent<Unit>().GetComponent<NumericComponent>().GetAsInt(NumericType.Now_MonsterDis);        //5-10  ??????????????????????????????,?????????????????????
            self.ChaseRange = (float)MonsterCof.ChaseRange;    //???????????????????????????
            self.ActDistance = (float)MonsterCof.ActDistance;  //2    ???????????????
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

            try
            {
                string[] targetpoints = MonsterCof.AIParameter.Split('@');
                for (int i = 0; i < targetpoints.Length; i++)
                {
                    string[] potioninfo = targetpoints[i].Split(';');
                    float x = float.Parse(potioninfo[0]);
                    float y = float.Parse(potioninfo[1]);
                    float z = float.Parse(potioninfo[2]);
                    self.TargetPoint.Add(new Vector3(x, y, z));
                }
            }
            catch (Exception ex)
            {
                Log.Debug(ex.ToString());
            }
        }

        public static void InitTempFollower(this AIComponent self, int monsteConfigId)
        {
            MonsterConfig MonsterCof = MonsterConfigCategory.Instance.Get(monsteConfigId);
            //?????????AI?????????????????????
            self.ActRange = (float)MonsterCof.ActRange;        //5-10  ??????????????????????????????,?????????????????????
            self.ChaseRange = (float)MonsterCof.ChaseRange;    //???????????????????????????
            self.ActDistance = (float)MonsterCof.ActDistance;  //2    ???????????????
            self.AISkillIDList.Add(MonsterCof.ActSkillID);
        }

        //???????????????????????????AI
        public static void InitTianTiPet(this AIComponent self, int petConfigId)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(petConfigId);
            self.ChaseRange = 100;
            self.ActRange = 100;
            self.ActDistance = 2;
            self.AISkillIDList.Add(petConfig.ActSkillID);
            self.StopAI = false;
        }

        /// <summary>
        /// ???????????????????????????Unit. ???Unit??????
        /// </summary>
        /// <param name="self"></param>
        /// <param name="petConfigId"></param>
        /// 
        public static void InitPet(this AIComponent self, RolePetInfo rolePetInfo)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            self.ChaseRange = 100;
            self.ActRange = petConfig.ChaseRange;

            int haveMagic = 0;
            for (int i = 0; i < rolePetInfo.PetSkill.Count; i++)
            {
                if (ComHelp.PetMagicSkill.Contains(rolePetInfo.PetSkill[i]))
                {
                    haveMagic = rolePetInfo.PetSkill[i];
                    break;
                }
            }
            if (haveMagic > 0)
            {
                self.AISkillIDList.Add(haveMagic);
                self.ActDistance = 6;
            }
            else
            {
                self.AISkillIDList.Add(petConfig.ActSkillID);
                self.ActDistance = (float)petConfig.ActDistance;
            }
        }

        public static int GetActSkillId(this AIComponent self)
        {
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

        public static void BeAttacking(this AIComponent self, Unit attack)
        {
            if (!self.BeAttackList.Contains(attack.Id))
            {
                self.BeAttackList.Add(attack.Id);
            }

            //0.1???????????????????????????
            float moveActPro = 0.1f;
            moveActPro = moveActPro * (1+ attack.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_ChaoFengPro));
            if (moveActPro <= 0)
            {
                return;
            }
            long serverTime = TimeHelper.ServerNow();
            if (serverTime - self.LastChangeTime < 6000)
            {
                return;
            }
            self.LastChangeTime = serverTime;

            if (self.GetParent<Unit>().Type == UnitType.Pet)
            {
                bool gaiLv = RandomHelper.RandFloat01() < 0.1f;
                if (self.TargetID == 0 && gaiLv)
                {
                    self.ChangeTarget(attack.Id);
                }
            }
            else
            {
                //??????
                //1.???????????????????????????????????????
                //2.????????????????????????????????????????????????????????????10 %???????????????5 %??????
                //3.???????????????????????????6??????????????????????????????
                float gaiLv = RandomHelper.RandFloat01();
                if (self.ActDistance <= 4 && gaiLv <= 0.1f)
                {
                    self.ChangeTarget(attack.Id);
                }
                if (self.ActDistance > 4 && gaiLv <= 0.05f)
                {
                    self.ChangeTarget(attack.Id);
                }
            }
        }

        public static void ChangeTarget(this AIComponent self, long targetId)
        {
            if (!self.IsRetreat)
            {
                self.TargetID = targetId;
            }
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