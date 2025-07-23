using System.IO;

namespace Douyin.Game
{
    public static class OSDKAndroidResourceUtils
    {
        /// <summary>
        /// Android插件所在目录.
        /// </summary>
        public static string PluginsAndroidDir
        {
            get
            {
                var pluginsAndroidDir = "Assets/Plugins/Android";
                if (!Directory.Exists(pluginsAndroidDir))
                {
                    Directory.CreateDirectory(pluginsAndroidDir);
                }
                return pluginsAndroidDir;
            }
        }
    }
}