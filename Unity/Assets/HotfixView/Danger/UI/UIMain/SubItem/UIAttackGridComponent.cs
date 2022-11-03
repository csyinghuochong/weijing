using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{

    [Timer(TimerType.AttackGridTimer)]
    public class AttackGridTimer : ATimer<UIAttackGridComponent>
    {
        public override void Run(UIAttackGridComponent self)
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

    public class UIAttackGridComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Btn_SkillStart;
        public SkillConfig SkillConfig;
        public GameObject FightEffect;

        public int SkillId;
        public float LastSkillTime;
        public bool IsComboSkill;
        public int ComboSkillId;
        public bool InitEffect;
        public long MoveAttackId;

        public float ComboStartTime;
        public float CombatEndTime;

        public float AttackDistance = 0f;

        public List<int> Weights = new List<int>();
        public List<int> SkillList = new List<int>() { };

        public readonly C2M_SkillCmd c2mSkillCmd = new C2M_SkillCmd();

        public long CDTime = 800;
        public long CDEndTime;

        public long Timer;
    }

    [ObjectSystem]
    public class UIAttackGridComponentAwakeSystem : AwakeSystem<UIAttackGridComponent, GameObject>
    {
        public override void Awake(UIAttackGridComponent self, GameObject gameObject)
        {
            self.Awake(gameObject);
        }
    }

    [ObjectSystem]
    public class UIAttackGridComponentDestroySystem : DestroySystem<UIAttackGridComponent>
    {
        public override void Destroy(UIAttackGridComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIAttackGridComponentSystem
    {

        public static void Awake(this UIAttackGridComponent self, GameObject gameObject)
        {
            self.InitEffect = false;
            self.MoveAttackId = 0;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
            self.Btn_SkillStart = rc.Get<GameObject>("Btn_SkillStart");
            self.FightEffect = rc.Get<GameObject>("FightEffect");
           
            ButtonHelp.AddEventTriggers(self.Btn_SkillStart, (PointerEventData pdata) => { self.PointerDown(pdata); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_SkillStart, (PointerEventData pdata) => { self.OnEndDrag(pdata); }, EventTriggerType.EndDrag);
            ButtonHelp.AddEventTriggers(self.Btn_SkillStart, (PointerEventData pdata) => { self.PointerUp(pdata); }, EventTriggerType.PointerUp);

            self.UpdateComboTime();
        }

        public static void OnEndDrag(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.FightEffect.SetActive(false);

            self.ZoneScene().GetComponent<SkillIndicatorComponent>().RecoveryEffect();
        }

        public static void OnLockUnit(this UIAttackGridComponent self, Unit targetUnit)
        {
            self.OnMoveStart();

            if (targetUnit == null)
            {
                self.MoveAttackId = 0;
                Unit unit = UnitHelper.MainUnit;
                int targetAngle = self.GetTargetAnagle(Mathf.FloorToInt(unit.Rotation.eulerAngles.y), null);
                unit.GetComponent<SkillManagerComponent>().SendUseSkill(self.ComboSkillId, 0, targetAngle, 0, 0).Coroutine();
                self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
            }
            else
            {
                self.MoveAttackId = targetUnit.Id;
                self.BeginAutoAttack();
            }
        }

        public static void PointerUp(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.FightEffect.SetActive(false);
            Scene curscene = self.ZoneScene();
            curscene.GetComponent<SkillIndicatorComponent>().RecoveryEffect();
            if (TimeHelper.ClientNow() < self.CDEndTime)
            {
                return;
            }
            Unit unit = UnitHelper.MainUnit;
            if (unit == null || unit.GetComponent<FsmComponent>().IsSkillMove())
            {
                return;
            }
            LockTargetComponent lockTargetComponent = curscene.GetComponent<LockTargetComponent>();
            long targetId = lockTargetComponent.LockTargetUnit(true);
            Unit targetUnit = unit.GetParent<UnitComponent>().Get(targetId);
            self.OnLockUnit(targetUnit);
        }

        public static async ETTask ShowFightEffect(this UIAttackGridComponent self)
        {
            self.FightEffect.SetActive(true);
            if (!self.InitEffect)
            {
                self.InitEffect = true;
                GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(ABPathHelper.GetEffetPath("UIFightHintEffect"));
                GameObject effect = UnityEngine.Object.Instantiate(prefab);
                effect.GetComponent<UISizeFangDa>().Obj_Img = self.Btn_SkillStart;
                UICommonHelper.SetParent(effect, self.FightEffect);
            }
            else
            {
                if (self.FightEffect.transform.childCount > 0)
                {
                    GameObject effect = self.FightEffect.transform.GetChild(0).gameObject;
                    effect.SetActive(false);
                    effect.SetActive(true);
                }
             }
        }

        //连击
        public static void UpdateComboTime(this UIAttackGridComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            if (bagComponent.GetEquipType() == ItemEquipType.Sword)
            {
                //剑
                self.ComboStartTime = 0.5f;
                self.CombatEndTime = 1f;
            }
            else if (bagComponent.GetEquipType() == ItemEquipType.Knife)
            {
                //刀
                self.ComboStartTime = 1f;
                self.CombatEndTime = 2f;
            }
            else
            {
                //空手默认是剑
                self.ComboStartTime = 0.5f;
                self.CombatEndTime = 1f;
            }
        }

        public static int  RandomGetSkill(this UIAttackGridComponent self)
        {
            int index =  RandomHelper.RandomByWeight(self.Weights);
            return self.SkillList[index];
        }

        public static void PointerDown(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.ShowFightEffect().Coroutine();
            self.ZoneScene().GetComponent<SkillIndicatorComponent>().ShowCommonAttackZhishi();
        }
        
        public static void OnMoveStart(this UIAttackGridComponent self)
        {
            self.MoveAttackId = 0;
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void SetAttackSpeed(this UIAttackGridComponent self)
        {
            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            NumericComponent numericComponent = UnitHelper.MainUnit.GetComponent<NumericComponent>();  
            float attackSpped = 1f + numericComponent.GetAsFloat(NumericType.Now_ActSpeedPro);
            float cdTime = EquipType == (int)ItemEquipType.Knife ? 1000 : 800;
            self.CDTime = (int)(cdTime / attackSpped);
        }

        public static void SetComboSkill(this UIAttackGridComponent self)
        {
            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            if ((EquipType == (int)ItemEquipType.Sword
                || EquipType == (int)ItemEquipType.Common))
            {
                self.ComboSkillId = self.RandomGetSkill();
            }
        }

        public static  void AutoAttack_1(this UIAttackGridComponent self, Unit unit, Unit taretUnit)
        {
            if (TimeHelper.ClientNow() <= self.CDEndTime)
            {
                return;
            }
            if (Time.time - self.LastSkillTime > self.CombatEndTime)
            {
                self.ComboSkillId = self.SkillId;
            }
            else
            {
                self.ComboSkillId = SkillConfigCategory.Instance.Get(self.ComboSkillId).ComboSkillID;
            }
            self.SetAttackSpeed();
            self.SetComboSkill();

            int targetAngle = self.GetTargetAnagle(Mathf.FloorToInt(unit.Rotation.eulerAngles.y), taretUnit);
            unit.GetComponent<SkillManagerComponent>().SendUseSkill(self.ComboSkillId, 0, targetAngle, taretUnit.Id, 0).Coroutine();
            self.LastSkillTime = Time.time;
            self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
            if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
            {
                self.ComboStartTime = 1.25f;
                self.CombatEndTime = 2f;
            }
        }

        public static void BeginAutoAttack(this UIAttackGridComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(200, TimerType.AttackGridTimer, self);
        }

        public static void OnUpdate(this UIAttackGridComponent self)
        {
            Unit unit = UnitHelper.MainUnit;
            if (self.MoveAttackId == 0 || unit == null || unit.IsDisposed)
            {
                TimerComponent.Instance?.Remove( ref self.Timer);
                return;
            }
            Unit taretUnit = unit.GetParent<UnitComponent>().Get(self.MoveAttackId);
            if (taretUnit == null || taretUnit.IsDisposed || taretUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                self.MoveAttackId = 0;
                self.DomainScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            if (PositionHelper.Distance2D(unit, taretUnit) <= self.AttackDistance)
            {
                self.AutoAttack_1(unit, taretUnit);
            }
            else
            {
                unit.MoveToAsync2(taretUnit.Position, false).Coroutine();
            }
        }

        public static int GetTargetAnagle(this UIAttackGridComponent self, int angle, Unit taretUnit)
        {
            if (taretUnit == null || taretUnit.IsDisposed)
            {
                return angle;
            }
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            Vector3 direction = taretUnit.Position - myUnit.Position;
            float ange = Mathf.Rad2Deg * Mathf.Atan2(direction.x, direction.z);
            return Mathf.FloorToInt(ange);
        }

        public static void UpdateAttackDis(this UIAttackGridComponent self, int skillid)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkillID(skillid, bagComponent.GetEquipType()));
            self.AttackDistance = (float)skillConfig.SkillRangeSize;
        }

        public static void UpdateSkillInfo(this UIAttackGridComponent self, int skillid)
        {
            self.SkillId = skillid;
            self.SkillConfig = SkillConfigCategory.Instance.Get(skillid);
            self.ComboSkillId = self.SkillConfig.ComboSkillID;
            self.UpdateAttackDis(skillid);

            self.SkillList.Clear();
            while (skillid != 0 && self.SkillList.Count < 3)
            {
                self.SkillList.Add(skillid);
                SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillid);
                skillid = skillConfig.ComboSkillID;
                if (!SkillConfigCategory.Instance.Contain(skillid))
                {
                    break;
                }
            }
            switch (self.SkillList.Count)
            {
                case 3:
                    self.Weights = new List<int>() { 70, 20, 20 };
                    break;
                case 2:
                    self.Weights = new List<int>() { 70, 20 };
                    break;
                case 1:
                    self.Weights = new List<int>() { 100 };
                    break;
            }
        }

    }

}
