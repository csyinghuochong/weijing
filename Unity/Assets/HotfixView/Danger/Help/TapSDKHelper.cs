using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if UNITY_ANDROID
using TapTap.Bootstrap;
using TapTap.Common;
using TapTap.TapDB;
#endif

namespace ET
{

#if UNITY_ANDROID
    public static class TapSDKHelper
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

        public static void Init(string clientID, string clientToken, string serverURL)
        {
            var config = new TapConfig.Builder()
            .ClientID("pm0a9qavoyvn0qqmse")  // 必须，开发者中心对应 Client ID
            .ClientToken("Amv51zGQvweTTsqPKtNdO9GDKPs6FlTcMpbMQ6BW")  // 必须，开发者中心对应 Client Token
            .ServerURL("https://pm0a9qav.cloud.tds1.tapapis.cn")  // 必须，开发者中心 > 你的游戏 > 游戏服务 > 基本信息 > 域名配置 > API
            .RegionType(RegionType.CN)  // 非必须，CN 表示中国大陆，IO 表示其他国家或地区
            .TapDBConfig(true, "gameChannel", "gameVersion", true)  // TapDB 会根据 TapConfig 的配置进行自动初始化
            .ConfigBuilder();

            TapBootstrap.Init(config);
        }

        /// <summary>
        /// 在单独使用 TapDB 功能时（即不接登录功能时，不导入 TapBootstrap 包时），可以通过以下方式初始化 TapDB。
        /// </summary>
        /// <param name="clientId">Client Id 可以在控制台获取</param>
        /// <param name="channel">分包渠道</param>
        /// <param name="gameVersion">游戏版本，为空时，自动获取游戏安装包的版本</param>
        /// <param name="isCN">区域，true 表示中国大陆，false 表示中国大陆以外的国家或地区。</param>
        public static void TabDBInit(string clientId, string channel, string gameVersion, bool isCN)
        {
            TapDB.Init(clientId, channel, gameVersion, true);
        }

        /// <summary>
        /// user_login	账号登录	调用 SDK SetUser 接口时会上报此事件，首次上报一个账号 ID 时将在账号表产生一条记录
        /// </summary>
        /// <param name="userId"></param>
        public static void SetUser(string userId)
        {
            TapDB.SetUser("userId");
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
            TapDB.ClearUser();
        }

        /// <summary>
        /// 在用户进行账号登录后，可调用该接口设置该账号的名称，调用后将更新账号的账号名称（ user_name ）属性。
        /// </summary>
        /// <param name="name"></param>
        public static void SetName(string name)
        {
            TapDB.SetName("Tarara");
        }


        /// <summary>
        /// 在用户进行账号登录后，可调用该接口设置该账号的等级，调用将更新账号的账号等级（ level ）属性。
        /// </summary>
        /// <param name="level"></param>
        public static void SetLevel(int level)
        {
            TapDB.SetLevel(5);
        }

        /// <summary>
        /// 设置账号区服,在用户进行账号登录后，可调用该接口设置该账号的区服信息，调用将初始化账号的首次区服（ first_server ）属性、更新账号的当前区服（ current_server ）属性。
        /// </summary>
        /// <param name="server"></param>
        public static void SetServer(string server)
        {
            TapDB.SetServer("1 区");
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
        public static void OnCharge(string orderId, string product, long amount, string currencyType, string payment,
            string properties)
        {
            TapDB.OnCharge("0xueiEns", "轩辕剑", 100, "CNY", "wechat", "{\"on_sell\":true}");
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
        public static void TrackEvent(string eventName, string properties)
        {
            TapDB.TrackEvent("eventName_1", "{\"weapon\":\"axe\"}");
        }

        /// <summary>
        /// 对于一些所有事件都要携带的属性，建议使用通用事件属性实现。
        /// 添加静态通用事件属性
        /// </summary>
        /// <param name="staticProperties">静态通用事件属性字典</param>
        public static void RegisterStaticProperties(string staticProperties)
        {
            //当设置了静态通用事件属性 #current_channel，值固定为 TapDB 后使用事件上报时，等效于在事件属性中添加了 #current_channel
            string properties = "{\"#current_channel\":\"TapDB\"}";
            TapDB.RegisterStaticProperties(properties);
        }

        /// <summary>
        /// 删除单个静态通用事件属性
        /// </summary>
        /// <param name="propertyName">静态通用属性名</param>
        public static void UnregisterStaticProperty(string propertyName)
        {
            TapDB.UnregisterStaticProperty("#current_channel");
        }

        /// <summary>
        /// 清空全部静态通用属性
        /// </summary>
        public static void ClearStaticProperties()
        {
            TapDB.ClearStaticProperties();
        }

        /// <summary>
        /// 注册动态通用事件属性
        /// 对于可能随时发生变化的通用事件属性，可以注册动态通用事件属性回调，该回调会在每次调用时被触发，将计算好的属性添加到本次上报事件属性中。
        /// </summary>
        /// <param name="properties">动态通用事件属性计算回调</param>
        public static void RegisterDynamicProperties(IDynamicProperties properties)
        {

        }

        /// <summary>
        /// TapDB 支持两种用户主体：设备和账号，你可以通过如下接口对这两种用户的属性进行操作。
        /// 修改设备属性
        /// 设备属性初始化
        /// 对于需要保证只有首次设置时有效的属性，可以使用该接口进行赋值操作，仅当前值为空时赋值操作才会生效，如当前值不为空，则赋值操作会被忽略。
        /// </summary>
        /// <param name="properties">属性字典</param>
        public static void DeviceInitialize(string properties)
        {
            properties = "{\"firstActiveServer\":\"server1\"}";
            TapDB.DeviceInitialize(properties);
            // 此时设备表的 "#firstActiveServer" 字段值为 "server1"

            //string properties = "{\"firstActiveServer\":\"server2\"}";
            //TapDB.DeviceInitialize(properties);
            // 此时设备表的 "#firstActiveServer" 字段值还是为 "server1"
        }

        /// <summary>
        /// 对于常规的设备属性，可使用该接口进行赋值操作，新的属性值将会直接覆盖旧的属性值。
        /// </summary>
        /// <param name="properties">属性字典</param>
        public static void DeviceUpdate(string properties)
        {
            properties = "{\"currentPoints\":10}";
            TapDB.DeviceUpdate(properties);
            // 此时设备表的 "currentPoints" 字段值为 10

            properties = "{\"currentPoints\":42}";
            TapDB.DeviceUpdate(properties);
            // 此时设备表的 "currentPoints" 字段值为 42
        }

        /// <summary>
        /// 对于数值类型的属性，可以使用该接口进行累加操作，调用后 TapDB 将对原属性值进行累加后保存结果值
        /// </summary>
        /// <param name="properties">属性字典，value 仅支持数值类型</param>
        public static void DeviceAdd(string properties)
        {
            properties = "{\"totalPoints\":10}";
            TapDB.DeviceAdd(properties);
            // 此时设备表的 "totalPoints" 字段值为 10

            properties = "{\"totalPoints\":-2}";
            TapDB.DeviceAdd(properties);
            // 此时设备表的 "totalPoints" 字段值为 8
        }


        /// <summary>
        /// 修改账号属性
        //账号属性初始化
        //使用方法同设备属性初始化操作
        /// </summary>
        /// <param name="properties"></param>
        public static void UserInitialize(string properties)
        {
            TapDB.UserInitialize(properties);
        }


        /// <summary>
        /// 使用方法同设备属性更新操作
        /// </summary>
        /// <param name="properties"></param>
        public static void UserUpdate(string properties)
        {
            TapDB.UserUpdate(properties);
        }

        /// <summary>
        /// 使用方法同设备属性累加操作
        /// </summary>
        /// <param name="properties"></param>
        public static void UserAdd(string properties)
        {
            TapDB.UserAdd(properties);
        }
    }
#endif
}
