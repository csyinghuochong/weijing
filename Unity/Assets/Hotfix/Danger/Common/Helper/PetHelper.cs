namespace ET
{
    public static class PetHelper
    {

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
