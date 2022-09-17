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
        PlayerIcon,
        MulLanguageIcon,
    }

    public static class ABAtlasHelp
    {
        public static string GetAtlasPath_2(string path, string name)
        {
            return $"Assets/Bundles/Icon/{path}/{name}.png";
        }

        public static Sprite GetIconSprite(ABAtlasTypes types, string icon)
        {
            //if (GlobalHelp.GetVersion() > 4)
            var path = GetAtlasPath_2(types.ToString(), icon);
            Sprite prefab =  ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            //SpriteAtlas atlas = prefab.Get<SpriteAtlas>(types.ToString());
            //var code_1 = ABPathHelper.GetAtlasPath_2();
            //var request1 = libx.Assets.LoadAssetAsync(code_1, typeof(Sprite));
            return prefab;
        }

        public static Sprite GetIconSprite_2(ABAtlasTypes types, string icon)
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
            GameObject prefab = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            SpriteAtlas atlas = prefab.Get<SpriteAtlas>(types.ToString());
            //SpriteAtlas atlas = ResourcesComponent.Instance.LoadAsset<SpriteAtlas>(path);
            //Sprite spr = atlas.GetSprite(icon);
            return atlas.GetSprite(icon);
        }

    }
}
