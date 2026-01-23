using System;
using UnityEngine;

namespace ET
{

    public class GooglePurchasingComponentAwake : AwakeSystem<GooglePurchasingComponent>
    {
        public override void Awake(GooglePurchasingComponent self)
        {
            GameObject.Find("Global").GetComponent<IAPManager>().SuccessedCallback = self.OnIosPaySuccessedCallback;
            GameObject.Find("Global").GetComponent<IAPManager>().FailedCallback = self.OnGooglePayFailCallback;
        }
    }

    public static class GooglePurchasingComponentSystem
    {
        public static void OnIosPaySuccessedCallback(this GooglePurchasingComponent self, string info)
        {
            self.OnGooglePaySuccessedToVerify(info).Coroutine();
        }

        private static async ETTask OnGooglePaySuccessedToVerify(this GooglePurchasingComponent self, string info)
        {
            Scene ZoneScene = Game.GetZoneScene(1);
            if (ZoneScene == null)
            {
                Log.Error($"OnIosPayFailCallbackError:ZoneScene == null ");
                FloatTipManager.Instance.ShowFloatTip("ZoneScene == null！");
                return;
            }

            FloatTipManager.Instance.ShowFloatTipDi("Google支付返回11");

            //掉线
            SessionComponent sessionComponent = ZoneScene.GetComponent<SessionComponent>();
            AccountInfoComponent accountInfoComponent = ZoneScene.GetComponent<AccountInfoComponent>();
            if (sessionComponent == null)
            {
                PlayerPrefsHelp.SetString("Google_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                PlayerPrefsHelp.SetInt("GoogleRecharge_" + accountInfoComponent.CurrentRoleId.ToString(), accountInfoComponent.RechargeType);
                return;
            }
            Session session = sessionComponent.Session;
            if (session == null || session.IsDisposed)
            {
                PlayerPrefsHelp.SetString("Google_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                PlayerPrefsHelp.SetInt("GoogleRecharge_" + accountInfoComponent.CurrentRoleId.ToString(), accountInfoComponent.RechargeType);
                return;
            }

            MapComponent mapComponent = ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum < (int)SceneTypeEnum.MainCityScene)
            {
                PlayerPrefsHelp.SetString("Google_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                PlayerPrefsHelp.SetInt("GoogleRecharge_" + accountInfoComponent.CurrentRoleId.ToString(), accountInfoComponent.RechargeType);
                return;
            }

         
            Receipt receipt = null;
            try
            {
                receipt = JsonHelper.FromJson<Receipt>(info);
            }
            catch (Exception ex)
            {
                FloatTipManager.Instance.ShowFloatTipDi($"SendGoogle. Exception11  {ex.Message}");
                return;
            }

       
            //string payLoad = receipt.Payload;
            //string sendStr = "{\"receipt-data\":\"" + payLoad + "\"}";

            C2R_GooglePayVerifyRequest request = new C2R_GooglePayVerifyRequest()
            {
                UnitId = UnitHelper.GetMyUnitId(ZoneScene),
                payMessage = receipt.Payload,
                UnitName = ZoneScene.GetComponent<UserInfoComponent>().UserInfo.Name,
                RechargeType = ZoneScene.GetComponent<AccountInfoComponent>().RechargeType,
            };
            ZoneScene.GetComponent<SessionComponent>().Session.Call(request).Coroutine();

            UI uirecharget = UIHelper.GetUI(ZoneScene, UIType.UIRecharge);
            if (uirecharget != null)
            {
                uirecharget.GetComponent<UIRechargeComponent>().Loading.SetActive(false);
            }
            await ETTask.CompletedTask;
        }

        public static void OnGooglePayFailCallback(this GooglePurchasingComponent self)
        {
            Scene ZoneScene = Game.GetZoneScene(1);
            if (ZoneScene == null)
            {
                Log.Error($"OnIosPayFailCallbackError:ZoneScene == null ");
                return;
            }

            UI uirecharget = UIHelper.GetUI(ZoneScene, UIType.UIRecharge);
            if (uirecharget != null)
            {
                uirecharget.GetComponent<UIRechargeComponent>().Loading.SetActive(false);
            }
        }


    }

}