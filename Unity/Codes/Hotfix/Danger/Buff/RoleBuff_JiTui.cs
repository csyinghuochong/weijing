using System;
using UnityEngine;

namespace ET
{
    [BuffHandler]
    public class RoleBuff_JiTui : RoleBuff_Base
    {

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            float leftTime = this.BuffData.BuffConfig.BuffTime * 0.001f - this.PassTime;
            Vector3 curPostion = Vector3.zero;
            if (leftTime <= 0)
            {
                curPostion = this.BuffData.TargetPosition;
                this.BuffState = BuffState.Finished;
            }
            else
            {
                curPostion = this.StartPosition + (this.BuffData.TargetPosition - this.StartPosition).normalized * (float)this.BuffData.BuffConfig.buffParameterValue * this.PassTime;
            }
            this.TheUnitBelongto.Position = curPostion;
        }
    }
}
