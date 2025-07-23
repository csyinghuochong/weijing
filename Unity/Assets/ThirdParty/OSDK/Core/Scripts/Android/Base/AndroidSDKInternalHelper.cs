#if UNITY_ANDROID
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    public static class AndroidSDKInternalHelper
    {
        // UnityPlayerActivity
        private static AndroidJavaObject _Activity;

        /// <summary>
        /// Gets the unity main activity.
        /// </summary>
        /// <returns>Activity .</returns>
        public static AndroidJavaObject GetActivity()
        {
            if (_Activity == null)
            {
                var unityPlayer = new AndroidJavaClass(
                    "com.unity3d.player.UnityPlayer");
                SDKInternalLog.D("unityPlayer:" + unityPlayer);
                _Activity = unityPlayer.GetStatic<AndroidJavaObject>(
                    "currentActivity");
                SDKInternalLog.D("unityPlayer activity:" + _Activity);
            }

            return _Activity;
        }

        /// <summary>
        /// 获取Android原生applicationContext
        /// </summary>
        /// <returns></returns>
        public static AndroidJavaObject GetApplicationContext()
        {
            var activity = GetActivity();
            return activity.Call<AndroidJavaObject>("getApplicationContext");
        }
        
        /// <summary>
        /// dictionary转HashMap
        /// </summary>
        /// <returns></returns>
        public static  AndroidJavaObject CSharpHashMap<K,T>(Dictionary<K, T> dictionary)
        {
            var androidJavaObject = new AndroidJavaObject("java.util.HashMap");

            if (dictionary == null)
            {
                return androidJavaObject;
            }
            // put(k, v)
            IntPtr putMethod = AndroidJNIHelper.GetMethodID(
                androidJavaObject.GetRawClass(), "put",
                "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
            
            foreach (var keyValuePair in dictionary)
            {
                object[] args = new object[2];
                var key = keyValuePair.Key.ToString();
                var value = keyValuePair.Value.ToString();
                using (AndroidJavaObject k = new AndroidJavaObject("java.lang.String", key))
                {
                    using (AndroidJavaObject v = new AndroidJavaObject("java.lang.String", value))
                    {
                        args[0] = k;
                        args[1] = v;
                        AndroidJNI.CallObjectMethod(androidJavaObject.GetRawObject(),
                            putMethod, AndroidJNIHelper.CreateJNIArgArray(args));
                    }
                }
            }
            return androidJavaObject;
        }

        public static AndroidJavaObject CCharpDictionaryToJavaJsonObject(Dictionary<string, string> dictionary)
        {
            var androidJavaObject = new AndroidJavaObject("org.json.JSONObject");
            IntPtr putMethod = AndroidJNIHelper.GetMethodID(
                androidJavaObject.GetRawClass(), "put",
                "(Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
            if (dictionary != null && dictionary.Count > 0)
            {
                foreach (var keyValuePair in dictionary)
                {
                    var key = new AndroidJavaObject("java.lang.String", keyValuePair.Key);
                    var value = new AndroidJavaObject("java.lang.String", keyValuePair.Value);
                    
                    AndroidJNI.CallObjectMethod(androidJavaObject.GetRawObject(),
                            putMethod, AndroidJNIHelper.CreateJNIArgArray(new object[] { key, value }));
                }
            }

            return androidJavaObject;
        }

        // 运行在android主线程
        public static void RunOnAndroidUIThread(Action action)
        {
            var runnable = new AndroidJavaRunnable(() => { action?.Invoke(); });
            GetActivity().Call("runOnUiThread", runnable);
        }
    }
}

#endif