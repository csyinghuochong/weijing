using UnityEngine;

namespace ET
{

    //子弹1
    public class Skill_ComTargetMove_RangDamge_1 : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);

            //60; 5; 0.3; 3
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');//0;1;0.3;2  90011941
            if (paraminfos.Length >= 4)
            {
                this.SkillTriggerLastTime = 0;
                this.SkillTriggerInvelTime = (long)(float.Parse(paraminfos[2]) * 1000);
                this.SkillExcuteNum = int.Parse(paraminfos[3]);
            }
            else
            {
                this.SkillExcuteNum = 1;
            }
        }

        public Vector3 GetBulletTargetPoint(int angle)
        {
            Vector3 sourcePoint = TheUnitFrom.Position;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            Vector3 TargetPoint = sourcePoint + rotation * Vector3.forward * SkillConf.SkillLiveTime * (float)SkillConf.SkillMoveSpeed * 0.001f;
            return TargetPoint;
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
            long serverTime = TimeHelper.ServerNow();
            if (serverTime - this.SkillTriggerLastTime < this.SkillTriggerInvelTime)
            {
                return;
            }

            this.HurtIds.Clear();
            this.SkillTriggerLastTime = serverTime;
            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';');
            int angle = this.SkillInfo.TargetAngle;
            int range = paraminfos.Length > 1 ? int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ? range / (number - 1) : 0;
            int starAngle = angle - (int)(range * 0.5f);
            for (int i = 0; i < number; i++)
            {
                Vector3 targetpos = this.GetBulletTargetPoint(starAngle + i * delta);
                Unit unit = UnitFactory.CreateBullet(this.TheUnitFrom.DomainScene(), this.TheUnitFrom.Id, this.SkillConf.Id, 0, this.TheUnitFrom.Position, new CreateMonsterInfo());
                unit.AddComponent<RoleBullet1Componnet>().OnBaseBulletInit(this, this.TheUnitFrom.Id);
                unit.BulletMoveToAsync(targetpos).Coroutine();
            }
            this.SkillExcuteNum--;
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();

            this.CreateBullet();

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
    }
}
