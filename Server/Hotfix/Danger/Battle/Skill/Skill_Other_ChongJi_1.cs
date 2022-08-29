using UnityEngine;

namespace ET
{
    public class Skill_Other_ChongJi_1 : SkillHandler
    {
      
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OldSpeed = theUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);

            Quaternion rotation = Quaternion.Euler(0, this.SkillCmd.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            TargetPosition = theUnitFrom.Position + rotation * Vector3.forward * ((float)SkillConf.SkillMoveSpeed * SkillLiveTime * 0.001f);
            TargetPosition = theUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(theUnitFrom.Position, TargetPosition);

            theUnitFrom.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Speed, (long)(10000*SkillConf.SkillMoveSpeed));
            OnExecute();
        }

        public override void OnExecute()
        {
            this.BaseOnExecute();
            this.BaseOnUpdate();
        }

        public override void OnUpdate()
        {
            PassTime = TimeHelper.ServerNow() - this.BeginTime;
            if (!this.IsTriggerHurt && this.PassTime >= this.DelayHurtTime)
            {
                this.IsTriggerHurt = true;
                TheUnitFrom.FindPathMoveToAsync(TargetPosition).Coroutine();
            }
            if (PassTime > SkillLiveTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
            this.UpdateCheckPoint();
            this.TriggerSkillHurt();
        }

        public override void OnFinished()
        {
            TheUnitFrom.GetComponent<NumericComponent>().ApplyValue(NumericType.Now_Speed, (long)(10000 * OldSpeed));
        }
    }
}
