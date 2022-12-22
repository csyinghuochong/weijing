using UnityEngine;

namespace ET
{
    public class Skill_Other_ChongJi_1 : SkillHandler
    {
      
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            float oldSpeed = theUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            float moveDistance = ((float)this.SkillConf.SkillMoveSpeed * this.SkillConf.SkillLiveTime * 0.001f);
            Quaternion rotation = Quaternion.Euler(0, this.SkillInfo.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            this.TargetPosition = theUnitFrom.Position + rotation * Vector3.forward * moveDistance;
            this.TargetPosition = theUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(theUnitFrom.Position, TargetPosition);

            //1-10 表示 10%-100%
            double addPro = (double)theUnitFrom.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_JumpDisAdd) / 10;
            float newSpeed = (float)(this.SkillConf.SkillMoveSpeed * (1 + addPro));
            this.AddSpeed_Mul = (newSpeed - oldSpeed) / oldSpeed - theUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Extra_Buff_Speed_Mul);
            theUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Mul, this.AddSpeed_Mul);
            Unit targetUnit = theUnitFrom.GetParent<UnitComponent>().Get(skillId.TargetID);
            if (targetUnit!=null)
            {
                float distance = PositionHelper.Distance2D(theUnitFrom, targetUnit);
                if (distance < 1f)
                {
                    TargetPosition = theUnitFrom.Position;
                }
                else if (distance < moveDistance)
                {
                    Vector3 dir = theUnitFrom.Position - targetUnit.Position;
                    this.TargetPosition = targetUnit.Position + dir.normalized;
                }
            }

            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
            this.TheUnitFrom.FindPathMoveToAsync(TargetPosition, null, false).Coroutine();
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            if (serverNow > this.SkillEndTime + 100)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
            this.UpdateCheckPoint();
            this.ExcuteSkillAction();
        }

        public override void OnFinished()
        {
            float speed_mul = TheUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Extra_Buff_Speed_Mul) - this.AddSpeed_Mul;
            TheUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Mul, Mathf.Max(0, speed_mul));
        }
    }
}
