using UnityEngine;

namespace ET
{
    //旋转攻击
    public class Skill_XuanZhuan_Attack : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            this.ICheckShape.Clear();
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
            for (int i = 0; i < 3; i++)
            {
                this.ICheckShape.Add(this.CreateCheckShape(starAngle + i * delta));
            }
            OnExecute();
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
        }

        public override void OnUpdate()
        {
            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;
            //根据技能效果延迟触发伤害
            if (this.PassTime < this.DelayHurtTime)
            {
                return;
            }
            //根据技能存在时间设置其结束状态
            if (this.PassTime > this.SkillLiveTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int range = int.Parse(paraminfos[0]);
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
            int addrangle = (int)(this.PassTime * range * 1f / this.SkillConf.SkillLiveTime);
            for (int i = 0; i < this.ICheckShape.Count; i++)
            {
                (this.ICheckShape[i] as Rectangle).s_forward = (Quaternion.Euler(0, starAngle + i * delta + addrangle, 0) * Vector3.forward).normalized; ;
            }
            this.TheUnitFrom.Rotation = Quaternion.Euler(0, this.SkillCmd.TargetAngle + addrangle, 0);

            this.ExcuteSkillAction();
        }

        public override void OnFinished()
        {
            this.PassTime = 0;
        }
    }
}
