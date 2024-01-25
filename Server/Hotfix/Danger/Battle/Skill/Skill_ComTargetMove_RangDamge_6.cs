using UnityEngine;

namespace ET
{
    /// <summary>
    /// 向前方释放一个火球火球移动过程造成一次伤害，移动x秒后位置固定，并且对周围造成持续伤害持续伤害间隔时间，中途碰撞时是否停下
    /// 参数（移动时间，伤害间隔时间，碰撞是否停下）
    /// </summary>
    public class Skill_ComTargetMove_RangDamge_6: SkillHandler
    {
        private long MoveTime;
        private int IsStop;

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            this.MoveTime = (long)(float.Parse(paraminfos[0]) * 1000);
            this.SkillTriggerInvelTime = (long)(float.Parse(paraminfos[1]) * 1000);
            this.IsStop = int.Parse(paraminfos[2]);

            this.SkillExcuteNum = 1;
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();
            this.OnUpdate();
        }

        public override void OnUpdate()
        {
            this.CreateBullet();
            if (TimeHelper.ServerNow() > SkillEndTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
        }

        public override void OnFinished()
        {
            this.Clear();
        }

        public void CreateBullet()
        {
            if (TimeHelper.ServerNow() < this.SkillExcuteHurtTime)
            {
                return;
            }

            if (this.SkillExcuteNum <= 0)
            {
                return;
            }

            Unit unit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, this.TheUnitFrom.Position,
                new CreateMonsterInfo());
            unit.AddComponent<RoleBullet6Componnet>().OnBaseBulletInit(this, this.TheUnitFrom.Id, this.IsStop);
            Vector3 sourcePoint = this.TheUnitFrom.Position;
            Quaternion rotation = Quaternion.Euler(0, this.SkillInfo.TargetAngle, 0);
            Vector3 TargetPoint = sourcePoint + rotation * Vector3.forward * this.MoveTime * (float)SkillConf.SkillMoveSpeed * 0.001f;
            unit.BulletMoveToAsync(TargetPoint).Coroutine();
            this.SkillExcuteNum--;
        }
    }
}