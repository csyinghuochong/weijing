using System.Collections.Generic;
using UnityEngine;

namespace KO.UI.Common.Atlas
{
    [System.Serializable]
    public class SpriteCache
    {
        public bool IsAvailable
        {
            get { return Sprite != null; }
        }

        [System.NonSerialized]
        public SpriteCacheGroup Group;
        public string Name;
        public Sprite Sprite;
        public float Width;
        public float Height;
    }

    [System.Serializable]
    public class SpriteCacheGroup
    {
        public Texture2D Texture;
        public List<SpriteCache> Sprites = new List<SpriteCache>();
    }

    [System.Serializable]
    public class AtlasCache
    {
        public bool Used = false;
        public string DefaulSpriteName;
        public List<SpriteCacheGroup> Groups = new List<SpriteCacheGroup>();
        private Dictionary<string, SpriteCache> mSpriteDict;
        private SpriteCache mDefault;

        public Sprite GetSpriteByName(string name)
        {
            SpriteCache spriteCache = GetSpriteCacheByName(name);
            if (spriteCache == null)
                return null;
            return spriteCache.Sprite;
        }

        public SpriteCache GetDefaultSprite()
        {
            if (mDefault != null)
                return mDefault;
            if (!string.IsNullOrEmpty(DefaulSpriteName))
            {
                mDefault = GetSpriteCacheByName(DefaulSpriteName);
                return mDefault;
            }
            return null;
        }

        public SpriteCache GetSpriteCacheByName(string name)
        {
#if UNITY_EDITOR
            if (!Application.isPlaying)
            {
                for (int i = 0; i < Groups.Count; i++)
                {
                    SpriteCacheGroup spriteCacheGroup = Groups[i];
                    for (int j = spriteCacheGroup.Sprites.Count - 1; j >= 0; j--)
                    {
                        SpriteCache spriteCache = spriteCacheGroup.Sprites[j];
                        if (!spriteCache.IsAvailable)
                        {
                            spriteCacheGroup.Sprites.RemoveAt(j);
                        }
                        else if (spriteCache.Name == name)
                        {
                            spriteCache.Group = spriteCacheGroup;
                            return spriteCache;
                        }
                    }
                }
                if (name == DefaulSpriteName)
                {
                    return null;
                }
                return GetDefaultSprite();
            }
#endif

            if (mSpriteDict == null)
            {
                mSpriteDict = new Dictionary<string, SpriteCache>();
                for (int i = 0; i < Groups.Count; i++)
                {
                    SpriteCacheGroup spriteCacheGroup = Groups[i];
                    for (int j = spriteCacheGroup.Sprites.Count - 1; j >= 0; j--)
                    {
                        SpriteCache spriteCache = spriteCacheGroup.Sprites[j];
                        if (!spriteCache.IsAvailable)
                        {
                            spriteCacheGroup.Sprites.RemoveAt(j);
                        }
                        spriteCache.Group = spriteCacheGroup;
                        mSpriteDict[spriteCache.Name] = spriteCache;
                    }
                }
            }

            if (mSpriteDict != null)
            {
                SpriteCache spriteCache = null;
                if (!string.IsNullOrEmpty(name) && mSpriteDict.TryGetValue(name, out spriteCache))
                    return spriteCache;
                if (name == DefaulSpriteName)
                    return null;
                return GetDefaultSprite();
            }

            return null;
        }
    }
}