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

            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';') ;
            int angle = this.SkillCmd.TargetAngle;
            int range = 0;
            int number = 1;
            int starAngle = angle - (int)(range * 0.5f);
            if (paraminfos.Length == 2)
            {
                range = int.Parse(paraminfos[0]);
                number = int.Parse(paraminfos[1]);
            }

            for (int i = 0; i < number; i++)
            {
                BuffData buffData = new BuffData();
                buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get(6);
                buffData.BuffClassScript = buffData.BuffConfig.BuffScript;
                buffData.SkillConfig = this.SkillConf;
                buffData.TargetAngle = starAngle + i * (range / (number - 1));
                TheUnitFrom.GetComponent<BuffManagerComponent>().BulletFactory(buffData, TheUnitFrom, this);
            }
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
