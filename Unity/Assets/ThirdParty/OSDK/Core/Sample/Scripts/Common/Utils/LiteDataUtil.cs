using UnityEngine;

namespace Douyin.Game
{
    // 轻量级数据存储
    public static class LiteDataUtil
    {
        
        private static void SetBool(string key, bool result)
        {
            PlayerPrefs.SetInt(key, result ? 1 : 0);
        }

        private static bool GetBool(string key, bool defaultValue = false)
        {
            return PlayerPrefs.GetInt(key, defaultValue ? 1 : 0) == 1;
        }
    }
}