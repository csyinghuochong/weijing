using System.Collections.Generic;
using System.Text;

namespace ET
{

    public static class StringBuilderHelper
    {

        public static string ToonBasic = "Toon/Basic";
        public static string Ill_HighLight = "Custom/Ill_HighLight";
        public static string Ill_RimLight = "Custom/Ill_RimLight";

        public static string RoleBoneSet = "RoleBoneSet";

        public static string Skill_ComTargetMove_RangDamge_2 = "Skill_ComTargetMove_RangDamge_2";

        public static List<string> NoEffectSkills = new List<string>()
        {
            "Skill_ComTargetMove_RangDamge_1",
            "Skill_ComTargetMove_RangDamge_2",
        };
        
        public static string MainCity = "101";

        public static string GuangHuan = "GuangHuan";

        public static string UI_pro_4_2 = "UI_pro_4_2";
        public static string UI_pro_3_2 = "UI_pro_3_2";
        public static string UI_pro_3_4 = "UI_pro_3_4";

        public static string 族长 = "族长";
        public static string 成员 = "成员";


        public static StringBuilder stringBuilder = new StringBuilder();

        public static string GetFps()
        {
            return string.Empty;
        }
    }
}