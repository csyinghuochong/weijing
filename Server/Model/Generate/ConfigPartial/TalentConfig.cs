using System;
using System.Collections.Generic;

namespace ET
{
    public partial class TalentConfigCategory
    {

        public Dictionary<int, List<int>> SkillToTalentList = new Dictionary<int, List<int>>();

        public override void AfterEndInit()
        {

            // 得到所有技能的基础技能
            foreach (TalentConfig talentConfig in this.GetAll().Values)
            {
                string[] addPropreListStr = talentConfig.AddPropreListStr.Split("@");

                for (int k = 0; k < addPropreListStr.Length; k++)
                {
                    string[] properInfo = addPropreListStr[k].Split(";");

                    switch (properInfo[0])
                    {
                        case TianFuProEnum.SkillIdAdd:

                            int skillId = int.Parse(properInfo[1]);

                            if (!SkillToTalentList.ContainsKey(skillId))
                            {
                                SkillToTalentList.Add(skillId, new List<int>());
                                //Console.WriteLine($"SkillToTalentList.ContainsKey:  天赋ID1 {talentConfig.Id}  天赋ID2  {SkillToTalentList[skillId]}  含有相同技能ID {skillId}  ");
                            }
                            SkillToTalentList[skillId].Add(talentConfig.Id);
                            break;
                        default:
                            break;
                    }
                }

            }
        }


        public List<int> GetSkillToTalentId(int skillid)
        {
            if (SkillToTalentList.ContainsKey(skillid))
            {
                return SkillToTalentList[skillid];
            }
            return null;
        }
    }
}
