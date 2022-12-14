using UnityEngine;

namespace ET
{

    /// <summary>
    /// 弹道类型BUFF
    /// </summary>
    public class RoleBuffBullet_1 : BuffHandler
    {
        
        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.mSkillHandler = skillHandler;
            this.OnBaseBulletInit(buffData, theUnitFrom, theUnitBelongto);
        }

        public override void OnUpdate()
        {
            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;
            if (this.PassTime <= this.DelayTime)
            {
                return;
            }

            if (TimeHelper.ServerNow() > BuffEndTime)
            {
                //Log.Info("持续伤害结束了");
                this.BuffState = BuffState.Finished;
            }

            Quaternion rotation = Quaternion.Euler(0, BuffData.TargetAngle, 0); //按照Z轴旋转30度的Quaterion
            Vector3 movePosition = rotation * Vector3.forward * ((PassTime - DelayTime) * (float)(BuffData.SkillConfig.SkillMoveSpeed)) * 0.001f;
            Vector3 currentPosition = this.StartPosition + movePosition;


            this.OnBulletUpdate(currentPosition);
        }

        public override void OnFinished()
        {
        }
    }
}
