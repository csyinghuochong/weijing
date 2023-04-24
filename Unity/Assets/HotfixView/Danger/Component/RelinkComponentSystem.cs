using System;
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

#if UNITY_IPHONE
            GameObject.Find("Global").GetComponent<PurchasingManager>().SuccessedCallback = self.OnIosPaySuccessedCallback;
            GameObject.Find("Global").GetComponent<PurchasingManager>().FailedCallback = self.OnIosPayFailCallback;
#endif
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

        public static void OnIosPaySuccessedCallback(this RelinkComponent self, string info)
        {
            //掉线
            SessionComponent sessionComponent = self.DomainScene().GetComponent<SessionComponent>();
            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            if (sessionComponent == null)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                return;
            }
            Session session = sessionComponent.Session;
            if (session == null || session.IsDisposed)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                return;
            }
            MapComponent mapComponent = self.DomainScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum < (int)SceneTypeEnum.MainCityScene)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                return;
            }

            Receipt receipt = JsonHelper.FromJson<Receipt>(info);
            Log.Debug("payload[内购成功]:" + receipt.Payload);

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            C2R_IOSPayVerifyRequest request = new C2R_IOSPayVerifyRequest() { UnitId = unit.Id, payMessage = receipt.Payload };
            session.Call(request).Coroutine();

            UI uirecharget = UIHelper.GetUI(self.ZoneScene(), UIType.UIRecharge);
            if (uirecharget != null)
            {
                uirecharget.GetComponent<UIRechargeComponent>().Loading.SetActive(false);
            }
        }

        public static void OnIosPayFailCallback(this RelinkComponent self)
        {
            UI uirecharget = UIHelper.GetUI(self.ZoneScene(), UIType.UIRecharge);
            if (uirecharget != null)
            {
                uirecharget.GetComponent<UIRechargeComponent>().Loading.SetActive(false);
            }
        }


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
                G2C_ExitGameGate response = await sessionComponent.Session.Call(new C2G_ExitGameGate() {  }) as G2C_ExitGameGate;
            }
            catch (Exception e)
            {
                Log.Debug(e.ToString());
            }
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
            for (int i = 0; i < 5; i++)
            {
                long instanceid = self.InstanceId;
                Log.ILog.Debug($"重连请求11！！ {self.Relink}");
                if (TimerComponent.Instance == null || !self.Relink)
                {
                    break;
                }
                await TimerComponent.Instance.WaitAsync(4000);
                if (instanceid != self.InstanceId)
                {
                    break;
                }
                if (TimerComponent.Instance == null || !self.Relink)
                {
                    break;
                }
                Log.ILog.Debug($"重连请求22！！ {self.Relink}");
                self.SendLogin().Coroutine();
                if(i == 4)
                {
                    UIHelper.Remove(self.DomainScene(), UIType.UIRelink);
                    EventType.ReturnLogin.Instance.ZoneScene = self.DomainScene();
                    Game.EventSystem.PublishClass(EventType.ReturnLogin.Instance);
                    break;
                }
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

            AccountInfoComponent accountInfoComponent = zoneScene.GetComponent<AccountInfoComponent>();
            string info = PlayerPrefsHelp.GetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString());
            if (!string.IsNullOrEmpty(info))
            {
                NetHelper.SendIOSPayVerifyRequest(zoneScene, info);
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), string.Empty);
                FloatTipManager.Instance.ShowFloatTip("重连成功_IOS！");
            }
            else
            {
                FloatTipManager.Instance.ShowFloatTip("重连成功！");
            }

            UI uIMain = UIHelper.GetUI(zoneScene, UIType.UIMain);
            if (uIMain != null)
            {
                uIMain.GetComponent<UIMainComponent>().OnRelinkUpdate();
            }
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(zoneScene);
            if (unit.GetComponent<NumericComponent>().GetAsInt(NumericType.Now_Dead) == 1
                && UIHelper.GetUI(zoneScene, UIType.UICellDungeonRevive) == null)
            {
                unit.GetComponent<HeroDataComponent>().OnDead();
                EventType.UnitDead.Instance.Unit = unit;
                Game.EventSystem.PublishClass(EventType.UnitDead.Instance);
            }
            //UI uiRecharge = UIHelper.GetUI(zoneScene, UIType.UIRecharge);
            //if (uiRecharge != null)
            //{
            //    uiRecharge.GetComponent<UIRechargeComponent>().OnRelinkUpdate();
            //}
        }

        /// <summary>
        /// 断线重连，重新走登录流程
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask<int> SendLogin(this RelinkComponent self)
        {   
            AccountInfoComponent PlayerComponent = self.DomainScene().GetComponent<AccountInfoComponent>();

            int code = await LoginHelper.Login(
                        self.DomainScene(),
                        PlayerComponent.ServerIp,
                        PlayerComponent.Account,
                        PlayerComponent.Password, true);
            if (code != ErrorCore.ERR_Success)
            {
                return code;
            }
            await TimerComponent.Instance.WaitAsync(1000);
            code = await LoginHelper.GetRealmKey(self.DomainScene());
            if (code != ErrorCore.ERR_Success)
            {
                return code;
            }
            code = await LoginHelper.EnterGame(self.ZoneScene(), SystemInfo.deviceName, true);
            return code;
        }

    }
}
