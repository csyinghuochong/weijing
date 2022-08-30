using System;
using System.Collections.Generic;
using KO;
using KO.UI.Common.Atlas;
using UnityEngine;

public class UIAtlasInfo : MonoBehaviour
{
    public Material GrayMaterial
    {
        get
        {
            return /*AtlasUtils.GrayMaterial;*/ null;
        }
    }

    public string defaultSpriteName;
    public Texture2D texture;
    public List<Sprite> sprites = new List<Sprite>();
    private Dictionary<string, Sprite> mSpriteCached;

    private Sprite mDefaulSprite;


    public AtlasCache Cache = new AtlasCache();

    public List<Sprite> GetSprites()
    {
        return sprites;
    }

    public void Clear()
    {
        texture = null;
        sprites.Clear();
        mSpriteCached = null;
        Cache = new AtlasCache();
    }
    
    private void Awake()
    {
        RefreshChache();
    }

    public void RefreshChache()
    {
        CreateAtlasCache();
    }

    private void CreateAtlasCache()
    {
        mSpriteCached = new Dictionary<string, Sprite>();
        for (int i = 0, c = sprites.Count; i < c; i++)
        {
            Sprite sp = sprites[i];
            if (sp == null)
                continue;
            if (!mSpriteCached.ContainsKey(sp.name))
                mSpriteCached.Add(sp.name, sp);
        }
#if !UNITY_EDITOR
        sprites.Clear();
#endif
    }

    public void Apply()
    {
        Cache.Used = true;
        Cache.DefaulSpriteName = defaultSpriteName;
        SpriteCacheGroup spriteCacheGroup = new SpriteCacheGroup();
        spriteCacheGroup.Texture = texture;
        for (int i = 0; i < sprites.Count; i++)
        {
            if (sprites[i] != null)
            {
                SpriteCache spriteCache = new SpriteCache();
                spriteCache.Sprite = sprites[i];
                spriteCache.Name = spriteCache.Sprite.name;
                spriteCache.Width = spriteCache.Sprite.textureRect.width;
                spriteCache.Height = spriteCache.Sprite.textureRect.height;
                spriteCacheGroup.Sprites.Add(spriteCache);
            }
        }
        Cache.Groups.Add(spriteCacheGroup);
        sprites.Clear();
    }
    
    public SpriteCache GetSpriteCacheByName(string name)
    {
        if (Cache.Used)
            return Cache.GetSpriteCacheByName(name);
        return null;
    }

    public Sprite GetSpriteByName(string name)
    {
        if (Cache.Used)
            return Cache.GetSpriteByName(name);

        if (mSpriteCached == null)
            RefreshChache();
        if (mSpriteCached != null)
        {
            if (!string.IsNullOrEmpty(name))
            {
                Sprite sp = null;
                if (mSpriteCached.TryGetValue(name, out sp))
                    return sp;
            }

            if (!string.IsNullOrEmpty(defaultSpriteName))
            {
                Sprite sp = null;
                if (mSpriteCached.TryGetValue(defaultSpriteName, out sp))
                    return sp;
            }

            return null;
        }

        for (int i = 0, c = sprites.Count; i < c; i++)
        {
            Sprite sp = sprites[i];
            if (sp == null)
                continue;
            if (sp.name == name)
                return sp;
        }

        if (!string.IsNullOrEmpty(defaultSpriteName) && mSpriteCached != null)
        {
            Sprite sp = null;
            if (mSpriteCached.TryGetValue(defaultSpriteName, out sp))
                return sp;
        }

        return null;
    }

    public void Remove(Sprite sprite)
    {
        if (!Cache.Used)
        {
            sprites.Remove(sprite);
        }
        else
        {
            foreach (SpriteCacheGroup spriteCacheGroup in Cache.Groups)
            {
                spriteCacheGroup.Sprites.RemoveAll(delegate(SpriteCache cache) { return cache.Name == sprite.name; });
            }
        }
    }

    public int GetSpriteCount()
    {

        if (!Cache.Used)
        {
            return sprites.Count;
        }
        else
        {
            int size = 0;
            for (int i = 0; i < Cache.Groups.Count; i++)
            {
                size += Cache.Groups[i].Sprites.Count;
            }
            return size;
        }
    }

    public void GetAllSprites(Action<string, Sprite> handle)
    {
        if (!Cache.Used)
        {
            for (int i = 0; i < sprites.Count; i++)
            {
                Sprite sp = sprites[i];
                if (sp != null)
                {
                    handle(sp.name, sp);
                }
            }
        }
        else
        {
            for (int i = 0; i < Cache.Groups.Count; i++)
            {
                SpriteCacheGroup spriteCacheGroup = Cache.Groups[i];
                for (int j = 0; j < spriteCacheGroup.Sprites.Count; j++)
                {
                    SpriteCache spriteCache = spriteCacheGroup.Sprites[j];
                    if (spriteCache.IsAvailable)
                    {
                        handle(spriteCache.Name, spriteCache.Sprite);
                    }
                }
            }
        }
    }

    public Texture2D GetMainTexture()
    {
        if (!Cache.Used)
        {
            return texture;
        }
        else
        {
            for (int i = 0; i < Cache.Groups.Count; i++)
            {
                SpriteCacheGroup spriteCacheGroup = Cache.Groups[i];
                return spriteCacheGroup.Texture;
            }
        }
        return null;
    }
}