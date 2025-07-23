using System.IO;
using UnityEditor.Android;

namespace Douyin.Game
{
    public class OSDKPostProcessBuildAndroid : IPostGenerateGradleAndroidProject
    {
        public int callbackOrder => (int)PreProcessBuildCallBackOrder.Core;

        public void OnPostGenerateGradleAndroidProject(string path)
        {
            var assetsDir = path + OSDKProjectPathUtils.SdkWorkDirAssets;
            
            // 先写入配置文件，在拷贝config.json文件到assets目录
            var configOriginFilePath = OSDKIntegrationPathUtils.ConfigJsonFilePathAndroid;
            CopyFileToAndoridStudioDir(
                configOriginFilePath,
                assetsDir,
                OSDKIntegrationPathUtils.ConfigJsonFileNameAndroid);
        }

        private static void CopyFileToAndoridStudioDir(string originFilePath, string targetDir, string targetFileName,
            bool isOverwrite = true)
        {
            if (!File.Exists(originFilePath))
            {
                SDKInternalLog.D("originFilePath not exits ---" + originFilePath);
                return;
            }

            if (!Directory.Exists(targetDir))
            {
                Directory.CreateDirectory(targetDir);
            }

            File.Copy(originFilePath, Path.Combine(targetDir, targetFileName), isOverwrite);
        }
    }
}