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

        public static async ETTask OnTikTokAuthorizeHandler(this UILoginComponent self, string jsonresult)
        {
            if (Json.Deserialize(jsonresult) is Dictionary<string, object> obj)
            {
                var auth_code = obj["auto_code"] as string;
                string clienttoken = obj["client_token"] as string;
                string accesstoken = obj["access_token"] as string;
                string open_id = obj["open_id"] as string;

                C2A_TikTokGetOpenId c2A_TikTokVerifyUser = new C2A_TikTokGetOpenId()
                {
                    AuthCode = auth_code,
                    ClientToken = clienttoken,
                    OpenId = open_id,
                    AccessToken = accesstoken
                };
                Session accountSession = self.ZoneScene().GetComponent<NetKcpComponent>().Create(NetworkHelper.ToIPEndPoint(self.ServerInfo.ServerIp));
                A2C_TikTokGetOpenId a2C_TikTokVerifyUser = (A2C_TikTokGetOpenId)await accountSession.Call(c2A_TikTokVerifyUser);
                if (a2C_TikTokVerifyUser.Error == ErrorCode.ERR_Success)
                {
                    self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = 100;
                    self.Account.GetComponent<InputField>().text = a2C_TikTokVerifyUser.sdk_open_id.ToString();
                    self.Password.GetComponent<InputField>().text = LoginTypeEnum.TikTok.ToString();
                    return;
                }
            }
            self.ZoneScene().GetComponent<AccountInfoComponent>().Age_Type = -1;
            self.Account.GetComponent<InputField>().text = string.Empty;
            self.Password.GetComponent<InputField>().text = string.Empty;
            FloatTipManager.Instance.ShowFloatTip("抖音登录失败！");
        }

    }

    [Event]
    public class TikTok_TikTokCreateRole : AEventClass<EventType.TikTokCreateRole>
    {
        protected override void Run(object a)
        {
            EventType.TikTokCreateRole args = a as EventType.TikTokCreateRole;

            Log.ILog.Debug("TikTok_TikTokCreateRole");

            //后端请求
            //$"{createRoleInfo.UserID}_{createRoleInfo.PlayerName}_{accountInfoComponent.ServerId}_{accountInfoComponent.ServerName}_{createRoleInfo.PlayerOcc}_{accountInfoComponent.AccountId}";
            OSDKGameRole init = GameObject.Find("Global").GetComponent<OSDKGameRole>();

            string[] roleinfo = args.CreateRoleInfo.Split('_');

            GameAccountRole role = new GameAccountRole();
            role.RoleId = roleinfo[0];
            role.RoleName = roleinfo[1];
            role.RoleLevel = "1";
            role.ServerId = roleinfo[2];
            role.ServerName = roleinfo[3];
            role.AvatarUrl = "https://img.71acg.net/kbdev/opensj/20230109/15243214265";

            init.ReportGameRole(roleinfo[5], role);
        }
    }

    [Event]
    public class TikTok_TikTokAccountRegister : AEventClass<EventType.TikTokAccountRegister>
    {
        protected override void Run(object a)
        {
            EventType.TikTokAccountRegister args = a as EventType.TikTokAccountRegister;

            Log.ILog.Debug($"TikTok_TikTokAccountRegister:  {args.GameUserID}");
            if (string.IsNullOrEmpty(args.GameUserID))
            {
                return;
            }

            OSDKDataLink init = GameObject.Find("Global").GetComponent<OSDKDataLink>();
            //init.CheckTimeInteval = 3600 * 1000;
            init.OnAccountRegister(args.GameUserID);
        }
    }

    [Event]
    public class TikTok_TikTokGetAuthorizeCode : AEventClass<EventType.TikTokGetAuthorizeCode>
    {
        protected override void Run(object a)
        {
            EventType.TikTokGetAuthorizeCode args = a as EventType.TikTokGetAuthorizeCode;

            Log.ILog.Debug("TikTok_TikTokGetAuthorizeCode");

            //后端请求
            GameObject.Find("Global").GetComponent<OSDKDouyin>().OnTikTokAuthorizeHandler = args.TikTokAuthorizeHandler;

            OSDKDouyin init = GameObject.Find("Global").GetComponent<OSDKDouyin>();
            //init.CheckTimeInteval = 3600 * 1000;
            init.Authorize("user_info");
        }
    }
}