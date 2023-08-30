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

        }

        public override void OnUpdate()
        {
            if (TimeHelper.ServerNow() > this.BuffEndTime)
            {
                this.BuffState = BuffState.Finished;
            }
        }

        public override void OnFinished()
        {
        }
    }
}
