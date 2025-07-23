using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// SDK内部打印，通过此类
    /// </summary>
    public static class SDKInternalLog
    {
        // 方便查阅的 tag
        private const string CommonTAG = "OSDK-Unity--";

        private static bool OPEN = OSDKIntegration.IsDebugMode;

        public static void SetLogState(bool open)
        {
            OPEN = open;
        }

        // verbose
        public static void V(object msg)
        {
            Debug.Log(CommonTAG + msg);
        }

        // debug
        public static void D(object msg)
        {
            if (OPEN)
            {
                Debug.Log(CommonTAG + msg);
            }
        }

        // error
        public static void E(object msg)
        {
            if (OPEN)
            {
                Debug.LogError(CommonTAG + msg);
            }
        }
    }
}