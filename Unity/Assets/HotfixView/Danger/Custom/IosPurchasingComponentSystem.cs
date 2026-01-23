using System;
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
            self.OnIosPaySuccessedToVerify(info).Coroutine();
        }

        private static async ETTask OnIosPaySuccessedToVerify(this IosPurchasingComponent self, string info)
        {
            Scene ZoneScene = Game.GetZoneScene(1);
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
                PlayerPrefsHelp.SetInt("IOSRecgargeType_" + accountInfoComponent.CurrentRoleId.ToString(), accountInfoComponent.RechargeType);
                return;
            }
            Session session = sessionComponent.Session;
            if (session == null || session.IsDisposed)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                PlayerPrefsHelp.SetInt("IOSRecgargeType_" + accountInfoComponent.CurrentRoleId.ToString(), accountInfoComponent.RechargeType);
                return;
            }

            MapComponent mapComponent = ZoneScene.GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum < (int)SceneTypeEnum.MainCityScene)
            {
                PlayerPrefsHelp.SetString("IOS_" + accountInfoComponent.CurrentRoleId.ToString(), info);
                PlayerPrefsHelp.SetInt("IOSRecgargeType_" + accountInfoComponent.CurrentRoleId.ToString(), accountInfoComponent.RechargeType);
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
            //FloatTipManager.Instance.ShowFloatTipDi($"SendIOS. info  {info.Length}");

            Receipt receipt = null;

            try
            {
                receipt = JsonHelper.FromJson<Receipt>(info);
            }
            catch (Exception ex)
            {
                FloatTipManager.Instance.ShowFloatTipDi($"SendIOS. Exception11  {ex.Message}");
                return;
            }
           
            //客户端效验
            //FloatTipManager.Instance.ShowFloatTipDi($"SendIOS .receipt.Payload  {receipt.Payload.Length}");

            string payLoad = receipt.Payload;
            string sendStr = "{\"receipt-data\":\"" + payLoad + "\"}";

            //bool gm = GMHelp.GmAccount.Contains(ZoneScene.GetComponent<AccountInfoComponent>().Account);
            // string uurl = gm ? "https://sandbox.itunes.apple.com/verifyReceipt" : "https://buy.itunes.apple.com/verifyReceipt";
            //string uurl ="https://buy.itunes.apple.com/verifyReceipt";
            //string postReturnStr = await HttpHelper.GetIosPayParameter(uurl, sendStr);

            C2R_IOSPayVerifyRequest request = new C2R_IOSPayVerifyRequest()
            {
                UnitId = UnitHelper.GetMyUnitId(ZoneScene),
                payMessage = receipt.Payload,
                UnitName = ZoneScene.GetComponent<UserInfoComponent>().UserInfo.Name,
                RechargeType = ZoneScene.GetComponent<AccountInfoComponent>().RechargeType
            };
            ZoneScene.GetComponent<SessionComponent>().Session.Call(request).Coroutine();

            //NetHelper.SendIOSPayVerifyRequest(self.ZoneScene(), info).Coroutine();
            UI uirecharget = UIHelper.GetUI(ZoneScene, UIType.UIRecharge);
            if (uirecharget != null)
            {
                uirecharget.GetComponent<UIRechargeComponent>().Loading.SetActive(false);
            }
            await ETTask.CompletedTask;
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