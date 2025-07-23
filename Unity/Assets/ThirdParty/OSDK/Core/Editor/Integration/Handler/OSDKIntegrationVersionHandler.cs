using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public static class OSDKIntegrationVersionHandler
    {
        private static readonly string _dialogTitle = "SDK更新提示";
        private static readonly string _dialogOk = "ok";

        private static readonly double _autoFetchMinIntervalSeconds = 10;    // 最少要间隔10秒，才会自动拉取
        private static readonly double _autoPopupMinIntervalHours = 12;    // 最少要间隔12小时，才会自动弹窗

        internal static void UpdateSDKVersion(bool isManual = false)
        {
            if (!isManual)
            {
                // 如果是自动拉取的，限制一下拉取频率，不需要太频繁地拉取
                var dt = DateTime.Now - new DateTime(OSDKIntegrationEditor.Instance.lastFetchVersionTime);
                if (dt.TotalSeconds < _autoFetchMinIntervalSeconds)
                {
                    return;
                }
            }

            var isAndroid = true;   // 暂时只支持安卓
            var platform = isAndroid ? OSDKPlatform.Android : OSDKPlatform.iOS;

            var appSecret = OSDKIntegrationConfig.GetAppSecret();
            var packageName = OSDKIntegrationConfig.BundleId(platform);
            var bizMode = (int)OSDKIntegrationConfig.GetBizMode();

            if (string.IsNullOrEmpty(appSecret) || string.IsNullOrEmpty(packageName))
            {
                if (isManual)
                {
                    EditorUtility.DisplayDialog(_dialogTitle, "密钥和包名不能为空，\n请前往厂商合作平台获取填写后重试", _dialogOk);
                }
                return;
            }

            Dictionary<string, object> versionDictionary = null;
            string logid = string.Empty;

            // 拉取配置 
            try
            {
                versionDictionary = OSDKIntegrationHttp.FetchSDKVersion(isAndroid ? 1 : 2, bizMode, appSecret, packageName, out logid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                string failureMessage = string.Empty;
                bool success = false;
                Dictionary<string, object> data = null;

                if (versionDictionary != null)
                {
                    var code = versionDictionary.SafeGetValue<long>("status_code");
                    data = versionDictionary.SafeGetValue<Dictionary<string, object>>("data");

                    success = code == 0 && data != null;

                    failureMessage = HandleErrorCode(code);

                    OSDKIntegrationRecord.FetchVersion(code);
                }
                else
                {
                    failureMessage = "请查看控制台网络错误";
                }

                HandleResult(success, isManual, data, failureMessage);
                EditorUtility.SetDirty(OSDKIntegrationEditor.Instance);
            }
        }
        static string HandleErrorCode(long errorCode)
        {
            switch (errorCode)
            {
                case 10011:
                case 10003:
                    return $"{errorCode} 配置错误，请检查环境配置中的密钥填写是否正确";
                case 10014:
                case 10004:
                    return $"{errorCode} 配置错误，请检查包名和业务模式是否匹配";
                case 5013014:
                case 50016:
                case 10002:
                    return $"{errorCode} 系统错误，请联系服务台技术人员协助处理";
            }

            return $"{errorCode} 服务错误，请查看控制台日志";
        }

        static void HandleResult(bool isSuccess, bool isManual, Dictionary<string, object> data, string failMessage)
        {
            var recommendSdkVersion = !isSuccess ? default : data.SafeGetValue<long>("recommend_sdk_version");
            var recommendDocumentLink = !isSuccess ? default : data.SafeGetValue<string>("recommend_document_link");
            var forceSdkVersion = !isSuccess ? default : data.SafeGetValue<long>("force_sdk_version");
            var forceDocumentLink = !isSuccess ? default : data.SafeGetValue<string>("force_document_link");

            // 1. 更新面板信息
            OSDKIntegrationEditor.Instance.lastFetchVersionSuccess = isSuccess;
            OSDKIntegrationEditor.Instance.recommendSdkVersion = recommendSdkVersion;
            OSDKIntegrationEditor.Instance.recommendDocumentLink = recommendDocumentLink;
            OSDKIntegrationEditor.Instance.forceSdkVersion = forceSdkVersion;
            OSDKIntegrationEditor.Instance.forceDocumentLink = forceDocumentLink;

            var now = DateTime.Now;
            OSDKIntegrationEditor.Instance.lastFetchVersionTime = now.Ticks;

            // 2. 展示弹窗
            if (!isSuccess)
            {
                if (isManual)
                {
                    EditorUtility.DisplayDialog(_dialogTitle, $"检查更新失败，{failMessage}", _dialogOk);
                }
            }
            else
            {
                var currentVersion = long.Parse(OSDK.SDK_VERSION.Replace(".", string.Empty));

                if (isManual)
                {
                    // 手动触发的，一定展示弹窗
                    ShowVersionDialog(currentVersion, recommendSdkVersion, forceSdkVersion, recommendDocumentLink, forceDocumentLink);
                }
                else
                {
                    // 自动触发的，只有 force 才弹窗。并且有频率限制
                    if (currentVersion < forceSdkVersion)
                    {
                        var timeSpan = now - new DateTime(OSDKIntegrationEditor.Instance.lastAutoPopupVersionTime);
                        if (timeSpan.TotalHours > _autoPopupMinIntervalHours)
                        {
                            // 更新时间
                            OSDKIntegrationEditor.Instance.lastAutoPopupVersionTime = now.Ticks;

                            // 展示弹窗
                            ShowVersionDialog(currentVersion, recommendSdkVersion, forceSdkVersion, recommendDocumentLink, forceDocumentLink);
                        }
                    }
                }

            }

        }

        static void ShowVersionDialog(long currentVersion, long recommendVersion, long forceVersion, string recommendLink, string forceLink)
        {
            var title = _dialogTitle;
            var ok = _dialogOk;

            if (forceVersion > 0 && forceVersion > currentVersion)
            {
                var message = $"当前版本过低！请更新到{forceVersion}版本以上，否则可能出现SDK功能异常或包体审核被驳回";
                if (forceVersion == recommendVersion)
                {
                    EditorUtility.DisplayDialog(title, message, ok);
                    OpenLink(forceLink);
                }
                else
                {
                    bool confirm = EditorUtility.DisplayDialog(title, message, $"{forceVersion}版本", "最新版本");
                    OpenLink(confirm ? forceLink : recommendLink);
                }
            }
            else if (recommendVersion > 0 && recommendVersion > currentVersion)
            {
                bool confirm = EditorUtility.DisplayDialog(title, $"SDK有新版本，您可以选择更新到最新版本{recommendVersion}", "前往文档更新", "暂不前往");
                if (confirm)
                {
                    OpenLink(recommendLink);
                }
            }
            else
            {
                EditorUtility.DisplayDialog(title, "当前SDK版本已是最新～", ok);
            }

        }

        static void OpenLink(string link)
        {
            Application.OpenURL(link);
        }

    }
}