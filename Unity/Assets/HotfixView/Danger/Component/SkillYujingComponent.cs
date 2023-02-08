using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    [Timer(TimerType.YujingTimer)]
    public class SkillYujingTimer : ATimer<SkillYujingComponent>
    {
        public override void Run(SkillYujingComponent self)
        {
            try
            {
                self.OnUpdate();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class SkillYujingComponent : Entity, IAwake, IDestroy
    {
        public SkillConfig mSkillConfig;
        public float SkillRangeSize;
        public List<SkillIndicatorItem> SkillIndicatorList = new List<SkillIndicatorItem>();
        public long Timer;
    }

    [ObjectSystem]
    public class SkillYujingComponentAwakeSystem : AwakeSystem<SkillYujingComponent>
    {
        public override void Awake(SkillYujingComponent self)
        {
            self.Timer = 0;
            self.mSkillConfig = null;
            self.SkillIndicatorList.Clear();
        }
    }

    [ObjectSystem]
    public class SkillYujingComponentDestroySystem : DestroySystem<SkillYujingComponent>
    {
        public override void Destroy(SkillYujingComponent self)
        {
            for (int i = self.SkillIndicatorList.Count - 1; i >= 0; i--)
            {
                SkillIndicatorItem skillIndicatorItem = self.SkillIndicatorList[i];
                self.RecoveryEffect(skillIndicatorItem);
                self.SkillIndicatorList.RemoveAt(i);
            }

            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class SkillYujingComponentSystem
    {

        public static string GetIndicatorPath(this SkillYujingComponent self, int skillZhishiType)
        {
            string effect = "";
            switch (skillZhishiType)
            {
                case SkillZhishiType.Position:
                    effect = "SkillZhishi/Yujing_Position";
                    break;
                case SkillZhishiType.Line:
                    effect = "SkillZhishi/Yujing_Dir";
                    break;
                case SkillZhishiType.Angle60:
                    effect = "SkillZhishi/Yujing_Area_60";
                    break;
                case SkillZhishiType.Angle120:
                    effect = "SkillZhishi/Yujing_Area_120";
                    break;
            }
            return ABPathHelper.GetEffetPath(effect);
        }

        //怪物技能预警
        public static  void ShowMonsterSkillYujin(this SkillYujingComponent self, SkillInfo skillcmd, double delayTime, bool enemyColor)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            self.mSkillConfig = skillConfig;
            SkillIndicatorItem skillIndicatorItem = new SkillIndicatorItem();
            skillIndicatorItem.SkillInfo = skillcmd;
            skillIndicatorItem.SkillZhishiType = skillConfig.SkillZhishiType;
            skillIndicatorItem.EffectPath = self.GetIndicatorPath(skillIndicatorItem.SkillZhishiType);
            skillIndicatorItem.InstanceId = IdGenerater.Instance.GenerateInstanceId();
            skillIndicatorItem.TargetAngle = skillcmd.TargetAngle;
            skillIndicatorItem.PassTime = 0;
            skillIndicatorItem.LiveTime = (float)delayTime;
            skillIndicatorItem.EnemyColor = enemyColor;
            self.SkillIndicatorList.Add(skillIndicatorItem);
            GameObjectPoolComponent.Instance.AddLoadQueue(skillIndicatorItem.EffectPath, skillIndicatorItem.InstanceId, self.OnLoadGameObject);
        }

        public static void OnLoadGameObject(this SkillYujingComponent self, GameObject gameObject, long formId)
        {
            if (self.IsDisposed)
            {
                GameObject.DestroyImmediate(gameObject);
                return;
            }
            SkillIndicatorItem skillIndicatorItem = null;
            for (int i = 0; i < self.SkillIndicatorList.Count; i++)
            {
                if (self.SkillIndicatorList[i].InstanceId == formId)
                {
                    skillIndicatorItem = self.SkillIndicatorList[i];
                    break;
                }
            }
            if (skillIndicatorItem == null)
            {
                GameObject.DestroyImmediate(gameObject);
                return;
            }

            SkillInfo skillcmd = skillIndicatorItem.SkillInfo;
            skillIndicatorItem.GameObject = gameObject;
            skillIndicatorItem.GameObject.transform.localScale = Vector3.one * 0.1f;

            Color colorred = Color.red;
            Color colorgreen = Color.green;

            GameObject Quad_1 = null;
            GameObject Quad_2 = null;

            switch (skillIndicatorItem.SkillZhishiType)
            {
                case SkillZhishiType.Position:
                    //effect = "SkillZhishi/Yujing_Position";
                    Quad_1 = gameObject.transform.Find("Skill_InnerArea/Position/Quad").gameObject;
                    Quad_2 = gameObject.transform.Find("Skill_OuterArea/Position/Quad").gameObject;

                    //Quad_1.GetComponent<MeshRenderer>().material.color = skillIndicatorItem.EnemyColor ? Color.red : Color.green;
                    //Quad_2.GetComponent<MeshRenderer>().material.color = skillIndicatorItem.EnemyColor ? Color.red : Color.green;
                    break;
                case SkillZhishiType.Line:
                    //effect = "SkillZhishi/Yujing_Dir";
                    Quad_1 = gameObject.transform.Find("Skill_Dir/scale/Quad1").gameObject;
                    Quad_2 = gameObject.transform.Find("Skill_Dir/scale/Quad2").gameObject;
                    break;
                case SkillZhishiType.Angle60:
                    //effect = "SkillZhishi/Yujing_Area_60";
                    Quad_1 = gameObject.transform.Find("Skill_Area/Position/Quad").gameObject;
                    Quad_2 = gameObject.transform.Find("Skill_Area_60/Position/scale/Quad").gameObject;
                    break;
                case SkillZhishiType.Angle120:
                    //effect = "SkillZhishi/Yujing_Area_120";
                    Quad_1 = gameObject.transform.Find("Skill_Area/Position/Quad").gameObject;
                    Quad_2 = gameObject.transform.Find("Skill_Area_120/Position/scale/Quad").gameObject;
                    break;
            }

            Quad_1.GetComponent<MeshRenderer>().material.SetColor("_TintColor", skillIndicatorItem.EnemyColor ? colorred : colorgreen);
            Quad_2.GetComponent<MeshRenderer>().material.SetColor("_TintColor", skillIndicatorItem.EnemyColor ? colorred : colorgreen);

            skillIndicatorItem.GameObject.SetActive(true);
            UICommonHelper.SetParent(skillIndicatorItem.GameObject, GlobalComponent.Instance.Unit.gameObject);
            skillIndicatorItem.GameObject.transform.position = new Vector3(skillcmd.PosX, skillcmd.PosY, skillcmd.PosZ);
            self.InitZhishiEffect(skillIndicatorItem);
            self.AddTimer();
        }

        public static void AddTimer(this SkillYujingComponent self)
        {
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.YujingTimer, self);
            }
        }

        private static void InitZhishiEffect(this SkillYujingComponent self, SkillIndicatorItem skillIndicatorItem)
        {
            switch (skillIndicatorItem.SkillZhishiType)
            {
                case SkillZhishiType.Position:
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_OuterArea").transform.localScale = Vector3.one * (float)self.mSkillConfig.DamgeRange[0] * 2f;
                    break;
                case SkillZhishiType.Line:
                    float outerRadius = (float)self.mSkillConfig.SkillRangeSize * 2f;   //半径 * 2                                                              
                                                                                        //skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area").transform.localScale = new Vector3(outerRadius, 1f, outerRadius);
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Dir").transform.localRotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Dir").transform.localScale = Vector3.one * (float)self.mSkillConfig.DamgeRange[0] * 2f;
                    break;
                case SkillZhishiType.Angle60:
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area_60").transform.localRotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    break;
                case SkillZhishiType.Angle120:
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area_120").transform.localRotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    break;
            }
        }

        public static void RecoveryEffect(this SkillYujingComponent self, SkillIndicatorItem skillIndicatorItem)
        {
            skillIndicatorItem.GameObject.SetActive(false);
            GameObjectPoolComponent.Instance.RecoverGameObject(skillIndicatorItem.EffectPath, skillIndicatorItem.GameObject);
            skillIndicatorItem = null;
        }

        public static void OnUpdate(this SkillYujingComponent self)
        {
            for (int i = self.SkillIndicatorList.Count - 1; i >= 0; i--)
            {
                SkillIndicatorItem skillIndicatorItem = self.SkillIndicatorList[i];
                skillIndicatorItem.PassTime += Time.deltaTime;
                if (skillIndicatorItem.GameObject == null)
                {
                    continue;
                }
                switch (skillIndicatorItem.SkillZhishiType)
                {
                    case SkillZhishiType.Position:
                        skillIndicatorItem.GameObject.Get<GameObject>("Skill_InnerArea").transform.localScale = Vector3.one * (skillIndicatorItem.PassTime / skillIndicatorItem.LiveTime) * (float)self.mSkillConfig.DamgeRange[0] * 2f;
                        break;
                    default:
                        //skillIndicatorItem.GameObject.transform.localScale = Vector3.one * (skillIndicatorItem.PassTime / skillIndicatorItem.LiveTime) * 2f;
                        break;
                }

                if (skillIndicatorItem.LiveTime != -1 && skillIndicatorItem.PassTime >= skillIndicatorItem.LiveTime)
                {
                    self.RecoveryEffect(skillIndicatorItem);
                    self.SkillIndicatorList.RemoveAt(i);
                }
            }

            if (self.SkillIndicatorList.Count == 0)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
            }
        }
    }

}


