using System.Collections.Generic;

namespace ET
{

    public class SkillManagerComponent : Entity, IAwake, IDestroy
    {
        public List<SkillInfo> t_Skills = new List<SkillInfo>();
        public List<ASkillHandler> Skills = new List<ASkillHandler>();
        public List<SkillCDItem> SkillCDs = new List<SkillCDItem>();       //冷却时间列表
        public C2M_SkillCmd SkillCmd = new C2M_SkillCmd();
        public long SkillPublicCDTime;                                                              //技能公共CD
        public int FangunSkillId;
        public long FangunLastTime;

        public long SkillMoveTime;  //1旋风斩之类的技能. 可以移动但是需要保持技能动作
        public long SkillSingTime;  //吟唱， 移动会打断施法动作

        public long Timer;
    }

}
