using System;
using UnityEngine;


#if UNITY_ANDROID
#if UNITY_2022_1_OR_NEWER
#if !Google7 && !TikTokGuanFu8
using TapSDK.Core;
using TapSDK.Compliance;
using TapSDK.Login;
#endif
#endif
#endif

namespace ET
{

#if UNITY_ANDROID
#if UNITY_2022_1_OR_NEWER
    public static class TapSDKV20Helper
    {

        //预置事件
        //事件名 名称 说明
        //device_login App 启动 调用 SDK 初始化接口时会上报此事件，首次上报一个设备 ID 时将在设备表产生一条记录
        //user_login  账号登录 调用 SDK SetUser 接口时会上报此事件，首次上报一个账号 ID 时将在账号表产生一条记录
        //play_game   游玩时长 SDK 会以应用进入前台作为计时起点，置于后台时，上报此时间段的时长
        //charge  用户付费 调用 SDK Charge 接口时会上报此事件，通常情况下建议使用服务端 REST API 进行上报


        /// <summary>
        /// 在 TapSDK 初始化时，同步初始化 TapDB。
        /// </summary>
        /// <param name="clientID"> 必须，开发者中心对应 Client ID</param>
        /// <param name="clientToken">必须，开发者中心对应 Client Token</param>
        /// <param name="serverURL">必须，开发者中心 > 你的游戏 > 游戏服务 > 基本信息 > 域名配置 > API</param>
        ////非必须，CN 表示中国大陆，IO 表示其他国家或地区
        /// TapDB 会根据 TapConfig 的配置进行自动初始化
        ///device_login	App 启动	调用 SDK 初始化接口时会上报此事件，首次上报一个设备 ID 时将在设备表产生一条记录 

        // 是否已初始化
        private static bool hasInit = false;


        public static void Init()
        {
#if !Google7 && !TikTokGuanFu8
            if (!hasInit)
            {
                hasInit = true;

                ET.Log.ILog.Debug("Tap Bootstrap.Init");

                // 核心配置
                TapTapSdkOptions coreOptions = new TapTapSdkOptions
                {
                    // 客户端 ID，开发者后台获取
                    clientId = ConfigHelper.clientId,
                    // 客户端令牌，开发者后台获取
                    clientToken = ConfigHelper.clientToken,
                    // 地区，CN 为国内，Overseas 为海外
                    region = TapTapRegionType.CN,
                    // 语言，默认为 Auto，默认情况下，国内为 zh_Hans，海外为 en
                    preferredLanguage = TapTapLanguageType.zh_Hans,
                    // 游戏版本号，如果不传则默认读取应用的版本号
                    gameVersion = "gameVersion",
                    // CAID，仅国内 iOS
                    caid = "000-000-0000-00000",
                    // 是否开启广告商 ID 收集，默认为 false
                    enableAdvertiserIDCollection = false,
                    // OAID证书, 仅 Android，用于上报 OAID 仅 [TapTapRegion.CN] 生效
                    oaidCert = null,
                    // 是否开启日志，Release 版本请设置为 false
                    enableLog = true,
                    // 是否禁用 OAID 反射，默认为 true
                    disableReflectionOAID = true
                };

                // 合规认证配置 防沉迷
                TapTapComplianceOption complianceOption = new TapTapComplianceOption
                {
                    showSwitchAccount = true,  // 是否显示切换账号按钮
                    useAgeRange = false  // 游戏是否需要获取真实年龄段信息
                };

                //数据分析相关配置
                TapTapEventOptions eventOptions = new TapTapEventOptions
                {
                    // 渠道，如 AppStore、GooglePlay
                    channel = "gameChannel",
                    // 初始化时传入的自定义参数，会在初始化时上报到 device_login 事件
                    propertiesJson = "",
                    // 是否能够覆盖内置参数，默认为 false
                    overrideBuiltInParameters = false,
                    // 是否开启自动上报 IAP 事件
                    enableAutoIAPEvent = true,
                    // 是否禁用自动上报设备登录事件，默认为 false
                    disableAutoLogDeviceLogin = false
                };


                TapTapSdkBaseOptions[] otherOptions = new TapTapSdkBaseOptions[]
                {
                    complianceOption,
                    eventOptions,
                    // ... 其他模块配置项
                };
                TapTapSDK.Init(coreOptions, otherOptions);
            }
#endif
        }

        /// <summary>
        /// user_login	账号登录	调用 SDK SetUser 接口时会上报此事件，首次上报一个账号 ID 时将在账号表产生一条记录
        /// </summary>
        /// <param name="userId"></param>
        public static void SetUser(string userId)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            ET.Log.ILog.Debug("Tab SetUser.Init");
            TapTapEvent.SetUserID(userId);
#endif
        }

        //衍生事件
        //在上报预置事件时，TapDB 也会同时记录一些特殊事件，这类特殊的事件我们称之为衍生事件。衍生事件无法通过 API 直接上报，只会由预置事件上报后触发。
        //dau_device App 当日首次次启动 App 在每日首次上报 device_login 时触发，可用于快速查询设备 DAU
        //dvau_device App 当日首次启动（按版本）	App 的不同版本在每日首次上报 device_login 时触发，可用于快速查询分版本的设备 DAU
        //wau_device App 当周首次启动 App 在每周首次上报 device_login 时触发，可用于快速查询设备 WAU
        //mau_device App 当月首次启动 App 在每月首次上报 device_login 时触发，可用于快速查询设备 MAU
        //dau_user 账号当日首次登录    账号每日首次上报 user_login 时触发，可用于快速查询账号 DAU
        //wau_user 账号当周首次登录    账号每周首次上报 user_login 时触发，可用于快速查询账号 WAU
        //mau_user 账号当月首次登录    账号每月首次上报 user_login 时触发，可用于快速查询账号 MAU
        public static void ClearUser()
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.ClearUser();
#endif
        }

        /// <summary>
        /// 在用户进行充值后，可调用该接口上报充值信息，调用后将上报 charge 事件，并将传入的参数作为事件的属性。
        /// </summary>
        /// <param name="orderId">订单 ID</param>
        /// <param name="product">产品名称</param>
        /// <param name="amount">充值金额（单位分，即无论什么币种，都需要乘以 100）</param>
        /// <param name="currencyType">货币类型，遵循 ISO 4217 标准。参考：人民币 CNY，美元 USD；欧元 EUR</param>
        /// <param name="payment">支付方式，如：支付宝</param>
        /// <param name="properties">充值（ charge ）的事件属性</param>
        public static void OnCharge(string orderId, string product, long amount, string currencyType, string payment, string properties)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.LogPurchasedEvent(orderID: orderId,
                productName: product,
                amount: amount,
                currencyType: currencyType,
                paymentMethod: payment,
                properties: properties);
#endif
        }

        //自定义事件
        //除了预置事件和衍生事件外，也可以在事件管理中建立更多自定义事件。
        //TapDB 的 REST API 支持传入数据格式为 URLEncode 后的 JSON 对象， 如果你直接使用 TapDB 的 REST API 则需要按照此格式进行上报。 如果你使用 SDK 接入，数据也会转化成该格式进行上报。
        //    {
        //    ["index" | "client_id"]: ["APPID" | "ClientID"],
        //    "device_id": "DeviceID",
        //    "user_id": "UserID",
        //    "type": "track",
        //    "name": "EventName",
        //    "properties": {
        //        "os": "Android",             
        //        "device_id1": "000",             
        //        "device_id2": "000",             
        //        "device_id3": "000",             
        //        "device_id4": "000",     
        //        "width": 256,                    
        //        "height": 768,                   
        //        "device_model": "pixel",         
        //        "os_version": "Android 10.0",
        //        "provider": "O2",                
        //        "network": "1",                  
        //        "channel": "Google Play",        
        //        "app_version": "1.0",
        //        "sdk_version": "2.8.0",
        //        "#custem_event_property_name": "CustomEventPropertyValue"
        //    }
        //}
        /// <summary>
        /// 在 SDK 初始化完成后可使用该接口上报事件
        /// </summary>
        /// <param name="eventName">事件的名称</param>
        /// <param name="properties">事件的属性</param>
        /// 注意:
        //事件名支持上报预置事件和自定义事件，其中自定义事件应以 # 开头
        //事件属性的 key 值为属性的名称，支持 NSString 类型
        //事件属性的 value 值为属性的名称，支持 NSString（最大长度 256 ）、NSNumber（取值区间为[-9E15, 9E15] ）类型
        //事件属性支持上报预置属性和自定属性，其中自定义属性应以 # 开头
        //事件属性传入预置属性时，SDK 默认采集的预置属性将被覆盖
        public static void TestTrackEvent(string eventName, string properties)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            ET.Log.ILog.Debug("Tap TrackEvent");
            TapTapEvent.LogEvent("#eventName_2", "{\"#serverid\":\"3\"}");
#endif
        }

        public static void TrackEvent(string eventName, string properties)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.LogEvent(eventName, properties);
#endif
        }

        /// <summary>
        /// 对于一些所有事件都要携带的属性，建议使用通用事件属性实现。
        /// 添加静态通用事件属性
        /// </summary>
        /// <param name="staticProperties">静态通用事件属性字典</param>
        public static void RegisterStaticProperties(string staticProperties)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.AddCommon(staticProperties);
#endif
        }

        /// <summary>
        /// 删除单个静态通用事件属性
        /// </summary>
        /// <param name="propertyName">静态通用属性名</param>
        public static void UnregisterStaticProperty(string propertyName)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.ClearCommonProperty("#current_channel");
#endif
        }

        /// <summary>
        /// 清空全部静态通用属性
        /// </summary>
        public static void ClearStaticProperties()
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.ClearAllCommonProperties();
#endif
        }


        public static void UploadUserData(string rolename, int level, int combat, int rechargeNumber, string servername)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"#rolename\":\"" + rolename + "\"}";
            Log.ILog.Debug(properties);
            TapTapEvent.UserUpdate(properties);

            properties = "{\"#level\":\"" + level + "\"}";
            TapTapEvent.UserUpdate(properties);

            properties = "{\"#combat\":\"" + combat + "\"}";
            TapTapEvent.UserUpdate(properties);

            properties = "{\"#rechargeNumber\":\"" + rechargeNumber + "\"}";
            TapTapEvent.UserUpdate(properties);

            properties = "{\"#servername\":\"" + servername + "\"}";
            TapTapEvent.UserUpdate(properties);
#endif
        }


        // 角色名称
        public static void UserUpdate_rolename(string rolename)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"rolename\":\"" + rolename + "\"}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 服务器名称
        public static void UserUpdate_servername(string servername)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"servername\":\"" + servername + "\"}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 在线时间（单位：分钟）
        public static void UserUpdate_allOnLine(int add)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"allOnLine\":" + add + "}";
            TapTapEvent.UserAdd(properties);
#endif
        }

        // 最后离线时间(时间戳)
        public static void UserUpdate_finalOffline(string finalOffline)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"finalOffline\":\"" + finalOffline + "\"}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 是否第一次建立角色
        public static void UserUpdate_isFirstCreateRole(int isFirstCreateRole)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"isFirstCreateRole\":" + isFirstCreateRole + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 战力
        public static void UserUpdate_combat(int combat)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"combat\":" + combat + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 等级
        public static void UserUpdate_level(int level)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"level\":" + level + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 金币
        public static void UserUpdate_gold(int gold)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"gold\":" + gold + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 钻石
        public static void UserUpdate_diamond(int diamond)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"diamond\":" + diamond + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 充值
        public static void UserUpdate_rechargeNumber(int rechargeNumber)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"rechargeNumber\":" + rechargeNumber + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 当前任务ID
        public static void UserUpdate_currentTaskId(int currentTaskId)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"currentTaskId\":" + currentTaskId + "}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        // 当前任务名称
        public static void UserUpdate_currentTaskName(string currentTaskName)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            string properties = "{\"currentTaskName\":\"" + currentTaskName + "\"}";
            TapTapEvent.UserUpdate(properties);
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rolename"></param>
        /// <param name="servername"></param>
        /// <param name="eventType">  1.十连抽次数  2 洗炼次数  3 宠物抽奖次数 4 充值 5被杀记录</param>   
        /// <param name="eventVlue"></param>
        public static void UpLoadPlayEvent(string rolename, string servername, int level, int eventType, int eventVlue)
        {
            if (!hasInit)
            {
                return;
            }

#if !Google7 && !TikTokGuanFu8
            TapTapEvent.LogEvent("#WeiJingEvent", "{\"#rolename\":\"" + rolename + "\"}");
            TapTapEvent.LogEvent("#WeiJingEvent", "{\"#level\":\"" + level + "\"}");
            TapTapEvent.LogEvent("#WeiJingEvent", "{\"#servername\":\"" + servername + "\"}");
            TapTapEvent.LogEvent("#WeiJingEvent", "{\"#EventType\":\"" + eventType + "\"}");
            TapTapEvent.LogEvent("#WeiJingEvent", "{\"#EventValue\":\"" + eventVlue + "\"}");
#endif
        }

        //1.激活
        //2.注册
        //3.付费
        //4.次留
        //枚举值{1,2,3,4,5,6}：1：激活 首次打开 APP 2：注册 在 APP 内注册账户/创角 3：付费(多次)4：次留 5：全渠道首次吊起（当日 app 首次被促活广告拉起） 6：关键事件 （用户在 app 进行了一些黑盒关键行为， 如加购等）
        //转化事件发生后，开发者/第三方在请求接口后附上回传字段({DEEP_CALLBACK_URL}&tap_project_id=13&tap_track_id=xxxevent_type=xxx&event_timestamp={timestamp}&???=xxx)，并发起 GET 请求，上报给 TapREP。
        public static async ETTask TapReqEvent(string taprepRequest, int eventType, string eventData)
        {
            if (!hasInit)
            {
                return;
            }
            if (string.IsNullOrEmpty(taprepRequest))
            {
                return;
            }


#if !Google7
            //转化事件发生后，开发者/第三方在请求接口后附上回传字段({DEEP_CALLBACK_URL}&event_type=xxx&event_timestamp={timestamp}&???=xxx)，并发起 GET 请求，上报给 TapREP。
            string url = $"{taprepRequest}&event_type={eventType}&event_timestamp={TimeHelper.ServerNow()}&amount={eventData}";

            Log.ILog.Debug($"taprepRequest:{taprepRequest}   {eventType}");

            Log.Debug($"TapReqEvent_1 request  url: {url}");
            string routerInfo = await HttpClientHelper.Get(url);
            Log.Debug($"TapReqEvent_1 respose  url: {routerInfo}");
#endif
        }





        //500	LOGIN_SUCCESS 玩家未受到限制，正常进入游戏
        //1000	EXITED 退出防沉迷认证及检查，当开发者调用 Exit 接口时或用户认证信息无效时触发，游戏应返回到登录页
        //1001	SWITCH_ACCOUNT 用户点击切换账号，游戏应返回到登录页
        //1030	PERIOD_RESTRICT 用户当前时间无法进行游戏，此时用户只能退出游戏或切换账号
        //1050	DURATION_LIMIT 用户无可玩时长，此时用户只能退出游戏或切换账号
        //1100	AGE_LIMIT 当前用户因触发应用设置的年龄限制无法进入游戏
        //1200	INVALID_CLIENT_OR_NETWORK_ERROR 数据请求失败，游戏需检查当前设置的应用信息是否正确及判断当前网络连接是否正常
        //9002	REAL_NAME_STOP 实名过程中点击了关闭实名窗，游戏可重新开始防沉迷认证

        public static Action<int, string> AntiAddictionHandler;

        /// <summary>
        /// �����
        /// -1	δ֪
        ///0	0 �� 7 ��
        ///8	8 �� 15 ��
        ///16	16 �� 17 ��
        ///18	�������
        /// </summary>
        /// <returns></returns>
        public static async ETTask<int> GetAgeRange()
        {
#if !Google7 && !TikTokGuanFu8
            return await TapTapCompliance.GetAgeRange();
#else
            return 0;
#endif

        }


        public static async ETTask<int> GetRemainingTime()
        {
#if !Google7 && !TikTokGuanFu8
            return await TapTapCompliance.GetRemainingTime();
#else
            return 0;
#endif
        }

        private static string clientId = ConfigHelper.clientId;


        private static bool v20hasInit = false;


        public static bool hasCheckedAntiAddiction { get; private set; }



        public static void InitSDK()
        {

#if !Google7 && !TikTokGuanFu8
            if (!v20hasInit)
            {
                v20hasInit = true;

                Action<int, string> AntiAddictionCallback = (code, errorMsg) =>
                {

                    switch (code)
                    {

                        case 500: // ���δ�����ƣ�����������
                                  // TODO: ��ʾ��ʼ��Ϸ��ť      
                            break;

                        case 1000: // ��������֤ƾ֤��Чʱ����
                        case 1001: // ����Ҵ���ʱ������ʱ����������ش����С��л��˺š���ť
                        case 9002: // ʵ����֤��������ҹر���ʵ������
                            TapTapLogin.Instance.Logout(); // �����Ϸ�������˻�ϵͳ����ʱҲӦִ���˳�
                                                           // TODO: �л�����¼ҳ�� ���磺SceneManager.LoadScene("Login");
                            break;

                        case 1100: // ��ǰ�û����Ӧ�����õ����������޷�������Ϸ
                                   // TODO: ��ϷӦ���л�������������ʾ������������˳���Ϸ
                            break;

                        case 1200: // ��������ʧ�ܣ�Ӧ����Ϣ��������������쳣  
                                   // TODO: �������ȷ�����������Ƿ������������µ��ÿ�ʼ��֤�ӿ�
                            break;

                        default:
                            Debug.Log("������ѡ�ص�");
                            break;
                    }

                    UnityEngine.Debug.LogFormat($"code: {code} error Message: {errorMsg}");

                    // UnityEngine.Debug.LogFormat($"ageRange: {AntiAddictionUIKit.AgeRange}");
                    // UnityEngine.Debug.LogFormat($"remainingTime: {AntiAddictionUIKit.RemainingTime}");

                    if (AntiAddictionHandler != null)
                    {
                        AntiAddictionHandler(code, errorMsg);
                    }
                };

                // 回调设置
                TapTapCompliance.RegisterComplianceCallback(AntiAddictionCallback);
            }

#endif
        }

        /// <summary>
        /// taptapʵ����֤
        /// </summary>
        public static void RealNameAuther(string userid)
        {

            InitSDK();

#if !Google7 && !TikTokGuanFu8
            ///System.Guid.NewGuid();  ϵͳ��������Ψһid
            // ע��Ψһ��ʶ����ֵ���Ȳ��ܳ��� 64 �ַ�
            //int timestart = (int)Time.time;
            TapTapCompliance.Startup(userid);
#endif
        }

        /// <summary>
        /// ��ʼ�Ϲ���֤���
        /// </summary>
        /// <param name="userIdentifier">�û�Ψһ��ʶ</param>
        public static void StartAntiAddiction(string userIdentifier)
        {
            hasCheckedAntiAddiction = false;
            //AntiAddictionUIKit.StartupWithTapTap(userIdentifier);
        }



    }

#endif
#endif
}


