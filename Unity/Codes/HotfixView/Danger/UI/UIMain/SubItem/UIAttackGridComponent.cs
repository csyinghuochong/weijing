using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{

    public class UIAttackGridComponent : Entity, IAwake
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

        public long CDTime = 500;
        public long CDEndTime;
    }

    [ObjectSystem]
    public class UIAttackGridComponentAwakeSystem : AwakeSystem<UIAttackGridComponent>
    {
        public override void Awake(UIAttackGridComponent self)
        {
            self.Awake();
        }
    }

    public static class UIAttackGridComponentSystem
    {

        public static void Awake(this UIAttackGridComponent self)
        {
            self.InitEffect = false;
            self.MoveAttackId = 0;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
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
            self.CancellationToken?.Cancel();
            self.CancellationToken = null;
            ETCancellationToken cancellationToken = new ETCancellationToken();
            self.CancellationToken = cancellationToken;

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (targetUnit == null)
            {
                self.MoveAttackId = 0;
                int targetAngle = self.GetTargetAnagle(Mathf.FloorToInt(unit.Rotation.eulerAngles.y), 0);
                MapHelper.SendUseSkill(self.DomainScene(), self.ComboSkillId, targetAngle, 0, 0).Coroutine();
                self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
                return;
            }

            float distance = PositionHelper.Distance2D(unit, targetUnit);
            if (distance < self.AttackDistance)
            {
                self.MoveAttackId = 0;
                self.AutoAttack(targetUnit.Id, self.CancellationToken).Coroutine();
                return;
            }
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            self.MoveAttackId = targetUnit.Id;
            self.SendMoveToUnit(unit, targetUnit.Position).Coroutine();
        }

        public static void PointerUp(this UIAttackGridComponent self, PointerEventData pdata)
        {
            self.FightEffect.SetActive(false);
            self.ZoneScene().CurrentScene().GetComponent<SkillIndicatorComponent>().ClearnsShow();
            if (TimeHelper.ClientNow() < self.CDEndTime)
            {
                return;
            }

            LockTargetComponent lockTargetComponent = self.ZoneScene().CurrentScene().GetComponent<LockTargetComponent>();
            long targetId = lockTargetComponent.LockTargetUnit(true);
            Unit targetUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(targetId);

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
        }

        public static async ETTask AutoAttack(this UIAttackGridComponent self, long targetId, ETCancellationToken cancellationToken = null)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            long instanceid = unit.InstanceId;
            while (true)
            {
                if (instanceid != unit.InstanceId)
                {
                    return;
                }
                if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
                {
                    return;
                }
                LockTargetComponent lockTargetComponent = self.ZoneScene().CurrentScene().GetComponent<LockTargetComponent>();
                if (targetId != lockTargetComponent.LastLockId)
                {
                    Unit targetUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(lockTargetComponent.LastLockId);
                    self.OnLockUnit(targetUnit);
                    return;
                }

                Unit taretUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(targetId);
                if (taretUnit == null || taretUnit.IsDisposed || taretUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1)
                {
                    return;
                }

                bool canAttack = true;
                int errorCode = ErrorCore.ERR_Success;
                if (Time.time - self.LastSkillTime < self.ComboStartTime)
                {
                    canAttack = false;
                }
                if (canAttack)
                {
                    if (Time.time - self.LastSkillTime > self.CombatEndTime)
                    {
                        canAttack = true;
                        self.ComboSkillId = self.SkillId;
                    }
                    else
                    {
                        //更新技能ID
                        canAttack = true;
                        self.ComboSkillId = SkillConfigCategory.Instance.Get(self.ComboSkillId).ComboSkillID;
                    }
                    int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
                    if ((EquipType == (int)ItemEquipType.Sword || EquipType == (int)ItemEquipType.Common))
                    {
                        self.ComboSkillId = self.RandomGetSkill();
                    }
                    float distance = PositionHelper.Distance2D(unit, taretUnit);
                    if (distance < self.AttackDistance)
                    {
                        errorCode = await self.SendAttackUnit(unit, targetId);
                    }
                    else
                    {
                        return;
                    }
  
                    if (errorCode == ErrorCore.ERR_Success)
                    {
                        self.LastSkillTime = Time.time;
                        if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
                        {
                            self.ComboStartTime = 1.25f;
                            self.CombatEndTime = 2f;
                        }
                    }
                }

                if (cancellationToken.IsCancel())
                {
                    return;
                }
                bool timeRet = await TimerComponent.Instance.WaitAsync(self.CDTime, cancellationToken);
                if (!timeRet)
                {
                    return;
                }
            }
        }

        public static async ETTask<int> SendAttackUnit(this UIAttackGridComponent self, Unit unit, long targetId)
        {
            Unit taretUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(targetId);
            if (taretUnit == null || taretUnit.IsDisposed)
            {
                return ErrorCore.ERR_NetWorkError;
            }
            self.CDEndTime = TimeHelper.ClientNow() + self.CDTime;
            int targetAngle = self.GetTargetAnagle(Mathf.FloorToInt(unit.Rotation.eulerAngles.y), targetId);
            return await MapHelper.SendUseSkill(self.DomainScene(), self.ComboSkillId, targetAngle, targetId, 0);
        }

        public static async ETTask SendMoveToUnit(this UIAttackGridComponent self, Unit unit, Vector3 position)
        {
            self.CheckMove().Coroutine();
            int value = await unit.MoveToAsync2(position, false);
            long targetId = self.ZoneScene().CurrentScene().GetComponent<LockTargetComponent>().LastLockId;
            Unit taretUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(targetId);
            //说明正常移动到目标点
            if (value == 0 && taretUnit != null && PositionHelper.Distance2D(unit, taretUnit) < self.AttackDistance)
            {
                self.CancellationToken?.Cancel();
                self.CancellationToken = null;
                ETCancellationToken cancellationToken = new ETCancellationToken();
                self.CancellationToken = cancellationToken;
                self.AutoAttack(targetId, cancellationToken).Coroutine();
            }
        }

        public static async ETTask CheckMove(this UIAttackGridComponent self)
        {
            for (int i = 0; i < 100; i++)
            {
                await TimerComponent.Instance.WaitFrameAsync();
                if (self.MoveAttackId == 0)
                {
                    return;
                }
                Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
                if (unit == null)
                {
                    return;
                }
                Unit taretUnit = self.ZoneScene().CurrentScene().GetComponent<UnitComponent>().Get(self.MoveAttackId);
                if (taretUnit == null || taretUnit.IsDisposed || (PositionHelper.Distance2D(unit, taretUnit) <= self.AttackDistance))
                {
                    self.MoveAttackId = 0;
                    self.DomainScene().GetComponent<SessionComponent>().Session.Send(new C2M_Stop());
                    return;
                }
            }
        }

        public static int GetTargetAnagle(this UIAttackGridComponent self, int angle, long targetId)
        {
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (targetId == 0)
                return angle;
            Unit taretUnit = self.DomainScene().CurrentScene().GetComponent<UnitComponent>().Get(targetId);
            if (taretUnit == null || taretUnit.IsDisposed)
                return angle;

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
