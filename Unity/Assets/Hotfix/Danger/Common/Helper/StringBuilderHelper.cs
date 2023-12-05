using System.Collections.Generic;
using System.Text;

namespace ET
{

    public static class StringBuilderHelper
    {

        public static string ToonBasic = "Toon/Basic";
        public static string ToonBasicOutline = "Toon/BasicOutline";
        public static string Ill_HighLight = "Custom/Ill_HighLight";
        public static string SimpleAlpha = "Custom/SimpleAlpha";
        public static string Outline = "Custom/Outline";
        public static string RoleBoneSet = "RoleBoneSet";
        public static string Skill_Halo_2 = "Skill_Halo_2";
        public static string Skill_ComTargetMove_RangDamge_2 = "Skill_ComTargetMove_RangDamge_2";

        public static List<string> NoEffectSkills = new List<string>()
        {
            "Skill_ComTargetMove_RangDamge_1",
            "Skill_ComTargetMove_RangDamge_2",
            "Skill_ChainLightning",
            "Skill_ChainLightning_2",
            "Skill_Follow_Damge_1",
            "Skill_Range_Bomb_1",
            "Skill_Boomerang",
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

        public static string UnitFashionPath_1 = "Assets/Bundles/Unit/Parts/1/";
        public static string UnitFashionPath_2 = "Assets/Bundles/Unit/Parts/2/";
        public static string UnitFashionPath_3 = "Assets/Bundles/Unit/Parts/3/";
        public static string UnitFashionPath = "Assets/Bundles/Unit/Parts/Fashion/";
        public static string UnitPrefab =  ".prefab";

        public static string UIBattleFly = "Assets/Bundles/UI/Blood/UIBattleFly.prefab";

        public static string UnitEffectPath = "Assets/Bundles/Effect/";

        public static string UIDropUIPath = "Assets/Bundles/UI/Blood/UIDropItem.prefab";

        public static StringBuilder stringBuilder = new StringBuilder();

        public static string GetFps()
        {
            return string.Empty;
        }

        public static string GetPing(long ping)
        {
            stringBuilder.Clear();
            stringBuilder.Append("延迟: ");
            stringBuilder.Append(ping);
            return stringBuilder.ToString();
        }

        public static string GetMessageCnt(long cnt)
        {
            stringBuilder.Clear();
            stringBuilder.Append("数量: ");
            stringBuilder.Append(cnt);
            return stringBuilder.ToString();
        }

        public static string GetExpTip(long exp)
        {
            stringBuilder.Clear();
            stringBuilder.Append("获得");
            stringBuilder.Append(exp);
            stringBuilder.Append("经验");
            return stringBuilder.ToString();
        }

        public static string GetFashionDefault(int occ, string asset) 
        {
            string stringpath = UnitFashionPath_1;
            if (occ == 2)
            {
                stringpath = UnitFashionPath_2;
            }
            else if(occ == 3)
            {
                stringpath = UnitFashionPath_3;
            }
            stringBuilder.Clear();

            stringBuilder.Append(stringpath);
            stringBuilder.Append(asset);
            stringBuilder.Append(UnitPrefab);
            return stringBuilder.ToString();
        }

        public static string GetChatText(string playerName, string showValue)
        {
            stringBuilder.Clear();

            stringBuilder.Append(playerName);
            stringBuilder.Append(":");
            stringBuilder.Append(showValue);
            return stringBuilder.ToString();
        }

        public static string GetFashionPath(string asset)
        {
            stringBuilder.Clear();
            stringBuilder.Append(UnitFashionPath);
            stringBuilder.Append(asset);
            stringBuilder.Append(UnitPrefab);
            return stringBuilder.ToString();
        }

        public static string GetEffetPath(string asset)
        {
            stringBuilder.Clear();
            stringBuilder.Append(UnitEffectPath);
            stringBuilder.Append(asset);
            stringBuilder.Append(UnitPrefab);
            return stringBuilder.ToString();
        }

        public static string GetFallText(string addStr, long targetValue)
        {
            stringBuilder.Clear();
            stringBuilder.Append(addStr);
            stringBuilder.Append(targetValue);
            return stringBuilder.ToString();
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