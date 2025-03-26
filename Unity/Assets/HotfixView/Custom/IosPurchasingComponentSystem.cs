using UnityEngine;


namespace ET
{
    
    public class IosPurchasingComponentAwake : AwakeSystem<IosPurchasingComponent>
    {
        public override void Awake(IosPurchasingComponent self)
        {
#if UNITY_IPHONE
            GameObject.Find("Global").GetComponent<PurchasingManager>().SuccessedCallback = self.OnIosPaySuccessedCallback;
            GameObject.Find("Global").GetComponent<PurchasingManager>().FailedCallback = self.OnIosPayFailCallback;
#endif

        }
    }

    public static class IosPurchasingComponentSystem
    {
        public static void OnIosPaySuccessedCallback(this IosPurchasingComponent self, string info)
        {
            Scene ZoneScene =  Game.GetZoneScene(1);
            if (ZoneScene == null)
            {
                Log.Error($"OnIosPayFailCallbackError:ZoneScene == null ");
                FloatTipManager.Instance.ShowFloatTip("ZoneScene == null！");
                return;
            }

            FloatTipManager.Instance.ShowFloatTipDi("ios支付返回11");

            //掉线
            SessionComponent sessionComponent = ZoneScene.GetComponent<SessionComponent>();
            AccountInfoComponent accountInfoComponent = ZoneScene.GetComponent<AccountInfoComponent>();
            if (sessionComponent == null)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                return;
            }

            FloatTipManager.Instance.ShowFloatTipDi("ios支付返回22");

            Session session = sessionComponent.Session;
            if (session == null || session.IsDisposed)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                return;
            }

            FloatTipManager.Instance.ShowFloatTipDi("ios支付返回33");

            MapComponent mapComponent = ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum < (int)SceneTypeEnum.MainCityScene)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                return;
            }

            //Receipt receipt = JsonHelper.FromJson<Receipt>(info);
            //Log.Debug("payload[内购成功]:" + receipt.Payload);
            //Unit unit = UnitHelper.GetMyUnitFromZoneScene(ZoneScene);
            //C2R_IOSPayVerifyRequest request = new C2R_IOSPayVerifyRequest() {
            //    UnitId = unit.Id,
            //    payMessage = receipt.Payload,
            //    UnitName = ZoneScene.GetComponent<UserInfoComponent>().UserInfo.Name,   
            //};
            //session.Call(request).Coroutine();

            FloatTipManager.Instance.ShowFloatTipDi($"ios支付返回44:{info}");
            NetHelper.SendIOSPayVerifyRequest(self.ZoneScene(), info).Coroutine();
            Log.Error("xxxxx: " + info);

            UI uirecharget = UIHelper.GetUI(ZoneScene, UIType.UIRecharge);
            if (uirecharget != null)
            {
                uirecharget.GetComponent<UIRechargeComponent>().Loading.SetActive(false);
            }
        }

        public static void OnIosPayFailCallback(this IosPurchasingComponent self)
        {
            Scene ZoneScene = Game.GetZoneScene(1);
            if (ZoneScene == null)
            {
                Log.Error( $"OnIosPayFailCallbackError:ZoneScene == null " );
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