using Douyin.Game;
using UnityEngine;
using System.Runtime.InteropServices;

namespace Demo.Douyin.Game
{
    public static class Clipboard
    {
        public static void CopyToClipboard(string text)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
            AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
            AndroidJavaObject clipboardManager = currentActivity.Call<AndroidJavaObject>("getSystemService", "clipboard");
            AndroidJavaClass clipDataClass = new AndroidJavaClass("android.content.ClipData");
            AndroidJavaObject clipData = clipDataClass.CallStatic<AndroidJavaObject>("newPlainText", "text", text);
            clipboardManager.Call("setPrimaryClip", clipData);
#elif UNITY_IOS && !UNITY_EDITOR
            OSDK_iOSCopyToClipboard(text);
#endif
        }

#if UNITY_IOS
        [DllImport("__Internal")]
        private static extern void OSDK_iOSCopyToClipboard(string text);
#endif
    }
}