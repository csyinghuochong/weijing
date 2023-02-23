using System.Collections.Generic;

namespace ET
{
    public class SkillSetComponent : Entity, IAwake, ITransfer, IUnitCache
    {
        public List<int> TianFuList = new List<int>();

        public List<SkillPro> SkillList = new List<SkillPro>();

        //生命之盾
        public List<KeyValuePair> ShieldList = new List<KeyValuePair>();

        public M2C_UpdateSkillSet M2C_UpdateSkillSet = new M2C_UpdateSkillSet();    
    }
}
