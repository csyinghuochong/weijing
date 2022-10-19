using ET;
using UnityEngine;
using System.Collections.Generic;

namespace ET
{

    //子弹2
    [SkillHandler]
    public class Skill_ComTargetMove_RangDamge_2 : ASkillHandler
    {
        private int angle = 0;
        private int skillNum;

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            skillNum = int.Parse(SkillConf.GameObjectParameter);
            OnExecute();
        }

        protected void PlayBullet_2()
        {
            //有可能有多个子弹
            for (int i = 0; i < skillNum; i++)
            {
                BuffData buffData = new BuffData();
                buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get(7);
                buffData.BuffClassScript = buffData.BuffConfig.BuffScript;
                angle += 120;
                buffData.TargetAngle = angle;
                buffData.SkillConfig = this.SkillConf;
                this.TheUnitFrom.GetComponent<BuffManagerComponent>().BuffFactory(buffData);
            }
        }

        public override void OnExecute()
        {
            PlayBullet_2();  //  播放特效
            this.OnShowSkillIndicator(this.SkillCmd);
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();
        }

        public override void OnFinished()
        {
            
        }
    }
}
