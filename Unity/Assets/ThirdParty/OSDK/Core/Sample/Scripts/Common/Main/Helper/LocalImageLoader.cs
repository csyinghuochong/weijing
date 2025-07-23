using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    // 本地图片加载器
    public static class LocalImageLoader
    {
        // 主页列表icon路径
        private const string MainIconPath = "Images/MainListIcon";

        // 首页开关icon路径
        private const string SwitchIconPath = "Images/SwitchIcon";

        // 主页列表前缀
        private const string MainIconPreFix = "icon_";

        // 缓存所有主页面icon图片
        private static readonly Dictionary<string, Sprite> MainIconMemoryCache = new Dictionary<string, Sprite>();

        // 加载主页面开关图片
        public static Sprite LoadMainSwitchIcon(string imageName)
        {
            return TryToMemoryGet(imageName) ?? LoadAndCacheToMemory(SwitchIconPath, imageName);
        }

        // 通过nameId 加载icon 图片
        public static Sprite LoadMainIconById(string id)
        {
            var imageName = MainIconPreFix + id;

            // 缓存里边有就从缓存中取出来
            return TryToMemoryGet(imageName) ?? LoadAndCacheToMemory(MainIconPath, imageName);
        }

        // 尝试从缓存中取，如果取到了，直接返回
        private static Sprite TryToMemoryGet(string imageName)
        {
            if (MainIconMemoryCache.ContainsKey(imageName) && MainIconMemoryCache[imageName] != null)
            {
                return MainIconMemoryCache[imageName];
            }

            return null;
        }


        // 加载图片并且将图片缓存到内存
        private static Sprite LoadAndCacheToMemory(string imagePath, string imageName)
        {
            // 缓存里没取到，去加载
            var sprite = LoadSpriteFromResources(imagePath, imageName);

            // 加载完，缓存起来
            MainIconMemoryCache[imageName] = sprite;
            return sprite;
        }


        // 从Resources 下加载精灵图片
        private static Sprite LoadSpriteFromResources(string path, string imageName)
        {
            return Resources.Load<Sprite>(path + "/" + imageName);
        }
    }
}