using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKEditorNotification : AssetPostprocessor
    {
#if UNITY_2021_2_OR_NEWER
        public static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths, bool didDomainReload)
#else
        public static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets,
            string[] movedFromAssetPaths)
#endif
        {
            var needRewrite = false;

            if (importedAssets.Any(path => path.StartsWith(OSDKProjectPathUtils.SdkDir)))
            {
                needRewrite = true;
            }
            if (deletedAssets.Any(path => path.StartsWith(OSDKProjectPathUtils.SdkDir)))
            {
                needRewrite = true;
            }

            if (needRewrite)
            {
                OSDKIntegrationSampleHandler.RewriteOSDKFileContent();
            }
        }
        
        private static bool isFocused;
        static OSDKEditorNotification()
        {
            EditorApplication.update += Update;
        }

        private static void Update()
        {
            if (isFocused == UnityEditorInternal.InternalEditorUtility.isApplicationActive)
            {
                return;
            }
            isFocused = UnityEditorInternal.InternalEditorUtility.isApplicationActive;
            OnEditorFocus(isFocused);
        }

        private static void OnEditorFocus(bool focus)
        {
            if (!focus)
            {
                // 编辑器失去焦点时，检测数据模型保存文件
                OSDKIntegrationSampleHandler.SyncAllAdInfosToTargetFileIfNeed();
            }
        }
    }
}