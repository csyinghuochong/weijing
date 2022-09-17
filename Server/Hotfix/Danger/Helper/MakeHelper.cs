using System;
using System.Collections.Generic;

namespace ET
{
    public static class MakeHelper
    {
        public static List<int> GetInitMakeList( int makeType)
        {
            string[] makeValue = GlobalValueConfigCategory.Instance.Get(43).Value.Split(';');
            List<int> makeList = new List<int>();
            for (int i = 0; i < makeValue.Length; i++)
            {
                int makeId = int.Parse(makeValue[i]);
                if (EquipMakeConfigCategory.Instance.Get(makeId).ProficiencyType == makeType)
                {
                    makeList.Add(makeId);
                }    
            }
            return makeList;
        }


        public static int GetNewMakeID(int makeType, int makeId, List<int> learnIds)
        {
            //概率返回
            float chance = RandomHelper.RandFloat01();
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeId);
            Double lingwuPro = equipMakeConfig.LearnPro;
            if (chance > lingwuPro)
            {
                return 0;
            }

            //未学会的制造
            List<int> unLearnIds = new List<int> { };
            
            Dictionary<int, EquipMakeConfig> keyValuePairs = EquipMakeConfigCategory.Instance.GetAll();
            foreach (var item in keyValuePairs)
            {
                if (item.Value.ProficiencyType != makeType)
                {
                    continue;
                }
                if (equipMakeConfig.LearnLv != item.Value.LearnLv)
                {
                    continue;
                }
                if (learnIds.Contains(item.Key))
                {
                    continue;
                }
                unLearnIds.Add(item.Key);
            }
            if (unLearnIds.Count == 0)
            {
                return 0;
            }
            int index = RandomHelper.RandomNumber(0, unLearnIds.Count);
            return unLearnIds[index];
        }
    }
}
