using System.IO;
using Douyin.Game;
using UnityEditor.Android;

namespace Demo.Douyin.Game
{
    public class DemoCorePostProcessBuildAndroid : IPostGenerateGradleAndroidProject
    {
        public int callbackOrder => (int)PreProcessBuildCallBackOrder.Core;

        public void OnPostGenerateGradleAndroidProject(string path)
        {
            // 处理demo场景使用的测试文件
            // 1.根据是否为demo场景处理gbsdk_local_test文件
            var targetDir = path + OSDKProjectPathUtils.SdkWorkDirAssets;
            var targetFileName = "gbsdk_local_test";
            if (!OSDKEditorHelper.IsBuildDemoScene())
            {
                // a.非demo场景
                // 如果生成的gradle工程中上一次打包时创建的gbsdk_local_test文件还在，要主动删除
                var targetFilePath = Path.Combine(targetDir, targetFileName);
                if (File.Exists(targetFilePath))
                {
                    File.Delete(targetFilePath);
                }
                return;
            }
            // b.demo场景
            // 拷贝gbsdk_local_test文件
            var originGbSdkLocalTestFilePath = OSDKProjectPathUtils.CoreModuleDir + "/Sample/Editor/Configs/gbsdk_local_test";
            CopyFileToAndoridStudioDir(originGbSdkLocalTestFilePath, targetDir, targetFileName);
            
            // 2.demo场景，还要恢复构建信息
            DemoCoreProcessBuildAndroid.RestoreBuildInfo();
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