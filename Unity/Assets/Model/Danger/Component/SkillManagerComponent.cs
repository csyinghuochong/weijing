using System.Collections.Generic;

namespace ET
{

    public class SkillManagerComponent : Entity, IAwake, IDestroy
    {
        public List<ASkillHandler> Skills = new List<ASkillHandler>();
        public List<SkillCDItem> SkillCDs = new List<SkillCDItem>();       //冷却时间列表
        public C2M_SkillCmd SkillCmd = new C2M_SkillCmd();
        public long SkillPublicCDTime;                                                              //技能公共CD
        public int FangunSkillId;
        public long FangunLastTime;

        public long Timer;
    }

}
