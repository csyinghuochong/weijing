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

        public override void OnExecute()
        {
            this.EffectInstanceId = this.PlayBuffEffects();
            this.BuffState = BuffState.Running;
            ChangePosition().Coroutine();
        }

        public async ETTask ChangePosition()
        { 
            while (this.BuffState == BuffState.Running) 
            {
                await TimerComponent.Instance.WaitFrameAsync();
                this.BaseOnUpdate();
                if (this.BuffState != BuffState.Running)
                {
                    break;
                }
                float leftTime = this.mSkillBuffConf.BuffTime * 0.001f - this.PassTime;
                Vector3 curPostion;
                if (leftTime > 0)
                {
                    curPostion = this.StartPosition + (this.BuffData.TargetPostion - this.StartPosition).normalized * (float)this.mSkillBuffConf.buffParameterValue * this.PassTime;
                    this.TheUnitBelongto.Position = curPostion;
                }
                else
                {
                    curPostion = this.BuffData.TargetPostion;
                    this.TheUnitBelongto.Position = curPostion;
                    this.BuffState = BuffState.Finished;
                    break;
                }
            }
        }
    }
}
