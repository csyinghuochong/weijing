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
        public List<int> SkillList = new List<int>() { 50000101, 50000102, 50000102 };

        public ETCancellationToken CancellationToken;
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

            self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().ClearnsShow();
        }

        public static void OnLockUnit(this UIAttackGridComponent self, Unit targetUnit)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (targetUnit == null)
            {
                self.MoveAttackId = 0;
                int targetAngle = self.GetTargetAnagle(Mathf.FloorToInt(unit.Rotation.eulerAngles.y), null);
                MapHelper.SendUseSkill(self.DomainScene(), self.ComboSkillId, targetAngle, 0, 0).Coroutine();
                self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
                return;
            }

            float distance = PositionHelper.Distance2D(unit, targetUnit);
            if (distance < self.AttackDistance)
            {
                self.MoveAttackId = 0;
                self.CancellationToken?.Cancel();
                self.CancellationToken = new ETCancellationToken();
                self.AutoAttack_1(unit, targetUnit, self.CancellationToken).Coroutine();
                return;
            }
            self.MoveAttackId = targetUnit.Id;
            unit.MoveToAsync2(targetUnit.Position, false).Coroutine();
            self.BeginAutoAttack();
        }

        public static void PointerUp(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.FightEffect.SetActive(false);
            Scene curscene = self.ZoneScene().CurrentScene();
            if (curscene == null)
            {
                return;
            }
            curscene.GetComponent<SkillIndicatorComponent>().ClearnsShow();
            if (TimeHelper.ClientNow() < self.CDEndTime)
            {
                return;
            }
            LockTargetComponent lockTargetComponent = curscene.GetComponent<LockTargetComponent>();
            long targetId = lockTargetComponent.LockTargetUnit(true);
            Unit targetUnit = curscene.GetComponent<UnitComponent>().Get(targetId);
            self.OnLockUnit(targetUnit);
        }

        public static async ETTask ShowFightEffect(this UIAttackGridComponent self)
        {
            self.FightEffect.SetActive(true);
            if (!self.InitEffect)
            {
                self.InitEffect = true;
                await ETTask.CompletedTask;
                GameObject prefab =ResourcesComponent.Instance.LoadAsset<GameObject>(ABPathHelper.GetEffetPath("UIFightHintEffect"));
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
            self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().ShowCommonAttackZhishi().Coroutine();
        }
        
        public static void OnMoveStart(this UIAttackGridComponent self)
        {
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
            self.FinishAutoAttack();
        }

        public static async ETTask AutoAttack_1(this UIAttackGridComponent self, Unit unit, Unit taretUnit, ETCancellationToken cancellationToken = null)
        {
            if (PositionHelper.Distance2D(unit, taretUnit) > self.AttackDistance)
            {
                cancellationToken?.Cancel();
                //self.BeginAutoAttack();
                return;
            }
            if (taretUnit.IsDisposed || taretUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
            {
                cancellationToken?.Cancel();
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
            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            self.CDTime = EquipType == (int)ItemEquipType.Knife ? 1000 : 800;
            if ((EquipType == (int)ItemEquipType.Sword
                || EquipType == (int)ItemEquipType.Common))
            {
                self.ComboSkillId = self.RandomGetSkill();
            }
            
            int targetAngle = self.GetTargetAnagle(Mathf.FloorToInt(unit.Rotation.eulerAngles.y), taretUnit);
            MapHelper.SendUseSkill(self.DomainScene(), self.ComboSkillId, targetAngle, taretUnit.Id, 0).Coroutine();
            self.LastSkillTime = Time.time;
            self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
            if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
            {
                self.ComboStartTime = 1.25f;
                self.CombatEndTime = 2f;
            }
            bool timeRet = await TimerComponent.Instance.WaitAsync(self.CDTime, cancellationToken);
            if (!timeRet)
            {
                return;
            }
            self.AutoAttack_1(unit, taretUnit, self.CancellationToken).Coroutine();
        }

        public static void BeginAutoAttack(this UIAttackGridComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.AttackGridTimer, self);
        }

        public static void FinishAutoAttack(this UIAttackGridComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }

        public static void OnUpdate(this UIAttackGridComponent self)
        {
            //超出了攻击范围，则不再追击。
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (self.MoveAttackId == 0 || unit == null || unit.IsDisposed)
            {
                TimerComponent.Instance?.Remove( ref self.Timer);
                return;
            }
            Unit taretUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.MoveAttackId);
            if (taretUnit == null || taretUnit.IsDisposed)
            {
                self.MoveAttackId = 0;
                self.DomainScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
                TimerComponent.Instance?.Remove(ref self.Timer);
                return;
            }
            if (PositionHelper.Distance2D(unit, taretUnit) <= self.AttackDistance)
            {
                self.MoveAttackId = 0;
                self.DomainScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
                TimerComponent.Instance?.Remove(ref self.Timer);
                self.CancellationToken?.Cancel();
                self.CancellationToken = new ETCancellationToken();
                self.AutoAttack_1(unit, taretUnit, self.CancellationToken).Coroutine();
                return;
            }
        }

        public static int GetTargetAnagle(this UIAttackGridComponent self, int angle, Unit taretUnit)
        {
            if (taretUnit == null || taretUnit.IsDisposed)
                return angle;

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

            if (self.SkillList.Count == 3)
            {
                self.Weights = new List<int>() { 70, 20, 20 };
            }
            if (self.SkillList.Count == 2)
            {
                self.Weights = new List<int>() { 70, 20};
            }
            if (self.SkillList.Count == 1)
            {
                self.Weights = new List<int>() { 100 };
            }
        }

    }

}
