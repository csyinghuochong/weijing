using System.Collections.Generic;

namespace Douyin.Game
{
    public static class SDKInternalServiceManager
    {
        public static T GetService<T>() where T : class
        {
            var t = typeof(T);
            var fullName = t.FullName;
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return null;
            }
            var instance = ReflectionInvoke.InvokeStaticMethod(InternalService[fullName], StaticMethodName);
            var obj = (T)instance;
            return obj;
        }
        
        private const string StaticMethodName = "CreateService";
        private static Dictionary<string, string> InternalService = new Dictionary<string, string>
        {
            {"Douyin.Game.ICommonService","Douyin.Game.SDKInternalCommonServiceFactory"},
            {"Douyin.Game.IAdService","Douyin.Game.SDKInternalAdServiceFactory"},
            {"Douyin.Game.IDouyinService", "Douyin.Game.SDKInternalDouyinServiceFactory"},
            {"Douyin.Game.IGameRoleService", "Douyin.Game.SDKInternalGameRoleServiceFactory"},
            {"Douyin.Game.ICloudGameService", "Douyin.Game.SDKInternalCloudGameServiceFactory"},
            {"Douyin.Game.ICpsService", "Douyin.Game.SDKInternalCpsServiceFactory"},
            {"Douyin.Game.ILiveSdkService", "Douyin.Game.SDKInternalLiveServiceFactory"},
            {"Douyin.Game.IScreenRecordService", "Douyin.Game.SDKInternalScreenRecordServiceFactory"},
            {"Douyin.Game.IShareService", "Douyin.Game.SDKInternalShareServiceFactory"},
            {"Douyin.Game.ITeamPlayService", "Douyin.Game.SDKInternalTeamPlayServiceFactory"},
            {"Douyin.Game.IUnionService", "Douyin.Game.SDKInternalUnionServiceFactory"},
            {"Douyin.Game.IDataLinkService", "Douyin.Game.SDKInternalDataLinkServiceFactory"}
        };
    }
}