using System;
using System.IO;

namespace Douyin.Game
{
    public static class OSDKIntegrationPathUtils
    {
        public static readonly string IntegrationImgQuesPath = Path.Combine(OSDKProjectPathUtils.CoreModuleDir, "Editor/Integration/Resource/osdk_integration_ques.png");

        #region 模块是否导入
        
        public static bool DouyinModuleImported => Directory.Exists(OSDKProjectPathUtils.DouyinModuleDir);
        public static bool AdModuleImported => Directory.Exists(OSDKProjectPathUtils.AdModuleDir);
        public static bool ShareModuleImported => Directory.Exists(OSDKProjectPathUtils.ShareModuleDir);
        public static bool CloudGameModuleImported => Directory.Exists(OSDKProjectPathUtils.CloudGameModuleDir);
        public static bool CpsModuleImported => Directory.Exists(OSDKProjectPathUtils.CpsModuleDir);
        public static bool DataLinkModuleImported => Directory.Exists(OSDKProjectPathUtils.DataLinkModuleDir);
        public static bool LiveModuleImported => Directory.Exists(OSDKProjectPathUtils.LiveModuleDir);
        public static bool ScreenRecordModuleImported => Directory.Exists(OSDKProjectPathUtils.ScreenRecordModuleDir);
        public static bool TeamPlayModuleImported => Directory.Exists(OSDKProjectPathUtils.TeamPlayModuleDir);
        public static bool UnionModuleImported => Directory.Exists(OSDKProjectPathUtils.UnionModuleDir);
        public static bool SDKDeveloperExists => Directory.Exists(OSDKProjectPathUtils.SDKDeveloperDir);
        
        #endregion

        private static string Xml => "xml";
        private static string Values => "values";
        private static string Res => "res";
        private static string Resources => "Resources";
        public static readonly string SdkDataResourceDir = $"{OSDKProjectPathUtils.SdkDataDir}/{Resources}";
        
        #region Android服务端下发配置相关
        public const string ConfigJsonFileNameAndroid = "config.json";
        public static readonly string ConfigJsonFilePathAndroid = $"{SdkDataResourceDir}/{ConfigJsonFileNameAndroid}";
        #endregion

        #region iOS服务端下发配置相关
        public const string ConfigJsonFileNameIOS = "UOPSDKConfig.json";
        public static readonly string ConfigJsonFilePathIOS = $"{SdkDataResourceDir}/{ConfigJsonFileNameIOS}";
        #endregion
        
        #region 看播能力需要本地配置
        // license目标文件名，构建打包时从下面两个源文件路径分别拷贝到各平台的构建路径下，对应各自安装包的config.json/UOPSDKConfig.json文件中的字段名
        public const string ConfigFromLocalTTLiveLicenseFileName = "osdk_ttsdk_license.lic";
        // license源文件路径
        public static readonly string ConfigFromLocalTTLiveLicensePathAndroid = $"{SdkDataResourceDir}/osdk_ttsdk_license_Android.lic";
        public static readonly string ConfigFromLocalTTLiveLicensePathIOS = $"{SdkDataResourceDir}/osdk_ttsdk_license_iOS.lic";
        
        public const string ConfigFromLocalTTLiveMsextFileNameIOS = "osdk_ttsdk_msext.msext";
        public static readonly string ConfigFromLocalTTLiveMsextPathIOS = $"{SdkDataResourceDir}/{ConfigFromLocalTTLiveMsextFileNameIOS}";
        #endregion

        #region 标准化代码相关
        
        private const string SdkDir = OSDKProjectPathUtils.SdkDir;
        private const string SdkDataDir = OSDKProjectPathUtils.SdkDataDir;
        private static readonly string SdkDataScriptsDir = Path.Combine(SdkDataDir, "Scripts");
        private static readonly string SdkDataScriptsAdDir = Path.Combine(SdkDataScriptsDir, "Ad");
        public const string StandardAndroidAdidHolder = "private string BackupCodeId";
        public const string StandardAndroidBizidHolder = "private string BizId";
        // 预留
        public const string StandardIOSAdidHolder = "private string iOSAdId";
        public const string StandardIOSBizidHolder = "private string iOSBizId";
        
        // DevTool Bundle
        public const string DevToolBundleResourceIOS = "UOPDebugToolBundle.bundle";
        public static readonly string DevToolBundleResourceIOSPath = $"DevTools/Plugins/iOS/{DevToolBundleResourceIOS}";
        public static readonly string DevToolBundleResourceIOSOriPath = Path.Combine(SdkDir, DevToolBundleResourceIOSPath);
        public const string DevToolBundleTargetDir = "DevTools";
        public static readonly string DevToolBundleTargetPath = Path.Combine(DevToolBundleTargetDir, DevToolBundleResourceIOS);
        

        // 目标文件（Target）- 标准化代码文件是否存在（广告类型可能存在多个文件，需通过alias区分，alias参数非必须）
        public static bool StandardSampleTargetFileIfExist(OSDKSampleType type, string alias = null)
        {
            var path = StandardSampleTargetFilePath(type, alias);
            return File.Exists(path);
        }
        
        // 目标文件（Target）- 标准化代码文件路径
        public static string StandardSampleTargetFilePath(OSDKSampleType type, string alias = null)
        {
            var fileDir = StandardSampleTargetDir(type);
            var className = StandardSampleTargetClassName(type, alias);
            return $"{fileDir}/{className}.cs";   
        }
        
        // 目标文件（Target）- 标准化代码存储目录
        public static string StandardSampleTargetDir(OSDKSampleType type)
        {
            switch (type)
            {
                case OSDKSampleType.Init:
                    return Path.Combine(SdkDataScriptsDir, "Init");
                case OSDKSampleType.Authorize:
                    return Path.Combine(SdkDataScriptsDir, "Douyin");
                case OSDKSampleType.GameRole:
                    return Path.Combine(SdkDataScriptsDir, "GameRole");
                case OSDKSampleType.Cps:
                    return Path.Combine(SdkDataScriptsDir, "Cps");
                case OSDKSampleType.Share:
                    return Path.Combine(SdkDataScriptsDir, "Share");
                case OSDKSampleType.AdBasic:
                    return Path.Combine(SdkDataScriptsAdDir, "Basic");
                case OSDKSampleType.AdReward:
                    return Path.Combine(SdkDataScriptsAdDir, "Reward");
                case OSDKSampleType.AdNewInteraction:
                    return Path.Combine(SdkDataScriptsAdDir, "Interstitial");
                case OSDKSampleType.AdBanner:
                    return Path.Combine(SdkDataScriptsAdDir, "Banner");
                case OSDKSampleType.AdSplash:
                    return Path.Combine(SdkDataScriptsAdDir, "Splash");
                case OSDKSampleType.DouYinAccount:
                    return Path.Combine(SdkDataScriptsDir, "DouYinAccount");
                case OSDKSampleType.GameAccount:
                    return Path.Combine(SdkDataScriptsDir, "GameAccount");
                case OSDKSampleType.DouYinPay:
                    return Path.Combine(SdkDataScriptsDir, "DouYinPay");
                case OSDKSampleType.Record:
                    return Path.Combine(SdkDataScriptsDir, "ScreenRecord");
                case OSDKSampleType.Live:
                    return Path.Combine(SdkDataScriptsDir, "Live");
                case OSDKSampleType.CloudGame:
                    return Path.Combine(SdkDataScriptsDir, "CloudGame");
                case OSDKSampleType.TeamPlay:
                    return Path.Combine(SdkDataScriptsDir, "TeamPlay");
                case OSDKSampleType.DataLink:
                    return Path.Combine(SdkDataScriptsDir, "DataLink");
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
        
        // 目标文件（Target）- 标准化代码类名/文件名（广告类型可能存在多个，故需绑定alias别名区分，alias参数非必须）
        public static string StandardSampleTargetClassName(OSDKSampleType type, string alias = null)
        {
            string preClassName;
            switch (type)
            {
                case OSDKSampleType.Init:
                    preClassName = "OSDKInit";
                    break;
                case OSDKSampleType.GameRole:
                    preClassName = "OSDKGameRole";
                    break;
                case OSDKSampleType.Authorize:
                    preClassName = "OSDKDouyin";
                    break;
                case OSDKSampleType.Cps:
                    preClassName = "OSDKCps";
                    break;
                case OSDKSampleType.Share:
                    preClassName = "OSDKShare";
                    break;
                case OSDKSampleType.AdBasic:
                    preClassName = "OSDKAdBasic";
                    break;
                case OSDKSampleType.AdReward:
                    preClassName = "OSDKRewardAd";
                    break;
                case OSDKSampleType.AdNewInteraction:
                    preClassName = "OSDKInterstitialAd";
                    break;
                case OSDKSampleType.AdBanner:
                    preClassName = "OSDKBannerAd";
                    break;
                case OSDKSampleType.AdSplash:
                    preClassName = "OSDKSplashAd";
                    break;
                case OSDKSampleType.DouYinAccount:
                    preClassName = "OSDKDouYinAccount";
                    break;
                case OSDKSampleType.GameAccount:
                    preClassName = "OSDKGameAccount";
                    break;
                case OSDKSampleType.DouYinPay:
                    preClassName = "OSDKDouYinPay";
                    break;
                case OSDKSampleType.Record:
                    preClassName = "OSDKScreenRecord";
                    break;
                case OSDKSampleType.Live:
                    preClassName = "OSDKLive";
                    break;
                case OSDKSampleType.CloudGame:
                    preClassName = "OSDKCloudGame";
                    break;
                case OSDKSampleType.TeamPlay:
                    preClassName = "OSDKTeamPlay";
                    break;
                case OSDKSampleType.DataLink:
                    preClassName = "OSDKDataLink";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            return string.IsNullOrWhiteSpace(alias) ? preClassName : alias;
        }

        // 源文件（Origin）- 标准化代码类名/文件名
        public static string StandardSampleOriginClassName(OSDKSampleType type)
        {
            switch (type)
            {
                case OSDKSampleType.Init:
                    return "OSDKStandardInit";
                case OSDKSampleType.Authorize:
                    return "OSDKStandardDouyin";
                case OSDKSampleType.GameRole:
                    return "OSDKStandardGameRole";
                case OSDKSampleType.Share:
                    return "OSDKStandardShare";
                case OSDKSampleType.Cps:
                    return "OSDKStandardCps";
                case OSDKSampleType.AdBasic:
                    return "OSDKStandardAdBasicFunc";
                case OSDKSampleType.AdReward:
                    return "OSDKStandardRewardAd";
                case OSDKSampleType.AdNewInteraction:
                    return "OSDKStandardNewInteractionAd";
                case OSDKSampleType.AdBanner:
                    return "OSDKStandardBannerAd";
                case OSDKSampleType.AdSplash:
                    return "OSDKStandardSplashAd";
                case OSDKSampleType.DouYinAccount:
                    return "OSDKStandardDouYinAccount";
                case OSDKSampleType.GameAccount:
                    return "OSDKStandardGameAccount";
                case OSDKSampleType.DouYinPay:
                    return "OSDKStandardDouYinPay";
                case OSDKSampleType.Record:
                    return "OSDKStandardScreenRecord";
                case OSDKSampleType.Live:
                    return "OSDKStandardLive";
                case OSDKSampleType.CloudGame:
                    return "OSDKStandardCloudGame";
                case OSDKSampleType.TeamPlay:
                    return "OSDKStandardTeamPlay";
                case OSDKSampleType.DataLink:
                    return "OSDKStandardDataLink";
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        // 源文件（Origin）- 标准化代码文件路径
        public static string StandardSampleOriginFilePath(OSDKSampleType type)
        {
            var fileDir = StandardSampleOriginDir(type);
            var className = StandardSampleOriginClassName(type);
            return $"{fileDir}/{className}.cs";
        }
        
        // 源文件（Origin） - 标准化代码源文件所在目录
        private static string StandardSampleOriginDir(OSDKSampleType type)
        {
            string moduleDir;
            switch (type)
            {
                case OSDKSampleType.Init:
                    moduleDir = OSDKProjectPathUtils.CoreModuleDir;
                    break;
                case OSDKSampleType.Authorize:
                    moduleDir = OSDKProjectPathUtils.DouyinModuleDir;
                    break;
                case OSDKSampleType.GameRole:
                    moduleDir = OSDKProjectPathUtils.GameRoleModuleDir;
                    break;
                case OSDKSampleType.Cps:
                    moduleDir = OSDKProjectPathUtils.CpsModuleDir;
                    break;
                case OSDKSampleType.Share:
                    moduleDir = OSDKProjectPathUtils.ShareModuleDir;
                    break;
                case OSDKSampleType.AdBasic:
                case OSDKSampleType.AdReward:
                case OSDKSampleType.AdNewInteraction:
                case OSDKSampleType.AdBanner:
                case OSDKSampleType.AdSplash:
                    moduleDir = OSDKProjectPathUtils.AdModuleDir;
                    break;
                case OSDKSampleType.DouYinAccount:
                    moduleDir = Path.Combine(OSDKProjectPathUtils.UnionModuleDir, "DouYinAccount");
                    break;
                case OSDKSampleType.DouYinPay:
                    moduleDir = Path.Combine(OSDKProjectPathUtils.UnionModuleDir, "DouYinPay");
                    break;
                case OSDKSampleType.GameAccount:
                    moduleDir = Path.Combine(OSDKProjectPathUtils.UnionModuleDir, "GameAccount");
                    break;
                case OSDKSampleType.Record:
                    moduleDir = OSDKProjectPathUtils.ScreenRecordModuleDir;
                    break;
                case OSDKSampleType.Live:
                    moduleDir = OSDKProjectPathUtils.LiveModuleDir;
                    break;
                case OSDKSampleType.CloudGame:
                    moduleDir = OSDKProjectPathUtils.CloudGameModuleDir;
                    break;
                case OSDKSampleType.TeamPlay:
                    moduleDir = OSDKProjectPathUtils.TeamPlayModuleDir;
                    break;
                case OSDKSampleType.DataLink:
                    moduleDir = OSDKProjectPathUtils.DataLinkModuleDir;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            return $"{moduleDir}/Scripts/Standard";
        }
        
        #endregion
    }

    public static class OSDKDirectory
    {
        public static void Copy(string sourceDir, string destinationDir, bool recursive)
        {
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            DirectoryInfo[] dirs = dir.GetDirectories();
            
            Directory.CreateDirectory(destinationDir);

            foreach (FileInfo file in dir.GetFiles())
            {
                string targetFilePath = Path.Combine(destinationDir, file.Name);
                file.CopyTo(targetFilePath);
            }

            if (recursive)
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                    Copy(subDir.FullName, newDestinationDir, true);
                }
            }
        }

        public static void Delete(string sourceDir, bool recursive) 
        {
            var dir = new DirectoryInfo(sourceDir);
            if (!dir.Exists)
                throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

            foreach (FileInfo file in dir.GetFiles())
            {
                file.Delete();
            }
            
            DirectoryInfo[] dirs = dir.GetDirectories();
            if (recursive) 
            {
                foreach (DirectoryInfo subDir in dirs)
                {
                    string newDestinationDir = Path.Combine(sourceDir, subDir.Name);
                    Delete(newDestinationDir, true);
                }
            }

            dir.Delete();
        }
    }
}