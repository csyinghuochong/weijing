using System.Collections.Generic;
using System.Text;

namespace ET
{

    public static class StringBuilderHelper
    {

        public static string ToonBasic = "Toon/Basic";
        public static string ToonBasicOutline = "Toon/BasicOutline";
        public static string Ill_HighLight = "Custom/Ill_HighLight";
        public static string Ill_RimLight = "Custom/Ill_RimLight";
        public static string SimpleAlpha = "Custom/SimpleAlpha";

        public static string RoleBoneSet = "RoleBoneSet";


        public static string Skill_Halo_2 = "Skill_Halo_2";
        public static string Skill_ComTargetMove_RangDamge_2 = "Skill_ComTargetMove_RangDamge_2";

        public static List<string> NoEffectSkills = new List<string>()
        {
            "Skill_ComTargetMove_RangDamge_1",
            "Skill_ComTargetMove_RangDamge_2",
             "Skill_Follow_Damge_1",
            "Skill_Range_Bomb_1",
        };


        public static List<string> AiCheckList = new List<string>()
        {
           "AI_XunLuo",
           "AI_ZhuiJi",
           "AI_LocalDungeon"
        };
        
        public static string MainCity = "101";

        public static string GuangHuan = "GuangHuan";

        public static string UI_pro_4_2 = "UI_pro_4_2";
        public static string UI_pro_3_2 = "UI_pro_3_2";
        public static string UI_pro_3_4 = "UI_pro_3_4";

        public static string 族长 = "族长";
        public static string 成员 = "成员";

        public static string ai_1 = "AI_XunLuo";
        public static string ai_2 = "AI_ZhuiJi";
        public static string ai_3 = "AI_LocalDungeon";

        public static string 内存占用 = "内存占用:";

        public static StringBuilder stringBuilder = new StringBuilder();

        public static string GetFps()
        {
            return string.Empty;
        }

        public static string GetGemHole(List<int> gemholeid)
        {
            stringBuilder.Clear();
            for (int i = 0; i < gemholeid.Count; i++)
            {
                stringBuilder.Append(gemholeid[i]);
                if (i < gemholeid.Count - 1)
                {
                    stringBuilder.Append('_');
                }
            }
            return stringBuilder.ToString();
        }

    }
}