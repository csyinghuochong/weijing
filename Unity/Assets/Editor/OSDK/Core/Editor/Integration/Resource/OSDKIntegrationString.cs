namespace Douyin.Game
{
    public static class OSDKIntegrationString
    {
        internal const string KTitleHelpCenter = "错误码查询";
        internal const string KTitleHelpCenterText = "unity对应错误码快速查询。";
        internal const string KTitleSample = "Demo场景展示";
        internal const string KTitleEnvironment = "环境配置";
        internal const string KTitleSecretPlaceholder = "请填写Unity接入密钥";
        internal const string KTitleSecretKey = "1.密钥 Secret Key（必填）：";
        internal const string kTitleOSDKTypeKey = "2.当前业务模式";
        internal const string KTitleFetchConfigAndroidButton = "拉取Android配置信息";
        internal const string KTitleFetchConfigiOSButton = "    拉取iOS配置信息   ";
        internal const string KTitleConfigInfo = "配置信息";
        internal const string KTitleUniformId = "App ID：";
        internal const string KTitleClientKey = "Client Key：";
        internal const string KTitleLiveTTSDKID = "Live TTSDK ID：";
        internal const string KTitleLiveTTWebcastID = "Live TTWebcast ID：";
        internal const string KTitleLiveLicense = "Live TTSDK License：";
        internal const string KTitleLiveMsext = "Live TTSDK Msext  ：";
        internal const string KTitleIOSUserTrackingUsageDescription = "User Tracking Usage Description：";
        internal const string KTitleIOSPhotoLibraryUsageDescription = "Photo Library Usage Description：";
        internal const string KTitleIOSPermissions = "iOS权限描述";

        internal const string KTitleIndex = "自助接入";
        internal const string KTitleDebugMode = "调试开关 DebugMode：";
        internal const string KTitleGameStage = "游戏包类型：";
        internal const string KTitleInit = "基础：初始化";
        internal const string KTitleGameRole = "基础：游戏账号绑定";
        internal const string KTitleStandardCodeGuide = "标准化代码模板：";
        internal const string KTitleOpenButton = "打开模板代码";
        internal const string KTitleCreateButton = "创建模板代码";
        internal const string KTitleDeleteButton = "删除";
        internal const string KTitleGetButton = "获取";
        internal const string KTitlePCMock = "模拟验证：";
        
        internal const string KTitleUnion = "基础：流水分账";
        
        internal const string KTitleUnionAccount = "1.登录（Android）";
        internal const string KTitleAccountLoginPCMock = "账号登录模拟验证：";
        internal const string KTitleAccountSwitchPCMock = "账号切换模拟验证：";
        internal const string KTitleAccountLogoutPCMock = "账号退出模拟验证：";
        
        internal const string KTitleUnionPay = "2.支付（Android）";
        internal const string KTitlePayPCMock = "支付模拟验证：";
        
        internal const string KTitleDataLink = "基础：全官服促活分账";        

        internal const string KTitleAuthorize = "基础：抖音授权";

        internal const string KTitleAd = "附加：广告";
        
        internal const string KTitleShare = "附加：分享";
        
        internal const string KTitleRecord = "附加：录制";
        internal const string KTitleStartRecordPCMock = "开始录制模拟验证：";
        internal const string KTitleStopRecordPCMock = "结束录制模拟验证：";
        internal const string KTitleGetRecordListPCMock = "获取录制列表模拟验证：";
        internal const string KTitleDeleteRecordVideoPCMock = "删除录制视频模拟验证：";
        
        internal const string KTitleLive = "附加：看播";
        internal const string KTitleCloudGame = "基础：云游戏";
        internal const string KTitleTeamPlay = "附加：一键上车";
        
        internal const string KTitleADConfig = "0.广告基础配置";
        internal const string KTitleRewardAD = "1.激励视频广告";
        internal const string KTitleInterstitialAD = "2.插屏广告";
        internal const string KTitleBannerAD = "3.Banner广告";
        internal const string KTitleSplashAD = "4.开屏广告";
        internal const string KTitleUpdateADInfo = "同步广告信息";
        internal const string KTitleNameInput = "模板代码文件名称：   ";
        internal const string KTitleNameInputCloud = "开放平台广告名称：   ";
        internal const string KTitleAndroidAdid = "android 代码位 id：  ";
        internal const string KTitleAndroidBizid = "android biz id：      ";
        internal const string KTitleIosAdid = "ios代码位id：        ";
        internal const string KTitleIosBizid = "ios biz id： ";
        internal const string KTitleAdOrientation = "横竖屏：              ";

        internal const string KTitleMoreSettings = "Android更多配置";
        
        internal const string KTitleArchiveAndroidDebugAPK = "构建 Debug 环境APK包";
        internal const string KTitleArchiveAndroidReleaseAPK = "构建 Release 环境APK包";
        internal const string KTitleArchive = "构建";
        internal const string KTitleSelect = "选取";
        internal const string KTitleExport = "导出";
        
        internal const string KTitleArchiveIOSEnvironmentSelect = "构建环境          ：";
        internal const string KTitleArchiveIOSIPA = "构建 IPA 包       ：";
        internal const string KTitleExportIOSDebugProject = "导出 Debug 环境Xcode工程";
        internal const string KTitleExportIOSReleaseProject = "导出 Release 环境Xcode工程";
        internal const string KTitleArchiveIOSProvisionProfile = "配置文件（ProvisionProfile）";
        internal const string KTitleArchiveIOSTeamID = "Signing Team ID（Readonly）：";
        internal const string KTitleArchiveIOSDevelopmentCer = "Development 环境配置文件";
        internal const string KTitleArchiveIOSProductionCer = "Production     环境配置文件";

        internal const string KTitleVersion = "SDK版本";
        
        #region 提示相关文案

        internal const string KTipsSecretKey =
            "填写Unity接入密钥，点击【获取】按钮获取密钥，填写后点击【拉取配置信息】按钮拉取配置信息。\n密钥路径：抖音游戏厂商合作平台 - 游戏资料 - SDK接入 - 接入管理 - 查看详情 - 完成技术接入 - 去接入 - 参数配置 - App Secret。";
        internal const string KTipsOSDKBizMode = "业务模式可以在抖音游戏厂商合作平台-接入管理-接入详情-配置接入方案中查看。\n若展示的业务模式和实际业务不符合，请检查导入的产物包是否正确。";
        internal const string KTipsDebugMode = "开启调试模式会弹出行为检测工具插件辅助接入，输出日志信息等。\n正式出包时，必须关闭调试模式。";
        internal const string KTipsGameStage = "游戏包类型（游戏运营阶段），包括 删档测试包 和 不删档包（正式包）。\n删档测试包：在抖音圈选一批用户提前体验游戏，例如删档不付费测试、删档付费测试；\n不删档包（正式包）：正式发行运营的游戏包，包括不删档付费测试的包。";
        internal const string KTipsLiveLicense = "用于直播服务能力校验，可发起抖音游戏SDK服务台协助申请。";
        internal const string KTipsLiveMsext = "用于直播服务能力校验，可发起抖音游戏SDK服务台协助申请。";

        internal const string KTipsStandardCodeGuide =
            "点击「创建模板代码」按钮，会自动生成标准化模板代码，可直接在生成的模板中完善游戏逻辑，挂载到对应游戏物体。\n若已创建模板代码，按钮变为「打开模板代码」，点击后可自动跳转至模板代码。";

        internal const string KWarningSecretKey = "使用demo的配置参数无法创建模板代码，请使用正式应用的包名和密钥拉取配置后再开始接入";
        internal const string KTipsPCMock = "当前功能接入完成后，可直接在Unity Editor环境中，模拟回调结果，验证游戏逻辑。";
        
        internal const string KTipsArchiveIOSEnvironmentSelect = "iOS构建环境选择，控制构建IPA与导出Xcode工程的环境，会根据环境选择自动配置证书。";
        internal const string KTipsArchiveIOSIPA = "根据「构建环境」，构建IPA包，温馨提示：Apple规定仅Debug环境包可直接安装至手机，Release环境包需上传至苹果商店，通过TestFlight安装。";
        internal const string KTipsExportIOSProject = "根据「构建环境」，导出iOS工程。";
        
        #endregion
    }
}