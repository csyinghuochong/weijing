using System;
using UnityEngine;

namespace ET
{
    public class RoleBuff_JiFei : BuffHandler
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="buffData"></param>
        /// <param name="theUnitFrom">buff持有者</param>
        /// <param name="theUnitBelongto">施法者</param>
        /// <param name="skillHandler"></param>
        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.OnBaseBuffInit(buffData, theUnitFrom, theUnitBelongto);
            int buff_time = this.mBuffConfig.BuffTime;
            float speed = (float)this.mBuffConfig.buffParameterValue;
            float distance = (buff_time * speed) * 0.001f;
            Vector3 dir = (theUnitBelongto.Position - theUnitFrom.Position).normalized;
            Vector3 vector3 = theUnitBelongto.Position + dir * distance;
            this.BeginTime = TimeHelper.ServerNow();
            this.StartPosition = theUnitBelongto.Position;
            this.TargetPosition = vector3;
            theUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.JiTui);
        }

        public override void OnUpdate()
        {
            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;
            float leftTime = this.mBuffConfig.BuffTime - this.PassTime;
            Vector3 curPostion = Vector3.zero;
            if (leftTime <= 0)
            {
                curPostion = this.TargetPosition;
                this.BuffState = BuffState.Finished;
            }
            else
            {
                curPostion = this.StartPosition + (this.TargetPosition - this.StartPosition).normalized * (float)this.mBuffConfig.buffParameterValue * this.PassTime * 0.001f;
            }
            this.TheUnitBelongto.Position = curPostion;
        }

        public override void OnFinished()
        {
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.JiTui);
        }

    }
}
