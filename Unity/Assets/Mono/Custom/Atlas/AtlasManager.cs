using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace KO
{
    // 此枚举需要和 naruto.protocol.config.PlotConfAvatarType 对齐
    public enum AtlasType
    {
        Item,
        Job,
        MainCityFunc,
    }

    public class AtlasManager
    {
        private static AtlasManager _instance;

        public static AtlasManager instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AtlasManager();
                }

                return _instance;
            }
        }

        private Dictionary<AtlasType, UIAtlas> mAtlases = new Dictionary<AtlasType, UIAtlas>();

        public void AddAtlas(AtlasType type, UIAtlas atlas)
        {
            if (mAtlases.ContainsKey(type))
                mAtlases[type] = atlas;
            else
                mAtlases.Add(type, atlas);
        }

        public UIAtlas GetAtlas(AtlasType type)
        {
            UIAtlas atlas = mAtlases.ContainsKey(type) ? mAtlases[type] : null;
            return atlas;
        }

        public Texture2D GetAlphaTexture(AtlasType type)
        {
            UIAtlas atlas = GetAtlas(type);
            if (atlas != null && atlas.alphaMat != null)
                return atlas.alphaMat.GetTexture("_AlphaTex") as Texture2D;
            return null;
        }

        public Sprite GetSprite(AtlasType type, string path)
        {
            UIAtlas atlas = GetAtlas(type);
            Sprite sprite = null;
            if (atlas != null)
                sprite = atlas.GetSpriteByName(path);
//#if UNITY_EDITOR
//            if (sprite == null)
//                sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>("Assets/ArtistResources/UI/[AtlasSprites]/" + type + "/" + path + ".png");
//#endif
            return sprite;
        }
    }
}
