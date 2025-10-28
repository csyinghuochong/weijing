using System.Collections.Generic;
using Douyin.Game;
using UnityEngine;
using UnityEngine.Scripting;

namespace Demo.Douyin.Game
{
    [Preserve]
    public class DemoDataLinkFunctionScript : Singeton<DemoDataLinkFunctionScript>
    {
        public const string ITEM_ID_SDK_DATALINK_MOCK = "sdk_datalink_mock";
        public const string ITEM_ID_SDK_DATALINK_ACTIVE = "sdk_datalink_active";
        public const string ITEM_ID_SDK_DATALINK_ACCOUNT_REGISTER = "sdk_datalink_account_register";
        public const string ITEM_ID_SDK_DATALINK_ROLE_REGISTER = "sdk_datalink_role_register";
        public const string ITEM_ID_SDK_DATALINK_ACCOUNT_LOGIN = "sdk_datalink_account_login";
        public const string ITEM_ID_SDK_DATALINK_ROLE_LOGIN = "sdk_datalink_role_login";
        public const string ITEM_ID_SDK_DATALINK_PAY = "sdk_datalink_pay";
        public const string ITEM_ID_SDK_DATALINK_CUSTOM_EVENT = "sdk_custom_event";
        public const string ITEM_ID_SDK_DATALINK_UPDATE_CLOUD_GAME_INFO = "sdk_update_cloud_game_info";
        public const string ITEM_ID_SDK_DATALINK_SET_EVENT_LISTENER = "sdk_set_event_listener";
        public const string ITEM_ID_SDK_DATALINK_GET_EVENT_LISTENER = "sdk_get_event_listener";
        private Dictionary<string, string> Args = new Dictionary<string, string>();

        /**
         * 生成mock数据
         */
        private void GenerateArgs()
        {
            Args["game_user_id"] = "1000" + UnityEngine.Random.Range(0, 1000);
            Args["game_role_id"] = "2000" + UnityEngine.Random.Range(0, 1000);
            Args["game_order_id"] = "3000" + UnityEngine.Random.Range(0, 1000);;
            
            var LoginTime = 1701007123 - UnityEngine.Random.Range(0, 10000);
            Args["role_last_login_time"] = LoginTime.ToString();
            Args["account_last_login_time"] = (LoginTime - UnityEngine.Random.Range(0, 10000)).ToString();
        }
        
        [Preserve]
        public void FunctionDispatcher(string ItemID)
        {
            switch (ItemID)
            {
                case ITEM_ID_SDK_DATALINK_MOCK:
                {
                    DemoLog.D("调用数据MOCK方法");
                    GenerateArgs();
                    var userid = Args["game_user_id"];
                    DemoStandardDataLink.ShowToastAndPrint($"[COPY]参数已经生成, gameuserid:{userid}");
                    Clipboard.CopyToClipboard(userid);
                } break;
                case ITEM_ID_SDK_DATALINK_ACTIVE:
                {
                    if (!DemoStandardCore.Instance.IsInited())
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先完成SDK初始化");
                        return;
                    }
                    if (Args.Count == 0)
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先生成MOCK参数");
                        return;
                    }
                    DemoLog.D("调用游戏激活事件");
                    var result = DemoStandardDataLink.Instance.OnGameActive()?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"游戏激活事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_ACCOUNT_REGISTER:
                {
                    if (!DemoStandardCore.Instance.IsInited())
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先完成SDK初始化");
                        return;
                    }
                    if (Args.Count == 0)
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先生成MOCK参数");
                        return;
                    }
                    DemoLog.D("调用账号注册事件");
                    var gameUserID = Args["game_user_id"];
                    var result = DemoStandardDataLink.Instance.OnAccountRegister(gameUserID)?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"账号注册事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_ROLE_REGISTER:
                {
                    if (!DemoStandardCore.Instance.IsInited())
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先完成SDK初始化");
                        return;
                    }
                    if (Args.Count == 0)
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先生成MOCK参数");
                        return;
                    }
                    DemoLog.D("调用角色注册事件");
                    var gameUserID = Args["game_user_id"];
                    var gameRoleID = Args["game_role_id"];
                    var result = DemoStandardDataLink.Instance.OnRoleRegister(gameUserID, gameRoleID)?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"角色注册事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_ACCOUNT_LOGIN:
                {
                    if (!DemoStandardCore.Instance.IsInited())
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先完成SDK初始化");
                        return;
                    }
                    if (Args.Count == 0)
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先生成MOCK参数");
                        return;
                    }
                    DemoLog.D("调用账号登录事件");
                    var gameUserID = Args["game_user_id"];
                    var lastLoginTime = long.Parse(Args["account_last_login_time"]);
                    var result = DemoStandardDataLink.Instance.OnAccountLogin(gameUserID, lastLoginTime)?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"账号登录事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_ROLE_LOGIN:
                {
                    if (!DemoStandardCore.Instance.IsInited())
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先完成SDK初始化");
                        return;
                    }
                    if (Args.Count == 0)
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先生成MOCK参数");
                        return;
                    }
                    DemoLog.D("调用角色登录事件");
                    var gameUserID = Args["game_user_id"];
                    var gameRoleID = Args["game_role_id"];
                    var lastRoleLoginTime = long.Parse(Args["role_last_login_time"]);
                    var result = DemoStandardDataLink.Instance.OnRoleLogin(gameUserID, gameRoleID, lastRoleLoginTime)?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"角色登录事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_PAY:
                {
                    if (!DemoStandardCore.Instance.IsInited())
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先完成SDK初始化");
                        return;
                    }
                    if (Args.Count == 0)
                    {
                        DemoStandardDataLink.ShowToastAndPrint("请先生成MOCK参数");
                        return;
                    }
                    DemoLog.D("调用用户付费事件");
                    var gameUserID = Args["game_user_id"];
                    var gameRoleID = Args["game_role_id"];
                    var gameOrderID = Args["game_order_id"];
                    var totalAmount = 648;
                    var productID = "product123";
                    var productName = "钻石宝箱";
                    var productDesc = "一大箱钻石";
                    var result = DemoStandardDataLink.Instance.OnPay(gameUserID, gameRoleID, gameOrderID, totalAmount, productID, productName, productDesc)?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"用户付费事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_CUSTOM_EVENT:
                {
                    var jsonParams = Json.Serialize(new Dictionary<string, object>()
                    {
                        { "test_custom_event_1", 1 },
                        { "test_custom_event_2", "a" }
                    });
                    Debug.Log("jsonParams: " + jsonParams);
                    var result = DemoStandardDataLink.Instance.CustomEvent("test_custom",jsonParams)?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"自定义事件事件调用{result}");
                } break;
                case ITEM_ID_SDK_DATALINK_UPDATE_CLOUD_GAME_INFO:
                {
                    Debug.Log("更新云游戏信息");
                    var result = DemoStandardDataLink.Instance.UpdateCloudGameInfo(new CloudGameInfo()
                    {
                        CloudGameName = "test_cloud_game"
                    })?"成功":"失败";
                    DemoStandardDataLink.ShowToastAndPrint($"更新云游戏信息{result}");
                } break;
                
                case ITEM_ID_SDK_DATALINK_SET_EVENT_LISTENER:
                {
                    DemoStandardDataLink.Instance.SetDataLinkEventListener();
                    DemoStandardDataLink.ShowToastAndPrint("设置事件监听成功");

                } break;
                
                case ITEM_ID_SDK_DATALINK_GET_EVENT_LISTENER:
                {
                    var result = DemoStandardDataLink.Instance.GetDataLinkEventListener() == null?"失败":"成功";
                    DemoStandardDataLink.ShowToastAndPrint($"获取事件监听{result}");
                } break;
            }
        }
    }
}