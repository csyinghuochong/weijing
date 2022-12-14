namespace ET
{

    //子弹1
    [SkillHandler]
    public class Skill_ComTargetMove_RangDamge_1 : ASkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            OnExecute();
        }

        protected void PlayBullet_1()
        {
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int angle = this.SkillInfo.TargetAngle;
            int range = paraminfos.Length > 1 ?  int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ?  range / (number - 1) : 0;
            int starAngle = angle - (int)(range * 0.5f);

            for (int i = 0; i < number; i++ )
            {
                //有可能有多个子弹
                BuffData buffData = new BuffData();
                buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get(6);
                buffData.BuffClassScript = buffData.BuffConfig.BuffScript;
                buffData.TargetAngle = starAngle + i * delta;
                buffData.SkillConfig = this.SkillConf;
                this.TheUnitFrom.GetComponent<BuffManagerComponent>().BuffFactory(buffData);

                SkillInfo skillInfo = ComHelp.DeepCopy<SkillInfo>(this.SkillInfo);
                skillInfo.TargetAngle = starAngle + i * delta;
                this.OnShowSkillIndicator(skillInfo);
            }
        }

        public override void OnExecute()
        {
            PlayBullet_1();     //播放特效
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
