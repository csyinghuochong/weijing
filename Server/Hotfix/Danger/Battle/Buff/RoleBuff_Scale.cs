using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{

    /// <summary>
    /// 缩放buff
    /// </summary>
    public class RoleBuff_Scale : BuffHandler
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
