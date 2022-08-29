using UnityEngine;

namespace ET
{

    //子弹1
    public class Skill_ComTargetMove_RangDamge_1 : SkillHandler
    {

        public override void OnInit(SkillInfo skillId, Unit theUnitFrom)
        {
            this.BaseOnInit(skillId, theUnitFrom);
           
            OnExecute();
        }

        public Vector3 GetBulletTargetPoint(int angle)
        {
            Vector3 sourcePoint = TheUnitFrom.Position;
            Quaternion rotation = Quaternion.Euler(0, angle, 0);
            Vector3 TargetPoint = sourcePoint + rotation * Vector3.forward * ((float)SkillConf.SkillMoveSpeed* SkillLiveTime * 0.001f);
            return TargetPoint;
        }

        public override void OnExecute()
        {
            this.BaseOnExecute();

            BuffData buffData = new BuffData();
            buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get(6);
            buffData.BuffClassScript = buffData.BuffConfig.BuffScript;
            buffData.SkillConfig = this.SkillConf;
            buffData.TargetAngle = this.SkillCmd.TargetAngle;
            TheUnitFrom.GetComponent<BuffManagerComponent>().BulletFactory(buffData, TheUnitFrom, this);

            //for (int i = 0; i < 3; i++)
            //{
            //    int targetAngle = (int)(mSkillCmd.TargetAngle + 30 * (i - 1));

            //    Vector3 sourcePoint = TheUnitFrom.Position;
            //    Quaternion rotation = Quaternion.Euler(0, targetAngle, 0); //按照Z轴旋转30度的Quaterion
            //    Vector3 SkillTargetPoint = sourcePoint + rotation * Vector3.forward * mSkillCmd.TargetDistance;

            //    BuffDataBase buffData = new BuffDataBase();
            //    buffData.BuffSystemType = BuffSystemType.BUFFType_Bullet;
            //    buffData.SkillConfig = mSkillConf;
            //    buffData.mSkillActionBase = this;
            //    buffData.TargetPosition = SkillTargetPoint;
            //    BuffFactory.AcquireBuff(buffData, TheUnitFrom, TheUnitFrom);
            //}

        }

        public override void OnUpdate()
        {
            PassTime = TimeHelper.ServerNow() - this.BeginTime;
            if (PassTime > SkillLiveTime)
            {
                this.SetSkillState(SkillState.Finished);
                return;
            }
        }

        public override void OnFinished()
        {
            
        }
    }
}
