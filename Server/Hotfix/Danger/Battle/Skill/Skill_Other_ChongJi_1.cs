using NLog.Targets;
using UnityEngine;

namespace ET
{
    public class Skill_Other_ChongJi_1 : SkillHandler
    {
      
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            float oldSpeed = theUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            //float moveDistance = ((float)this.SkillConf.SkillMoveSpeed * this.SkillConf.SkillLiveTime * 0.001f);
            //Quaternion rotation = Quaternion.Euler(0, this.SkillInfo.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            //this.TargetPosition = theUnitFrom.Position + rotation * Vector3.forward * moveDistance;
            //this.TargetPosition = theUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(theUnitFrom.Position, TargetPosition);

            //1-10 表示 10%-100%
            double addPro = (double)theUnitFrom.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_JumpDisAdd) / 10;
            float newSpeed = (float)(this.SkillConf.SkillMoveSpeed * (1 + addPro));

            theUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Add, newSpeed - oldSpeed);
           
            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.BaseOnUpdate();
        }

        public void MoveToSync()
        {
            Unit targetUnit = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.SkillInfo.TargetID);
            if (targetUnit != null && this.SkillConf.GameObjectParameter == "1")
            {
                Vector3 direction = targetUnit.Position - this.TheUnitFrom.Position;
                this.SkillInfo.TargetAngle = (int)Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
            }

            float moveDistance = ((float)this.SkillConf.SkillMoveSpeed * this.SkillConf.SkillLiveTime * 0.001f);
            Quaternion rotation = Quaternion.Euler(0, this.SkillInfo.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            this.TargetPosition = this.TheUnitFrom.Position + rotation * Vector3.forward * moveDistance;
            this.TargetPosition = this.TheUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(this.TheUnitFrom.Position, TargetPosition);
            this.TheUnitFrom.FindPathMoveToAsync(this.TargetPosition, null, false).Coroutine();
        }

        //public async ETTask MoveToAsync()
        //{
        //    await this.TheUnitFrom.FindPathMoveToAsync(TargetPosition, null, false);
        //    if (this.TheUnitFrom.IsDisposed)
        //    {
        //        return;
        //    }
        //    OnFinished();
        //}

        public override void OnUpdate()
        {
            long serverNow = TimeHelper.ServerNow();

            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }
            //只触发一次，需要多次触发的重写
            if (!this.IsExcuteHurt)
            {
                this.IsExcuteHurt = true;
                MoveToSync();
                //MoveToAsync().Coroutine();
            }
            if (serverNow > this.SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
            if (this.ICheckShape.Count > 0)
            {
                this.UpdateCheckPoint(this.TheUnitFrom.Position);
                this.ExcuteSkillAction();
            }
            if (this.SkillFirstHurtTime > 0 && this.SkillConf.GameObjectParameter == "1")
            {
                this.TheUnitFrom.Stop(-2);
                this.SetSkillState(SkillState.Finished);
                return;
            }
        }

        public override void OnFinished()
        {
            //float cur_mul = TheUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Extra_Buff_Speed_Mul);
            //float speed_mul = cur_mul - this.AddSpeed_Mul;
            //Log.Debug($"OnFinished {speed_mul}");
            //TheUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Mul, Mathf.Max(0, speed_mul));
            this.TheUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Add, 0);
            this.Clear();
        }
    }
}
