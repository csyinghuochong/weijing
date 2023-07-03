using System;
using System.Collections.Generic;

namespace ET
{
    public partial class SkillConfigCategory
    {
        public Dictionary<int, List<KeyValuePairInt>> EquipSkillList = new Dictionary<int, List<KeyValuePairInt>> ();

        public override void AfterEndInit()
        {
            foreach (SkillConfig skillconfig in this.GetAll().Values)
            {
                string equipskill = skillconfig.EquipSkill;
                if (string.IsNullOrEmpty(equipskill) || equipskill.Equals("0"))
                {
                    continue;
                }
                //61023101,61023102;61023102,61023103;61023103,61023104;61023104,61023105;61023105,61023106
                string[] skillkeys = equipskill.Split(';');
                if (skillkeys == null || skillkeys.Length != 2)
                {
                    Log.Console($"skillconfig.EquipSkill.error: {equipskill}");
                    continue;
                }

                List<KeyValuePairInt> equipSkillds = null;
                EquipSkillList.TryGetValue( skillconfig.Id, out equipSkillds);
                if (equipSkillds == null)
                {
                    equipSkillds = new List<KeyValuePairInt>();
                    EquipSkillList.Add(skillconfig.Id, equipSkillds);
                }
                try
                {
                    KeyValuePairInt keyValuePairInt = new KeyValuePairInt();
                    keyValuePairInt.KeyId = int.Parse(skillkeys[0]);
                    keyValuePairInt.Value = int.Parse(skillkeys[1]);
                    equipSkillds.Add(keyValuePairInt);
                }
                catch (Exception ex)
                {
                    Log.Console(ex.ToString());
                }
            }
        }

        public int GetNewSkill(int baseskill, int oldskiull)
        {
            List<KeyValuePairInt> equipSkillds = null;
            EquipSkillList.TryGetValue(baseskill, out equipSkillds);
            if (equipSkillds == null)
            {
                return 0;
            }

            for (int i = 0; i  < equipSkillds.Count; i++)
            {
                if (equipSkillds[i].KeyId == oldskiull)
                {
                    return (int)equipSkillds[i].Value;
                }
            }
            return 0;
        }

        public int GetOldSkill(int baseskill, int newskiull)
        {
            List<KeyValuePairInt> equipSkillds = null;
            EquipSkillList.TryGetValue(baseskill, out equipSkillds);
            if (equipSkillds == null)
            {
                return 0;
            }

            for (int i = 0; i < equipSkillds.Count; i++)
            {
                if (equipSkillds[i].Value == newskiull)
                {
                    return equipSkillds[i].KeyId;
                }
            }
            return 0;
        }
    }
}
