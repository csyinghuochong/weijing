using System.Collections.Generic;

namespace ET
{
    public class SkillManagerComponent : Entity, IAwake, IDestroy
    {

        public List<SkillInfo> DelaySkillList = new List<SkillInfo>();
        public List<SkillHandler> Skills = new List<SkillHandler>();

        public Dictionary<int, SkillCDList> SkillCDs = new Dictionary<int, SkillCDList>();  //技能CD列表
        public long SkillPublicCDTime;      //公共CD

        public int FangunSkillId;
        public int FangunComboNumber;
        public long FangunLastTime;

        public long Timer;
    }
}
