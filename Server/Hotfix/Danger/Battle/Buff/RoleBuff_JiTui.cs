using System;
using UnityEngine;

namespace ET
{
    public class RoleBuff_JiTui : BuffHandler
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
            int buff_time = mBuffConfig.BuffTime;
            float oldSpeed = theUnitFrom.GetComponent<NumericComponent>().GetAsFloat(NumericType.Now_Speed);
            float newSpeed = (float)mBuffConfig.buffParameterValue;
            float distance = (buff_time * newSpeed) * 0.001f;
            Vector3 dir = (theUnitBelongto.Position - theUnitFrom.Position).normalized;
            Vector3 vector3 = theUnitBelongto.Position + dir * distance;
            this.BeginTime = TimeHelper.ServerNow();
            this.StartPosition = theUnitBelongto.Position;
            this.TargetPosition = theUnitBelongto.DomainScene().GetComponent<MapComponent>().GetCanChongJiPath(theUnitBelongto.Position, vector3);

            theUnitBelongto.Stop(-1);
            theUnitBelongto.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Add, newSpeed - oldSpeed);
            theUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.JiTui);
            theUnitBelongto.FindPathMoveToAsync(this.TargetPosition, null, false).Coroutine();
        }

        public override void OnUpdate()
        {
            this.PassTime = TimeHelper.ServerNow() - this.BeginTime;
            float leftTime = this.mBuffConfig.BuffTime - this.PassTime;
            if (leftTime <= 0)
            {
                this.BuffState = BuffState.Finished;
            }
        }

        public override void OnFinished()
        {
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.JiTui);
            this.TheUnitBelongto.GetComponent<NumericComponent>().Set(NumericType.Extra_Buff_Speed_Add, 0);
        }

    }
}
