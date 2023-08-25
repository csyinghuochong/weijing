using System;
using UnityEngine;

namespace ET
{

    /// <summary>
    /// 无视地形
    /// </summary>
    [BuffHandler]
    public class RoleBuff_JiFei : RoleBuff_Base
    {

        public override void OnUpdate()
        {
            this.BaseOnUpdate();

            float leftTime = this.mSkillBuffConf.BuffTime * 0.001f - this.PassTime;
            Vector3 curPostion = Vector3.zero;
            if (leftTime <= 0)
            {
                curPostion = this.BuffData.TargetPostion;
                this.BuffState = BuffState.Finished;
            }
            else
            {
                curPostion = this.StartPosition + (this.BuffData.TargetPostion - this.StartPosition).normalized * (float)this.mSkillBuffConf.buffParameterValue * this.PassTime;
            }
            this.TheUnitBelongto.Position = curPostion;
        }
    }
}
