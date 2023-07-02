using System.Collections.Generic;

namespace ET
{
    public partial class MonsterConfigCategory
    {

        public List<int> NoSkillMonsterList = new List<int>();

        public override void AfterEndInit()
        {
            foreach (MonsterConfig monsterConfig in this.GetAll().Values)
            {
                if(monsterConfig.ActSkillID != 70000001)
                {
                    continue;
                }
                int[] skillids = monsterConfig.SkillID;
                if (skillids != null)
                {
                    for (int i = 0; i < skillids.Length; i++)
                    {
                        if (skillids[i] != 0)
                        {
                            continue;
                        }
                    }
                }

                NoSkillMonsterList.Add(monsterConfig.Id);
            }
        }
    }
}
