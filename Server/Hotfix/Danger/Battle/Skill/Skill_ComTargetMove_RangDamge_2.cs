using ET;
using UnityEngine;

namespace ET
{

    //子弹2
    public class Skill_ComTargetMove_RangDamge_2 : SkillHandler
    {
      
        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            SkillExcuteNum = int.Parse(this.SkillConf.GameObjectParameter);
            OnExecute();
        }


        public override void OnExecute()
        {
            for (int i = 0; i < SkillExcuteNum; i++)
            {
                BuffData buffData = new BuffData();
                buffData.BuffId = 7;
                buffData.SkillId = this.SkillConf.Id;
                buffData.TargetAngle = 360 / SkillExcuteNum * i;      //设置旋转球出现的位置
                TheUnitFrom.GetComponent<BuffManagerComponent>().BulletFactory(buffData, TheUnitFrom, this);
            }
        }

        public override void OnUpdate()
        {
            if (TimeHelper.ServerNow() > SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }

            this.CheckChiXuHurt();
        }

        public override void OnFinished()
        {
            this.Clear();
        }
    }
}
