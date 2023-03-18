using UnityEngine;
using System.Linq;
using System;
using System.Collections.Generic;

namespace ET
{

    [ObjectSystem]
    public class LockTargetComponentAwakeSystem : AwakeSystem<LockTargetComponent>
    {
        public override void Awake(LockTargetComponent self)
        {
            Camera camera = UIComponent.Instance.MainCamera;
            self.MyCamera_1 =  camera.GetComponent<MyCamera_1>();
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
        }
    }

    public static class LockTargetComponentSystem
    {
        public static void OnMainHeroMove(this LockTargetComponent self)
        {
            Unit haveBoss = null;
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.MainCityScene)
            {
                List<Unit> allUnit = main.GetParent<UnitComponent>().GetAll();
                for (int i = 0; i < allUnit.Count; i++)
                {
                    Unit unit = allUnit[i] as Unit;
                    if (unit.Type != UnitType.Monster)
                    {
                        continue;
                    }
                    MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unit.ConfigId);
                    if (monsterConfig.MonsterType == (int)MonsterTypeEnum.Boss && PositionHelper.Distance2D(unit, main) < 5f)
                    {
                        haveBoss = unit;
                        break;
                    }
                }
                UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                uimain.GetComponent<UIMainComponent>().UIMainHpBar.ShowBossHPBar(haveBoss);
            }
            else
            {
                self.MyCamera_1.OnUpdate();
            }
        }

        public static void BeginEnterScene(this LockTargetComponent self)
        {
            self.HideLockEffect();

            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UIMainHpBar.OnChangeScene();
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
            }
        }

        public static void LockTargetUnitId(this LockTargetComponent self, long unitId)
        {
            self.LastLockId = unitId;
            if (self.LastLockId == 0)
            {
                return;
            }
            self.CheckLockEffect();
            Unit unitTarget = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.LastLockId);
            UICommonHelper.SetParent(self.LockUnitEffect, unitTarget.GetComponent<GameObjectComponent>().GameObject);
            self.LockUnitEffect.SetActive(true);
            
            if (unitTarget.Type == UnitType.Monster)
            {
                MonsterConfig monsterConfig = MonsterConfigCategory.Instance.Get(unitTarget.ConfigId);
                UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                uimain.GetComponent<UIMainComponent>().UIMainHpBar.OnLockUnit(unitTarget);
                uimain.GetComponent<UIMainComponent>().UIMainSkillComponent.OnLockUnit(unitTarget);
                self.SetEffectSize((float)monsterConfig.SelectSize);
            }
        }

        public static long LockTargetUnit(this LockTargetComponent self, bool first = false)
        {
            Unit main = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (first && self.LastLockId != 0)
            {
                Unit unitTarget = main.GetParent<UnitComponent>().Get(self.LastLockId);
                if (unitTarget != null && PositionHelper.Distance2D(main, unitTarget) < 10f)
                {
                    return self.LastLockId;
                }
            }
            Entity[] units = main.GetParent<UnitComponent>().Children.Values.ToArray();
            float distance = 10f;
            ListComponent<UnitLockRange> UnitLockRanges = new ListComponent<UnitLockRange>();
            for (int i = 0; i < units.Length; i++)
            {
                Unit unit = units[i] as Unit;
                if (!main.IsCanAttackUnit(unit) && !unit.IsJingLing())
                {
                    continue;
                }
                if (units[i].GetComponent<StateComponent>().StateTypeGet(StateTypeEnum.Stealth))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd < distance)
                {
                    UnitLockRanges.Add(new UnitLockRange() { Id = unit.Id, Range = (int)(dd * 100) });
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
            self.LockTargetUnitId(self.LastLockId);
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
            self.CheckLockEffect();
            UICommonHelper.SetParent(self.LockUnitEffect, unitTarget.GetComponent<GameObjectComponent>().GameObject);
            self.LockUnitEffect.SetActive(true);
            self.SetEffectSize(1f);
        }
    }

}
