using UnityEngine;

namespace Douyin.Game
{
    public static class OSDKIntegrationRouter
    {
        internal static void OpenHelpCenterWeb()
        {
            Debug.Log("请补充错误码查询地址");
            // Application.OpenURL("https://api.ohayoo.cn/services/errorcode/home");
        }
        
        internal static void OpenSecretKeyWeb()
        {
            Application.OpenURL("https://game.open.douyin.com/platform/product_list");
        }
    }
}