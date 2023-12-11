using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    /// <summary>
    /// 怪物连击
    /// </summary>
    public class Skill_Monster_Combo : SkillHandler
    {

        private List<long> ComboTimeList = new List<long>();    

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            //1;0@2;0                   时间;参数(保留字段)@ 时间;参数
            //1;90010503@2;90010503     时间;技能@ 时间;技能
            this.ComboTimeList.Clear();
            string[] skillparams = SkillConfigCategory.Instance.Get(this.SkillInfo.WeaponSkillID).GameObjectParameter.Split('@');
            for (int i = 0; i < skillparams.Length; i++)
            {
                string[] comboinfo = skillparams[i].Split(';');
                this.ComboTimeList.Add((long)(float.Parse(comboinfo[0]) * 1000));
            }
        }

        public override void OnExecute()
        {

            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            //this.BaseOnUpdate();
            long serverNow = TimeHelper.ServerNow();
            //根据技能效果延迟触发伤害
            if (serverNow < this.SkillExcuteHurtTime)
            {
                return;
            }
            this.HurtIds.Clear();  
            this.UpdateCheckPoint(this.TheUnitFrom.Position);
            this.ExcuteSkillAction();

            if (this.ComboTimeList.Count > 0)
            {
                this.SkillExcuteHurtTime = serverNow + this.ComboTimeList[0];
                this.ComboTimeList.RemoveAt(0); 
            }
            if (serverNow > this.SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
            }
        }


        public override void OnFinished()
        {
            this.Clear();
        }

    }
}
