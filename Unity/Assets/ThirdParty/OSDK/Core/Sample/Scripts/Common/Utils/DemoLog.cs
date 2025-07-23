using UnityEngine;

namespace Douyin.Game
{
    public static class DemoLog
    {
        private const string CommonTAG = "Demo-Unity-OSdk---";

        // debug
        public static void D(object msg)
        {
            Debug.Log(CommonTAG + msg);
        }

        // error
        public static void E(object msg)
        {
            Debug.LogError(CommonTAG + msg);
        }
        
        public static void ShowToastAndPrint(string tag, string message)
        {
            message = $"[{tag}] {message}";
            D(message);
            ToastManager.Instance.ShowToast(message);
        }
        
        public static void ShowToastAndError(string tag, string message)
        {
            message = $"[{tag}] {message}";
            E(message);
            ToastManager.Instance.ShowToast(message);
        }
    }
    
   
}