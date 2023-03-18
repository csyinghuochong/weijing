using System.Collections.Generic;

namespace ET
{
    public class SkillSetComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        public int TianFuPlan = 0;

        public List<int> TianFuList = new List<int>();          //第一套天賦方案

        public List<int> TianFuList1 = new List<int>();         //第二套天賦方案

        public List<SkillPro> SkillList = new List<SkillPro>();

        //生命之盾
        public List<LifeShieldInfo> LifeShieldList = new List<LifeShieldInfo>();

        public M2C_SkillSetMessage M2C_SkillSetMessage = new M2C_SkillSetMessage() { SkillSetInfo = new SkillSetInfo() };
    }
}
