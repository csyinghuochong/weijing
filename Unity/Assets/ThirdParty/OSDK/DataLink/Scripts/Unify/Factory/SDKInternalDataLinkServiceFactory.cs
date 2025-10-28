using UnityEngine.Scripting;

namespace Douyin.Game
{
    [Preserve]
    public static class SDKInternalDataLinkServiceFactory
    {
        private static IDataLinkService _dataLinkService;

        [Preserve]
        public static IDataLinkService CreateService()
        {
            if (_dataLinkService != null)
            {
                return _dataLinkService;
            }
#if UNITY_EDITOR
            _dataLinkService = new EditorDataLinkServiceImpl();
#elif UNITY_ANDROID
            _dataLinkService = new AndroidDataLinkServiceImpl();
#elif UNITY_IOS
            _dataLinkService = new iOSDataLinkServiceImpl();
#endif
            return _dataLinkService;
        }
    }
}