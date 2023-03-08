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
            Vector3 TargetPoint = sourcePoint + rotation * Vector3.forward * SkillConf.SkillLiveTime * 0.001f;
            return TargetPoint;
        }

        public override void OnExecute()
        {
            this.InitSelfBuff();

            string[] paraminfos = this.SkillConf.GameObjectParameter.Split(';') ;
            int angle = this.SkillInfo.TargetAngle;
            int range = paraminfos.Length > 1 ? int.Parse(paraminfos[0]) : 0;
            int number = paraminfos.Length > 1 ? int.Parse(paraminfos[1]) : 1;
            int delta = number > 1 ? range / (number - 1) : 0;
            int starAngle = angle - (int)(range * 0.5f);

            for (int i = 0; i < number; i++)
            {
                BuffData buffData = new BuffData();
                buffData.BuffConfig = SkillBuffConfigCategory.Instance.Get(6);
                buffData.SkillConfig = this.SkillConf;
                buffData.TargetAngle = starAngle + i * delta;
                TheUnitFrom.GetComponent<BuffManagerComponent>().BulletFactory(buffData, TheUnitFrom, this);
            }
        }

        public override void OnUpdate()
        {
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
