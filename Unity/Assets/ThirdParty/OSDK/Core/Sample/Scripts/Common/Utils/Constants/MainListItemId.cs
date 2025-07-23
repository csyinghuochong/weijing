namespace Douyin.Game
{
    public static class MainListItemId
    {
        // ############ 基础功能ID ################
        // ------------登录功能-------------
        public const string LOGIN_FUNCTION = "login_function";
        public const string LOGIN = "login"; // 登录
        public const string SWITCH_ACCOUNT = "switch_account"; // 切换账号
        public const string GUEST_ACCOUNT_BINDING = "guest_account_binding"; // 游客账号绑定
        public const string CHECKOUT_IF_VISITORS = "check_if_visitors"; // 查询是否游客登录
        public const string QUERY_ACCOUNT_INFO = "query_account_info"; // 查询用户信息
        public const string UPDATE_ACCOUNT_NICKNAME = "update_account_nickname"; // 更新用户昵称
        public const string CLOSE_ACCOUNT = "close_account"; // 注销账号
        public const string UNBIND_DOUYIN = "unbind_douyin"; //解绑抖音
        public const string QUERY_DEVICE_PRIVACY_INFO = "query_device_privacy_info"; //查询设备隐私信息
        public const string CLOSE_DEVICE_INFO = "close_device_info"; //注销设备信息
        public const string DeviceRealNameAntiAddiction = "device_real_name_anti_addiction"; //触发设备实名和防沉迷

        // -----------支付功能--------------
        public const string PAYMENT_FUNCTION = "payment_function";
        public const string PAYMENT_ENTER_AMOUNT = "payment_input_amount"; // 请输入支付金额
        public const string STARTUP_PAY = "startup_pay"; // 启动支付服务
        public const string PAYMENT = "payment"; // 支付
        public const string CHECK_IF_PAYMENT_IS_SUPPORTED = "check_if_payment_is_supported"; // 查询是否支持支付
        public const string REBIND_ORDER_PAY = "rebind_order_pay"; // 自助补单弹窗


        // -----------合规--------------
        public const string REAL_NAME_SYSTEM = "real_name_system";
        public const string CHECK_IF_THE_REAL_NAME_AUTHENTICATION = "check_if_the_real_name_authentication"; // 查询是否已实名
        public const string QUERY_GP_INFORMATION = "query_gp_information"; // 查询gp信息
        public const string REPORT_GP_RESULT = "report_gp_result"; // 上报处罚结果
        public const string PersonalPrivacyProtectionSetting = "personal_privacy_protection_setting";
        public const string AgeLevelHintOpen = "age_level_hint_open";
        public const string AgeLevelHintOpenAndAutoClose = "age_level_hint_open_and_auto_close";

        // -----------ad--------------
        public const string Ad = "ad";

        //广告隐私合规相关
        public const string SETTING_CLOSE_LOCATION_PERMISSION = "close_location_permission"; // 关闭广告地理位置申请
        public const string SETTING_BLOCK_PERSONALIZED_ADS = "block_personalized_ads"; // 屏蔽个性化推荐广告
        public const string SETTING_UNBLOCK_PERSONALIZED_ADS = "unblock_personalized_ads"; // 不屏蔽个性化推荐广告
        public const string PersonalAdsStatus = "Personal_Ads_status";
        public const string CAIDSwitchIsOn = "CAID_Switch_IsOn";
        public const string ConfigCAIDSwitchOn = "config_CAID_Switch_On";
        public const string ConfigCAIDSwitchOff = "config_CAID_Switch_Off";
        public const string InputLongitude = "input_longitude";
        public const string ConfigLongitude = "config_longitude";
        public const string CurrentLongitude = "current_longitude";
        public const string InputLatitude = "input_latitude";
        public const string ConfigLatitude = "config_latitude";
        public const string CurrentLatitude = "current_latitude";
        public const string UserValueGroup = "User_Value_Group";
        
        // 原生广告
        public const string NATIVE_AD = "native_ad";

        // 全屏视频
        public const string FULL_SCREEN_AD = "full_screen_ad"; // 全屏视频广告
        public const string LOAD_FULL_SCREEN_AD_H = "load_full_screen_ad_h"; // 加载横版全屏视频广告//
        public const string LOAD_FULL_SCREEN_AD_V = "load_full_screen_ad_v"; // 加载竖版全屏视频广告
        public const string SHOW_FULL_SCREEN_AD = "show_full_screen_ad"; // 展示全屏视频广告
        public const string SHOW_FULL_SCREEN_AD_WITH_SCENE = "show_full_screen_ad_with_scene"; // 展示全屏视频

        // 插全屏广告
        public const string LOAD_INTERSTITIAL_AD_H = "load_interstitial_ad_h"; // 加载横版全屏视频广告//
        public const string LOAD_INTERSTITIAL_AD_V = "load_interstitial_ad_v"; // 加载竖版全屏视频广告
        public const string SHOW_INTERSTITIAL_AD = "show_interstitial_ad"; // 展示全屏视频广告

        // 激励视频
        public const string REWARD_AD = "reward_ad";
        public const string LOAD_REWARD_AD_H = "load_reward_ad_h"; // 加载横版激励视频广告
        public const string LOAD_REWARD_AD_V = "load_reward_ad_v"; // 加载竖版激励视频广告
        public const string SHOW_REWARD_AD = "show_reward_ad"; // 展示激励视频广告
        public const string SHOW_REWARD_AD_WITH_SCENE = "show_reward_ad_with_scene"; // 在场景中展示激励视频广告

        // 个性化模板全屏广告
        public const string EXPRESS_FULL_SCREEN_AD = "express_full_screen_ad";
        public const string LOAD_EXPRESS_FULL_SCREEN_AD_H = "load_express_full_screen_ad_h"; // 加载横版个性化模板全屏视频广告
        public const string LOAD_EXPRESS_FULL_SCREEN_AD_V = "load_express_full_screen_ad_v"; // 加载竖版个性化模板全屏视频广告
        public const string SHOW_EXPRESS_FULL_SCREEN_AD = "show_express_full_screen_ad"; // 展示个性化模板全屏视频广告
        public const string SHOW_EXPRESS_FULL_SCREEN_AD_WITH_SCENE = "show_express_full_screen_ad_with_scene"; // 在场景中展示个性化模板全屏视频广告

        // 个性化模板激励广告
        public const string EXPRESS_REWARD_AD = "express_reward_ad";
        public const string LOAD_EXPRESS_REWARD_AD_H = "load_express_reward_ad_h"; // 加载横版个性化模板激励视频广告
        public const string LOAD_EXPRESS_REWARD_AD_V = "load_express_reward_ad_v"; // 加载竖版个性化模板激励视频广告
        public const string SHOW_EXPRESS_REWARD_AD = "show_express_reward_ad"; // 展示个性化模板激励视频广告
        public const string SHOW_EXPRESS_REWARD_AD_WITH_SCENE = "show_express_reward_ad_with_scene"; // 在场景中展示个性化模板激励视频广告

        // 开屏广告
        public const string SPLASH_AD = "splash_ad";
        public const string LOAD_SPLASH_AD = "load_splash_ad"; // 加载开屏广告
        public const string SHOW_SPLASH_AD = "show_splash_ad"; // 展示开屏广告

        // 原生横幅广告
        public const string BANNER_AD = "banner_ad";
        public const string LOAD_BANNER_AD = "load_banner_ad"; // 加载原生横幅广告
        public const string SHOW_BANNER_AD = "show_banner_ad"; // 展示原生横幅广告
        
        // 原生信息流广告
        public const string LOAD_NATIVE_AD = "load_native_ad"; // 加载原生广告
        public const string REMOVE_NATIVE_AD = "remove_native_ad"; // 移除原生广告

        // ############ 运营功能ID ################
        // 反馈系统
        public const string FEEDBACK_SYSTEM = "feedback_system";
        public const string USER_FEEDBACK = "user_feedback";
        
        // 用户触达
        public const string USER_REACH = "user_reach";
        public const string EMAIL_SYSTEM = "email_system";
        public const string QueryAnnouncementCount = "query_announcement_count";
        public const string OpenAnnouncement = "open_announcement";
        public const string FETCH_CROSS_DIVERSION_INFO = "fetch_cross_diversion_info";
        public const string IS_SHOW_ACTIVITY_POINT_ACTIVE = "is_show_activity_point_active";
        public const string IS_SHOW_ACTIVITY_POINT_PASSIVE = "is_show_activity_point_passive";
        public const string ACTIVE_POP_UP_DRAINAGE_WINDOW = "active_pop_up_drainage_pop_up_window";
        public const string PASSIVE_POP_UP_DRAINAGE_WINDOW = "passive_pop_up_drainage_pop_up_window";
        
        //兑换码
        public const string REDEEM_CODE = "redeem_code";
        public const string REDEEM = "redeem";
        public const string INPUT_REDEEM_CODE = "input_redeem_code";
        
        // ############ 其他功能个ID ################
        public const string OTHER = "other"; // 其他功能

        public const string GAME_EVENT_VERIFICATION = "game_event_verification"; // 游戏埋点验证
        public const string CUSTOM_EVENT_SENDING = "custom_event_sending"; // 自定义事件发送

        // 增值功能
        public const string APPRECIATION_FUNCTIONS = "appreciation_functions";
        public const string GAME_PROTECT_SENSITIVE_WORDS_INPUT = "gp_sensitive_words_input"; // 敏感词输入框
        public const string GAME_PROTECT_SENSITIVE_WORDS_VERIFY = "gp_sensitive_words_verify"; // 敏感词验证
        public const string IN_APP_GUIDED_SCORE = "ios_app_rating";//应用内引导评分
        
        // 设置功能
        public const string GAME_SETTING = "game_settings"; // 游戏设置

        public const string SETTING_REQUIRE_IDFA = "require_idfa"; // 获取 IDFA 权限
        public const string SETTING_USER_PROTOCOL = "open_user_protocol"; // 打开用户协议
        public const string SETTING_PRIVACY_PROTOCOL = "open_privacy_protocol"; // 打开隐私政策
        public const string SETTING_IDENTIFY_PROTOCOL = "open_identify_protocol"; // 打开隐私政策 
        public const string SETTING_AGE_LIMIT_TIPS = "open_age_limit_tips"; // 打开适龄提示 
        public const string SETTING_SDK_INITIALIZE = "SDK_initialize"; // 触发初始化

        // 仅供测试功能
        public const string TEST_FUNCTION = "test_function"; // 测试功能
        public const string SETTING_TRIGGER_CRASH = "trigger_crash"; // 触发崩溃
        public const string SETTING_SDK_VERSION = "sdk_version"; // sdkVersion
        public const string CLEAR_ACCOUNT_TOKEN = "clear_account_token"; // 清除账号Token(ForTest)

    }
}