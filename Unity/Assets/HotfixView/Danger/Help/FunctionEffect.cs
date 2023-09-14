

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

        public void PlayHitEffect(Unit attack, Unit unit,int skillID) 
        {
            //Log.Info("播放受击特效PlayHitEffect:" + skillID);
            //播放受击特效
            if (skillID == 0)
                return;
            SkillConfig skillCof = SkillConfigCategory.Instance.Get(skillID);
            if (skillCof.SkillHitEffectID == 0)
                return;


            int angle = 0;
            EffectConfig effectConfig = EffectConfigCategory.Instance.Get(skillCof.SkillHitEffectID);
            if (attack!=null && effectConfig.PlayType == 1)
            {
                Vector3 direction = attack.Position - unit.Position;
                angle = Mathf.FloorToInt((Mathf.Atan2(direction.x, direction.z)) * Mathf.Rad2Deg);
            }
            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.EffectId = skillCof.SkillHitEffectID;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = angle;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            playEffectBuffData.InstanceId = 1;
            unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
        }

        public void PlaySelfEffect(Unit unit, int effectID)
        {
            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.EffectId = effectID;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            playEffectBuffData.InstanceId = 1;
            unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
        }

        public void PlayDropEffect(Unit unit, int effectID)
        {
            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.EffectId = effectID;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;
            playEffectBuffData.InstanceId = 1;
            unit.GetComponent<EffectViewComponent>()?.EffectFactory(playEffectBuffData);
        }
    }
}
