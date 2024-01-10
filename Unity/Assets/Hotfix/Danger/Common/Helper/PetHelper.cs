using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class PetHelper
    {

        public static Dictionary<int, int> GetEquipSkillList(RolePetInfo rolePetInfo, BagComponent bagComponent)
        {
            Dictionary<int, int> hideSkillId = new Dictionary<int, int>();
            for (int i = 0; i < rolePetInfo.PetEquipList.Count; i++)
            {
                long baginfoId = rolePetInfo.PetEquipList[i];
                if (baginfoId == 0)
                {
                    continue;
                }

                BagInfo bagInfo = bagComponent.GetItemByLoc(ItemLocType.PetLocEquip, baginfoId);
                if (bagInfo == null || !ItemConfigCategory.Instance.Contain(bagInfo.ItemID))
                {
                    continue;
                }

                for (int skill = 0; skill < bagInfo.HideSkillLists.Count; skill++)
                {
                    int skillId = bagInfo.HideSkillLists[skill];
                    if (!hideSkillId.ContainsKey(skillId))
                    {
                        hideSkillId.Add(skillId, 0);
                    }
                    hideSkillId[skillId] ++;
                }
            }

            return hideSkillId;
        }

        public static (RolePetInfo, RolePetInfo) GetPetHeChengZiZhiPreview(RolePetInfo rolePetA, RolePetInfo rolePetB)
        {
            RolePetInfo rolePetInfoMin = new RolePetInfo();
            RolePetInfo rolePetInfoMax = new RolePetInfo();

            int zizhiNow_Hp_1 = rolePetA.ZiZhi_Hp;
            int zizhiNow_Act_1 = rolePetA.ZiZhi_Act;
            int zizhiNow_MageAct_1 = rolePetA.ZiZhi_MageAct;
            int zizhiNow_Def_1 = rolePetA.ZiZhi_Def;
            int zizhiNow_Adf_1 = rolePetA.ZiZhi_Adf;
            int zizhiNow_ActSpeed_1 = rolePetA.ZiZhi_ActSpeed;
            float zizhiNow_ChengZhang_1 = rolePetA.ZiZhi_ChengZhang;

            int zizhiNow_Hp_2 = rolePetB.ZiZhi_Hp;
            int zizhiNow_Act_2 = rolePetB.ZiZhi_Act;
            int zizhiNow_MageAct_2 = rolePetB.ZiZhi_MageAct;
            int zizhiNow_Def_2 = rolePetB.ZiZhi_Def;
            int zizhiNow_Adf_2 = rolePetB.ZiZhi_Adf;
            int zizhiNow_ActSpeed_2 = rolePetB.ZiZhi_ActSpeed;
            float zizhiNow_ChengZhang_2 = rolePetB.ZiZhi_ChengZhang;

            rolePetInfoMin.ZiZhi_Hp = Mathf.Min((int)(Mathf.Min(zizhiNow_Hp_1, zizhiNow_Hp_2) * 0.95f),3200);
            rolePetInfoMin.ZiZhi_Act = Mathf.Min((int)(Mathf.Min(zizhiNow_Act_1, zizhiNow_Act_2) * 0.95f), 1600);
            rolePetInfoMin.ZiZhi_MageAct = Mathf.Min((int)(Mathf.Min(zizhiNow_MageAct_1, zizhiNow_MageAct_2) * 0.95f), 1600);
            rolePetInfoMin.ZiZhi_Def = Mathf.Min((int)(Mathf.Min(zizhiNow_Def_1, zizhiNow_Def_2) * 0.95f), 1600);
            rolePetInfoMin.ZiZhi_Adf = Mathf.Min((int)(Mathf.Min(zizhiNow_Adf_1, zizhiNow_Adf_2) * 0.95f), 1600);
            rolePetInfoMin.ZiZhi_ActSpeed = Mathf.Min((int)(Mathf.Min(zizhiNow_ActSpeed_1, zizhiNow_ActSpeed_2) * 0.95f), 1600);
            rolePetInfoMin.ZiZhi_ChengZhang = (float)(Mathf.Min(zizhiNow_ChengZhang_1, zizhiNow_ChengZhang_2) * 0.95f);

            rolePetInfoMax.ZiZhi_Hp = Mathf.Min((int)(Mathf.Max(zizhiNow_Hp_1, zizhiNow_Hp_2) * 1.05f), 3200);
            rolePetInfoMax.ZiZhi_Act = Mathf.Min((int)(Mathf.Max(zizhiNow_Act_1, zizhiNow_Act_2) * 1.05f), 1600);
            rolePetInfoMax.ZiZhi_MageAct = Mathf.Min((int)(Mathf.Max(zizhiNow_MageAct_1, zizhiNow_MageAct_2) * 1.05f), 1600);
            rolePetInfoMax.ZiZhi_Def = Mathf.Min((int)(Mathf.Max(zizhiNow_Def_1, zizhiNow_Def_2) * 1.05f), 1600);
            rolePetInfoMax.ZiZhi_Adf = Mathf.Min((int)(Mathf.Max(zizhiNow_Adf_1, zizhiNow_Adf_2) * 1.05f), 1600);
            rolePetInfoMax.ZiZhi_ActSpeed = Mathf.Min((int)(Mathf.Max(zizhiNow_ActSpeed_1, zizhiNow_ActSpeed_2) * 1.05f), 1600);
            rolePetInfoMax.ZiZhi_ChengZhang = (float)(Mathf.Max(zizhiNow_ChengZhang_1, zizhiNow_ChengZhang_2) * 1.05f);

            return (rolePetInfoMin, rolePetInfoMax);
        }

        public static float Pet_HeCheng_ZiZhi(float zizhiValue_1, float zizhiValue_2, float maxZiZhi = 99999, string ziZhiType = "0")
        {
            float ZiZhimin = Mathf.Min(zizhiValue_1, zizhiValue_2);
            float ZiZhimax = Mathf.Max(zizhiValue_1, zizhiValue_2);

            ZiZhimin = ZiZhimin * 0.95f;
            ZiZhimax = ZiZhimax * 1.05f;

            float chaValuie = ZiZhimax - ZiZhimin;

            float zhizhiValue = ZiZhimin + chaValuie * RandomHelper.RandFloat01();

            //限制最高资质
            if (zhizhiValue > maxZiZhi)
            {
                zhizhiValue = maxZiZhi;
            }

            return (float)Math.Round(zhizhiValue, 2);
        }

        public static int GetPetMaxNumber(Unit unit, int level)
        {
            int petNumber = 1;
            string[] petInfos = GlobalValueConfigCategory.Instance.Get(34).Value.Split('@');
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            for (int i = 0; i < petInfos.Length; i++)
            {
                string[] numberInfos = petInfos[i].Split(';');
                petNumber = int.Parse(numberInfos[1]);
                if (level <= int.Parse(numberInfos[0]))
                {
                    return petNumber + numericComponent.GetAsInt(NumericType.PetExtendNumber);
                }
            }

            return petNumber + numericComponent.GetAsInt(NumericType.PetExtendNumber);
        }

        public static void UpdatePetNumeric(RolePetInfo rolePetInfo)
        {
            for (int i = 0; i < rolePetInfo.Ks.Count; i++)
            {
                Update(rolePetInfo, rolePetInfo.Ks[i]);
            }
        }

        public static long GetByKey(RolePetInfo rolePetInfo, int key)
        {
            long value = 0;
            for (int i = 0; i < rolePetInfo.Ks.Count; i++)
            {
                if (rolePetInfo.Ks[i] == key)
                {
                    return rolePetInfo.Vs[i];
                }
            }

            return value;
        }

        public static float GetAsFloat(RolePetInfo rolePetInfo, int numericType)
        {
            return (float)GetByKey(rolePetInfo, numericType) / 10000;
        }

        public static void Update(RolePetInfo rolePetInfo, int numericType)
        {
            if (numericType < (int)NumericType.Max)
            {
                return;
            }

            int nowValue = (int)numericType / 100;

            int add = nowValue * 100 + 1;
            int mul = nowValue * 100 + 2;
            int finalAdd = nowValue * 100 + 3;
            int buffAdd = nowValue * 100 + 11;
            int buffMul = nowValue * 100 + 12;
            long old = GetByKey(rolePetInfo, nowValue);
            long nowPropertyValue = (long)
            (
                (GetByKey(rolePetInfo, add) * (1 + GetAsFloat(rolePetInfo, mul)) + GetByKey(rolePetInfo, finalAdd)) *
                (1 + GetAsFloat(rolePetInfo, buffMul))
                + GetByKey(rolePetInfo, buffAdd)
            );

            int keyIndex = rolePetInfo.Ks.IndexOf(nowValue);
            if (keyIndex == -1)
            {
                rolePetInfo.Ks.Add(nowValue);
                rolePetInfo.Vs.Add(nowPropertyValue);
            }
            else
            {
                rolePetInfo.Vs[keyIndex] = nowPropertyValue;
            }
        }

        /// <summary>
        /// 宠物当前是第一个皮肤为普通宠物 其他皮肤是变异宠物
        /// </summary>
        /// <param name="rolePetInfo"></param>
        /// <returns></returns>
        public static bool IsBianYI(RolePetInfo rolePetInfo)
        {
            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            return petConfig.Skin[0] != rolePetInfo.SkinId;
        }

        public static void CheckPropretyPoint(RolePetInfo rolePetInfo)
        {
            int maxPoint = (rolePetInfo.PetLv - 1) * 5;
            if (!string.IsNullOrEmpty(rolePetInfo.AddPropretyValue))
            {
                string[] attributeinfos = rolePetInfo.AddPropretyValue.Split('_');
                int pro_LiLiang = int.Parse(attributeinfos[0]);
                int pro_ZhiLi = int.Parse(attributeinfos[1]);
                int pro_TiZhi = int.Parse(attributeinfos[2]);
                int pro_NaiLi = int.Parse(attributeinfos[3]);
                int allValue = pro_LiLiang + pro_ZhiLi + pro_TiZhi + pro_NaiLi;

                if (pro_LiLiang < 0 || pro_ZhiLi < 0 || pro_TiZhi < 0 || pro_NaiLi < 0
                    || rolePetInfo.AddPropretyNum < 0 || allValue > maxPoint)
                {
                    rolePetInfo.AddPropretyValue = ItemHelper.DefaultGem;
                    rolePetInfo.AddPropretyNum = (rolePetInfo.PetLv - 1) * 5;
                }
            }
        }

        public static List<int> GetAllShenShou()
        {
            List<int> shenshous = new List<int>();
            foreach (var item in PetConfigCategory.Instance.GetAll())
            {
                if (item.Value.PetType == 2)
                {
                    shenshous.Add(item.Key);
                }
            }

            return shenshous;
        }

        /// <summary>
        /// 2000001 2000001
        /// </summary>
        /// <param name="rolePetInfos"></param>
        /// <returns></returns>
        public static bool IsHaveShenShou(List<RolePetInfo> rolePetInfos)
        {
            List<int> allshenshous = GetAllShenShou();

            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                int index = allshenshous.IndexOf(rolePetInfos[i].ConfigId);
                if (index != -1)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 2000001 2000001
        /// </summary>
        /// <param name="rolePetInfos"></param>
        /// <returns></returns>
        public static bool IsShenShouFull(List<RolePetInfo> rolePetInfos)
        {
            List<int> allshenshous = GetAllShenShou();

            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                int index = allshenshous.IndexOf(rolePetInfos[i].ConfigId);
                if (index != -1)
                {
                    allshenshous.RemoveAt(index);
                }
            }

            return allshenshous.Count == 0;
        }

        public static int GetBagPetNum(List<RolePetInfo> rolePetInfos)
        {
            return rolePetInfos.Count - GetCangKuPetNum(rolePetInfos);
        }

        public static int GetCangKuPetNum(List<RolePetInfo> rolePetInfos)
        {
            int number = 0;
            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                if (rolePetInfos[i].PetStatus == 3)
                {
                    number++;
                }
            }

            return number;
        }

        public static int GetCangKuOpenLv(int num)
        {
            foreach (var item in JiaYuanConfigCategory.Instance.GetAll())
            {
                if (item.Value.PetNum >= num)
                {
                    return item.Key;
                }
            }

            return -1;
        }

        //宠物评分
        public static int PetPingJia(RolePetInfo petinfo)
        {
            int fightValue = 0;
            float fightValueFloat = 0f;

            //宠物资质
            fightValue += (int)(petinfo.ZiZhi_Act / 2);
            fightValue += (int)(petinfo.ZiZhi_Adf / 2);
            fightValue += (int)(petinfo.ZiZhi_Def / 2);
            fightValue += (int)(petinfo.ZiZhi_Hp / 4);
            fightValue += (int)(petinfo.ZiZhi_MageAct / 2);

            float addfloat = petinfo.ZiZhi_ChengZhang - 1;

            /*
            if (addfloat >= 0) {
                addfloat = addfloat * 5f;
            }
            */
            if (addfloat > 0)
            {
                fightValueFloat = addfloat * 5f + 1;
            }
            else
            {
                fightValueFloat = petinfo.ZiZhi_ChengZhang;
            }
            //fightValueFloat = petinfo.ZiZhi_ChengZhang * 5f;

            //宠物技能评分
            for (int i = 0; i < petinfo.PetSkill.Count; i++)
            {
                if (petinfo.PetSkill[i] >= 80001001 && petinfo.PetSkill[i] < 80001999)
                {
                    fightValueFloat += 0.05f;
                }

                if (petinfo.PetSkill[i] >= 80002001 && petinfo.PetSkill[i] < 80002999)
                {
                    fightValueFloat += 0.15f;
                }
            }

            fightValue = (int)((float)fightValue * fightValueFloat);

            //fightValue += (int)(petinfo.ZiZhi_ChengZhang * 3000);

            return fightValue;
        }

        public static bool IsShenShou(int configid)
        {
            return PetConfigCategory.Instance.Get(configid).PetType == 2;
        }

        public static bool HavePetHeXin(RolePetInfo rolePetInfo)
        {
            for (int i = 0; i < rolePetInfo.PetHeXinList.Count; i++)
            {
                if (rolePetInfo.PetHeXinList[i] > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void CheckPetPosition(List<long> petTeamList, List<long> petMingPosition)
        {
            ///移除
            for (int i = 0; i < petMingPosition.Count; i++)
            {
                long petid = petMingPosition[i];
                if (petid == 0)
                {
                    continue;
                }

                bool have = false;
                for (int pp = 0; pp < petTeamList.Count; pp++)
                {
                    if (petid == petTeamList[pp])
                    {
                        have = true;
                        break;
                    }
                }

                if (!have)
                {
                    petMingPosition[i] = 0;
                }
            }

            //新增
            for (int i = 0; i < petTeamList.Count; i++)
            {
                int teamid = i / 5;
                long petid = petTeamList[i];
                if (petid == 0)
                {
                    continue;
                }

                bool have = false;
                for (int pp = 0; pp < petMingPosition.Count; pp++)
                {
                    if (petMingPosition[pp] != petid)
                    {
                        continue;
                    }

                    if ((pp / 9) != teamid)
                    {
                        petMingPosition[pp] = 0;
                    }
                    else
                    {
                        have = true;
                        break;
                    }
                }

                if (have)
                {
                    continue;
                }

                for (int pp = teamid * 9; pp < teamid * 9 + 9; pp++)
                {
                    if (petMingPosition[pp] == 0)
                    {
                        petMingPosition[pp] = petid;
                        break;
                    }
                }
            }
        }
    }
}