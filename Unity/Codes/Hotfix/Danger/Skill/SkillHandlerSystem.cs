using UnityEngine;

namespace ET
{
    public static class SkillHandlerSystem
    {
        public static void BaseOnInit(this ASkillHandler self, SkillInfo skillcmd, Unit theUnitFrom, Unit theUnitBelongto = null)
        {
            self.PassTime = 0f;
            self.mSkillCmd = skillcmd;
            self.SkillConf = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            int effctId = self.SkillConf.SkillEffectID[0];
            if (effctId!= 0 && !EffectConfigCategory.Instance.Contain(effctId))
            {
                Log.Error($"SkillHandlerSystem effctId not found {effctId}");
            }
            self.EffectConf = effctId != 0 ? EffectConfigCategory.Instance.Get(effctId) :null;
            self.PlayMusic = self.EffectConf != null;
            self.BeingTime = TimeHelper.ClientNow();

            self.TheUnitFrom = theUnitFrom;
            self.SkillState = SkillState.Running;

            self.TargetPosition = new Vector3(skillcmd.PosX, skillcmd.PosY, skillcmd.PosZ);
            self.LiveTime = (int)self.SkillConf.SkillLiveTime * 0.001f;
            self.EffectInstanceId = 0;
        }

        public static void BaseOnUpdate(this ASkillHandler self)
        {
            self.PassTime = (TimeHelper.ClientNow() - self.BeingTime) * 0.001f;

            if (self.PlayMusic && self.PassTime >= self.EffectConf.SkillEffectDelayTime)
            {
                self.PlayMusic = false;
                string music = self.SkillConf.SkillMusic;
                if (!string.IsNullOrEmpty(music) && music != "0")
                {
                    EventType.SkillSound.Instance.Asset = "Skill/" + music;
                    EventSystem.Instance.PublishClass(EventType.SkillSound.Instance);
                }
            }

            if (self.PassTime >= self.LiveTime)
            {
                self.SetSkillState(SkillState.Finished);
            }
        }

        public static void SetSkillState(this ASkillHandler self, SkillState state)
        {
            self.SkillState = state;
        }

        public static bool IsSkillFinied(this ASkillHandler self)
        {
            return self.SkillState == SkillState.Finished;
        }

        //播放技能特效
        public static void PlaySkillEffects(this ASkillHandler self, Vector3 effectPostion)
        {
            //特效为空直接返回
            if (self.EffectConf == null)
                return;
            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.TargetID = self.mSkillCmd.TargetID;
            playEffectBuffData.mSkillConfig = self.SkillConf;                   //技能相关配置
            playEffectBuffData.mEffectConfig = self.EffectConf;                 //特效相关配置
            playEffectBuffData.TargetPosition = effectPostion;           //技能目标点
            playEffectBuffData.TargetAngle = self.mSkillCmd.TargetAngle;         //技能角度
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;              //特效类型
            playEffectBuffData.InstanceId = IdGenerater.Instance.GenerateInstanceId();
            self.EffectInstanceId = playEffectBuffData.InstanceId;

            EventType.SkillEffect.Instance.EffectData = playEffectBuffData;
            EventType.SkillEffect.Instance.Unit = self.TheUnitFrom;
            EventSystem.Instance.PublishClass(EventType.SkillEffect.Instance);
        }

        public static void EndSkillEffect(this ASkillHandler self)
        {
            if (self.EffectInstanceId == 0)
            {
                return;
            }
            EventType.SkillEffectFinish.Instance.EffectInstanceId = self.EffectInstanceId;
            EventType.SkillEffectFinish.Instance.Unit = self.TheUnitFrom;
            EventSystem.Instance.PublishClass(EventType.SkillEffectFinish.Instance);
        }

        //播放受击特效
        public static void PlayHitEffect(this ASkillHandler self, Unit unit)
        {
            EffectData playEffectBuffData = new EffectData();
            EffectConfig hitSkillConfig = EffectConfigCategory.Instance.Get(self.SkillConf.SkillHitEffectID);
            playEffectBuffData.mEffectConfig = hitSkillConfig;                  //特效相关配置
            playEffectBuffData.TargetPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;

            EventType.SkillEffect.Instance.EffectData = playEffectBuffData;
            EventType.SkillEffect.Instance.Unit = unit;
            EventSystem.Instance.PublishClass(EventType.SkillEffect.Instance);
        }
    }
}
