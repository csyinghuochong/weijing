namespace ET
{
    //量子导弹
    public class Skill_Follow_Damge_1 : SkillHandler
    {
        private Unit FollowUnit;

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.SkillTriggerInvelTime = (long)(float.Parse(SkillConf.GameObjectParameter) * 1000);
            this.SkillTriggerLastTime = 0;
        }

        public override void OnExecute()
        {
            this.FollowUnit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, this.NowPosition, new CreateMonsterInfo());

            //寻找最近的可攻击对象
            this.TheUnitTarget = AIHelp.GetNearestEnemy(this.TheUnitFrom, 10, true);
        }

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            if (this.FollowUnit == null || this.FollowUnit.IsDisposed)
            {
                this.TheUnitTarget = AIHelp.GetNearestEnemy(this.TheUnitFrom, 10, true);
                return;
            }
            long servernow = TimeHelper.ServerNow();
            if (servernow - this.SkillTriggerLastTime < this.SkillTriggerInvelTime)
            {
                return;
            }
            this.SkillTriggerLastTime = servernow;
            this.HurtIds.Clear();
            this.UpdateCheckPoint(this.FollowUnit.Position);
            this.ExcuteSkillAction();
            this.FollowUnit.BulletMoveToAsync(this.TheUnitTarget.Position).Coroutine();
        }

        public override void OnFinished()
        {
            //移除Unity
            if (this.FollowUnit != null && !this.FollowUnit.IsDisposed)
            {
                this.FollowUnit.GetParent<UnitComponent>().Remove(FollowUnit.Id);
            }
            this.Clear();
        }
    } 

}
