using System;
using UnityEngine;

namespace ET
{
    public class RoleBuffQuSan : BuffHandler
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
            this.BeginTime = TimeHelper.ServerNow();

            BuffManagerComponent buffManager = theUnitFrom.GetComponent<BuffManagerComponent>();
            for (int i = buffManager.m_Buffs.Count - 1; i >= 0; i--)
            {
                SkillBuffConfig skillBuff = buffManager.m_Buffs[i].mBuffConfig;
                if (skillBuff.BuffBenefitType == 2)
                {
                    buffManager.m_Buffs[i].BuffState = BuffState.Finished;
                }
            }
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
