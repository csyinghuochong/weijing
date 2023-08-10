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

            this.GetTheUnitTarget();
        }

        public void GetTheUnitTarget()
        {
            //寻找最近的可攻击对象
            this.TheUnitTarget = AIHelp.GetNearestEnemyByPosition(this.TheUnitFrom, this.FollowUnit.Position, 10);
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
            //根据技能存在时间设置其结束状态
            if (serverNow > this.SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }

            if (this.FollowUnit == null || this.FollowUnit.IsDisposed)
            {
                this.GetTheUnitTarget();
                return;
            }
            if (serverNow - this.SkillTriggerLastTime < this.SkillTriggerInvelTime)
            {
                return;
            }
            this.SkillTriggerLastTime = serverNow;
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
