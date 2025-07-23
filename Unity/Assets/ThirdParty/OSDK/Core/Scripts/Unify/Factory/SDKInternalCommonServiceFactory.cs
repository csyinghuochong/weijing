using UnityEngine.Scripting;

namespace Douyin.Game
{
    [Preserve]
    public static class SDKInternalCommonServiceFactory
    {
        private static ICommonService _commonService;

        [Preserve]
        public static ICommonService CreateService()
        {
            if (_commonService != null)
            {
                return _commonService;
            }
#if UNITY_EDITOR
            _commonService = new EditorCommonServiceImpl();
#elif UNITY_ANDROID
            _commonService = new AndroidCommonServiceImpl();
#elif UNITY_IOS
            _commonService = new iOSCommonServiceImpl();
#endif
            return _commonService;
        }
    }
}