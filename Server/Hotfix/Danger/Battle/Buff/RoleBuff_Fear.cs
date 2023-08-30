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
            this.TheUnitFrom.GetComponent<StateComponent>().StateTypeAdd(StateTypeEnum.Fear);
        }

        public override void OnUpdate()
        {
            if (TimeHelper.ServerNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }

            if (Vector3.Distance(this.TargetPosition, this.TheUnitFrom.Position) < 0.2f)
            {
                this.TargetPosition.x = this.TheUnitFrom.Position.x + RandomHelper.RandomNumberFloat(-10, 10);
                this.TargetPosition.y = this.TheUnitFrom.Position.y;
                this.TargetPosition.z = this.TheUnitFrom.Position.z + RandomHelper.RandomNumberFloat(-10, 10);
                this.TargetPosition = this.TheUnitFrom.DomainScene().GetComponent<MapComponent>()
                        .GetCanChongJiPath(this.TheUnitFrom.Position, TargetPosition);
                this.TheUnitFrom.FindPathMoveToAsync(this.TargetPosition).Coroutine();
            }

        }

        public override void OnFinished()
        {
            this.TheUnitBelongto.GetComponent<StateComponent>().StateTypeRemove(StateTypeEnum.Fear);
        }
    }
}
