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

            theUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Add, newSpeed - oldSpeed);
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
            MoveToAsync().Coroutine();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
        }

        public async ETTask MoveToAsync()
        {
            await this.TheUnitFrom.FindPathMoveToAsync(TargetPosition, null, false);
            OnFinished();
        }

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();
            if (serverNow > this.SkillEndTime + 100)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
            if (this.ICheckShape.Count > 0)
            {
                this.UpdateCheckPoint(this.TheUnitFrom.Position);
                this.ExcuteSkillAction();
            }
        }

        public override void OnFinished()
        {
            //float cur_mul = TheUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Extra_Buff_Speed_Mul);
            //float speed_mul = cur_mul - this.AddSpeed_Mul;
            //Log.Debug($"OnFinished {speed_mul}");
            //TheUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Mul, Mathf.Max(0, speed_mul));
            TheUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Add, 0);
            this.Clear();
        }
    }
}
