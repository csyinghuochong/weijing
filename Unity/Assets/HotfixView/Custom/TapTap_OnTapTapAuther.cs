using UnityEngine;

namespace ET
{

    public static class UILoginComponentSystem3
    {

        //实名认证回调
        // code == 500;   // 玩家未受到限制，正常进入游戏
        // code == 1000;  // 退出防沉迷认证及检查，当开发者调用 Exit 接口时或用户认证信息无效时触发，游戏应返回到登录页
        // code == 1001;  // 用户点击切换账号，游戏应返回到登录页
        // code == 1030;  // 用户当前时间无法进行游戏，此时用户只能退出游戏或切换账号
        // code == 1050;  // 用户无可玩时长，此时用户只能退出游戏或切换账号
        // code == 1100;  // 当前用户因触发应用设置的年龄限制无法进入游戏
        // code == 1200;  // 数据请求失败，游戏需检查当前设置的应用信息是否正确及判断当前网络连接是否正常
        // code == 9002;  // 实名过程中点击了关闭实名窗，游戏可重新开始防沉迷认证
        public static  async ETTask OnAntiAddictionHandler(this UILoginComponent self, int code, string errormsg)
        {
            if (code == 1050)
            {
                FloatTipManager.Instance.ShowFloatTip("用户无可玩时长，此时用户只能退出游戏或切换账号");
                return;
            }

            if (code != 500)
            {
                FloatTipManager.Instance.ShowFloatTip("实名认证失败");
                return;
            }

            //获取年龄
            int age =  TapSDKV20Helper.Instance.GetAgeRange();
            //获取剩余游戏时长
            int remaintime =  TapSDKV20Helper.Instance.GetRemainingTime();

            Log.ILog.Debug($"tap认证返回： age:{age}  remingtime:{remaintime}");

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            accountInfoComponent.Age_Type = age;

            string account = accountInfoComponent.Account;
            string password = accountInfoComponent.Password;
            string loginType = accountInfoComponent.LoginType;

            if (loginType == "3" || loginType == "4")
            {
                password = "3";
                loginType = "3";
            }

            long instanceid = self.InstanceId;

            C2A_TapTapAuther c2A_TapTapAuther = new C2A_TapTapAuther() { 
                Account = account,
                Password = password,   
                LoginType = int.Parse(loginType),
                age_type = age
            };
            Session accountSession = self.ZoneScene().GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(self.ServerInfo.ServerIp));
            A2C_TapTapAuther a2C_TikTokVerifyUser = (A2C_TapTapAuther)await accountSession.Call(c2A_TapTapAuther);
            accountSession.Dispose();

            if (instanceid != self.InstanceId)
            {
                FloatTipManager.Instance.ShowFloatTip("实名认证失败");
                return;
            }

            self.RequestLoginV20(account, password, loginType).Coroutine();
        }
    }

    public class TapTap_OnTapTapShare : AEventClass<EventType.TapTapShare>
    {
        protected override void Run(object numerice)
        {
            EventType.TapTapShare args = numerice as EventType.TapTapShare;

            GlobalHelp.TapTapShare(args.Content);
        }
    }

    public class TapTap_OnTapTapGetOAID : AEventClass<EventType.TapTapGetOAID>
    {
        protected override void Run(object numerice)
        {
            EventType.TapTapGetOAID args = numerice as EventType.TapTapGetOAID;

            GameObject.Find("Global").GetComponent<Init>().OnGetDeviceOAIDHandler = (string text) =>
            {
                UI ui = UIHelper.GetUI(args.ZoneScene, UIType.UILogin);
                ui.GetComponent<UILoginComponent>().OnGetDeviceOAID(text);
            };
            Log.ILog.Debug($"RequestGetDeviceOAID");
            GameObject.Find("Global").GetComponent<Init>().GetDeviceOAID();
        }
    };


    public class TapTap_OnTapTapAuther : AEventClass<EventType.TapTapAuther>
    {
        protected override void Run(object numerice)
        {
            EventType.TapTapAuther args = numerice as EventType.TapTapAuther;

            UI ui = UIHelper.GetUI( args.ZoneScene, UIType.UILogin );
            TapSDKV20Helper.Instance.AntiAddictionHandler =  (int errror, string msg)=>
            {
                ui.GetComponent<UILoginComponent>().OnAntiAddictionHandler(errror, msg).Coroutine();
            };

            TapSDKV20Helper.Instance.RealNameAuther( args.Account );
        }
    }
}
