using UnityEngine;
using UnityEngine.U2D;

namespace ET
{

    public enum ABAtlasTypes
    {
        ItemIcon,
        ItemQualityIcon,
        PetHeadIcon,
        PetSkillIcon,
        RoleSkillIcon,
        TianFuIcon,
        ChapterIcon,
        PropertyIcon,
        ChengJiuIcon,
        RechageIcon,
        MonsterIcon,
        TiTleIcon,
        TaskIcon,
        OtherIcon,
        PlayerIcon,
        MulLanguageIcon,
    }

    public static class ABAtlasHelp
    {
        public static Sprite GetIconSprite(ABAtlasTypes types, string icon)
        {
            var path = ABPathHelper.GetAtlasPath_2(types.ToString(), icon);
            Sprite prefab =  ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            return prefab;
        }

    }
}
