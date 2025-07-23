using System.Collections.Generic;
using UnityEngine;

namespace Douyin.Game
{
    public class UnityContext : Singeton<UnityContext>
    {
        /// <summary>
        /// 所有的key固定以extra_开头,需要在unity主线程执行
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> UnityIntegrationExtra()
        {
            var dictionary = new Dictionary<string,string>();
            dictionary["extra_unity_editor_version"] = Application.unityVersion;
            dictionary["extra_unity_package_version"] = OSDK.SDK_VERSION;
            dictionary["extra_unity_graphics_api"] = SystemInfo.graphicsDeviceType.ToString();
            return dictionary;
        }
    }
}