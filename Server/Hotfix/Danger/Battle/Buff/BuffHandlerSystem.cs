using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public static class BuffHandlerSystem
    {

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
    }
}
