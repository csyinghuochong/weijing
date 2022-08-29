using UnityEngine;
using UnityEngine.U2D;

namespace ET
{

    public enum ABAtlasTypes
    {
        BuffIcon,
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
        UIPlayerIcon,
        MulLanguageIcon,
    }

    public static class ABAtlasHelp
    {


        public static Sprite GetIconSprite(ABAtlasTypes types, string icon)
        {
            var path = ABPathHelper.GetAtlasPath(types.ToString());
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            SpriteAtlas atlas = prefab.Get<SpriteAtlas>(types.ToString());
            //SpriteAtlas atlas = ResourcesComponent.Instance.LoadAsset<SpriteAtlas>(path);
            Sprite spr = atlas.GetSprite(icon);
            return spr;
        }

        public static async ETTask<Sprite> GetIconSpriteAsync(ABAtlasTypes types, string icon)
        {
            var path = ABPathHelper.GetAtlasPath(types.ToString());
            await ETTask.CompletedTask;
            GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            SpriteAtlas atlas = prefab.Get<SpriteAtlas>(types.ToString());
            //SpriteAtlas atlas = ResourcesComponent.Instance.LoadAsset<SpriteAtlas>(path);
            //Sprite spr = atlas.GetSprite(icon);
            return atlas.GetSprite(icon);
        }

    }
}
