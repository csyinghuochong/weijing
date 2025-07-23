
namespace Douyin.Game
{
    /// <summary>
    /// SDK提供的所有接口都通过此类调用
    /// </summary>
    public static class OSDK
    {
        public const string SDK_VERSION = "2.4.4.2";
        
        /// <summary>
        /// 获取组件服务
        /// </summary>
        /// <typeparam name="T"> 组件服务泛型 </typeparam>
        /// <returns> 组件服务 </returns>
        public static T GetService<T>() where T : class
        {
            return SDKInternalServiceManager.GetService<T>();
        }
    }
}
/*
 组件服务泛型 T 包括：
 ICommonService：核心Core模块
 IDouyinService: 抖音授权模块
*/
