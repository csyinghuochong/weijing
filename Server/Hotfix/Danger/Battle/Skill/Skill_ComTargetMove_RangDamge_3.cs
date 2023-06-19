using UnityEngine;
namespace ET
{

    /// <summary>
    /// 多条裂地斩
    /// </summary>
    public class Skill_ComTargetMove_RangDamge_3 : SkillHandler
    {
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            this.ICheckShape.Clear();
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int angle = this.SkillInfo.TargetAngle;
            int range = paraminfos.Length > 1 ? int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ? range / (number - 1) : 0;
            int starAngle = angle - (int)(range * 0.5f);

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
            long serverNow = TimeHelper.ServerNow();
            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }
            //根据技能存在时间设置其结束状态
            if (serverNow > this.SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
            if (!this.IsExcuteHurt)
            {
                this.IsExcuteHurt= true;
                this.ExcuteSkillAction();
                this.CheckChiXuHurt();
            }
        }

        public override void OnFinished()
        {
            this.Clear();
        }

    }
}
