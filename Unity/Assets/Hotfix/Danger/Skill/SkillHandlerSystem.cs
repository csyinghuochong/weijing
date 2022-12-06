using UnityEngine;

namespace ET
{
    public static class SkillHandlerSystem
    {
        public static void BaseOnInit(this ASkillHandler self, SkillInfo skillcmd, Unit theUnitFrom, Unit theUnitBelongto = null)
        {
            self.SkillInfo = skillcmd;
            self.SkillConf = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            int effctId = self.SkillConf.SkillEffectID[0];
            self.EffectConf = effctId != 0 ? EffectConfigCategory.Instance.Get(effctId) :null;
            self.TheUnitFrom = theUnitFrom;
            self.SkillState = SkillState.Running;
            self.IsExcuteHurt = self.EffectConf != null;
            self.SkillExcuteHurtTime = (long)(1000 * (self.EffectConf!=null?self.EffectConf.SkillEffectDelayTime:0)) + skillcmd.SkillBeginTime;

            self.TargetPosition = new Vector3(skillcmd.PosX, skillcmd.PosY, skillcmd.PosZ);
            self.EffectInstanceId.Clear();
        }

        public static void BaseOnUpdate(this ASkillHandler self)
        {
            long serverNow = TimeHelper.ServerNow();
           
            if (self.IsExcuteHurt && serverNow >= self.SkillExcuteHurtTime)
            {
                self.IsExcuteHurt = false;
                string music = self.SkillConf.SkillMusic;
                if (!string.IsNullOrEmpty(music) && music != "0")
                {
                    EventType.SkillSound.Instance.Asset = "Skill/" + music;
                    EventSystem.Instance.PublishClass(EventType.SkillSound.Instance);
                }
            }

            if (serverNow >= self.SkillInfo.SkillEndTime)
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

        public static void OnShowSkillIndicator(this ASkillHandler self, SkillInfo skillcmd)
        {
            Unit unit = self.TheUnitFrom;
            if (unit.Type != UnitType.Monster)
            {
                return;
            }
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillcmd.WeaponSkillID);
            if (skillConfig.SkillZhishiType == 0 || skillConfig.SkillDelayTime == 0)
            {
                return;
            }

            EventType.SkillYuJing.Instance.Unit = unit;
            EventType.SkillYuJing.Instance.SkillInfo = skillcmd;
            EventType.SkillYuJing.Instance.SkillConfig = skillConfig;
            Game.EventSystem.PublishClass(EventType.SkillYuJing.Instance);
        }

        //播放技能特效
        public static void PlaySkillEffects(this ASkillHandler self, Vector3 effectPostion, float effectAngle = 0f)
        {
            //特效为空直接返回
            if (self.EffectConf == null)
                return;
            EffectData playEffectBuffData = new EffectData();
            playEffectBuffData.TargetID = self.SkillInfo.TargetID;
            playEffectBuffData.SkillConfig = self.SkillConf;                   //技能相关配置
            playEffectBuffData.EffectConfig = self.EffectConf;                 //特效相关配置
            playEffectBuffData.EffectPosition = effectPostion;           //技能目标点
            playEffectBuffData.EffectAngle = effectAngle;
            playEffectBuffData.TargetAngle = self.SkillInfo.TargetAngle;         //技能角度
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;              //特效类型
            playEffectBuffData.InstanceId = IdGenerater.Instance.GenerateInstanceId();
            self.EffectInstanceId.Add(playEffectBuffData.InstanceId);

            EventType.SkillEffect.Instance.EffectData = playEffectBuffData;
            EventType.SkillEffect.Instance.Unit = self.TheUnitFrom;
            EventSystem.Instance.PublishClass(EventType.SkillEffect.Instance);
        }

        public static void EndSkillEffect(this ASkillHandler self)
        {
            for (int i = 0; i < self.EffectInstanceId.Count; i++)
            {
                EventType.SkillEffectFinish.Instance.EffectInstanceId = self.EffectInstanceId[i];
                EventType.SkillEffectFinish.Instance.Unit = self.TheUnitFrom;
                EventSystem.Instance.PublishClass(EventType.SkillEffectFinish.Instance);
            }
        }

        //播放受击特效
        public static void PlayHitEffect(this ASkillHandler self, Unit unit)
        {
            EffectData playEffectBuffData = new EffectData();
            EffectConfig hitSkillConfig = EffectConfigCategory.Instance.Get(self.SkillConf.SkillHitEffectID);
            playEffectBuffData.EffectConfig = hitSkillConfig;                  //特效相关配置
            playEffectBuffData.EffectPosition = Vector3.zero;
            playEffectBuffData.TargetAngle = 0;
            playEffectBuffData.EffectTypeEnum = EffectTypeEnum.SkillEffect;

            EventType.SkillEffect.Instance.EffectData = playEffectBuffData;
            EventType.SkillEffect.Instance.Unit = unit;
            EventSystem.Instance.PublishClass(EventType.SkillEffect.Instance);
        }
    }
}
