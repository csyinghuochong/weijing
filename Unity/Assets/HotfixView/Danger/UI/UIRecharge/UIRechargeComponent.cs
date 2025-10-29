using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRechargeComponent: Entity, IAwake, IDestroy
    {

        public GameObject Loading;
        public GameObject Img_Loading;
        public GameObject ImageSelect2;
        public GameObject ImageSelect1;
        public GameObject ButtonAliPay;
        public GameObject ButtonWeiXin;
        public GameObject ButtonIOSTest;

        public GameObject ImageButton;
        public GameObject RechargeList;

        public int PayType; //1微信  2支付宝
        public int ReChargeNumber;

        public string AssetPath = string.Empty;
    }

    public class UIRechargeComponentDestroy : DestroySystem<UIRechargeComponent>
    {
        public override void Destroy(UIRechargeComponent self)
        {
            //GameObject.Find("Global").GetComponent<Init>().OnRiskControlInfoHandler = null;
            if (!string.IsNullOrEmpty(self.AssetPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);
            }
        }
    }

    public class UIRechargeComponentAwakeSystem : AwakeSystem<UIRechargeComponent>
    {

        public override void Awake(UIRechargeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Loading = rc.Get<GameObject>("Loading");
            self.Loading.SetActive(false);
            self.ImageSelect2 = rc.Get<GameObject>("ImageSelect2");
            self.ImageSelect1 = rc.Get<GameObject>("ImageSelect1");
            self.Img_Loading = rc.Get<GameObject>("Img_Loading");

            UI uirotate = self.AddChild<UI, string, GameObject>("Img_Loading", self.Img_Loading);
            uirotate.AddComponent<UIRotateComponent>().Start = true;

            self.ButtonAliPay = rc.Get<GameObject>("ButtonAliPay");
            self.ButtonAliPay.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.ImageSelect1.SetActive(false);
                self.ImageSelect2.SetActive(true);
                self.PayType = PayTypeEnum.AliPay;
            });
            self.ButtonWeiXin = rc.Get<GameObject>("ButtonWeiXin");
            self.ButtonWeiXin.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.ImageSelect1.SetActive(true);
                self.ImageSelect2.SetActive(false);
                self.PayType = PayTypeEnum.WeiXinPay;
            });
            self.ImageSelect1.SetActive(false);
            self.ImageSelect2.SetActive(true);
            self.RechargeList = rc.Get<GameObject>("RechargeList");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Close(); });
            self.PayType = PayTypeEnum.AliPay;

            self.ButtonIOSTest = rc.Get<GameObject>("ButtonIOSTest");
            self.ButtonIOSTest.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonIOSTest(); });
            self.ButtonIOSTest.SetActive(false);
#if UNITY_IPHONE
             self.ButtonIOSTest.SetActive( GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account));
#endif
             self.InitRechargeList().Coroutine();

            if (GlobalHelp.GetPlatform() == 5)
            {
                self.PayType = PayTypeEnum.TikTok;
                self.ImageSelect1.SetActive(false);
                self.ImageSelect2.SetActive(false);
                self.ButtonAliPay.SetActive(false);
                self.ButtonWeiXin.SetActive(false);
            }

            if (GlobalHelp.GetPlatform() == 7 || GameSettingLanguge.Language == 1)
            {
                self.PayType = PayTypeEnum.Google;
                self.ImageSelect1.SetActive(false);
                self.ImageSelect2.SetActive(false);
                self.ButtonAliPay.SetActive(false);
                self.ButtonWeiXin.SetActive(false);
            }
            
            if (GlobalHelp.GetPlatform() == 100)
            {
                self.PayType = PayTypeEnum.QuDaoPay;
                self.ImageSelect1.SetActive(false);
                self.ImageSelect2.SetActive(false);
                self.ButtonAliPay.SetActive(false);
                self.ButtonWeiXin.SetActive(false);
            }
#if UNITY_IPHONE && !UNITY_EDITOR
            self.ImageSelect1.SetActive(false);
            self.ImageSelect2.SetActive(false);
            self.ButtonAliPay.SetActive(false);
            self.ButtonWeiXin.SetActive(false);    
#endif


        }
    }

    public static class UIRechargeComponentSystem
    {
        public static async ETTask InitRechargeList(this UIRechargeComponent self)
        {
            long instanceid = self.InstanceId;
            string path = ABPathHelper.GetUGUIPath("Main/Recharge/UIRechargeItem");
            GameObject bundleObj = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            self.AssetPath = path;
            if (GlobalHelp.GetPlatform() == 7 || GameSettingLanguge.Language == 1)
            {
                foreach (var item in ConfigHelper.RechargeGive_EN)
                {
                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.RechargeList);
                    UI ui_1 = self.AddChild<UI, string, GameObject>("rewardItem_" + item.Key.ToString(), skillItem);
                    UIRechargeItemComponent uIItemComponent = ui_1.AddComponent<UIRechargeItemComponent>();
                    uIItemComponent.OnInitData(item.Key, item.Value);
                    uIItemComponent.SetClickHandler((int number) => { self.OnClickRechargeItem(number).Coroutine(); });
                }
            }
            else
            {
                foreach (var item in ConfigHelper.RechargeGive)
                {
                    if (item.Key == 1)
                    {
                        continue;
                    }

                    GameObject skillItem = GameObject.Instantiate(bundleObj);
                    UICommonHelper.SetParent(skillItem, self.RechargeList);
                    UI ui_1 = self.AddChild<UI, string, GameObject>("rewardItem_" + item.Key.ToString(), skillItem);
                    UIRechargeItemComponent uIItemComponent = ui_1.AddComponent<UIRechargeItemComponent>();
                    uIItemComponent.OnInitData(item.Key, item.Value);
                    uIItemComponent.SetClickHandler((int number) => { self.OnClickRechargeItem(number).Coroutine(); });
                }
            }
        }

        public static void OnGetRiskControlInfo(this UIRechargeComponent self, string riskControl)
        {
            Log.ILog.Debug($"OnGetRiskControlInfo: {riskControl}");
            self.RequestRecharge(riskControl).Coroutine();
        }

        public static async ETTask RequestRecharge(this UIRechargeComponent self, string riskControl = "")
        {
            int rechargeNumber = self.ReChargeNumber;
            C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest()
            {
                RiskControlInfo = riskControl,
                RechargeNumber = rechargeNumber,
                PayType = self.PayType
            };

            M2C_RechargeResponse sendChatResponse = (M2C_RechargeResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);

            if (sendChatResponse.Error != ErrorCode.ERR_Success)
            {
                return;
            }
            if (GlobalHelp.IsBanHaoMode || string.IsNullOrEmpty(sendChatResponse.Message))
            {
                return;
            }
            if (self.PayType == PayTypeEnum.AliPay)
            {
                GlobalHelp.AliPay(sendChatResponse.Message);
            }
            if (self.PayType == PayTypeEnum.WeiXinPay)
            {
                GlobalHelp.WeChatPay(sendChatResponse.Message);
            }
            if (self.PayType == PayTypeEnum.TikTok)
            {
                if (GlobalHelp.GetBigVersion() >= 17 && GlobalHelp.GetPlatform() == 5)
                {
#if UNITY_ANDROID
                    Log.ILog.Debug($"M2C_RechargeResponse: {sendChatResponse.Message}");
                    EventType.TikTokPayRequest.Instance.ZoneScene = self.ZoneScene();
                    EventType.TikTokPayRequest.Instance.PayMessage = sendChatResponse.Message;
                    EventType.TikTokPayRequest.Instance.RechargeNumber = self.ReChargeNumber;
                    EventSystem.Instance.PublishClass(EventType.TikTokPayRequest.Instance);
#endif
                }
            }
            if (self.PayType == PayTypeEnum.QuDaoPay)
            {
                EventType.QuDaoOnPay.Instance.ZoneScene = self.ZoneScene();
                AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                string payinfo = $"{rechargeNumber}_{accountInfoComponent.CurrentRoleId}_{userInfoComponent.UserInfo.Lv}_{userInfoComponent.UserInfo.Name}_{accountInfoComponent.ServerId}_{accountInfoComponent.ServerName}_{sendChatResponse.Message}"; 
                EventType.QuDaoOnPay.Instance.PayInfo = payinfo;
                EventSystem.Instance.PublishClass(EventType.QuDaoOnPay.Instance);

                //test-----------------------------------------------------------
                //EventType.QuDaoOnPay.Instance.ZoneScene = self.ZoneScene();
                //AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                //UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
                //string payinfo = $"{1}_{accountInfoComponent.CurrentRoleId}_{userInfoComponent.UserInfo.Lv}_{userInfoComponent.UserInfo.Name}_{accountInfoComponent.ServerId}_{accountInfoComponent.ServerName}_{sendChatResponse.Message}";
                //EventType.QuDaoOnPay.Instance.PayInfo = payinfo;
                //EventSystem.Instance.PublishClass(EventType.QuDaoOnPay.Instance);
            }
        }

        public static async ETTask OnClickRechargeItem(this UIRechargeComponent self, int chargetNumber)
        {
 #if UNITY_IPHONE
            //AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
            //bool gm = GMHelp.GmAccount.Contains(accountInfoComponent.Account);
            //if (!gm)
            //{
            //    FloatTipManager.Instance.ShowFloatTip("苹果平台暂时不能充值！");
            //    return;
            //}
#endif

            FangChenMiComponent fangChenMiComponent = self.ZoneScene().GetComponent<FangChenMiComponent>();
            int code = fangChenMiComponent.CanRechage(chargetNumber);
            if (code != ErrorCode.ERR_Success)
            {
                //EventSystem.Instance.Publish( new EventType.CommonHintError() {  errorValue = code } );
                string tips = "";
                if (code == ErrorCode.ERR_FangChengMi_Tip3)
                {
                    tips = $"{ErrorHelp.Instance.ErrorHintList[code]}";
                }
                else {
                    tips = string.Format(GameSettingLanguge.LoadLocalization("{0} 你本月已充值{1}元"), ErrorHelp.Instance.ErrorHintList[code], fangChenMiComponent.GetMouthTotal());
                }

                PopupTipHelp.OpenPopupTip_3(self.ZoneScene(), GameSettingLanguge.LoadLocalization("防沉迷提示"), tips, () => { }).Coroutine();
                return;
            }
            self.ReChargeNumber = chargetNumber;

#if UNITY_IPHONE
            self.Loading.SetActive(true);
            GlobalHelp.OnIOSPurchase(chargetNumber);
            C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest() { RechargeNumber = chargetNumber, PayType = PayTypeEnum.IOSPay };
            self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest).Coroutine();
#else

            if (GlobalHelp.GetPlatform() == 5 && GlobalHelp.GetBigVersion() >= 17)
            {
#if UNITY_ANDROID
                EventType.TikTokRiskControlInfo.Instance.ZoneScene = self.ZoneScene();
                EventType.TikTokRiskControlInfo.Instance.RiskControlInfoHandler = (string text) => { self.OnGetRiskControlInfo(text); };
                EventSystem.Instance.PublishClass(EventType.TikTokRiskControlInfo.Instance);
#endif
            }
            else if (GlobalHelp.GetPlatform() == 7 && GlobalHelp.GetBigVersion() >= 23)
            {
                //google
                self.Loading.SetActive(true);
                //test
                //chargetNumber = 1;
                GlobalHelp.OnGooglePurchase(chargetNumber);
                C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest() { RechargeNumber = chargetNumber, PayType = PayTypeEnum.Google };
                self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest).Coroutine();
            }
            else
            {
                self.RequestRecharge().Coroutine();
            }

            //记录tap数据
            try
            {
                AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                string serverName = accountInfoComponent.ServerName;
                UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                TapSDKHelper.UpLoadPlayEvent(userInfo.Name, serverName, userInfo.Lv, 4, chargetNumber);
            }
            catch (Exception ex) {
                Log.Debug("UIRecharge ex:" + ex);
            }

#endif

            await ETTask.CompletedTask;
        }

        public static void OnButtonIOSTest(this UIRechargeComponent self)
        {
            string account = self.ZoneScene().GetComponent<AccountInfoComponent>().Account;
            if (!GMHelp.GmAccount.Contains(account))
            {
                return;
            }
            GlobalHelp.OnIOSPurchaseTest();
        }

        public static void OnBtn_Close(this UIRechargeComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIRecharge);
        }

        public static void OnRechageSucess(this UIRechargeComponent self, int amount, int now)
        {
#if UNITY_ANDROID
            if (amount <= 0)
            {
                return;
            }

            int r_num = RandomHelper.RandomNumber(1000, 9999);
            string nowTime = TimeHelper.ServerNow().ToString();
            string orderId = $"Pay_{r_num}_{nowTime}_{amount}";
            string product = $"{amount}WJ";
            string payment = "pay";
            if (self.PayType == PayTypeEnum.AliPay)
            {
                orderId = $"AliPay_{r_num}_{nowTime}_{amount}";
                payment = "alipay";
            }
            if (self.PayType == PayTypeEnum.WeiXinPay)
            {
                orderId = $"WXPay_{r_num}_{nowTime}_{amount}";
                payment = "wechat";
            }

            if (GlobalHelp.GetPlatform() == 1)
            {
                
                TapSDKHelper.OnCharge(orderId, product, amount * 100, "CNY", payment, "{\"on_sell\":true}");
                TapSDKHelper.UserUpdate_rechargeNumber(now);
            }

            if (GlobalHelp.GetPlatform() == 8)
            {
                AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                EventType.TikTokOnPay.Instance.ZoneScene = self.ZoneScene();
                EventType.TikTokOnPay.Instance.GameUserID = accountInfoComponent.Account;
                EventType.TikTokOnPay.Instance.GameRoleID = accountInfoComponent.CurrentRoleId.ToString();
                EventType.TikTokOnPay.Instance.GameOrderID = orderId;
                EventType.TikTokOnPay.Instance.TotalAmount = amount;
                EventType.TikTokOnPay.Instance.ProductID = product;
                EventType.TikTokOnPay.Instance.ProductName = product;
                EventType.TikTokOnPay.Instance.ProductDesc = product;

                EventSystem.Instance.PublishClass(EventType.TikTokOnPay.Instance);
            }
#endif
        }
    }
}

