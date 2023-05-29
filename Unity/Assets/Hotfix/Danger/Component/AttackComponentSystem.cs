using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    [Timer(TimerType.AttackGridTimer)]
    public class AttackGridTimer : ATimer<AttackComponent>
    {
        public override void Run(AttackComponent self)
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
    public class AttackComponentAwakeSystem : AwakeSystem<AttackComponent>
    {
        public override void Awake(AttackComponent self)
        {
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();
        }
    }

    [ObjectSystem]
    public class AttackComponentDestroySystemm : DestroySystem<AttackComponent>
    {
        public override void Destroy(AttackComponent self)
        {
            self.RemoveTimer();
        }
    }

    public static class AttackComponentSystem
    {

        public static void BeginAutoAttack(this AttackComponent self, long moveTargetId)
        {
            self.RemoveTimer();
            self.Timer = TimerComponent.Instance.NewRepeatedTimer(400, TimerType.AttackGridTimer, self);
            self.MoveAttackId = moveTargetId;
            self.OnUpdate();
        }

        public static void RemoveTimer(this AttackComponent self)
        {
            self.MoveAttackId = 0;
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
        public static void OnUpdate(this AttackComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (self.MoveAttackId == 0 || unit == null || unit.IsDisposed)
            {
                TimerComponent.Instance?.Remove(ref self.Timer);
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
                self.MoveAttackTime = TimeHelper.ClientNow();
                unit.MoveToAsync2(taretUnit.Position, true).Coroutine();
            }
        }

        public static void OnInit(this AttackComponent self)
        {
            //普通攻击
            OccupationConfig occConfig = OccupationConfigCategory.Instance.Get(self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ);
            self.UpdateSkillInfo(occConfig.InitActSkillID);

            self.UpdateComboTime();
        }

        public static void SetAttackSpeed(this AttackComponent self)
        {
            int EquipType = (int)self.ZoneScene().GetComponent<BagComponent>().GetEquipType();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            float attackSpped = 1f + numericComponent.GetAsFloat(NumericType.Now_ActSpeedPro);
            self.SkillCDs = EquipType == (int)ItemEquipType.Knife ? new List<int>() { 500, 1000, 1000 } : new List<int>() { 800, 800, 800 };
            for (int i = 0; i < self.SkillCDs.Count; i++)
            {
                self.SkillCDs[i] = (int)(self.SkillCDs[i] / attackSpped);
            }
        }

        public static void SetComboSkill(this AttackComponent self, long timeNow)
        {
            int lastSkill = self.ComboSkillId;
            if (timeNow - self.LastSkillTime > self.CombatEndTime)
            {
                self.ComboSkillId = self.SkillId;
            }
            else
            {
                self.ComboSkillId = SkillConfigCategory.Instance.Get(self.ComboSkillId).ComboSkillID;
            }

            int EquipType = (int)self.BagComponent.GetEquipType();
            if ((EquipType == (int)ItemEquipType.Sword
                || EquipType == (int)ItemEquipType.Common))
            {
                self.ComboSkillId = self.RandomGetSkill(lastSkill);
            }

            if (self.ComboSkillId == 60000103 || self.ComboSkillId == 60000203)
            {
                self.ComboStartTime = 1250;
                self.CombatEndTime = 2000;
            }

            int index = self.SkillList.IndexOf(self.ComboSkillId);
            self.CDTime = self.SkillCDs[index];
        }

        //连击
        public static void UpdateComboTime(this AttackComponent self)
        {
            if (self.BagComponent.GetEquipType() == ItemEquipType.Sword)
            {
                //剑
                self.ComboStartTime = 500;
                self.CombatEndTime = 500;
            }
            else if (self.BagComponent.GetEquipType() == ItemEquipType.Knife)
            {
                //刀
                self.ComboStartTime = 1000;
                self.CombatEndTime = 2000;
            }
            else
            {
                //空手默认是剑
                self.ComboStartTime = 500;
                self.CombatEndTime = 500;
            }
        }

        public static int RandomGetSkill(this AttackComponent self, int lastSkill)
        {
            int index = RandomHelper.RandomByWeight(self.Weights);
            return self.SkillList[index];
        }

        public static int GetTargetAnagle(this AttackComponent self, Unit unit, Unit taretUnit)
        {
            if (taretUnit == null || taretUnit.IsDisposed)
            {
#if !SERVER && NOT_UNITY
                return (int)Quaternion.QuaternionToEuler(unit.Rotation).y;
#else
                return Mathf.FloorToInt(unit.Rotation.eulerAngles.y);
#endif
            }
            else
            {
#if !SERVER && NOT_UNITY
                Vector3 direction = taretUnit.Position - unit.Position;
                float ange = Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
                return Mathf.FloorToInt(ange);
#else
                Vector3 direction = taretUnit.Position - unit.Position;
                float ange = Mathf.Rad2Deg * Mathf.Atan2(direction.x, direction.z);
                return Mathf.FloorToInt(ange);
#endif
            }
        }

        public static void AutoAttack_1(this AttackComponent self, Unit unit, Unit taretUnit)
        {
            long timeNow = TimeHelper.ServerNow();
            if (timeNow <= self.CDEndTime)
            {
                return;
            }
            self.SetAttackSpeed();
            self.SetComboSkill(timeNow);
            int targetAngle = self.GetTargetAnagle(unit, taretUnit);
            unit.GetComponent<SkillManagerComponent>().SendUseSkill(self.ComboSkillId,0,targetAngle, taretUnit != null ? taretUnit.Id : 0, 0,false ).Coroutine();
            self.LastSkillTime = TimeHelper.ServerNow();
            self.CDEndTime = self.LastSkillTime + self.CDTime;
        }

        public static void UpdateAttackDis(this AttackComponent self, int skillid)
        {
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillid, self.BagComponent.GetEquipType()));
            self.AttackDistance = (float)skillConfig.SkillRangeSize;
        }

        public static void UpdateSkillInfo(this AttackComponent self, int skillid)
        {
            self.SkillId = skillid;
            self.ComboSkillId = SkillConfigCategory.Instance.Get(skillid).ComboSkillID;
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
