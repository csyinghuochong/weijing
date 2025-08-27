using cn.sharesdk.unity3d;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public static class UILoginComponentSystem2
    {
        public static async ETTask GetTapUserInfo(this UILoginComponent self, string logintype)
        {
            await ETTask.CompletedTask;
            Init init = GameObject.Find("Global").GetComponent<Init>();
            Log.ILog.Debug("GetTapUserInfo: init.TapTapLogin");
            string tatapid = await init.TapTapLogin();

            if (string.IsNullOrEmpty(tatapid))
            {
                FloatTipManager.Instance.ShowFloatTip("请确认是否登录TapTap！");
                return;
            }
            self.LoginType = logintype;
            Log.ILog.Debug($"GetTapUserInfo1111: {tatapid}");
            self.OnGetTapUserInfo(tatapid);
        }


        public static async ETTask GetTapUserInfo_2(this UILoginComponent self, string logintype)
        {
            await ETTask.CompletedTask;
            Init init = GameObject.Find("Global").GetComponent<Init>();
            Log.ILog.Debug("GetTapUserInfo: init.TapTapLogin_2");

            string tatapid = await init.TapTapLogin_2();

            if (string.IsNullOrEmpty(tatapid))
            {
                FloatTipManager.Instance.ShowFloatTip("请确认是否登录TapTap！");
                return;
            }
            self.LoginType = logintype;
            Log.ILog.Debug($"GetTapUserInfo2222: {tatapid}");
            self.OnGetTapUserInfo(tatapid);
        }

        public static async ETTask OnRecvQuDaoUid(this UILoginComponent self, string access_token, string uid)
        {
            Log.ILog.Debug($"OnRecvQuDaoUid:{uid} ");
            self.Account.GetComponent<InputField>().text = uid;
            self.Password.GetComponent<InputField>().text = LoginTypeEnum.QuDao.ToString();

            C2A_QuDaoCheckUserInfor c2A_QuDao = new C2A_QuDaoCheckUserInfor() { token = access_token, uid = uid };
            Session accountSession = self.ZoneScene().GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(self.ServerInfo.ServerIp));
            A2C_QuDaoCheckUserInfor a2C_TikTokVerifyUser = (A2C_QuDaoCheckUserInfor)await accountSession.Call(c2A_QuDao);

            await ETTask.CompletedTask;
        }

        public static async ETTask OnRecvTikTokAccesstoken(this UILoginComponent self, string access_token)
        {
            if (TikTokHelper.UseOldLogin)
            {
                try
                {
                    C2A_TikTokVerifyUser c2A_TikTokVerifyUser = new C2A_TikTokVerifyUser() { access_token = access_token };
                    Session accountSession = self.ZoneScene().GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(self.ServerInfo.ServerIp));
                    A2C_TikTokVerifyUser a2C_TikTokVerifyUser = (A2C_TikTokVerifyUser)await accountSession.Call(c2A_TikTokVerifyUser);
                    if (a2C_TikTokVerifyUser.Error == ErrorCode.ERR_Success)
                    {
                        self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = a2C_TikTokVerifyUser.age_type;
                        self.Account.GetComponent<InputField>().text = a2C_TikTokVerifyUser.sdk_open_id.ToString();
                        self.Password.GetComponent<InputField>().text = LoginTypeEnum.TikTok.ToString();
                    }
                    else
                    {
                        self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = -1;
                        self.Account.GetComponent<InputField>().text = string.Empty;
                        self.Password.GetComponent<InputField>().text = string.Empty;
                        FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error(ex.ToString());
                }
            }
            else
            {
                if (string.IsNullOrEmpty(access_token))
                {
                    FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
                    return;
                }
                long serverNow = TimeHelper.ServerNow() / 1000;
                Dictionary<string, string> paramslist = new Dictionary<string, string>();
                paramslist.Add("access_token", access_token);
                paramslist.Add("app_id", TikTokHelper.AppID.ToString());
                paramslist.Add("ts", serverNow.ToString());
                string sign = TikTokHelper.getSign(paramslist);
                paramslist.Add("sign", sign);

                string result = HttpHelper.OnWebRequestPost_TikTokLogin("https://usdk.dailygn.com/gsdk/usdk/account/verify_user", paramslist);
                //OnWebRequestPost_1: {"code":-1001,"log_id":"202311141714565D4B186ED56A781CCE8D","message":"invalid parameter: app_id error"}
                if (string.IsNullOrEmpty(result))
                {
                    FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
                    return;
                }

                TikTokCode tikTokCode = JsonHelper.FromJson<TikTokCode>(result);
                if (tikTokCode.code != 0 || tikTokCode.data == null)
                {
                    FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
                    return;
                }

                if (string.IsNullOrEmpty(tikTokCode.data.sdk_open_id) || tikTokCode.data.age_type <= 0)
                {
                    FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
                    return;
                }

                C2A_TikTokVerifyUser c2A_TikTokVerifyUser = new C2A_TikTokVerifyUser() { sdk_open_id = tikTokCode.data.sdk_open_id, age_type = tikTokCode.data.age_type };
                Session accountSession = self.ZoneScene().GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(self.ServerInfo.ServerIp));
                A2C_TikTokVerifyUser a2C_TikTokVerifyUser = (A2C_TikTokVerifyUser)await accountSession.Call(c2A_TikTokVerifyUser);
                if (a2C_TikTokVerifyUser.Error == ErrorCode.ERR_Success)
                {
                    self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = a2C_TikTokVerifyUser.age_type;
                    self.Account.GetComponent<InputField>().text = a2C_TikTokVerifyUser.sdk_open_id.ToString();
                    self.Password.GetComponent<InputField>().text = LoginTypeEnum.TikTok.ToString();
                }
                else
                {
                    self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = -1;
                    self.Account.GetComponent<InputField>().text = string.Empty;
                    self.Password.GetComponent<InputField>().text = string.Empty;
                    FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
                }
            }
        }
    }

    [Event]
    public class QuDao_QuDaoEnterGame : AEventClass<EventType.QuDaoEnterGame>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoEnterGame args = a as EventType.QuDaoEnterGame;

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onEnterGame(args.EnterGameInfo);
        }
    }

    [Event]
    public class QuDao_QuDaoUpdateRole : AEventClass<EventType.QuDaoUpdateRole>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoUpdateRole args = a as EventType.QuDaoUpdateRole;

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onUpdateRoleInfo(args.UpdateRoleInfo);
        }
    }

    [Event]
    public class QuDao_QuDaoCreateRole : AEventClass<EventType.QuDaoCreateRole>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoCreateRole args = a as EventType.QuDaoCreateRole;

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onCreatRole(args.CreateRoleInfo);
        }
    }

    [Event]
    public class QuDao_QuDaoOnPay : AEventClass<EventType.QuDaoOnPay>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoOnPay args = a as EventType.QuDaoOnPay;

            Log.ILog.Debug("QuDaoOnPay: ");

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onPay(args.PayInfo);
        }
    }

    [Event]
    public class QuDao_QuDaoSdkExit : AEventClass<EventType.QuDaoSdkExit>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoSdkExit args = a as EventType.QuDaoSdkExit;

            Log.ILog.Debug("QuDaoExit: ");

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onExit();
        }
    }


    [Event]
    public class QuDao_QuDaoLoginout : AEventClass<EventType.QuDaoLoginout>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoLoginout args = a as EventType.QuDaoLoginout;

            Log.ILog.Debug("QuDaoLoginout: ");

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onLogout();
        }
    }

    [Event]
    public class QuDao_QuDaoLoginRequest : AEventClass<EventType.QuDaoLoginRequest>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoLoginRequest args = a as EventType.QuDaoLoginRequest;

            Log.ILog.Debug("QuDaoLoginRequest: EventHandle.onLogin");


            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onLoginSuccessAction = args.AccesstokenHandler;
            eventHandle.onLogin();
        }
    }

    [Event]
    public class QuDao_QuDaoSwichAccount : AEventClass<EventType.QuDaoSwichAccount>
    {
        protected override void Run(object a)
        {
            EventType.QuDaoSwichAccount args = a as EventType.QuDaoSwichAccount;

            Log.ILog.Debug("Register: QuDaoLoginSwichAccountHandler");

            EventHandle eventHandle = GameObject.Find("Global").GetComponent<EventHandle>();
            eventHandle.onSwitchAccountSuccessAction = args.QuDaoSwichAccountHandler;
        }
    }


    [Event]
    public class TikTok_TikTokGetAccesstoken : AEventClass<EventType.TikTokGetAccesstoken>
    {
        protected override void Run(object a)
        {
            EventType.TikTokGetAccesstoken args = a as EventType.TikTokGetAccesstoken;

            Log.ILog.Debug("GetTiktokAccesstoken: ");

            GameObject.Find("Global").GetComponent<Init>().OnTikTokAccesstokenHandler = args.AccesstokenHandler;

            Init init = GameObject.Find("Global").GetComponent<Init>();
            init.TikTokLogin();
        }
    }

    
    [Event]
    public class TikTok_OnRiskControlInfo : AEventClass<EventType.TikTokRiskControlInfo>
    {
        protected override void Run(object a)
        {
            EventType.TikTokRiskControlInfo args = a as EventType.TikTokRiskControlInfo;

            Log.ILog.Debug("TikTokRiskControlInfo");
            GameObject.Find("Global").GetComponent<Init>().OnRiskControlInfoHandler = args.RiskControlInfoHandler;

            GameObject.Find("Global").GetComponent<Init>().TikTokRiskControlInfo();
        }
    }

    [Event]
    public class TikTok_OnTikTokShare : AEventClass<EventType.TikTokShare>
    {
        protected override void Run(object a)
        {
            EventType.TikTokShare args = a as EventType.TikTokShare;

            GameObject.Find("Global").GetComponent<Init>().OnShareHandler = args.ShareHandler;

            string string_1 = string.Empty;
            for (int i = 0; i < args.ShareMessage.Count; i++)
            {
                if (i == args.ShareMessage.Count - 1)
                {
                    string_1 = string_1 + $"{args.ShareMessage[i]}";
                }
                else
                {
                    string_1 = string_1 + $"{args.ShareMessage[i]}&";
                }
            }
            string string_2 = string.Empty;
            Log.ILog.Debug($"TikTokShare: {string_1} \n {string_2}");
            GameObject.Find("Global").GetComponent<Init>().TikTokShareImage(string_1, string_2);
        }
    }

    [Event]
    public class Login_LoginCheckRoot : AEventClass<EventType.LoginCheckRoot>
    {
        protected override void Run(object a)
        {
            EventType.LoginCheckRoot args = a as EventType.LoginCheckRoot;
            
            Init init = GameObject.Find("Global").GetComponent<Init>();
            AccountInfoComponent accountInfoComponent = args.ZoneScene.GetComponent<AccountInfoComponent>();
            accountInfoComponent.Simulator = init.IsEmulator;
            accountInfoComponent.Root = init.IsRoot;
            Log.ILog.Debug($"LoginCheckRoot: {init.IsRoot} {init.IsEmulator}");
        }
    }

    [Event]
    public class TikTok_OnTikTokPayRequest : AEventClass<EventType.TikTokPayRequest>
    {
        protected override void Run(object a)
        {
            EventType.TikTokPayRequest args = a as EventType.TikTokPayRequest;

            string[] parminfolist = args.PayMessage.Split('&');
            string dinghaoid = parminfolist[0];

            Log.ILog.Debug($"TikTokPayMessage:  {args.RechargeNumber}   {args.PayMessage}");
            TikTokPay tikTokPay = JsonHelper.FromJson<TikTokPay>(parminfolist[0]);
            if (tikTokPay.code == 0 && tikTokPay.message.Equals("success"))
            {
                //TikTokPay(String cpOrderId, int amountInCent, String productId, String productName, String sdkParam)
                GameObject.Find("Global").GetComponent<Init>().TikTokPay(dinghaoid, (args.RechargeNumber * 100), args.RechargeNumber.ToString(), "钻石", tikTokPay.sdk_param);
            }
            else
            {
                Log.ILog.Debug($"TikTokPayError: {tikTokPay.message}");
            }
        }
    }


}
