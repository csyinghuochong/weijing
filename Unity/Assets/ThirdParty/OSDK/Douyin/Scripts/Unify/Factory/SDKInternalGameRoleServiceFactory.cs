using UnityEngine.Scripting;

namespace Douyin.Game
{
    [Preserve]
    public static class SDKInternalGameRoleServiceFactory
    {
        private static IGameRoleService _gameRoleService;

        [Preserve]
        public static IGameRoleService CreateService()
        {
            if (_gameRoleService != null)
            {
                return _gameRoleService;
            }
#if UNITY_EDITOR
            _gameRoleService = new EditorGameRoleServiceImpl();
#elif UNITY_ANDROID
            _gameRoleService = new AndroidGameRoleServiceImpl();
#elif UNITY_IOS
            _gameRoleService = new iOSGameRoleServiceImpl();
#endif
            return _gameRoleService;
        }
    }
}