using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKIntegrationConfig
    {
        // -----------------
        private static readonly string OSDKManifestDir = Path.Combine(OSDKProjectPathUtils.SdkDataDir, "Editor");
        private static readonly string OSDKManifestFile = Path.Combine(OSDKManifestDir, "OSDKManifest.json");

        // 存到json文件的数据结构
        [Serializable]
        private class OSDKManifestData
        {
            public string appSecret;
        }

        private static string _appSecret;
        private static bool _isLoaded; // 是否已加载过

        public enum BizMode
        {
            DouyinChannel = 1,
            OmniChannel = 2
        }
        
        private static BizMode _bizMode = BizMode.OmniChannel;
        private static bool isInitBizMode = false;
        
        public static string GetAppSecret()
        {
            LoadIfNeed();
            return _appSecret;
        }
        
        public static void SetAppSecret(string appSecret, bool save2File)
        {
            if (appSecret != null)
            {
                _appSecret = appSecret.Trim();
                if (save2File)
                {
                    SaveAppSecret();
                }
            }
        }

        public static void SaveAppSecret()
        {
            if (!Directory.Exists(OSDKManifestDir))
            {
                Directory.CreateDirectory(OSDKManifestDir);
            }
            
            // 存储到文件
            OSDKManifestData data = new OSDKManifestData();
            data.appSecret = _appSecret;
            string json = JsonUtility.ToJson(data);
            File.WriteAllText(OSDKManifestFile, json);
        }
        
        private static void LoadIfNeed()
        {
            if (!_isLoaded)
            {
                if (File.Exists(OSDKManifestFile))
                {
                    string json = File.ReadAllText(OSDKManifestFile);
                    OSDKManifestData data = JsonUtility.FromJson<OSDKManifestData>(json);
                    _appSecret = data.appSecret.Trim();
                }
                if (_appSecret == null)
                {
                    _appSecret = string.Empty;
                }
                _isLoaded = true;
            }
        }
        // -----------------

        public static BizMode GetBizMode()
        {
            if (OSDKIntegrationPathUtils.SDKDeveloperExists) //开发者环境
            {
                return OSDKIntegrationEditor.Instance.osdkTypeState == 0 ? BizMode.OmniChannel : BizMode.DouyinChannel;
            }
            else
            {
                InitBizMode();
                return _bizMode;
            }
        }

        private static void InitBizMode()
        {
            if (!isInitBizMode)
            {
                if (OSDKIntegrationPathUtils.DataLinkModuleImported)
                {
                    _bizMode = BizMode.OmniChannel;
                } else if (OSDKIntegrationPathUtils.UnionModuleImported || OSDKIntegrationPathUtils.CpsModuleImported)
                {
                    _bizMode = BizMode.DouyinChannel;
                } else
                {
                    //由于未支持非流水分账非全渠情况，默认值暂时为全渠
                    _bizMode = BizMode.OmniChannel;
                }
            }
        }
        
        /// <summary>
        /// 应用ID
        /// </summary>
        public static string AppID(OSDKPlatform platform)
        {
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value = OSDKIntegrationEditor.Instance.pAndroidAppID;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value = OSDKIntegrationEditor.Instance.piOSAppID;
            }
            return value;
        }

        public static string AppName(OSDKPlatform platform)
        {
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value = OSDKIntegrationEditor.Instance.pAndroidAppName;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value = OSDKIntegrationEditor.Instance.piOSAppName;
            }
            return value;
        }

        public static string AppName()
        {
            var value = AppName(OSDKPlatform.Android);
            if (string.IsNullOrEmpty(value))
            {
                return AppName(OSDKPlatform.iOS);
            }
            return value;
        }

        public static string ClientKey(OSDKPlatform platform)
        {
            
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value = OSDKIntegrationEditor.Instance.pAndroidClientKey;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value = OSDKIntegrationEditor.Instance.piOSClientKey;
            }
            return value;
        }

        public static string LiveTTSDKID(OSDKPlatform platform)
        {
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value =  OSDKIntegrationEditor.Instance.pAndroidLiveTTSDKID;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value =  OSDKIntegrationEditor.Instance.piOSLiveTTSDKID;
            }
            return value;
        }
        
        public static string LiveLicenseUpdateTime(OSDKPlatform platform)
        {
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value = OSDKIntegrationEditor.Instance.pAndroidLiveLicenseUpdateTime;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value = OSDKIntegrationEditor.Instance.piOSLiveLicenseUpdateTime;
            }
            return value;
        }
        
        public static string LiveLicensePath(OSDKPlatform platform)
        {
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value = OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicensePathAndroid;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value = OSDKIntegrationPathUtils.ConfigFromLocalTTLiveLicensePathIOS;
            }
            return value;
        }
        
        public static string LiveTTWebcastID(OSDKPlatform platform)
        {
            var value = string.Empty;
            if (platform == OSDKPlatform.Android)
            {
                value = OSDKIntegrationEditor.Instance.pAndroidLiveTTWebcastID;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                value = OSDKIntegrationEditor.Instance.piOSLiveTTWebcastID;
            }
            return value;
        }
        
        public static string AndroidSdkType()
        {
            return OSDKIntegrationEditor.Instance.pAndroidSdkType;
        }
        
        public static string IOSSdkType()
        {
            return OSDKIntegrationEditor.Instance.piOSSdkType;
        }

        public static int UnionMode(OSDKPlatform platform)
        {
            var sdkType = string.Empty;
            var value = 100;
            if (platform == OSDKPlatform.Android)
            {
                sdkType = OSDKIntegrationConfig.AndroidSdkType();
                value = OSDKIntegrationEditor.Instance.pAndroidUnionMode;
            }
            else if (platform == OSDKPlatform.iOS)
            {
                sdkType = OSDKIntegrationConfig.IOSSdkType();
                value = OSDKIntegrationEditor.Instance.piOSUnionMode;
            }

            if (sdkType == "Omnichannel_DataLink" )
            {
                // 数据互通映射 11
                return 11;
            }
            else if (sdkType == "Omnichannel_ActivityLink")
            {
                // 活跃互通映射 12
                return 12;
            }

            return value;
        }

        public static bool DebugMode()
        {
            return OSDKIntegrationEditor.Instance.debugModeState == 1;
        }

        #region 工程配置信息
        internal static string BundleId(OSDKPlatform platform)
        {
            var bundleid = "";
            if (platform == OSDKPlatform.Android)
            {
                bundleid = PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.Android);
            }
            else if (platform == OSDKPlatform.iOS)
            {
                bundleid = PlayerSettings.GetApplicationIdentifier(BuildTargetGroup.iOS);
            }
            return bundleid;
        }

        internal static string ScreenOrientation()
        {
            // 默认竖屏
            var interfaceOrientation = "sensorPortrait";
            var isAutoLandscape = PlayerSettings.defaultInterfaceOrientation == UIOrientation.AutoRotation
                && !PlayerSettings.allowedAutorotateToPortrait
                && !PlayerSettings.allowedAutorotateToPortraitUpsideDown;

            // 横屏
            if (isAutoLandscape ||
                PlayerSettings.defaultInterfaceOrientation == UIOrientation.LandscapeRight ||
                PlayerSettings.defaultInterfaceOrientation == UIOrientation.LandscapeLeft)
            {
                interfaceOrientation = "sensorLandscape";
            }
            return interfaceOrientation;
        }

        #endregion
    }
}