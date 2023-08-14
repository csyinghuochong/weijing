using System;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public partial class SkillConfigCategory
    {
        public Dictionary<int, List<KeyValuePairInt>> EquipSkillList = new Dictionary<int, List<KeyValuePairInt>>();

        /// <summary>
        /// 69060301 69060302 ..的基础技能都是69060300
        /// </summary>
        public Dictionary<int, int> BaseSkillList = new Dictionary<int, int>();

        /// <summary>
        /// /待实现、  获取是技能的一级基础技能
        /// </summary>
        /// <param name="skillid"></param>
        /// <returns></returns>
        public int GetBaseSkill(int skillid)
        {
            int baseskillid = 0;
            BaseSkillList.TryGetValue(skillid, out baseskillid);
            return baseskillid;
        }

        public override void AfterEndInit()
        {
            foreach (SkillConfig skillconfig in this.GetAll().Values)
            {
                string equipskill = skillconfig.EquipSkill;
                if (string.IsNullOrEmpty(equipskill) || equipskill.Equals("0"))
                {
                    continue;
                }

                List<KeyValuePairInt> equipSkillds = null;
                EquipSkillList.TryGetValue(skillconfig.Id, out equipSkillds);
                if (equipSkillds == null)
                {
                    equipSkillds = new List<KeyValuePairInt>();
                    EquipSkillList.Add(skillconfig.Id, equipSkillds);
                }

                //61023101,61023102;61023102,61023103;61023103,61023104;61023104,61023105;61023105,61023106
                string[] skillkeys = equipskill.Split(';');
                if (skillkeys == null)
                {
                    Log.Console($"skillconfig.EquipSkill.error1: equipskillid: {skillconfig.Id}  :{equipskill}");
                    continue;
                }

                foreach (string key in skillkeys)
                {
                    try
                    {
                        string[] skillitem = key.Split(',');
                        if (skillitem.Length != 2)
                        {
                            Log.Console($"skillconfig.EquipSkill.error2: equipskillid: {skillconfig.Id} {equipskill}");
                            continue;
                        }

                        KeyValuePairInt keyValuePairInt = new KeyValuePairInt();
                        keyValuePairInt.KeyId = int.Parse(skillitem[0]);
                        keyValuePairInt.Value = int.Parse(skillitem[1]);
                        equipSkillds.Add(keyValuePairInt);
                    }
                    catch (Exception ex)
                    {
                        Log.Console(ex.ToString());
                    }
                }
            }

            List<int> baseSkills = new List<int>
            {
                69060100,
                69060200,
                69060300,
                69060400,
                69060500,
                69060600,
                69060700,
                69060800
            };
            // foreach (OccupationConfig occupationConfig in OccupationConfigCategory.Instance.GetAll().Values)
            // {
            //     baseSkills.AddRange(occupationConfig.BaseSkill);
            // }
            int baseId = 0;
            int nextId = 0;
            foreach (SkillConfig skillConfig in this.GetAll().Values)
            {
                if (baseSkills.Contains(skillConfig.Id))
                {
                    baseId = skillConfig.Id;
                    this.BaseSkillList.Add(skillConfig.Id, baseId);
                    nextId = skillConfig.NextSkillID;
                }
                else
                {
                    if (nextId == skillConfig.Id)
                    {
                        this.BaseSkillList.Add(skillConfig.Id, baseId);
                        nextId = skillConfig.NextSkillID;
                    }
                    else
                    {
                        this.BaseSkillList.Add(skillConfig.Id, 0);
                        baseId = 0;
                        nextId = 0;
                    }
                }
            }
        }


        public int GetNewSkill(List<SkillPro> skillPros,  int oldskiull)
        {
            if (skillPros == null)
            {
                return 0;
            }
            for (int i = 0; i < skillPros.Count; i++)
            {
                List<KeyValuePairInt> equipSkillds = null;
                this.EquipSkillList.TryGetValue(skillPros[i].SkillID, out equipSkillds);
                if (equipSkillds == null)
                {
                    continue;
                }

                for (int skillindex = 0; skillindex < equipSkillds.Count; skillindex++)
                {
                    if (equipSkillds[skillindex].KeyId == oldskiull)
                    {
                        return (int)equipSkillds[skillindex].Value;
                    }
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
