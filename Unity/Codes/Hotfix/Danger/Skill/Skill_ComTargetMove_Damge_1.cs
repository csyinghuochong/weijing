using ET;
using UnityEngine;

namespace ET
{

    //指定目标攻击
    [SkillHandler]
    public class Skill_ComTargetMove_Damge_1 : ASkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.NowPosition = theUnitFrom.Position;

            OnExecute();
        }

        public override void OnExecute()
        {
            this.PlaySkillEffects(this.TargetPosition);
        }

        public override void OnUpdate()
        {
            float passTime = this.PassTime;
            this.BaseOnUpdate();
            if (this.PassTime < this.EffectConf.SkillEffectDelayTime)
            {
                return;
            }

            float deltaTime = this.PassTime - passTime;
            Unit TheUnitBelongto = TheUnitFrom.DomainScene().GetComponent<UnitComponent>().Get(mSkillCmd.TargetID);
            if (TheUnitBelongto != null)
            {
                this.TargetPosition = TheUnitBelongto.Position;
            }

            Vector3 dir = (this.TargetPosition - this.NowPosition).normalized;
            float dis = PositionHelper.Distance2D(this.TargetPosition, this.NowPosition);
            float move = (float)this.SkillConf.SkillMoveSpeed * deltaTime; // (this.PassTime - (float)this.EffectConf.SkillEffectDelayTime);
            move = Mathf.Min(dis, move);

            this.NowPosition = this.NowPosition + (move * dir);
            this.NowPosition.y = this.TargetPosition.y + 0.5f;

            EventType.SkillEffectMove.Instance.EffectInstanceId = this.EffectInstanceId;
            EventType.SkillEffectMove.Instance.Unit = this.TheUnitFrom;
            EventType.SkillEffectMove.Instance.Postion = this.NowPosition;
            EventSystem.Instance.PublishClass(EventType.SkillEffectMove.Instance);

            dis = PositionHelper.Distance2D(this.NowPosition, this.TargetPosition);
            if (dis < 0.5f)
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
