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
            //有可能有多个子弹
            BuffData buffData = new BuffData();
            buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get(6);
            buffData.BuffClassScript = buffData.BuffConfig.BuffScript;
            buffData.TargetAngle = this.mSkillCmd.TargetAngle;
            buffData.SkillConfig = this.SkillConf;
            this.TheUnitFrom.GetComponent<BuffManagerComponent>().BuffFactory(buffData);
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
