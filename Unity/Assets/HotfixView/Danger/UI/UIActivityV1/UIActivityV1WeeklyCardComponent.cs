using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1WeeklyCardComponent : Entity, IAwake, IDestroy
    {


        public GameObject Node_1;
        public GameObject Node_2;
        public GameObject ButtonAliPay;
        public GameObject ButtonWeiXix;
        public GameObject ButtonDiClose;
        public GameObject RechargeSelectUI;
        public GameObject Text_Number;
        public GameObject ButtonOpen_1;
        public GameObject ButtonOpen_2;
        public GameObject UIActivityV1WeeklyCardItem;
        public GameObject TaskListNode;
        public GameObject BtnItemTypeSet;
        public UIPageButtonComponent uIPageViewComponent;
        public int ReChargeNumber;
        public int PayType;

        public List<UIActivityV1WeeklyCardItemComponent> WeeklyCardItemList = new List<UIActivityV1WeeklyCardItemComponent>();    
    }

    public class UIActivityV1WeeklyCardComponentDestroy : DestroySystem<UIActivityV1WeeklyCardComponent>
    {
        public override void Destroy(UIActivityV1WeeklyCardComponent self)
        {

        }
    }

    public class UIActivityV1WeeklyCardComponentAwake : AwakeSystem<UIActivityV1WeeklyCardComponent>
    {
        public override void Awake(UIActivityV1WeeklyCardComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            self.WeeklyCardItemList.Clear();

            self.Node_1 = rc.Get<GameObject>("Node_1");
            self.Node_2 = rc.Get<GameObject>("Node_2");
            self.Node_1.SetActive(false);
            self.Node_2.SetActive(false);

            self.UIActivityV1WeeklyCardItem = rc.Get<GameObject>("UIActivityV1WeeklyCardItem");
            self.UIActivityV1WeeklyCardItem.SetActive(false);
            self.TaskListNode = rc.Get<GameObject>("TaskListNode");

            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            self.uIPageViewComponent = uIPageViewComponent;
            uIPageViewComponent.SetClickHandler((int page) => { self.OnClickPageButton(page); });
           

            self.ButtonAliPay = rc.Get<GameObject>("ButtonAliPay");
            self.ButtonWeiXix = rc.Get<GameObject>("ButtonWeiXix"); 
            self.ButtonDiClose = rc.Get<GameObject>("ButtonDiClose"); 
            self.RechargeSelectUI = rc.Get<GameObject>("RechargeSelectUI");
            self.RechargeSelectUI.SetActive(false);
            self.Text_Number = rc.Get<GameObject>("Text_Number"); 
            self.ButtonOpen_1 = rc.Get<GameObject>("ButtonOpen_1");
            self.ButtonOpen_1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickRechargeItem().Coroutine();  } );

            self.ButtonOpen_2 = rc.Get<GameObject>("ButtonOpen_2");
            self.ButtonOpen_2.GetComponent<Button>().onClick.AddListener(() => { self.OnClickRechargeItem().Coroutine(); });

            self.ButtonDiClose.GetComponent<Button>().onClick.AddListener(self.OnButtonDiClose);
            self.ButtonAliPay.GetComponent<Button>().onClick.AddListener(self.OnButtonAliPay);
            self.ButtonWeiXix.GetComponent<Button>().onClick.AddListener(self.OnButtonWeiXix);

            self.ZoneScene().GetComponent<AccountInfoComponent>().RechargeType = 1;

            uIPageViewComponent.OnSelectIndex(0);
        }
    }

    public static class UIActivityV1WeeklyCardComponentSystem
    {
        public static void OnButtonAliPay(this UIActivityV1WeeklyCardComponent self)
        {
            self.PayType = PayTypeEnum.AliPay;
            self.RechargeSelectUI.SetActive(false);
            self.RequestRecharge().Coroutine();
        }

        public static void OnButtonWeiXix(this UIActivityV1WeeklyCardComponent self)
        {
            self.PayType = PayTypeEnum.WeiXinPay;
            self.RechargeSelectUI.SetActive(false);
            self.RequestRecharge().Coroutine();
        }

        /// <summary>
        /// 抖音
        /// </summary>
        /// <param name="self"></param>
        /// <param name="riskControl"></param>
        public static void OnGetRiskControlInfo(this UIActivityV1WeeklyCardComponent self, string riskControl)
        {
            Log.ILog.Debug($"OnGetRiskControlInfo: {riskControl}");
            self.RequestRecharge(riskControl).Coroutine();
        }

        /// <summary>
        /// 像服务器请求支付订单
        /// </summary>
        /// <param name="self"></param>
        /// <param name="riskControl"></param>
        /// <returns></returns>
        public static async ETTask RequestRecharge(this UIActivityV1WeeklyCardComponent self, string riskControl = "")
        {
            int rechargeNumber = self.ReChargeNumber;
            C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest()
            {
                RiskControlInfo = riskControl,
                RechargeNumber = rechargeNumber,
                PayType = self.PayType,
                RechargeType = self.ZoneScene().GetComponent<AccountInfoComponent>().RechargeType
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
                //拉起支付宝支付
                GlobalHelp.AliPay(sendChatResponse.Message);
            }
            if (self.PayType == PayTypeEnum.WeiXinPay)
            {
                //拉起微信支付
                GlobalHelp.WeChatPay(sendChatResponse.Message);
            }
            if (self.PayType == PayTypeEnum.TikTok)
            {
                if (GlobalHelp.GetBigVersion() >= 17 && GlobalHelp.GetPlatform() == 5)
                {
#if UNITY_ANDROID
                    //拉起抖音支付
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
                // //拉起渠道支付
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

        public static async ETTask OnClickRechargeItem(this UIActivityV1WeeklyCardComponent self)
        {
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int dtype = self.uIPageViewComponent.CurrentIndex;
            long weeklycardtime = 0;
            int lefttimes = 0;
            int recvtimes = 0;
            if (dtype == 0)
            {
                weeklycardtime = numericComponent.GetAsLong(NumericType.GoldWeeklyCard);
                recvtimes = activityComponent.ActivityV1Info.GoldWeeklyCardRewards.Count;
            }
            else
            {
                weeklycardtime = numericComponent.GetAsLong(NumericType.DiamondWeeklyCard);
                recvtimes = activityComponent.ActivityV1Info.DiamondWeeklyCardRewards.Count;
            }

            long servertime = TimeHelper.ServerNow();
            lefttimes = ComHelp.GetDaysDiffByDate(servertime, weeklycardtime);
            if (lefttimes < 7 && recvtimes < 7)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("周卡还未到期！"));
                return;
            }

            await ETTask.CompletedTask;
            int chargetNumber = self.uIPageViewComponent.CurrentIndex == 0 ? 30 : 98;
            self.ReChargeNumber = chargetNumber;
#if UNITY_IPHONE
            //拉起ios支付
                                self.PayType = PayTypeEnum.IOSPay;
             GlobalHelp.OnIOSPurchase(chargetNumber);
            self.RechargeSelectUI.SetActive(false);

             //ios主要用来服务器打印日志
            C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest() { 
            RechargeNumber = chargetNumber,
            PayType = PayTypeEnum.IOSPay,
            RechargeType = self.ZoneScene().GetComponent<AccountInfoComponent>().RechargeType
            };
            self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest).Coroutine();
#else

            if (GlobalHelp.GetPlatform() == 5 && GlobalHelp.GetBigVersion() >= 17)
            {
#if UNITY_ANDROID
                //授权后才拉起抖音支付
                self.PayType = PayTypeEnum.TikTok;
                self.RechargeSelectUI.SetActive(false);
                EventType.TikTokRiskControlInfo.Instance.ZoneScene = self.ZoneScene();
                EventType.TikTokRiskControlInfo.Instance.RiskControlInfoHandler = (string text) => { self.OnGetRiskControlInfo(text); };
                EventSystem.Instance.PublishClass(EventType.TikTokRiskControlInfo.Instance);
#endif
            }
            else if (GlobalHelp.GetPlatform() == 100 && GlobalHelp.GetBigVersion() >= 23)
            {
                //渠道支付
                self.PayType = PayTypeEnum.QuDaoPay;
                self.RechargeSelectUI.SetActive(false);
                self.RequestRecharge(string.Empty).Coroutine();
            }
            else if (GlobalHelp.GetPlatform() == 7 && GlobalHelp.GetBigVersion() >= 23)
            {
                //拉起google支付
                self.PayType = PayTypeEnum.Google;
                self.RechargeSelectUI.SetActive(false);
                GlobalHelp.OnGooglePurchase(chargetNumber);
                //google 主要用来服务器打印日志
                C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest() 
                { 
                    RechargeNumber = chargetNumber, 
                    PayType = PayTypeEnum.Google, 
                    RechargeType = self.ZoneScene().GetComponent<AccountInfoComponent>().RechargeType
                };
                self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest).Coroutine();
            }
            else
            {
                self.RechargeSelectUI.SetActive(true);
            }

            //记录tap数据
            try
            {
                AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();
                string serverName = accountInfoComponent.ServerName;
                UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
                TapSDKHelper.UpLoadPlayEvent(userInfo.Name, serverName, userInfo.Lv, 4, chargetNumber);
            }
            catch (Exception ex)
            {
                Log.Debug("UIRecharge ex:" + ex);
            }

#endif
           
        }

        public static void OnButtonDiClose(this UIActivityV1WeeklyCardComponent self)
        {
            self.RechargeSelectUI.SetActive(false);
        }

        public static void OnClickPageButton(this UIActivityV1WeeklyCardComponent self, int page)
        {
            self.Node_1.SetActive(page == 0);
            self.Node_2.SetActive(page == 1);

            self.UpdateInfo();
            self.ShowLeftTimes();
        }

        public static void ShowLeftTimes(this UIActivityV1WeeklyCardComponent self)
        {
            ActivityComponent activityComponent  = self.ZoneScene().GetComponent<ActivityComponent>();  
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene() );
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();
            int dtype = self.uIPageViewComponent.CurrentIndex;
            long weekstarttime = 0;
            int lefttimes = 0;
            int recvtimes = 0;
            if (dtype == 0)
            {
                weekstarttime = numericComponent.GetAsLong( NumericType.GoldWeeklyCard );
                recvtimes = activityComponent.ActivityV1Info.GoldWeeklyCardRewards.Count;
            }
            else
            {
                weekstarttime = numericComponent.GetAsLong(NumericType.DiamondWeeklyCard);
                recvtimes = activityComponent.ActivityV1Info.DiamondWeeklyCardRewards.Count;
            }

            long servertime = TimeHelper.ServerNow();
            if (weekstarttime <= 0 || servertime < weekstarttime)
            {
                lefttimes = 0;
            }
            else
            {
                int passday = ComHelp.GetDaysDiffByDate(servertime, weekstarttime);
                if (passday < 7)
                {
                    lefttimes = passday + 1 - recvtimes;
                }
            }
   
            self.Text_Number.GetComponent<Text>().text = $"{lefttimes}/{7}";
        }

        public static void OnWeeklyCardUpdate(this UIActivityV1WeeklyCardComponent self)
        {
            self.OnClickPageButton(self.uIPageViewComponent.CurrentIndex);
        }

        public static void UpdateInfo(this UIActivityV1WeeklyCardComponent self)
        {
            int dtype = self.uIPageViewComponent.CurrentIndex ;
            List<string> rewardlist = ActivityConfigHelper.ActivityV1WeeklyCardReward[dtype + 1];

            for (int i = 0; i < rewardlist.Count; i++)
            {
                string rewarditem = rewardlist[i];
                UIActivityV1WeeklyCardItemComponent component = null;

                if (i < self.WeeklyCardItemList.Count)
                {
                    component = self.WeeklyCardItemList[i];
                }
                else
                {
                    GameObject go = UnityEngine.Object.Instantiate(self.UIActivityV1WeeklyCardItem);
                    component = self.AddChild<UIActivityV1WeeklyCardItemComponent, GameObject>(go);
                    UICommonHelper.SetParent(go, self.TaskListNode);
                    go.SetActive(true);
                    self.WeeklyCardItemList.Add(component);
                }

                component.OnUpdateData(dtype + ActivityConfigHelper.ActivityV1_GoldWeeklyCard, i);
            }

            for (int i = 0; i < self.WeeklyCardItemList.Count; i++)
            {
                

            }
        }
    }
}