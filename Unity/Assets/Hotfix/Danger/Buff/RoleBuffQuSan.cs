
namespace ET
{
    [BuffHandler]
    public class RoleBuffQuSan : RoleBuff_Base
    {
        public override void OnInit(BuffData buffData, Unit theUnitBelongto)
        {
            this.BaseOnBulletInit(buffData, theUnitBelongto);

            BuffManagerComponent buffManager = theUnitBelongto.GetComponent<BuffManagerComponent>();
            for (int i = buffManager.m_Buffs.Count - 1; i >= 0; i--)
            {
                SkillBuffConfig skillBuff = buffManager.m_Buffs[i].BuffData.BuffConfig;
                if (skillBuff.BuffBenefitType == 2)
                {
                    buffManager.m_Buffs[i].BuffState = BuffState.Finished;
                }
            }
        }
    }
}
