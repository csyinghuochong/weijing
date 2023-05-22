using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class BuffHandlerSystem
    {

        public static void OnBaseBulletInit(this BuffHandler self, BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto)
        {
            self.PassTime = 0;
            self.IsTrigger = false;
            self.BuffData = buffData;
            self.TheUnitFrom = theUnitFrom;
            self.TheUnitBelongto = theUnitBelongto;
            self.BuffState = BuffState.Running;
            self.BeginTime = TimeHelper.ServerNow();
            self.mSkillConf = SkillConfigCategory.Instance.Get(buffData.SkillId);
            self.mBuffConfig = SkillBuffConfigCategory.Instance.Get(buffData.BuffId);
            self.DelayTime = (long)(1000*self.mSkillConf.SkillDelayTime);
            self.StartPosition = theUnitBelongto.Position;
            self.DamageRange = self.mSkillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageRange) + (float)self.mSkillConf.DamgeRange[0];
            self.BuffEndTime = 1000 * (int)self.mSkillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime) + self.mSkillConf.SkillLiveTime + TimeHelper.ServerNow();
            self.InterValTimeSum = 0;
        }

        public static void OnBaseBuffInit(this BuffHandler self, BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto)
        {
            self.PassTime = 0;
            self.IsTrigger = false;
            self.BuffData = buffData;
            self.TheUnitFrom = theUnitFrom;
            self.TheUnitBelongto = theUnitBelongto;
            self.BuffState = BuffState.Running;
            self.BeginTime = TimeHelper.ServerNow();
            self.mSkillConf = SkillConfigCategory.Instance.Get(buffData.SkillId);
            self.mBuffConfig = SkillBuffConfigCategory.Instance.Get(buffData.BuffId);
            self.DelayTime = self.mBuffConfig.BuffDelayTime;
            self.BuffEndTime = self.mBuffConfig.BuffTime + 1000 * (int)self.GetTianfuProAdd((int)BuffAttributeEnum.AddBuffTime) + TimeHelper.ServerNow();
            self.BuffEndTime = buffData.BuffEndTime > 0 ? buffData.BuffEndTime : self.BuffEndTime;
            //初始化Buff类型
            self.BaseBuffType = self.mBuffConfig.BuffType;
            self.InterValTime = self.mBuffConfig.BuffLoopTime * 1000;
            self.InterValTimeSum = 0;
        }

        public static float GetTianfuProAdd(this BuffHandler self, int key)
        {
            SkillSetComponent skillSetComponent = self.TheUnitFrom.GetComponent<SkillSetComponent>();
            if (skillSetComponent == null)
                return 0f;

            float addValue = 0f;
            Dictionary<int, float> keyValuePairs = skillSetComponent.GetBuffPropertyAdd(self.mBuffConfig.Id);
            if (keyValuePairs == null)
                return addValue;
            keyValuePairs.TryGetValue(key, out addValue);
            return addValue;
        }

        public static void OnBulletUpdate_1(this BuffHandler self, Vector3 curPostion)
        {
            List<Unit> units = self.TheUnitFrom.GetParent<UnitComponent>().GetAll();
            for (int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i] as Unit;
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (uu.IsDisposed || uu.Id == self.TheUnitFrom.Id)
                {
                    continue;
                }
                if (self.mSkillHandler.HurtIds.Contains(uu.Id))
                {
                    continue;
                }

                //检测目标是否在技能范围
                if (Vector3.Distance(curPostion, uu.Position) > self.DamageRange)
                {
                    continue;
                }

                self.mSkillHandler.HurtIds.Add(uu.Id);
                self.mSkillHandler.OnCollisionUnit(uu);
            }
        }

        public static void OnBulletUpdate_2(this BuffHandler self, Vector3 curPostion)
        {
            List<Unit> units = self.TheUnitFrom.GetParent<UnitComponent>().GetAll();
            for (int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i] as Unit;
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (uu.IsDisposed||uu.Id == self.TheUnitFrom.Id)
                {
                    continue;
                }

                //检测目标是否在技能范围
                if (Vector3.Distance(curPostion, uu.Position) > 1f)
                {
                    continue;
                }
                if (self.HurtIds.Contains(uu.Id))
                {
                    continue;
                }
                self.HurtIds.Add(uu.Id);
                self.mSkillHandler.OnCollisionUnit(uu);
            }
        }

    }
}
