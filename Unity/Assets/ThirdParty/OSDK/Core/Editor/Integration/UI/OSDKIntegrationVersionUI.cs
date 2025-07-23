using System;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationVersionUI
    {
        // Section - 版本
        internal static void VersionSection()
        {
            var settings = OSDKIntegrationEditor.Instance;

            settings.showSectionVersion =
                EditorGUILayout.Foldout(settings.showSectionVersion, OSDKIntegrationString.KTitleVersion, OSDKIntegrationStyles.getSectionStyle());

            if (settings.showSectionVersion)
            {
                GUILayout.Space(12);

                // 显示当前版本
                var currentVersion = long.Parse(OSDK.SDK_VERSION.Replace(".", string.Empty));
                bool isFetched = settings.lastFetchVersionTime > 0;
                var lastFectTicks = new DateTime(settings.lastFetchVersionTime);
                var lastFetchTimeString = isFetched ? lastFectTicks.ToString("yyyy-MM-dd HH:mm:ss") : "-";

                var updateClicked = OSDKIntegrationLayout.LabelButtonTipsLayout($"当前版本: {currentVersion} （最后检查更新时间: {lastFetchTimeString}）", "检查更新");
                if (updateClicked)
                {
                    OSDKIntegrationRecord.FetchVersionClick();
                    OSDKIntegrationVersionHandler.UpdateSDKVersion(true);
                    GUIUtility.ExitGUI();
                }

                var forceVersion = settings.forceSdkVersion;
                var recommendVersion = settings.recommendSdkVersion;

                bool isFail = !settings.lastFetchVersionSuccess;   // 是否拉取失败
                bool showForce = !isFail && forceVersion > currentVersion; // 是否展示强制更新
                bool showRecommend = !isFail && recommendVersion > currentVersion && recommendVersion != forceVersion; // 是否展示推荐更新。如果推荐版本和强制版本一样，则不展示推荐
                bool showLastest = !isFail && !showForce && !showRecommend; // 是否展示当前已经最新

                // 拉取失败
                if (isFail)
                {
                    GUILayout.Space(12);

                    EditorGUILayout.HelpBox("拉取sdk版本遇到一些问题，请重试拉取", MessageType.Warning);
                }

                // 强制更新
                if (showForce)
                {
                    GUILayout.Space(12);

                    EditorGUILayout.HelpBox($"当前版本过低！请更新到{forceVersion}版本以上，否则可能出现SDK功能异常或包体审核被驳回", MessageType.Error);
                    DocumentArea(forceVersion, settings.forceDocumentLink);
                }

                // 推荐更新
                if (showRecommend)
                {
                    GUILayout.Space(12);

                    EditorGUILayout.HelpBox($"SDK有新版本，您可以选择更新到最新版本{recommendVersion}", MessageType.Info);
                    DocumentArea(recommendVersion, settings.recommendDocumentLink);
                }

                // 无需更新
                if (showLastest)
                {
                    // 无需更新
                    GUILayout.Space(12);

                    EditorGUILayout.HelpBox("当前SDK版本已是最新～", MessageType.Info);
                }

            }
        }

        static void DocumentArea(long version, string documentLink)
        {
            var goDocumentClicked = OSDKIntegrationLayout.Button($"前往 {version} 文档");
            if (goDocumentClicked)
            {
                Application.OpenURL(documentLink);
            }
        }

    }
}