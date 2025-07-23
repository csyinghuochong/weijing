using UnityEngine.Scripting;

namespace Douyin.Game
{
    [Preserve]
    public static class SDKInternalDouyinServiceFactory
    {
        private static IDouyinService _douyinService;

        [Preserve]
        public static IDouyinService CreateService()
        {
            if (_douyinService != null)
            {
                return _douyinService;
            }
#if UNITY_EDITOR
            _douyinService = new EditorDouyinServiceImpl();
#elif UNITY_ANDROID
            _douyinService = new AndroidDouyinServiceImpl();
#elif UNITY_IOS
            _douyinService = new iOSDouyinServiceImpl();
#endif
            return _douyinService;
        }
    }
}