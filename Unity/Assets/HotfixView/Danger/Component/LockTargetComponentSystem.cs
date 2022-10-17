using UnityEngine;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ET
{

    [Timer(TimerType.LockTarget)]
    public class LockTargetComponentTimer : ATimer<LockTargetComponent>
    {
        public override void Run(LockTargetComponent self)
        {
            try
            {
                self.OnMainHeroPosition();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    [ObjectSystem]
    public class LockTargetComponentAwakeSystem : AwakeSystem<LockTargetComponent>
    {
        public override void Awake(LockTargetComponent self)
        {
            //MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            //if (mapComponent.SceneTypeEnum >= (int)SceneTypeEnum.FubenScene)
            //{
            //    self.FrameTimer = TimerComponent.Instance.NewRepeatedTimer(1000, TimerType.LockTarget, self);
            //}

            DataUpdateComponent.Instance.AddListener(DataType.MainHeroPosition, self);
        }
    }

    [ObjectSystem]
    public class LockTargetComponentDestroySystem : DestroySystem<LockTargetComponent>
    {
        public override void Destroy(LockTargetComponent self)
        {
            if (self.LockUnitEffect != null)
            {
                GameObject.Destroy(self.LockUnitEffect);
                self.LockUnitEffect = null;
            }

            DataUpdateComponent.Instance.RemoveListener(DataType.MainHeroPosition, self);
        }
    }

    public static class LockTargetComponentSystem
    {
        public static void OnMainHeroPosition(this LockTargetComponent self)
        {
            Unit haveBoss = null;
            List<Unit> allUnit = self.DomainScene().GetComponent<UnitComponent>().GetAll();
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            for (int i = 0; i < allUnit.Count; i++)
            {
                Unit unit = allUnit[i] as Unit;
                UnitInfoComponent unitInfoComponent = unit.GetComponent<UnitInfoComponent>();
                if (unitInfoComponent.Type != UnitType.Monster)
                {
                    continue;
                }
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitInfoComponent.UnitCondigID);
                if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss && PositionHelper.Distance2D(unit, main) < 5f)
                {
                    haveBoss = unit;
                    break;
                }
            }
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain?.GetComponent<UIMainComponent>().UIMainHpBar.ShowBossHPBar(haveBoss);
        }

        public static void OnChangeSonScene(this LockTargetComponent self)
        {
            if (self.LockUnitEffect != null)
            {
                self.LockUnitEffect.SetActive(false);
                UICommonHelper.SetParent(self.LockUnitEffect, GlobalComponent.Instance.Pool.gameObject);
            }

            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UIMainHpBar.OnChangeSonScene();
        }

        public static void HideLockEffect(this LockTargetComponent self)
        {
            if (self.LockUnitEffect != null)
            {
                self.LockUnitEffect.SetActive(false);
            }
            self.LastLockId = 0;

            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UIMainHpBar.OnCancelLock();
        }

        public static void OnSelfDead(this LockTargetComponent self)
        {
            self.HideLockEffect();
        }

        public static void OnUnitDead(this LockTargetComponent self, Unit unit)
        {
            if (unit.Id == self.LastLockId)
            {
                self.HideLockEffect();
            }
        }

        public static void  CheckLockEffect(this LockTargetComponent self)
        {
            if (self.LockUnitEffect == null)
            {
                GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetEffetPath("SkillZhishi/RoseSelectTarget"));
                self.LockUnitEffect = GameObject.Instantiate(prefab);
                self.LockUnitEffect.SetActive(false);
            }
        }

        public static long LockTargetUnit(this LockTargetComponent self, bool first = false)
        {
            self.CheckLockEffect();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (first && self.LastLockId != 0)
            {
                Unit unitTarget = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.LastLockId);
                if (unitTarget != null && PositionHelper.Distance2D(unit, unitTarget) < 10f)
                {
                    return self.LastLockId;
                }
            }
            Entity[] units = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Children.Values.ToArray();
            float distance = 10f;
            ListComponent<UnitLockRange> UnitLockRanges = new ListComponent<UnitLockRange>();
            for (int i = 0; i < units.Length; i++)
            {
                Unit uu = units[i] as Unit;
                if (!uu.GetComponent<UnitInfoComponent>().IsCanBeAttackByUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(unit, uu);
                if (dd < distance)
                {
                    UnitLockRanges.Add(new UnitLockRange() { Id = uu.Id, Range = (int)(dd * 100) });
                }
            }

            UnitLockRanges.Sort(delegate (UnitLockRange a, UnitLockRange b)
            {
                return a.Range - b.Range;
            });

            if (UnitLockRanges.Count == 0)
            {
                //取消锁定
                self.LastLockIndex = -1;
                self.LastLockId = 0;
            }
            else
            {
                if (first) //锁定最近目标
                {
                    self.LastLockIndex = 0;
                    self.LastLockId = UnitLockRanges[self.LastLockIndex].Id;
                }
                else
                {
                    self.LastLockIndex++;
                    if (self.LastLockIndex >= UnitLockRanges.Count)
                    {
                        self.LastLockIndex = 0;
                    }
                    if (self.LastLockId != 0 && UnitLockRanges[self.LastLockIndex].Id == self.LastLockId)
                    {
                        self.LastLockIndex++;
                    }
                    if (self.LastLockIndex >= UnitLockRanges.Count)
                    {
                        self.LastLockIndex = 0;
                    }
                    self.LastLockId = UnitLockRanges[self.LastLockIndex].Id;
                }
            }

            if (self.LastLockId != 0)
            {
                Unit unitTarget = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.LastLockId);
                if (self.LockUnitEffect != null)
                {
                    self.LockUnitEffect.SetActive(true);
                    UICommonHelper.SetParent(self.LockUnitEffect, unitTarget.GetComponent<GameObjectComponent>().GameObject);
                }
                if (unitTarget.GetComponent<UnitInfoComponent>().Type == UnitType.Monster)
                {
                    UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                    uimain.GetComponent<UIMainComponent>().UIMainHpBar.OnLockUnit(unitTarget);
                    MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitTarget.GetComponent<UnitInfoComponent>().UnitCondigID);
                    self.SetEffectSize((float)monsterConfig.SelectSize);
                }
            }
            return self.LastLockId;
        }

        public static void SetEffectSize(this LockTargetComponent self, float size)
        {
            GameObject RedCircle = self.LockUnitEffect.transform.Find("Efx_Click_Red/RedCircle").gameObject;
            ParticleSystem ps = RedCircle.GetComponent<ParticleSystem>();
            var main = ps.main;
            main.startSize = new ParticleSystem.MinMaxCurve(3 * size);
        }

        public static void OnLockNpc(this LockTargetComponent self, Unit unitTarget=null)
        {
            if (unitTarget == null
                || unitTarget.GetComponent<GameObjectComponent>() == null
                || unitTarget.GetComponent<GameObjectComponent>().GameObject == null)
            {
                if (self.LockUnitEffect != null)
                {
                    self.LockUnitEffect.SetActive(false);
                }
                return;
            }
            self.CheckLockEffect();
            UICommonHelper.SetParent(self.LockUnitEffect, unitTarget.GetComponent<GameObjectComponent>().GameObject);
            self.SetEffectSize(1f);
        }
    }

}
