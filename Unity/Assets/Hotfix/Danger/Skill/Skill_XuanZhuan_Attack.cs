using UnityEngine;

namespace ET
{

    [SkillHandler]
    public class Skill_XuanZhuan_Attack : Skill_Action_Common
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public override void OnExecute()
        {
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int angle = this.SkillCmd.TargetAngle;
            int range = paraminfos.Length > 1 ? int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ? range / (number - 1) : 0;
            int starAngle = angle - (int)(range * 0.5f);

            for (int i = 0; i < number; i++)
            {
                this.PlaySkillEffects(this.TargetPosition, starAngle + i * delta);

                SkillInfo skillInfo = ComHelp.DeepCopy<SkillInfo>(this.SkillCmd);
                skillInfo.TargetAngle = starAngle + i * delta;
                this.OnShowSkillIndicator(skillInfo);
            }
        }

        public override void OnUpdate()
        {
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int angle = this.SkillCmd.TargetAngle;
            int range = paraminfos.Length > 1 ? int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ? range / (number - 1) : 0;
            int addrangle = (int)(this.PassTime * range * 1f / LiveTime);
            int starAngle = angle - (int)(range * 0.5f);

            for (int i = 0; i < this.EffectInstanceId.Count; i++)
            {
                EventType.SkillEffectMove.Instance.Postion = this.TargetPosition;
                EventType.SkillEffectMove.Instance.Unit = this.TheUnitFrom;
                EventType.SkillEffectMove.Instance.Angle = starAngle + i * delta + addrangle;
                EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId[i];
                EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);
            }
            this.TheUnitFrom.Rotation = Quaternion.Euler(0, this.SkillCmd.TargetAngle + addrangle, 0);
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            this.EndSkillEffect();
        }
    }
}
