using UnityEngine;

namespace ET
{
    public static class BuffHandlerSystem
    {

        /// <summary>
        /// 初始化buff数据
        /// </summary>
        /// <param name="buffData">Buff数据</param>
        /// <param name="theUnitFrom">来自哪个Unit</param>
        /// <param name="theUnitBelongto">寄生于哪个Unit</param>
        public static void BaseOnBulletInit(this ABuffHandler self, BuffData buffData, Unit theUnitBelongto) 
        {
            self.PassTime = 0f;
            self.TheUnitBelongto = theUnitBelongto;
            self.BuffData = buffData;
            self.EffectInstanceId = 0;

            //获取技能数据
            self.mSkillConf = SkillConfigCategory.Instance.Get(buffData.SkillConfig.Id);
            self.mEffectConf = self.mSkillConf.SkillEffectID[0] != 0 ? EffectConfigCategory.Instance.Get(self.mSkillConf.SkillEffectID[0]):null;

            self.mStartPosition = self.TheUnitBelongto.Position;
            self.mDelayTime = (float)(buffData.SkillConfig.SkillDelayTime);
            self.IsDelayPlay = self.mDelayTime > 0f;
            self.BuffEndTime = TimeHelper.ClientNow() + buffData.SkillConfig.SkillLiveTime;
            self.BuffBeginTime = TimeHelper.ClientNow();
        }

        /// <summary>
        /// 子弹和Buff做区分
        /// </summary>
        /// <param name="self"></param>
        /// <param name="buffData"></param>
        /// <param name="theUnitFrom"></param>
        /// <param name="theUnitBelongto"></param>
        public static void BaseOnBuffInit(this ABuffHandler self, BuffData buffData,Unit theUnitBelongto)
        {
            self.PassTime = 0f;
            self.TheUnitBelongto = theUnitBelongto;
            self.BuffData = buffData;
            self.EffectInstanceId = 0;
            //获取数据
            self.mSkillConf = buffData.SkillConfig;
            self.mSkillBuffConf = buffData.BuffConfig;
            self.mEffectConf = self.mSkillBuffConf.BuffEffectID == 0 ? null : EffectConfigCategory.Instance.Get(self.mSkillBuffConf.BuffEffectID);
            self.BuffEndTime = TimeHelper.ClientNow() + self.mSkillBuffConf.BuffTime;
            self.BuffEndTime = buffData.BuffEndTime > 0 ? buffData.BuffEndTime : self.BuffEndTime;
            self.BuffBeginTime = TimeHelper.ClientNow();
            self.StartPosition = theUnitBelongto.Position;
        }

        /// <summary>
        /// Buff持续
        /// </summary>
        public static void BaseOnUpdate(this ABuffHandler self)
        {
            self.PassTime = (TimeHelper.ClientNow() - self.BuffBeginTime) * 0.001f;
        }

        public static void Clear(this ABuffHandler self)
        {
            self.PassTime = 0;
            self.BuffEndTime = 0;
            self.BuffData = null;
            self.EffectData = null;
            self.mSkillConf = null;
            self.mEffectConf = null;
            self.mSkillBuffConf = null;
            self.TheUnitBelongto = null;
            self.BuffState = BuffState.Waiting;
        }

        //播放技能特效
        public static long PlayBuffEffects(this ABuffHandler self, bool followUpdate = true)
        {
            EffectData playEffectBuffData = new EffectData();
            if (self.mEffectConf == null)
            {
                return 0;
            }
            if (self.mSkillConf != null)
            {
                playEffectBuffData.mSkillConfig = self.mSkillConf;                   //技能相关配置
            }
            playEffectBuffData.TargetAngle = self.BuffData.TargetAngle;
            playEffectBuffData.FollowUnitMove = followUpdate;
            playEffectBuffData.mEffectConfig = self.mEffectConf;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.BuffEffect;
            playEffectBuffData.InstanceId = IdGenerater.Instance.GenerateInstanceId();
            //特效类型
            EventType.SkillEffect.Instance.EffectData = playEffectBuffData;
            EventType.SkillEffect.Instance.Unit = self.TheUnitBelongto;
            EventSystem.Instance.PublishClass(EventType.SkillEffect.Instance);
            self.EffectData = playEffectBuffData;
            return playEffectBuffData.InstanceId;
        }
    }
}