using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.SkillIndicator)]
    public class SkillIndicatorTimer : ATimer<SkillIndicatorComponent>
    {
        public override void Run(SkillIndicatorComponent self)
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

    [ObjectSystem]
    public class SkillIndicatorComponentAwakeSystem : AwakeSystem<SkillIndicatorComponent>
    {
        public override void Awake(SkillIndicatorComponent self)
        {
            self.SkillIndicator = null;
            self.ShowEffect = false;
            self.MainCamera = self.ZoneScene().GetComponent<UIComponent>().MainCamera;

        }
    }

    [ObjectSystem]
    public class SkillIndicatorComponentDestroySystem : DestroySystem<SkillIndicatorComponent>
    {
        public override void Destroy(SkillIndicatorComponent self)
        {
            self.ClearnsShow();
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class SkillIndicatorComponentSystem
    {
    
        public static void OnChangeSonScene(this SkillIndicatorComponent self)
        {
            self.RecoveryEffect();
        }

        public static void OnSelfDead(this SkillIndicatorComponent self)
        {
            self.RecoveryEffect();
        }

        public static string GetIndicatorPath(this SkillIndicatorComponent self, SkillZhishiType skillZhishiType)
        {
            string effect = "";
            switch (skillZhishiType)
            {
                case SkillZhishiType.CommonAttack:
                    effect = "SkillZhishi/Skill_CommonAttack";
                    break;
                case SkillZhishiType.Position:
                    effect = "SkillZhishi/Skill_Position";
                    break;
                case SkillZhishiType.Line:
                    effect = "SkillZhishi/Skill_Dir";
                    break;
                case SkillZhishiType.Angle60:
                    effect = "SkillZhishi/Skill_Area_60";
                    break;
                case SkillZhishiType.Angle120:
                    effect = "SkillZhishi/Skill_Area_120";
                    break;
            }

            return ABPathHelper.GetEffetPath(effect);
        }

        /// <summary>
        /// 显示技能指示器
        /// </summary>
        public static  void  ShowSkillIndicator(this SkillIndicatorComponent self, SkillConfig skillconfig)
        {
            //0  立即释放,自身中心点
            //1  技能指示器
            //2  立即释放,目标中心点
            self.ShowEffect = true;
            self.mSkillConfig = skillconfig;
            self.SkillRangeSize = (float)self.mSkillConfig.SkillRangeSize;
            SkillIndicatorItem skillIndicatorItem = new SkillIndicatorItem();
            skillIndicatorItem.SkillZhishiType = (SkillZhishiType)skillconfig.SkillZhishiType;
            skillIndicatorItem.EffectPath = self.GetIndicatorPath(skillIndicatorItem.SkillZhishiType);
            skillIndicatorItem.GameObject = GameObjectPoolComponent.Instance.GetExternal(skillIndicatorItem.EffectPath);
            skillIndicatorItem.GameObject.SetActive(true);
            UICommonHelper.SetParent(skillIndicatorItem.GameObject, GlobalComponent.Instance.Unit.gameObject);
            self.SkillIndicator = skillIndicatorItem;
            self.InitZhishiEffect(skillIndicatorItem);
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.SkillIndicator, self);
            }
        }

        /// <summary>
        /// 普攻预警
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask ShowCommonAttackZhishi(this SkillIndicatorComponent self)
        {
            self.RecoveryEffect();
            self.ShowEffect = true;
            SkillIndicatorItem skillIndicatorItem = new SkillIndicatorItem();
            skillIndicatorItem.SkillZhishiType = SkillZhishiType.CommonAttack;
            skillIndicatorItem.EffectPath = self.GetIndicatorPath(skillIndicatorItem.SkillZhishiType);
            skillIndicatorItem.GameObject = await GameObjectPoolComponent.Instance.GetExternalAsync(skillIndicatorItem.EffectPath);
            skillIndicatorItem.GameObject.SetActive(true);
            UICommonHelper.SetParent(skillIndicatorItem.GameObject, GlobalComponent.Instance.Unit.gameObject);
            self.SkillIndicator = skillIndicatorItem;
            self.InitZhishiEffect(skillIndicatorItem);
            if (!self.ShowEffect)
            {
                self.RecoveryEffect();
                return;
            }
            if (self.Timer == 0)
            {
                self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.SkillIndicator, self);
            }
        }

        private static void InitZhishiEffect(this SkillIndicatorComponent self, SkillIndicatorItem skillIndicatorItem)
        {
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;

            switch (skillIndicatorItem.SkillZhishiType)
            {
                case SkillZhishiType.CommonAttack:
                    float[] scaleList = new float[3] { 6f, 12f, 6f };
                    //法师加长
                    if (occ == 2) {
                        scaleList = new float[3] { 12f, 12f, 12f };
                    }
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area").transform.localScale = Vector3.one * scaleList[occ-1];
                    break;
                case SkillZhishiType.Position:
                    float outerRadius = (float)self.mSkillConfig.SkillRangeSize * 2f;   //半径 * 2                                                              
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_InnerArea").transform.localScale = Vector3.one * (float)self.mSkillConfig.DamgeRange[0] * 2f;
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area").transform.localScale = new Vector3(outerRadius, 1f, outerRadius);
                    break;
                case SkillZhishiType.Line:
                    break;
                case SkillZhishiType.Angle60:
                    break;
                case SkillZhishiType.Angle120:
                    break;
            }
        }

        public static void HideCommonAttackZhishi(this SkillIndicatorComponent self)
        {
            self.RecoveryEffect();
        }

        //鼠标按下
        public static void OnMouseDown(this SkillIndicatorComponent self, long targetId = 0)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Unit target = unit.GetParent<UnitComponent>().Get(targetId);
            self.StartIndicator = Vector2.zero;
            Vector2 vector2 = Vector2.zero;
            if (target != null)
            {
                float distance = PositionHelper.Distance2D(target.Position, unit.Position);
                float rate = distance / self.SkillRangeSize;
                rate = Mathf.Min(rate, 1f);
                Vector3 direction = target.Position - unit.Position;
                vector2.x = direction.x;
                vector2.y = direction.z;
                vector2 = vector2.normalized * 80 * rate;
                self.OnMouseDrag(vector2);
            }
            else
            {
                float roationy = Mathf.FloorToInt(unit.Rotation.eulerAngles.y);
                Quaternion rotation = Quaternion.Euler(0, roationy, 0);
                Vector3 postition = rotation * Vector3.forward * 0.01f;
                vector2.x = postition.x;
                vector2.y = postition.z;
                self.OnMouseDrag(vector2);
            }
        }

        //鼠标拖拽
        public static void OnMouseDrag(this SkillIndicatorComponent self,Vector2 indicator)
        {
            SkillIndicatorItem skillIndicatorItem = self.SkillIndicator;
            if (skillIndicatorItem == null)
            {
                return;
            }

            self.StartIndicator += indicator;
            //只有 IfSelectSkillRange 为1 可以选中释放距离
            if (skillIndicatorItem.SkillZhishiType == SkillZhishiType.Position)
            {
                float rate = 1;
                rate = self.StartIndicator.magnitude / 80;
                rate = (rate > 1) ? 1 : rate;
                skillIndicatorItem.AttackDistance = Mathf.FloorToInt(self.SkillRangeSize * rate);
                skillIndicatorItem.TargetAngle = 90 - (int)(Mathf.Atan2(self.StartIndicator.y, self.StartIndicator.x) * Mathf.Rad2Deg);
            }
            else
            {
                skillIndicatorItem.AttackDistance = 0;
                skillIndicatorItem.TargetAngle = 90 - (int)(Mathf.Atan2(self.StartIndicator.y, self.StartIndicator.x) * Mathf.Rad2Deg);
            }

            skillIndicatorItem.TargetAngle += (int)self.MainCamera.transform.eulerAngles.y;
        }

        public static float GetIndicatorDistance(this SkillIndicatorComponent self)
        {
            return self.SkillIndicator!=null ? self.SkillIndicator.AttackDistance:0;
        }

        public static int GetIndicatorAngle(this SkillIndicatorComponent self)
        {
            if (self.SkillIndicator != null)
            {
                return self.SkillIndicator.TargetAngle;
            }
            else
            {
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                if (unit != null)
                {
                    return (int)unit.Rotation.eulerAngles.y;
                }
                else
                {
                    return 0;
                }
            }
        }

        public static void ClearnsShow(this SkillIndicatorComponent self)
        {
            self.RecoveryEffect( );
        }

        public static void RecoveryEffect(this SkillIndicatorComponent self)
        {
            self.ShowEffect = false;
            SkillIndicatorItem skillIndicatorItem = self.SkillIndicator;
            if (skillIndicatorItem == null || skillIndicatorItem.GameObject == null)
            {
                return;
            }
            skillIndicatorItem.GameObject.SetActive(false);
            GameObjectPoolComponent.Instance.InternalPut(skillIndicatorItem.EffectPath, skillIndicatorItem.GameObject);
            self.StartIndicator = Vector2.zero;
            self.SkillIndicator = null;
        }

        public static void OnUpdate(this SkillIndicatorComponent self)
        {
            if (self.SkillIndicator == null)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Quaternion rotation;
            SkillIndicatorItem skillIndicatorItem = self.SkillIndicator;

            skillIndicatorItem.GameObject.transform.localPosition = unit.Position;
            switch (skillIndicatorItem.SkillZhishiType)
            {
                case SkillZhishiType.CommonAttack:
                    break;
                case SkillZhishiType.Position:
                    rotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_InnerArea").transform.localPosition = rotation * Vector3.forward * skillIndicatorItem.AttackDistance;
                    break;
                case SkillZhishiType.Line:
                    rotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    Vector3 skillTarget = rotation * Vector3.forward + unit.Position;
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Dir").transform.LookAt(skillTarget);
                    break;
                case SkillZhishiType.Angle60:
                    rotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    skillTarget = rotation * Vector3.forward + unit.Position;
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area_60").transform.LookAt(skillTarget);
                    break;
                case SkillZhishiType.Angle120:
                    rotation = Quaternion.Euler(0, skillIndicatorItem.TargetAngle, 0);
                    skillTarget = rotation * Vector3.forward + unit.Position;
                    skillIndicatorItem.GameObject.Get<GameObject>("Skill_Area_120").transform.LookAt(skillTarget);
                    break;
            }
        }

    }
}
