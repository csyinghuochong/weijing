

using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    //UI通用脚本
    public class FunctionEffect
    {

        public bool SkillMoveStatus;
        public string SkillMoveValue_Initial;
        public string SkillMoveValue_End;

        //实例化自身
        private static FunctionEffect _instance;
        public static FunctionEffect GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FunctionEffect();
            }
            return _instance;
        }

        public void PlayHitEffect(Unit unit,int skillID) {

            //Log.Info("播放受击特效PlayHitEffect:" + skillID);
            //播放受击特效
            SkillConfig skillCof = SkillConfigCategory.Instance.Get(skillID);
            if (skillCof.SkillHitEffectID == 0)
                return;
            EffectData playEffectBuffData = new EffectData();
            EffectConfig hitSkillConfig = EffectConfigCategory.Instance.Get(skillCof.SkillHitEffectID);
            playEffectBuffData.EffectConfig = hitSkillConfig;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
        }

        public void PlaySelfEffect(Unit unit, int effectID)
        {
            EffectData playEffectBuffData = new EffectData();
            EffectConfig hitSkillConfig = EffectConfigCategory.Instance.Get(effectID);
            playEffectBuffData.EffectConfig = hitSkillConfig;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
        }

        public void PlayDropEffect(Unit unit, int effectID)
        {
            EffectData playEffectBuffData = new EffectData();
            EffectConfig hitSkillConfig = EffectConfigCategory.Instance.Get(effectID);
            playEffectBuffData.EffectConfig = hitSkillConfig;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            AEffectHandler aeEffect = unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
            //aeEffect.EffectObj.transform.SetParent(unit.GetComponent<GameObjectComponent>().GameObject.transform);
            //aeEffect.EffectObj.transform.localPosition = Vector3.zero;
        }

    }
}
