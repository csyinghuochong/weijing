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
            self.BuffEndTime = CheckBuffTime(theUnitBelongto, self.mBuffConfig) + 1000 * (int)self.GetTianfuProAdd((int)BuffAttributeEnum.AddBuffTime) + TimeHelper.ServerNow();
            self.BuffEndTime = buffData.BuffEndTime > 0 ? buffData.BuffEndTime : self.BuffEndTime;
            //初始化Buff类型
            self.BaseBuffType = self.mBuffConfig.BuffType;
            self.InterValTime = self.mBuffConfig.BuffLoopTime * 1000;
            self.InterValTimeSum = 0;
        }

        /// <summary>
        /// 返回毫秒
        /// </summary>
        /// <param name="theUnitBelongto"></param>
        /// <param name="skillBuffConfig"></param>
        /// <returns></returns>
        public static int CheckBuffTime(Unit theUnitBelongto, SkillBuffConfig skillBuffConfig)
        {
            int buffTime = skillBuffConfig.BuffTime;
            if (skillBuffConfig.BuffType == 2 && skillBuffConfig.buffParameterType == 7)
            {
                //韧性缩短眩晕时间
                NumericComponent numericComponent = theUnitBelongto.GetComponent<NumericComponent>();
                float addResPro = numericComponent.GetAsFloat(NumericType.Now_Res);

                //最多抵抗一半
                if (addResPro <= 0.5f)
                {
                    addResPro = 0.5f;
                }

                buffTime = (int)((float)buffTime * (1f - addResPro));
            }
            return buffTime;
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
