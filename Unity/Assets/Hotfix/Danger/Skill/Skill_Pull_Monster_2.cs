using UnityEngine;

namespace ET
{

    [SkillHandler]
    public class Skill_Pull_Monster_2 : ASkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
           
            if (this.SkillConf.SkillMoveSpeed == 0f)
            {
                this.NowPosition = this.TargetPosition;
            }
            else
            {
                this.NowPosition = theUnitFrom.Position;
                Quaternion rotation = Quaternion.Euler(0, skillId.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
                Vector3 movePosition = rotation * Vector3.forward * (this.SkillConf.SkillLiveTime * (float)(this.SkillConf.SkillMoveSpeed) * 0.001f);
                this.TargetPosition = this.NowPosition + movePosition;
            }
            OnExecute();
        }

        public override void OnExecute()
        {
            this.PlaySkillEffects(this.NowPosition);
            this.OnShowSkillIndicator(this.SkillInfo);
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
            long serverNow = TimeHelper.ServerNow();
            float passTime = (serverNow - this.SkillInfo.SkillBeginTime) * 0.001f;
            if (passTime < this.SkillConf.SkillDelayTime)
            {
                return;
            }

            Vector3 dir = (this.TargetPosition - this.NowPosition).normalized;
            float dis = PositionHelper.Distance2D(this.TargetPosition, this.NowPosition);
            float move = (float)this.SkillConf.SkillMoveSpeed * 0.033f;
            move = Mathf.Min(dis, move);

            this.NowPosition = this.NowPosition + (move * dir);
            this.NowPosition.y = this.TargetPosition.y + 0.5f;

            EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId[0];
            EventType.SkillEffectMove.Instance.Unit = this.TheUnitFrom;
            EventType.SkillEffectMove.Instance.Postion = this.NowPosition;
            EventType.SkillEffectMove.Instance.Angle = -1;
            EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);

            dis = PositionHelper.Distance2D(this.NowPosition, this.TargetPosition);
            if (this.SkillConf.SkillMoveSpeed > 0f &&  dis < 0.5f  )
            {
                this.SetSkillState(SkillState.Finished);
            }
        }

        public override void OnFinished()
        {
            this.EndSkillEffect();
        }
    }
}
