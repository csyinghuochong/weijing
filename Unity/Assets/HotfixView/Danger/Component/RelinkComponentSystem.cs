using System;
using System.Net;
using UnityEngine;

namespace ET
{


    public class RelinkComponentAwakeSystem : AwakeSystem<RelinkComponent>
    {
        public override void Awake(RelinkComponent self)
        {
            self.Relink = false;
            GameObject.Find("Global").GetComponent<Init>().OnApplicationFocusHandler = (bool value) => 
            {
                self.OnApplicationFocusHandler(value);
            };
            GameObject.Find("Global").GetComponent<Init>().OnApplicationQuitHandler = () =>
            {
                self.OnApplicationQuitHandler().Coroutine();
            };

        }
    }


    public class RelinkComponentDestroySystem : DestroySystem<RelinkComponent>
    {
        public override void Destroy(RelinkComponent self)
        {
            self.Relink = false;
        }
    }

    public static class RelinkComponentSystem
    {

        public static async ETTask OnApplicationQuitHandler(this RelinkComponent self)
        {
            SessionComponent sessionComponent = self.DomainScene().GetComponent<SessionComponent>();
            if (sessionComponent == null)
            {
                return;
            }
            if (sessionComponent.Session == null || sessionComponent.Session.IsDisposed)
            {
                return;
            }
            try
            {
                //G2C_ExitGameGate response = await sessionComponent.Session.Call(new C2G_ExitGameGate() {  }) as G2C_ExitGameGate;
                await ETTask.CompletedTask;
            }
            catch (Exception e)
            {
                Log.Debug(e.ToString());
            }
        }

        static string GetLocalIp()
        {
            string addressIP = string.Empty;
            foreach (IPAddress ipAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    addressIP = ipAddress.ToString();
                    break;
                }
            }
            return addressIP;
        }

        public static void OnApplicationFocusHandler(this RelinkComponent self, bool value)
        {
            if (value)
            {
                MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
                if (mapComponent.SceneTypeEnum == (int)SceneTypeEnum.LoginScene)
                {
                    return;
                }
                SessionComponent sessionComponent = self.DomainScene().GetComponent<SessionComponent>();
                if (sessionComponent == null)
                {
                    return;
                }
                if (sessionComponent.Session == null || sessionComponent.Session.IsDisposed)
                {
                    PlayerPrefsHelp.RecordRelinkMessage($"切换到前台发现掉线准备重连  {GetLocalIp()}！！");
                    self.CheckRelink().Coroutine();
                }
            }
            else
            {
                UI uIMain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
                if (uIMain != null)
                {
                    uIMain.GetComponent<UIMainComponent>().OnStopAction();
                }
            }
        }

        public static async ETTask CheckRelink(this RelinkComponent self)
        {
            if (self.Relink)
            {
                return;
            }
            self.Relink = true;
            Log.ILog.Debug($"重连请求！！");
            UIHelper.Create(self.DomainScene(), UIType.UIRelink).Coroutine();
            PlayerPrefsHelp.RecordRelinkMessage($"开始重连！！");
            for (int i = 0; i < 5; i++)
            {
                long instanceid = self.InstanceId;
                Log.ILog.Debug($"重连请求11！！ {self.Relink}");
                if (TimerComponent.Instance == null || !self.Relink)
                {
                    break;
                }

                await TimerComponent.Instance.WaitAsync(1000);
                if (instanceid != self.InstanceId)
                {
                    break;
                }
                if (TimerComponent.Instance == null || !self.Relink)
                {
                    break;
                }
                Log.ILog.Debug($"重连请求22！！ {self.Relink}");
                await self.SendLogin();
                if(i == 4)
                {
                    UIHelper.Remove(self.DomainScene(), UIType.UIRelink);
                    EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
                    Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
                    break;
                }
            }
        }

        public static void  OnModifyData(this RelinkComponent self)
        {
            self.ModifyDataNumber++;

            if (self.ModifyDataNumber> 10)
            {
                return;
            }
            if (self.ModifyDataNumber == 10)
            {
                PlayerPrefsHelp.SetString(PlayerPrefsHelp.LoginErrorTime, (TimeHelper.ServerNow() + TimeHelper.Hour).ToString());
                EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
                Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
            }
        }

        public  static async ETTask OnRelinkSucess(this RelinkComponent self)
        {
            self.Relink = false;
            Log.ILog.Debug($"重连成功！！ {self.Relink}");
            Scene zoneScene = self.ZoneScene();
            UIHelper.Remove(self.DomainScene(), UIType.UIRelink);

            zoneScene.GetComponent<SessionComponent>().Session.Send(new C2M_RefreshUnitRequest());
            await NetHelper.RequestUserInfo(zoneScene, true);
            await NetHelper.RequestUnitInfo(zoneScene, true);
            await NetHelper.RequestAllPets(zoneScene);
            await NetHelper.RequestFriendInfo(zoneScene);

            AccountInfoComponent accountInfoComponent = zoneScene.GetComponent<AccountInfoComponent>();
            string info = PlayerPrefsHelp.GetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString());
            if (!string.IsNullOrEmpty(info))
            {
                NetHelper.SendIOSPayVerifyRequest(zoneScene, info).Coroutine();
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), string.Empty);
                FloatTipManager.Instance.ShowFloatTip("重连成功_IOS！");
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTip("重连成功！");
            }

            if (GlobalHelp.GetPlatform() == 7)
            {
                info = PlayerPrefsHelp.GetString("Google_" + accountInfoComponent.CurrentRoleId.ToString());
                if (!string.IsNullOrEmpty(info))
                {
                    NetHelper.SendGooglePayVerifyRequest(zoneScene, info).Coroutine();
                    PlayerPrefsHelp.SetString("Google_" + accountInfoComponent.CurrentRoleId.ToString(), string.Empty);
                    FloatTipManager.Instance.ShowFloatTip("重连成功_Google！");
                }
                else
                {
                    FloatTipManager.Instance.ShowFloatTip("重连成功！");
                }
            }

            UI uIMain = UIHelper.GetUI(zoneScene, UIType.UIMain);
            if (uIMain != null)
            {
                uIMain.GetComponent<UIMainComponent>().OnRelinkUpdate();
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);

            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int nowhp = numericComponent.GetAsInt( NumericType.Now_Hp );
            int nowdead = numericComponent.GetAsInt(NumericType.Now_Dead);

            if (nowdead == 1)
            {
                unit.GetComponent<UIUnitHpComponent>().UpdateBlood();
                unit.GetComponent<HeroDataComponent>().OnDead(null);
                EventType.UnitDead.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
            }

            UI uiFenxiang = UIHelper.GetUI(zoneScene, UIType.UIFenXiang);
            if (uiFenxiang != null) 
            {
                uiFenxiang.GetComponent<UIFenXiangComponent>().OnShareSucess();
            }
        }

        /// <summary>
        /// 断线重连，重新走登录流程
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask<int> SendLogin(this RelinkComponent self)
        {
            long instanceid = self.InstanceId;
            AccountInfoComponent PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            int code = await LoginHelper.Login(
                        self.DomainScene(),
                        PlayerComponent.ServerIp,
                        PlayerComponent.Account,
                        PlayerComponent.Password, true, string.Empty, PlayerComponent.LoginType);

            PlayerPrefsHelp.RecordRelinkMessage($"重连LoginHelper.Login  {code}！！");
            if (code != ErrorCode.ERR_Success)
            {
                return code;
            }
            code = await LoginHelper.GetRealmKey(self.DomainScene());
            PlayerPrefsHelp.RecordRelinkMessage($"重连LoginHelper.GetRealmKey  {code}！！");
            if (code != ErrorCode.ERR_Success)
            {
                return code;
            }

            await TimerComponent.Instance.WaitAsync(1500);
            if (instanceid != self.InstanceId)
            {
                return ErrorCode.ERR_NetWorkError ;
            }

#if TikTok5
            string deviveInfo = $"tiktok";
#else
            string deviveInfo = $"{UnityEngine.SystemInfo.deviceModel}_{UnityEngine.Screen.width}:{UnityEngine.Screen.height}";
#endif
            code = await LoginHelper.EnterGame(self.ZoneScene(), deviveInfo, true, GlobalHelp.GetPlatform());
            PlayerPrefsHelp.RecordRelinkMessage($"重连LoginHelper.EnterGame  {code}！！");
            return code;
        }

    }
}
