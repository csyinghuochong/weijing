using System.Collections.Generic;

namespace ET
{
    public static class PetHelper
    {

        public static List<int> GetAllShenShou()
        { 
            List<int> shenshous = new List<int>();
            foreach (var item in PetConfigCategory.Instance.GetAll())
            {
                if (item.Value.PetType == 2)
                {
                    shenshous.Add( item.Key );
                }
            }

            return shenshous;
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
                if (index!= -1)
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
            foreach(var item in JiaYuanConfigCategory.Instance.GetAll())
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
            return configid == 2000001 || configid == 2000002 || configid == 2000003;
        }
    }
}
