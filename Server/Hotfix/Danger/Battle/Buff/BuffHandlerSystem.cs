using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class BuffHandlerSystem
    {

        public static void OnBaseBulletInit(this BuffHandler self, BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto)
        {
            self.IsTrigger = false;
            self.PassTime = 0;
            self.TheUnitFrom = theUnitFrom;
            self.TheUnitBelongto = theUnitBelongto;
            self.BuffData = buffData;
            self.BuffState = BuffState.Running;
            self.SkillConf = buffData.SkillConfig;
            self.BeginTime = TimeHelper.ServerNow();
            self.DelayTime = (long)(1000*buffData.SkillConfig.SkillDelayTime);
            self.StartPosition = theUnitFrom.Position;
            self.DamageRange = self.mSkillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddDamageRange) + (float)buffData.SkillConfig.DamgeRange[0];
            self.BuffEndTime = (int)self.mSkillHandler.GetTianfuProAdd((int)SkillAttributeEnum.AddSkillLiveTime) +  buffData.SkillConfig.SkillLiveTime + TimeHelper.ServerNow();
        }

        public static void OnBaseBuffInit(this BuffHandler self, BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto)
        {
            self.PassTime = 0;
            self.IsTrigger = false;
            self.TheUnitFrom = theUnitFrom;
            self.TheUnitBelongto = theUnitBelongto;
            self.BuffData = buffData;
            self.BuffState = BuffState.Running;
            self.BeginTime = TimeHelper.ServerNow(); 
            self.DelayTime = buffData.BuffConfig.BuffDelayTime;
            self.BuffEndTime = buffData.BuffConfig.BuffTime + (int)self.GetTianfuProAdd((int)BuffAttributeEnum.AddBuffTime) + TimeHelper.ServerNow();
            self.BuffEndTime = buffData.BuffEndTime > 0 ? buffData.BuffEndTime : self.BuffEndTime;
            //初始化Buff类型
            self.BaseBuffType = buffData.BuffConfig.BuffType;
            self.InterValTime = buffData.BuffConfig.BuffLoopTime * 1000;
            self.InterValTimeSum = 0;
        }

        public static float GetTianfuProAdd(this BuffHandler self, int key)
        {
            SkillSetComponent skillSetComponent = self.TheUnitFrom.GetComponent<SkillSetComponent>();
            if (skillSetComponent == null)
                return 0f;

            float addValue = 0f;
            Dictionary<int, float> keyValuePairs = skillSetComponent.GetBuffPropertyAdd(self.BuffData.BuffConfig.Id);
            if (keyValuePairs == null)
                return addValue;
            keyValuePairs.TryGetValue(key, out addValue);
            return addValue;
        }

        public static void OnBulletUpdate(this BuffHandler self, Vector3 curPostion)
        {
            List<Entity> units = self.TheUnitFrom.Domain.GetComponent<UnitComponent>().Children.Values.ToList();
            for(int i = units.Count - 1; i >= 0; i--)
            {
                Unit uu = units[i] as Unit;
                //不对自己造成伤害和同一个目标不造成2次伤害
                if (uu.Id == self.TheUnitFrom.Id || self.mSkillHandler.HurtIds.Contains(uu.Id))
                {
                    continue;
                }

                if (!uu.GetComponent<UnitInfoComponent>().IsCanBeAttackByUnit(self.TheUnitFrom))
                    continue;

                //检测目标是否在技能范围
                if (Vector3.Distance(curPostion, uu.Position) > self.DamageRange)
                {
                    continue;
                }
                self.mSkillHandler.OnCollisionUnit(uu);
            }
        }

    }
}
