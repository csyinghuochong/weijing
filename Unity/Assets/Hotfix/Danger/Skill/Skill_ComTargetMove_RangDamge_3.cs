using UnityEngine;

namespace ET
{
    [SkillHandler]
    public class Skill_ComTargetMove_RangDamge_3 : Skill_Action_Common
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        public override void OnExecute()
        {
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int angle = this.SkillInfo.TargetAngle;
            int range = paraminfos.Length > 1 ? int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ? range / (number - 1) : 0;
            int starAngle = angle - (int)(range * 0.5f);

            for (int i = 0; i < number; i++)
            {
                this.PlaySkillEffects(this.TargetPosition, starAngle + i * delta);

                SkillInfo skillInfo = ComHelp.DeepCopy<SkillInfo>(this.SkillInfo);
                skillInfo.TargetAngle = starAngle + i * delta;
                this.OnShowSkillIndicator(skillInfo);
            }
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            this.EndSkillEffect();
        }
    }
}