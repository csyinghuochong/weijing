using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public static class OSDKIntegrationHandler
    {
        // 拉取配置信息
        // ReSharper disable Unity.PerformanceAnalysis
        internal static Task FetchSDKConfigClickAction(OSDKPlatform platform, bool toast = true, bool isUpload = true)
        {
            // 密钥
            var appSecret = OSDKIntegrationConfig.GetAppSecret();
            // 包名
            string package = null;
            string platformName = null;
            int devicePlatform = 1;
            
            // 接入模式
            // 入参要求2=全官服促活分账，1=渠道分账;
            var bizMode = OSDKIntegrationConfig.GetBizMode();

            if (platform == OSDKPlatform.Android)
            {
                package = PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.Android);
                platformName = "Android";
                devicePlatform = 1;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                package = PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.iOS);
                platformName = "iOS";
                devicePlatform = 2;
            }
            if (string.IsNullOrWhiteSpace(appSecret))
            {
                EditorUtility.DisplayDialog($"{platformName}配置拉取失败", "密钥 Secret Key 不能为空，\n请到开放平台获取填写后重试", "ok");
                return Task.CompletedTask;
            }

            if (!OSDKIntegrationPathUtils.SDKDeveloperExists)
            {
                if (bizMode == OSDKIntegrationConfig.BizMode.DouyinChannel &&
                    OSDKIntegrationPathUtils.DataLinkModuleImported)
                {
                    EditorUtility.DisplayDialog($"{platformName}配置拉取失败", "当前是流水分账模式，请删除Assets/OSDK/DataLink文件夹后重新拉取", "ok");
                    return Task.CompletedTask;
                }

                if (bizMode == OSDKIntegrationConfig.BizMode.OmniChannel &&
                    (OSDKIntegrationPathUtils.UnionModuleImported || OSDKIntegrationPathUtils.CpsModuleImported))
                {
                    EditorUtility.DisplayDialog($"{platformName}配置拉取失败", "当前是全渠促活模式，请删除Assets/OSDK/Union文件夹或Assets/OSDK/Cps文件夹后重新拉取", "ok");
                    return Task.CompletedTask;
                }
            }
            
            EditorUtility.DisplayProgressBar($"正在更新 {platformName} 配置文件", "正在更新", 0.5f);

            string title;
            string msg;
            // 拉取配置
            try
            {
                var configDictionary = OSDKIntegrationHttp.FetchSDKConfigs(devicePlatform, appSecret, package, (int)bizMode);
                if (configDictionary != null)
                {
                    var code = (long)configDictionary["status_code"];
                    if (code == 0) // 成功
                    {
                        HandleConfigData(configDictionary, platform);
                        title = $"{platformName}配置更新成功";
                        msg = $"{platformName}配置更新成功";
                    }
                    else
                    {
                        title = $"{platformName}配置更新失败";
                        msg = $"拉取配置失败（{code}） \n注意: 如果不需要接入{platformName}平台可忽略后续提示\n1.请检查厂商合作平台注册的包名是否与当前应用包名{package}一致\n2.请检查填写的【密钥 Secret Key】是否与平台上显示的一致\n3.请检查【业务模式】是否与平台上显示的一致";
                    }

                    if (isUpload)
                    {
                        OSDKIntegrationRecord.FetchSDKConfigInfo(code);
                    }
                }
                else
                {
                    title = $"{platformName}配置更新失败";
                    msg = $"{platformName}配置文件更新失败，请检查您的网络";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }
            
            if (toast)
            {
                var isOk = EditorUtility.DisplayDialog(title, msg, "ok");
                if (isOk)
                {
                    AssetDatabase.Refresh();
                }
            }
            else
            {
                AssetDatabase.Refresh();
            }
            
            // 拉取配置后标记为dirty，使下次AssetDatabase.SaveAssets()或关闭editor时保存最新拉取的值
            EditorUtility.SetDirty(OSDKIntegrationEditor.Instance);

            return Task.CompletedTask;
        }

        private static void HandleConfigData(Dictionary<string, object> dictionary, OSDKPlatform platform)
        {
            var data = (Dictionary<string, object>)dictionary["data"];
            if (data != null)
            {
                var appid = $"{(long)data["app_id"]}";;
                var osdkType = (string)data["osdk_type"];
                var unionMode = (long)data["union_mode"];
                var appName = (string)data["app_name"];
                if (platform == OSDKPlatform.Android)
                {
                    OSDKIntegrationEditor.Instance.pAndroidAppID = appid;
                    OSDKIntegrationEditor.Instance.pAndroidAppName = appName;
                    OSDKIntegrationEditor.Instance.pAndroidSdkType = osdkType;
                    OSDKIntegrationEditor.Instance.pAndroidUnionMode = (int)unionMode;
                }
                else
                {
                    OSDKIntegrationEditor.Instance.piOSAppID = appid;
                    OSDKIntegrationEditor.Instance.piOSAppName = appName;
                    OSDKIntegrationEditor.Instance.piOSSdkType = osdkType;
                    OSDKIntegrationEditor.Instance.piOSUnionMode = (int)unionMode;
                }
                
                var clientKey = (Dictionary<string, object>)data["client_key"];
                if (clientKey != null)
                {
                    var douyinKey = (string)clientKey["douyin_key"];
                    if (platform == OSDKPlatform.Android)
                    {
                        OSDKIntegrationEditor.Instance.pAndroidClientKey = douyinKey;
                    }
                    else
                    {
                        OSDKIntegrationEditor.Instance.piOSClientKey = douyinKey;
                    }
                }

                // iOS 拉取配置不处理广告内容
                if (platform == OSDKPlatform.iOS) {
                    return;
                }
                var slotList = (List<object>)data["ad_slot_list"];
                var adInfoList = new List<OSDKAdInfo>();
                foreach (var o in slotList)
                {
                    if (!(o is Dictionary<string, object> obj)) continue;
                    var bizID = (string)obj["biz_slot_id"];
                    var orientation = (long)obj["orientation"];
                    var slotID = (long)obj["slot_id"];
                    var slotName = (string)obj["slot_name"];
                    var slotType = (long)obj["slot_type"];
                    var info = new OSDKAdInfo()
                    {
                        androidBizid = bizID,
                        androidAdid = $"{slotID}",
                        orientation = (OSDKAdOrientation)orientation,
                        type = (OSDKAdType)slotType,
                        cloudName = slotName
                        //TODO: Cuikeyi 处理本地文件是否创建，Key为 slot_Typebizid_slot_id，Value为 本地文件name
                        
                    };
                    adInfoList.Add(info);
                }
                OSDKIntegrationEditor.Instance.HandleAdInfosList(adInfoList);
            }
        }

        public static void WriteAndroidConfigFiles()
        {
            // Android Json
            var appid = OSDKIntegrationConfig.AppID(OSDKPlatform.Android);
            var screenOrientation = OSDKIntegrationConfig.ScreenOrientation();
            var sdkType = OSDKIntegrationConfig.AndroidSdkType();
            var unionMode = OSDKIntegrationConfig.UnionMode(OSDKPlatform.Android);
            var douyinKey = OSDKIntegrationConfig.ClientKey(OSDKPlatform.Android);
            var debugMode = OSDKIntegrationConfig.DebugMode();
            var sdkPkgType = OSDKIntegrationEditor.Instance.gameStageState;
            var androidJsonObj = new Dictionary<string, object>
            {
                { "app_id", appid },
                { "screen_orientation", screenOrientation },
                { "osdk_type", sdkType },
                { "debug_mode", debugMode },
                { "osdk_pkg_type", sdkPkgType },
                { "client_key", new Dictionary<string, object>
                {
                    {"douyin_key", douyinKey} 
                }}
            };
            if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.DouyinChannel)
            {
                androidJsonObj.Add("union_mode", unionMode);
            }
            if (OSDKIntegrationPathUtils.LiveModuleImported)
            {
                var liveObj = new Dictionary<string, object>
                {
                    { "ttsdk_id", OSDKIntegrationConfig.LiveTTSDKID(OSDKPlatform.Android) },
                    { "ttsdk_license_path", "livesdk/osdk_ttsdk_license.lic" },
                    { "webcast_id", OSDKIntegrationConfig.LiveTTWebcastID(OSDKPlatform.Android) }
                };
                androidJsonObj.Add("live_sdk", liveObj);
            }

            var androidJson = Json.Serialize(androidJsonObj);
            if (!string.IsNullOrWhiteSpace(androidJson))
            {
                File.WriteAllText(OSDKIntegrationPathUtils.ConfigJsonFilePathAndroid, androidJson, new UTF8Encoding(false));
            }
            else
            {
                Debug.LogError("Android config.json文件写入失败。");
            }
        }
        
        public static void WriteIOSJsonFile()
        {
            // IOS Json
            var appid = OSDKIntegrationConfig.AppID(OSDKPlatform.iOS);
            var sdkType = OSDKIntegrationConfig.IOSSdkType();
            var unionMode = OSDKIntegrationConfig.UnionMode(OSDKPlatform.iOS);
            var douyinKey = OSDKIntegrationConfig.ClientKey(OSDKPlatform.iOS);
            var debugMode = OSDKIntegrationConfig.DebugMode();

            var iosJsonObj = new Dictionary<string, object>
            {
                { "app_id", appid },
                { "channel", "App Store" },
                { "osdk_type", sdkType},
                { "debug_mode", debugMode },
                { "client_key", new Dictionary<string, object>
                {
                    {"douyin_key", douyinKey} 
                }}
            };
            if (OSDKIntegrationConfig.GetBizMode() == OSDKIntegrationConfig.BizMode.DouyinChannel)
            {
                iosJsonObj.Add("union_mode", unionMode);
            }
            
            if (OSDKIntegrationPathUtils.LiveModuleImported)
            {
                var liveObj = new Dictionary<string, object>
                {
                    { "ttsdk_id", OSDKIntegrationConfig.LiveTTSDKID(OSDKPlatform.iOS) },
                    { "ttsdk_license", OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicenseFileName },
                    { "webcast_id", OSDKIntegrationConfig.LiveTTWebcastID(OSDKPlatform.iOS) }
                };
                iosJsonObj.Add("live_sdk", liveObj);
            }

            var iosJson = Json.Serialize(iosJsonObj);
            if (!string.IsNullOrWhiteSpace(iosJson))
            {
                File.WriteAllText(OSDKIntegrationPathUtils.ConfigJsonFilePathIOS ,iosJson, Encoding.UTF8);
            }
            else
            {
                Debug.LogError("iOS config.json文件写入失败。");
            }
        }

        // 剪切板复制并提示
        // ReSharper disable Unity.PerformanceAnalysis
        internal static void CopyBufferAndLog(string text, string label)
        {
            GUIUtility.systemCopyBuffer = text;
            Debug.Log($"【{label}】复制成功");
        }
        
        // 打包安卓
        internal static void ArchiveAndroidAction(bool isDebug)
        {
            if (!CheckAndroidArchive())
            {
                return;
            }
            if (isDebug)
            {
                OSDKIntegrationAndroidArchive.ArchiveDebug();
            }
            else
            {
                OSDKIntegrationAndroidArchive.ArchiveRelease();
            }
        }
        // 导出Xcode工程
        internal static void ExportXcodeProjectAction(bool isDebug)
        {
            if (!CheckIOSArchive(isDebug, false))
            {
                return;
            }
            OSDKIntegrationIOSArchive.ExportXcodeProject(isDebug);
        }
        // 打包iOS
        internal static void ArchiveIOSAction(bool isDebug)
        {
            if (!CheckIOSArchive(isDebug, true))
            {
                return;
            }
            if (isDebug)
            {
                OSDKIntegrationIOSArchive.ArchiveDebug();
            }
            else
            {
                OSDKIntegrationIOSArchive.ArchiveRelease();
            }
        }

        #region 辅助函数
        private static bool CheckAndroidArchive()
        {
            var lgAppidEmpty = string.IsNullOrWhiteSpace(OSDKIntegrationConfig.AppID(OSDKPlatform.Android));
            var lgSecretKeyEmpty = string.IsNullOrWhiteSpace(OSDKIntegrationConfig.GetAppSecret());
            if (lgAppidEmpty || lgSecretKeyEmpty)
            {
                EditorUtility.DisplayDialog("Android环境配置错误", "请完成自助化接入 - Step1：环境配置 - 密钥 Secret Key。（密钥不可为空，填写密钥后，请点击'拉取配置信息'按钮。）", "OK");
                return false;
            }
            return true;
        }

        private static bool CheckIOSArchive(bool isDebug, bool checkProfile)
        {
            var lgAppidEmpty = string.IsNullOrWhiteSpace(OSDKIntegrationConfig.AppID(OSDKPlatform.iOS));
            var lgSecretKeyEmpty = string.IsNullOrWhiteSpace(OSDKIntegrationConfig.GetAppSecret());
            if (lgAppidEmpty || lgSecretKeyEmpty)
            {
                EditorUtility.DisplayDialog("iOS环境配置错误", "请完成自助化接入 - Step1：环境配置 - 密钥 Secret Key。（密钥不可为空，填写密钥后，请点击'拉取配置信息'按钮。）", "OK");
                return false;
            }
            // 证书检测
            if (checkProfile && !PlayerSettings.iOS.appleEnableAutomaticSigning)
            {
                var check = false;
                var env = "";
                switch (isDebug)
                {
                    case true when string.IsNullOrWhiteSpace(OSDKIntegrationEditor.Instance.developmentProfileUuid):
                        check = true;
                        env = "Development";
                        break;
                    case false when string.IsNullOrWhiteSpace(OSDKIntegrationEditor.Instance.productionProfileUuid):
                        check = true;
                        env = "Production";
                        break;
                }
                if (check)
                {
                    EditorUtility.DisplayDialog("iOS 配置文件错误", $"请完成构建 - 配置文件（ProvisionProfile）- {env} 环境配置文件选取", "OK");
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}