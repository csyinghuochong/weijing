using UnityEngine;

namespace ET
{

    /// <summary>
    /// 回旋子弹
    /// </summary>
    public class Skill_Boomerang : SkillHandler
    {

        private bool Return;
        private Unit BulletUnit;


        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
            this.Return = false;
        }

        public override void OnExecute()
        {
            int angle = this.SkillInfo.TargetAngle;
            Vector3 sourcePoint = this.TheUnitFrom.Position;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            Vector3 TargetPoint = sourcePoint + rotation * Vector3.forward * this.SkillConf.SkillLiveTime * (float)this.SkillConf.SkillMoveSpeed * 0.001f;
            this.BulletUnit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, this.NowPosition, new CreateMonsterInfo());
            this.TargetPosition = TargetPoint;
            this.BulletUnit.BulletMoveToAsync(TargetPoint).Coroutine();

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

            this.UpdateCheckPoint(this.BulletUnit.Position);
            this.ExcuteSkillAction();
            if (!this.Return)
            {
                this.Return = Vector3.Distance(this.BulletUnit.Position, this.TargetPosition) < 0.5f;
                this.HurtIds.Clear();
            }
            if (this.Return)
            {
                this.BulletUnit.BulletMoveToAsync(this.TheUnitFrom.Position).Coroutine();
                if (Vector3.Distance(this.BulletUnit.Position, this.TheUnitFrom.Position) < 1f)
                {
                    this.SetSkillState(SkillState.Finished);
                }
            }
            //防止不销毁
            if (serverNow > this.SkillEndTime + TimeHelper.Minute)
            {
                this.SetSkillState(SkillState.Finished);
            }
        }


        public override void OnFinished()
        {
            //移除Unity
            if (this.BulletUnit != null && !this.BulletUnit.IsDisposed)
            {
                this.BulletUnit.GetParent<UnitComponent>().Remove(BulletUnit.Id);
            }
            this.Clear();
        }
    }
}
