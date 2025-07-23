using Douyin.Game;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace Demo.Douyin.Game
{
    public class DemoCoreProcessBuildAndroid : IPreprocessBuildWithReport
    {
        // private const string DEMO_PRODUCT_NAME = "GBSDK Demo";
        // private const string DEMO_PACKAGE_NAME = "com.bytedance.ttgame.tob.demo";

        private const string DEMO_KEY_STORE_PATH = "Assets/OSDK/Core/Sample/Plugins/Editor/union.keystore";
        private const string DEMO_KEY_ALIAS_NAME = "union";
        private const string DEMO_KEY_STORE_PASS = "123456";
        private const string DEMO_KEY_ALIAS_PASS = "123456";

        public int callbackOrder => (int)PreProcessBuildCallBackOrder.Core;


        private static BuildInfo OriginBuildInfo;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (report.summary.platform != BuildTarget.Android) return;
            if (!OSDKEditorHelper.IsBuildDemoScene())
            {
                return;
            }

            // 获取游戏原始构建参数，先保存
            OriginBuildInfo = new BuildInfo();
            OriginBuildInfo.ProductName = PlayerSettings.productName;
            OriginBuildInfo.PackageName = PlayerSettings.applicationIdentifier;

            OriginBuildInfo.KeyStoreName = PlayerSettings.Android.keystoreName;
            OriginBuildInfo.KeyStorePass = PlayerSettings.Android.keystorePass;
            OriginBuildInfo.KeyAliasName = PlayerSettings.Android.keyaliasName;
            OriginBuildInfo.KeyAliasPass = PlayerSettings.Android.keyaliasPass;

            // 设置Demo构建参数
            PlayerSettings.productName = OSDKIntegrationAndroidArchive.genApkName();
            // PlayerSettings.applicationIdentifier = DEMO_PACKAGE_NAME;
            PlayerSettings.Android.keystoreName = DEMO_KEY_STORE_PATH;
            PlayerSettings.Android.keystorePass = DEMO_KEY_STORE_PASS;
            PlayerSettings.Android.keyaliasName = DEMO_KEY_ALIAS_NAME;
            PlayerSettings.Android.keyaliasPass = DEMO_KEY_ALIAS_PASS;
            AssetDatabase.Refresh();
        }


        // 恢复构建信息
        public static void RestoreBuildInfo()
        {
            if (OriginBuildInfo == null)
            {
                return;
            }

            // 恢复为原始的构建信息
            PlayerSettings.productName = OriginBuildInfo.ProductName;
            PlayerSettings.applicationIdentifier = OriginBuildInfo.PackageName;
            PlayerSettings.Android.keystoreName = OriginBuildInfo.KeyStoreName;
            PlayerSettings.Android.keystorePass = OriginBuildInfo.KeyStorePass;
            PlayerSettings.Android.keyaliasName = OriginBuildInfo.KeyAliasName;
            PlayerSettings.Android.keyaliasPass = OriginBuildInfo.KeyAliasPass;
            AssetDatabase.Refresh();
            OriginBuildInfo = null;
        }

        private class BuildInfo
        {
            public string ProductName;
            public string PackageName;

            public string KeyStoreName;
            public string KeyStorePass;
            public string KeyAliasName;
            public string KeyAliasPass;
        }
    }
}