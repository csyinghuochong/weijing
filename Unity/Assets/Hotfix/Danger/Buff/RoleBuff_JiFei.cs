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
                this.BaseOnUpdate();
                float leftTime = this.mSkillBuffConf.buffParameterType * 0.001f - this.PassTime;
                if (leftTime <= 0f)
                {
                    this.TheUnitBelongto.Position = this.BuffData.TargetPostion;
                    Log.ILog.Debug($"leftTime: {leftTime}   {this.BuffData.TargetPostion.x} {this.BuffData.TargetPostion.z}");
                    break;
                }
                else
                {
                    this.TheUnitBelongto.Position = this.StartPosition + (this.BuffData.TargetPostion - this.StartPosition).normalized * (float)this.mSkillBuffConf.buffParameterValue * this.PassTime;
                    Log.ILog.Debug($"leftTime: {leftTime}   {this.TheUnitBelongto.Position.x} {this.TheUnitBelongto.Position.z}");
                }
                await TimerComponent.Instance.WaitFrameAsync();
                if (this.BuffState != BuffState.Running)
                {
                    break;
                }
            }
        }
    }
}
