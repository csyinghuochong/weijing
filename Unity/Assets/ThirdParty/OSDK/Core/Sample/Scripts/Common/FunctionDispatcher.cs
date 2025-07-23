using System.Collections.Generic;

namespace Douyin.Game
{
    // 所有demo中的功能使用方式，都由此类分发
    public static class FunctionDispatcher
    {
        private static readonly List<string> TypeNameList = new List<string>()
        {
            "Demo.Douyin.Game.DemoCoreFunctionScript",
            "Demo.Douyin.Game.DemoDouyinFunctionScript",
            "Demo.Douyin.Game.DemoGameRoleFunctionScript",
            "Demo.Douyin.Game.DemoDouYinAccountFunctionScript",
            "Demo.Douyin.Game.DemoGameAccountFunctionScript",
            "Demo.Douyin.Game.DemoDouYinPayFunctionScript",
            //"Demo.Douyin.Game.Demo_Ad_Download_Listener",
            //"Demo.Douyin.Game.Demo_Personal_ReComment",
            //"Demo.Douyin.Game.Demo_RewardAd",
            //"Demo.Douyin.Game.Demo_NewInteractionAd",
            //"Demo.Douyin.Game.Demo_BannerAd",
            //"Demo.Douyin.Game.Demo_SplashAd",
            // "Demo.Douyin.Game.DemoLiveFunctionScript",
            "Demo.Douyin.Game.DemoScreenRecordFunctionScript",
            "Demo.Douyin.Game.DemoShareFunctionScript",
            "Demo.Douyin.Game.DemoCpsFunctionScript",
            "Demo.Douyin.Game.DemoDataLinkFunctionScript",
#if UNITY_ANDROID
            "Demo.Douyin.Game.Demo_CloudGame",
            "Demo.Douyin.Game.DemoTestFunctionScript",
#endif
        };

        // 分发所有功能 Item的点击
        public static void HandleItemClick(string secondListNameId, string itemNameId)
        {
            foreach (var typeName in TypeNameList)
            {
                ReflectionInvoke.Invoke(typeName, "Instance", "FunctionDispatcher", new object[] { itemNameId });
            }
        }
    }
}