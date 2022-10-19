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
            int range = 0;
            int number = 1;
            int delta = 0;
            int starAngle = angle - (int)(range * 0.5f);
            if (paraminfos.Length == 2)
            {
                range = int.Parse(paraminfos[0]);
                number = int.Parse(paraminfos[1]);
            }
            if (number > 1)
            {
                delta = range / (number - 1);
            }

            for (int i = 0; i < number; i++)
            {
                this.PlaySkillEffects(this.TargetPosition, starAngle + i * delta);
            }
        }

        public override void OnUpdate()
        {
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int range = int.Parse(paraminfos[0]);
            int addrangle = (int)(this.PassTime * range * 1f / LiveTime);
            int angle = this.SkillCmd.TargetAngle;
            int number = 1;
            int delta = 0;
            int starAngle = angle - (int)(range * 0.5f);
            if (paraminfos.Length == 2)
            {
                range = int.Parse(paraminfos[0]);
                number = int.Parse(paraminfos[1]);
            }
            if (number > 1)
            {
                delta = range / (number - 1);
            }
            for (int i = 0; i < this.EffectInstanceId.Count; i++)
            {
                EventType.SkillEffectMove.Instance.Postion = this.TargetPosition;
                EventType.SkillEffectMove.Instance.Unit = this.TheUnitFrom;
                EventType.SkillEffectMove.Instance.Angle = starAngle + i * delta + addrangle;
                EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId[i];
                EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);
            }
            this.TheUnitFrom.Rotation = Quaternion.Euler(0, this.SkillCmd.TargetAngle + addrangle, 0);
            Log.Debug($"addrangle:   {addrangle}");
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            this.EndSkillEffect();
        }
    }
}
