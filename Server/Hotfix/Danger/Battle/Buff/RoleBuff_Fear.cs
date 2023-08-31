using System;
using UnityEngine;

namespace ET
{

    /// <summary>
    /// 恐惧BUFF. 随机移动
    /// </summary>
    public class RoleBuff_Fear : BuffHandler
    {
        public override void OnInit(BuffData buffData, Unit theUnitFrom, Unit theUnitBelongto, SkillHandler skillHandler = null)
        {
            this.OnBaseBuffInit(buffData, theUnitFrom, theUnitBelongto);
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.Fear);
            
            this.TargetPosition.x = this.TheUnitBelongto.Position.x + RandomHelper.RandomNumberFloat(-10, 10);
            this.TargetPosition.y = this.TheUnitBelongto.Position.y;
            this.TargetPosition.z = this.TheUnitBelongto.Position.z + RandomHelper.RandomNumberFloat(-10, 10);
            this.TargetPosition = this.TheUnitBelongto.DomainScene().GetComponent<MapComponent>()
                    .GetCanChongJiPath(this.TheUnitBelongto.Position, TargetPosition);
            this.TheUnitBelongto.FindPathMoveToAsync(this.TargetPosition).Coroutine();
        }

        public override void OnUpdate()
        {
            if (TimeHelper.ServerNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }

            if (Vector3.Distance(this.TargetPosition, this.TheUnitBelongto.Position) < 0.5f)
            {
                this.TargetPosition.x = this.TheUnitBelongto.Position.x + RandomHelper.RandomNumberFloat(-8, 8);
                this.TargetPosition.y = this.TheUnitBelongto.Position.y;
                this.TargetPosition.z = this.TheUnitBelongto.Position.z + RandomHelper.RandomNumberFloat(-8, 8);
                this.TargetPosition = this.TheUnitBelongto.DomainScene().GetComponent<MapComponent>()
                        .GetCanReachPath(this.TheUnitBelongto.Position, TargetPosition);
                this.TheUnitBelongto.FindPathMoveToAsync(this.TargetPosition).Coroutine();
            }

        }

        public override void OnFinished()
        {
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.Fear);
        }
    }
}
