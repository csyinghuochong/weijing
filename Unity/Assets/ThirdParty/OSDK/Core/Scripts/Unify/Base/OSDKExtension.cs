using System.Collections.Generic;

namespace Douyin.Game
{
    public static class OSDKExtension
    {
        public static T SafeGetValue<T>(this Dictionary<string, object> dictionary, string key)
        {
            if (dictionary.TryGetValue(key,out var val))
            {
                return (T)val;
            }
            return default;
        }
    }
}