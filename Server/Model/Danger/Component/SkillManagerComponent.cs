using System.Collections.Generic;

namespace ET
{
    public class SkillManagerComponent : Entity, IAwake, IDestroy
    {

        public List<SkillInfo> DelaySkillList = new List<SkillInfo>();
        public List<SkillHandler> Skills = new List<SkillHandler>();

        public Dictionary<int, SkillCDItem> SkillCDs = new Dictionary<int, SkillCDItem>();  //技能CD列表
        public long SkillPublicCDTime;      //公共CD

        public int FangunSkillId;
        public int FangunComboNumber;
        public long FangunLastTime;
        public long Timer;

        public M2C_SkillCmd M2C_SkillCmd = new M2C_SkillCmd();
        public M2C_UnitFinishSkill M2C_UnitFinishSkill = new M2C_UnitFinishSkill();
    }
}
