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
            float speed = (float)this.mBuffConfig.buffParameterValue;
            float distance = (this.mBuffConfig.buffParameterType * speed) * 0.001f;
            Vector3 dir = (theUnitBelongto.Position - theUnitFrom.Position).normalized;
            Vector3 vector3 = theUnitBelongto.Position + dir * distance;
            theUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.JiTui);
            this.BeginTime = TimeHelper.ServerNow();
            this.StartPosition = theUnitBelongto.Position;
            this.TargetPosition = vector3;
            this.TheUnitBelongto.Position = this.TargetPosition;
        }

        public override void OnUpdate()
        {
            if (TimeHelper.ServerNow() >= this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
                this.TheUnitBelongto.Position = this.StartPosition;
                Log.Console($"stop: {this.TheUnitBelongto.Position.x} {this.TheUnitBelongto.Position.z}");
                this.TheUnitBelongto.Stop(-2);
            }
        }

        public override void OnFinished()
        {
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.JiTui);
        }

    }
}
