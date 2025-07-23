using System;
using System.IO;
using UnityEngine;

namespace Douyin.Game
{
    public class OSDKProjectPathUtils
    {
        #region 工程基础路径定义
        // SDK所在文件路径
        public const string SdkDir = "Assets/ThirdParty/OSDK";
        // 用户数据文件目录
        public const string SdkDataDir = "Assets/ThirdParty/OSDKData";
        // Core模块目录
        public static readonly string CoreModuleDir = Path.Combine(SdkDir, "Core");
        // 授权模块
        public static readonly string DouyinModuleDir = Path.Combine(SdkDir, "Douyin");
        // 账号绑定
        public static readonly string GameRoleModuleDir = Path.Combine(SdkDir, "Douyin");
        // 广告模块
        public static readonly string AdModuleDir = Path.Combine(SdkDir, "Ad");
        // 分享模块
        public static readonly string ShareModuleDir = Path.Combine(SdkDir, "Share");
        // 云游戏模块
        public static readonly string CloudGameModuleDir = Path.Combine(SdkDir, "CloudGame");
        // CPS模块
        public static readonly string CpsModuleDir = Path.Combine(SdkDir, "Cps"); 
        // DataLink模块
        public static readonly string DataLinkModuleDir = Path.Combine(SdkDir, "DataLink"); 
        // 直播模块
        public static readonly string LiveModuleDir = Path.Combine(SdkDir, "Live");
        // 录屏模块
        public static readonly string ScreenRecordModuleDir = Path.Combine(SdkDir, "ScreenRecord");
        // 一键上车模块
        public static readonly string TeamPlayModuleDir = Path.Combine(SdkDir, "TeamPlay");
        // 联运模块
        public static readonly string UnionModuleDir = Path.Combine(SdkDir, "Union");
        // 检测工具
        public static readonly string DevToolsModuleDir = Path.Combine(SdkDir, "DevTools");
        // 开发者工具
        public static readonly string SDKDeveloperDir = Path.Combine(SdkDir, "SDKDeveloper");
        
        // SDK构建目录
        private static readonly string SdkArchiveProjectBuildDir = Path.Combine(Environment.CurrentDirectory, "BuildProductDir");
        
        #endregion
        
        #region Unity版本自带的Gradle模板所在路径
        // Unity 安装路径
        private static string UnityInstallPath => AppDomain.CurrentDomain.BaseDirectory;

        // Unity 版本自带的Gradle模板所在路径
        // Mac一般是这个路径
        private static string TemplateGradleBaseDirectory =>
            Path.Combine(UnityInstallPath, "PlaybackEngines/AndroidPlayer/Tools/GradleTemplates");
        // Windows一般是这个路径
        private static string TemplateGradleBaseDirectory2 =>
            Path.Combine(UnityInstallPath, "Data/PlaybackEngines/AndroidPlayer/Tools/GradleTemplates");

        public static string MainTemplateGradleFilePath
        {
            get
            {
                string path1 = Path.Combine(TemplateGradleBaseDirectory, MainTemplateGradleFileName);
                if (File.Exists(path1))
                {
                    return path1;
                }

                return Path.Combine(TemplateGradleBaseDirectory2, MainTemplateGradleFileName);
            }
        }

        public static string LauncherTemplateGradleFilePath
        {
            get {
                string path1  = Path.Combine(TemplateGradleBaseDirectory, LauncherTemplateGradleFileName);
                if (File.Exists(path1))
                {
                    return path1;
                }

                return Path.Combine(TemplateGradleBaseDirectory2, LauncherTemplateGradleFileName);
            }
        }
        
        public static string SettingsTemplateGradleFilePath
        {
            get {
                string path1  = Path.Combine(TemplateGradleBaseDirectory, SettingsTemplateGradleFileName);
                if (File.Exists(path1))
                {
                    return path1;
                }

                return Path.Combine(TemplateGradleBaseDirectory2, SettingsTemplateGradleFileName);
            }
        }

    #endregion


        // #region Unity版本自带AndroidManifest文件路径
        // 不同版本不一样，不同平台不一样，Windows是Data/PlaybackEngines/...
        // public static string CurrentDefaultManifestPath => Path.Combine(UnityInstallPath,
        //     "PlaybackEngines/AndroidPlayer/Apk/" + AndroidManifestXmlFileName);
        // #endregion
        
        #region 名词定义
        private static string Xml => "xml";
        private static string Values => "values";
        private static string Res => "res";
        private static string Resources => "Resources";
        private static string Assets => "assets";
        #endregion
        
        #region 安卓打包相关
        // 安卓构建目录
        public static readonly string SdkArchiveApkDirAndroid = $"{SdkArchiveProjectBuildDir}/Android/Products"; 
        // sdk工作目录下 values路径
        public static readonly string SdkWorkDirValuesPath = $"{SdkDataDir}/{Res}/{Values}";
        // 导出工程后 assets目录
        public static readonly string SdkWorkDirAssets = $"{GradleProjectSrcMainPath}/assets";
        #endregion
        
        #region 文件名定义
        public const string MainTemplateGradleFileName = "mainTemplate.gradle";
        public const string LauncherTemplateGradleFileName = "launcherTemplate.gradle";
        public const string SettingsTemplateGradleFileName = "settingsTemplate.gradle";
        public const string AndroidManifestXmlFileName = "AndroidManifest.xml";
        public const string IOSExportOptionsPlistFileName = "ExportOptions.plist";
        #endregion
        
        #region 生成Gradle工程后的路径相关
        private const string GradleProjectSrcMainPath = "/src/main";
        // Manifest文件路径
        public static readonly string GradleProjectManifestPath = $"{GradleProjectSrcMainPath}/{AndroidManifestXmlFileName}";
        // gradle res Path
        private static readonly string GradleProjectResPath = $"{GradleProjectSrcMainPath}/{Res}";
        // gradle project xml relative paths
        public static readonly string GradleProjectXmlRelativePath = $"{GradleProjectResPath}/{Xml}";
        // gradle project values relative paths
        public static readonly string GradleProjectValuesRelativePath = $"{GradleProjectResPath}/{Values}";
        #endregion
        
        #region iOS打包相关
        // Xcode工程目录
        public static readonly string SdkArchiveXcodeProjectDir = $"{SdkArchiveProjectBuildDir}/iOS/XcodeProjectDir";
        // Xcode工程准备目录
        public static readonly string SdkArchiveXcodePrepareInfoDebugDir = $"{SdkArchiveProjectBuildDir}/iOS/PrepareInfo/Debug";
        public static readonly string SdkArchiveXcodePrepareInfoProductDir = $"{SdkArchiveProjectBuildDir}/iOS/PrepareInfo/Release";
        // Xcode构建产物目录
        public static readonly string SdkArchiveXcodeProductsDir = $"{SdkArchiveProjectBuildDir}/iOS/Products";
        // Xcode构建日志目录
        public static readonly string SdkArchiveXcodeLogsDir = $"{SdkArchiveProjectBuildDir}/iOS/Logs";
        // Xcode导出ExportOptions.plist文件路径
        public static readonly string SdkArchiveXcodeExportOptPlistDebugPath = $"{SdkArchiveXcodePrepareInfoDebugDir}/{IOSExportOptionsPlistFileName}";
        public static readonly string SdkArchiveXcodeExportOptPlistProductPath = $"{SdkArchiveXcodePrepareInfoProductDir}/{IOSExportOptionsPlistFileName}";
        // 构建IPA包脚本路径
        public static readonly string SdkArchiveExportIpaShellPath =
            $"{Environment.CurrentDirectory}/{SdkDir}/Core/Editor/Integration/Archive/iOS/export_ipa_from_xcode_project.sh";

        #endregion
    }
}