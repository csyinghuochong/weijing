using System;
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

        public bool InitEffect;
        public long MoveAttackId;

        public long Timer;

        public AttackComponent AttackComponent;
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

            self.AttackComponent = self.ZoneScene().GetComponent<AttackComponent>();
        }

        public static void OnEndDrag(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.FightEffect.SetActive(false);

            self.ZoneScene().GetComponent<SkillIndicatorComponent>().RecoveryEffect();
        }

        public static void PointerUp(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.OnMoveStart();
            self.FightEffect.SetActive(false);
            Scene zoneScene = self.ZoneScene();
            zoneScene.GetComponent<SkillIndicatorComponent>().RecoveryEffect();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit == null)
            {
                return;
            }
            LockTargetComponent lockTargetComponent = zoneScene.GetComponent<LockTargetComponent>();
            long targetId = lockTargetComponent.LockTargetUnit(true);
            Unit targetUnit = unit.GetParent<UnitComponent>().Get(targetId);
            if (targetUnit == null)
            {
                self.MoveAttackId = 0;
                zoneScene.GetComponent<AttackComponent>().AutoAttack_1(unit, null);
            }
            else
            {
                self.MoveAttackId = targetUnit.Id;
                self.BeginAutoAttack();
            }
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

        public static void BeginAutoAttack(this UIAttackGridComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);

            self.Timer = TimerComponent.Instance.NewRepeatedTimer(100, TimerType.AttackGridTimer, self);
            self.OnUpdate();
        }

        public static void OnUpdate(this UIAttackGridComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
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
            if (PositionHelper.Distance2D(unit, taretUnit) <= self.AttackComponent.AttackDistance)
            {
                self.ZoneScene().GetComponent<AttackComponent>().AutoAttack_1(unit, taretUnit);
            }
            else
            {
                unit.MoveToAsync2(taretUnit.Position, false).Coroutine();
            }
        }
    }

}
