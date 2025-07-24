using cn.sharesdk.unity3d;
using Douyin.Game;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{

    public static class UILoginComponentSystem4
    {
        public static void OnRecvOpenIdCodeCode(this UILoginComponent self, string open_id)
        {
            Log.ILog.Debug($"OnRecvOpenIdCodeCode: {open_id}");
            if (string.IsNullOrEmpty(open_id))
            {
                self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = -1;
                self.Account.GetComponent<InputField>().text = string.Empty;
                self.Password.GetComponent<InputField>().text = string.Empty;
                FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
            }
            else
            {
                self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = 100;
                self.Account.GetComponent<InputField>().text = open_id;
                self.Password.GetComponent<InputField>().text = LoginTypeEnum.TikTok.ToString();
            }
        }

        public static async ETTask OnRecvTikTokAuthorizeCode(this UILoginComponent self, string auth_code)
        {
            C2A_TikTokGetOpenId c2A_TikTokVerifyUser = new C2A_TikTokGetOpenId() { auth_code = auth_code };
            Session accountSession = self.ZoneScene().GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(self.ServerInfo.ServerIp));
            A2C_TikTokGetOpenId a2C_TikTokVerifyUser = (A2C_TikTokGetOpenId)await accountSession.Call(c2A_TikTokVerifyUser);
            if (a2C_TikTokVerifyUser.Error == ErrorCode.ERR_Success)
            {
                self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = 100;
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

    [Event]
    public class TikTok_TikTokGetAuthorizeCode : AEventClass<EventType.TikTokGetAuthorizeCode>
    {
        protected override void Run(object a)
        {
            EventType.TikTokGetAuthorizeCode args = a as EventType.TikTokGetAuthorizeCode;

            Log.ILog.Debug("TikTok_TikTokGetAuthorizeCode");

            //GameObject.Find("Global").GetComponent<Init>().OnTikTokAuthorizeHandler = args.AuthorizeCodeHandler;
            GameObject.Find("Global").GetComponent<OSDKDouyin>().GetOpenIdCodeHandler = args.GetOpenIdCodeHandler;

            Init init = GameObject.Find("Global").GetComponent<Init>();
            init.TikTokAuthorize();
        }
    }
}