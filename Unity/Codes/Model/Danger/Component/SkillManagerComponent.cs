using System.Collections.Generic;

namespace ET
{

    public class SkillManagerComponent : Entity, IAwake, IDestroy
    {
        public List<ASkillHandler> Skills = new List<ASkillHandler>();
        public List<SkillCDList> SkillCDs = new List<SkillCDList>();       //冷却时间列表
        public long SkillPublicCDTime;                                                              //技能公共CD
        public int FangunSkillId;
        public long FangunLastTime;

        public long Timer;
    }

}
