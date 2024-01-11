using NLog.Targets;
using UnityEngine;

namespace ET
{
    public class Skill_Other_ChongJi_1 : SkillHandler
    {

        private float SpeedAddValue = 0f;

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.SkillFirstHurtTime = 0;
            this.SpeedAddValue = 0f;
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();

            this.OnUpdate();
        }

        public void MoveToSync()
        {
            //Unit targetUnit = this.TheUnitFrom.GetParent<UnitComponent>().Get(this.SkillInfo.TargetID);
            //if (targetUnit != null && this.SkillConf.GameObjectParameter == "1")
            //{
            //    Vector3 direction = targetUnit.Position - this.TheUnitFrom.Position;
            //    this.SkillInfo.TargetAngle = (int)Mathf.Rad2Deg(Mathf.Atan2(direction.x, direction.z));
            //}
            NumericComponent numericComponent = this.TheUnitFrom.GetComponent<NumericComponent>();
            float oldSpeed = numericComponent.GetAsFloat(NumericType.Now_Speed);
            float oldspeedAdd = numericComponent.GetAsFloat(NumericType.Extra_Buff_Speed_Add);
            //float moveDistance = ((float)this.SkillConf.SkillMoveSpeed * this.SkillConf.SkillLiveTime * 0.001f);
            //Quaternion rotation = Quaternion.Euler(0, this.SkillInfo.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            //this.TargetPosition = theUnitFrom.Position + rotation * Vector3.forward * moveDistance;
            //this.TargetPosition = theUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(theUnitFrom.Position, TargetPosition);
            //1-10 表示 10%-100%
            double addPro = (double)numericComponent.GetAsInt(NumericType.Now_JumpDisAdd) / 10;
            float newSpeed = (float)(this.SkillConf.SkillMoveSpeed * (1 + addPro));
            float newspeedAdd = newSpeed - oldSpeed;

            if (newSpeed > oldSpeed && newspeedAdd > oldspeedAdd)
            {
                this.SpeedAddValue = newspeedAdd - oldspeedAdd;
                numericComponent.Set(NumericType.Extra_Buff_Speed_Add, newspeedAdd);
            }
            else
            {
                this.SpeedAddValue = 0f;
            }

            float moveDistance = ((float)this.SkillConf.SkillMoveSpeed * this.SkillConf.SkillLiveTime * 0.001f);
            Quaternion rotation = Quaternion.Euler(0, this.SkillInfo.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            this.TargetPosition = this.TheUnitFrom.Position + rotation * Vector3.forward * moveDistance;
            this.TargetPosition = this.TheUnitFrom.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(this.TheUnitFrom.Position, TargetPosition);
            this.TheUnitFrom.FindPathMoveToAsync(this.TargetPosition, null, false).Coroutine();
            this.NowPosition = this.TheUnitFrom.Position;
            this.TheUnitFrom.GetComponent<BuffManagerComponent>().AddBuffRecord(1, 1);
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
                //分成五份计算
                Vector3 oldpos = this.NowPosition;
                Vector3 newpos = this.TheUnitFrom.Position;
                Vector3 inteva = (newpos - oldpos) / 5;

                for (int i = 0; i < 5; i++)
                {
                    this.UpdateCheckPoint(oldpos + inteva * ( i + 1 ) );
                    this.ExcuteSkillAction();
                }
            }

            if (this.SkillFirstHurtTime > 0 && this.SkillConf.GameObjectParameter == "1")
            {
                this.TheUnitFrom.Stop(-2);
                this.SetSkillState(SkillState.Finished);
                return;
            }

            this.NowPosition = this.TheUnitFrom.Position;
        }

        public override void OnFinished()
        {
            //float cur_mul = TheUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Extra_Buff_Speed_Mul);
            //float speed_mul = cur_mul - this.AddSpeed_Mul;
            //Log.Debug($"OnFinished {speed_mul}");
            //TheUnitFrom.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Mul, Mathf.Max(0, speed_mul));
            NumericComponent numericComponent = this.TheUnitFrom.GetComponent<NumericComponent>();
            float curspeedAdd = numericComponent.GetAsFloat(NumericType.Extra_Buff_Speed_Add) - this.SpeedAddValue;
            numericComponent.Set(NumericType.Extra_Buff_Speed_Add, Mathf.Max(0, curspeedAdd));
            this.TheUnitFrom.GetComponent<BuffManagerComponent>().AddBuffRecord(0, 1);
            this.Clear();
        }
    }
}
