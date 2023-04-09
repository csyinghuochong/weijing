using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    public class AttackRecordComponentAwake : AwakeSystem<AttackRecordComponent>
    {
        public override void Awake(AttackRecordComponent self)
        {
            self.DropType = 0;
            self.AttackingId = 0;
            self.BeAttackId = 0;
            self.BeAttackPlayerList.Clear();

            if (self.GetParent<Unit>().Type != UnitType.Monster)
            {
                return;
            }
            self.DropType = MonsterConfigCategory.Instance.Get(self.GetParent<Unit>().ConfigId).DropType;
        }
    }

    public static class AttackRecordComponentSystem
    {
        public static void BeAttacking(this AttackRecordComponent self, Unit attack, long hurtvalue)
        {
            if (hurtvalue >= 0)
            {
                return;
            }

            long attackId = UnitTypeHelper.GetMasterId(attack);
            if (attackId == 0)
            {
                return;
            }
            if ( !self.BeAttackPlayerList.ContainsKey(attackId))
            {
                self.BeAttackPlayerList.Add(attackId, 0);
            }
            self.BeAttackPlayerList[attackId] += (hurtvalue * -1);

            self.UpdateBelongId();
        }

        public static void OnRemoveAttackByUnit(this AttackRecordComponent self, long unitid)
        {
            if (self.BeAttackPlayerList.ContainsKey(unitid))
            {
                self.BeAttackPlayerList.Remove(unitid);
            }
        }

        public static void ClearBeAttack(this AttackRecordComponent self)
        {
            self.BeAttackPlayerList.Clear();
            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            numericComponent.ApplyValue(NumericType.BossBelongID, 0);
        }

        public static List<long> GetBeAttackPlayerList(this AttackRecordComponent self)
        {
            return self.BeAttackPlayerList.Keys.ToList();
            //List<long> attackid = new List<long>(); 
            //foreach ((long id, long hurt) in self.BeAttackPlayerList)
            //{
            //    attackid.Add(id);
            //}
            //return attackid;
        }

        public static void UpdateBelongId(this AttackRecordComponent self)
        {
            long belongId = 0;
            long hurtvalue = 0;
            foreach ((long id , long hurt) in self.BeAttackPlayerList)
            {
                if (hurt > hurtvalue)
                {
                    hurtvalue = hurt;
                    belongId = id;
                }
            }

            NumericComponent numericComponent = self.GetParent<Unit>().GetComponent<NumericComponent>();
            if (belongId > 0 && numericComponent.GetAsLong(NumericType.BossBelongID)!= belongId)
            {
                numericComponent.ApplyValue(NumericType.BossBelongID, belongId);
            }
        }
    }
}
