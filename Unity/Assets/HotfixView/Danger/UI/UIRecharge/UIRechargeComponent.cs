using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

namespace ET
{


    public class Receipt
    {
        public string Payload;
    }

    public class UIRechargeComponent: Entity, IAwake
    {
        public GameObject ImageSelect2;
        public GameObject ImageSelect1;
        public GameObject ButtonAliPay;
        public GameObject ButtonWeiXin;

        public GameObject ImageButton;
        public GameObject RechargeList;

        public int PayType; //1微信  2支付宝
        public int ChargetNumber;
    }

    [ObjectSystem]
    public class UIRechargeComponentAwakeSystem : AwakeSystem<UIRechargeComponent>
    {

        public override void Awake(UIRechargeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageSelect2 = rc.Get<GameObject>("ImageSelect2");
            self.ImageSelect1 = rc.Get<GameObject>("ImageSelect1");

            self.ButtonAliPay = rc.Get<GameObject>("ButtonAliPay");
            self.ButtonAliPay.GetComponent<Button>().onClick.AddListener(() => 
            {
                self.ImageSelect1.SetActive(false);
                self.ImageSelect2.SetActive(true);
                self.PayType = PayTypeEnum.AliPay;
            } );
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

            self.InitRechargeList().Coroutine();

#if UNITY_IPHONE && !UNITY_EDITOR
            self.ImageSelect1.SetActive(false);
            self.ImageSelect2.SetActive(false);
            self.ButtonAliPay.SetActive(false);
            self.ButtonWeiXin.SetActive(false);    
#endif

#if UNITY_IPHONE
            GameObject.Find("Global").GetComponent<PurchasingManager>().SuccessedCallback = self.OnIosPaySuccessedCallback;
#endif

        }

    }

    public static class UIRechargeComponentSystem
    {

        public static void OnIosPaySuccessedCallback(this UIRechargeComponent self, string info)
        {
            Receipt receipt = JsonHelper.FromJson<Receipt>(info);
            ET.Log.ILog.Debug("payload[内购成功]:" + receipt.Payload);
            C2M_IOSPayVerifyRequest request = new C2M_IOSPayVerifyRequest() { payMessage = receipt.Payload };
            self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request).Coroutine();
        }

        public static async ETTask InitRechargeList(this UIRechargeComponent self)
        {
            string path = ABPathHelper.GetUGUIPath("Main/Recharge/UIRechargeItem");
            GameObject bundleObj =await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            foreach (var item in ComHelp.RechargeGive)
            {
                GameObject skillItem = GameObject.Instantiate(bundleObj);
                UICommonHelper.SetParent(skillItem, self.RechargeList);
                UI ui_1 = self.AddChild<UI, string, GameObject>("rewardItem_" + item.Key.ToString(), skillItem);
                UIRechargeItemComponent uIItemComponent = ui_1.AddComponent<UIRechargeItemComponent>();
                uIItemComponent.OnInitData(item.Key, item.Value);
                uIItemComponent.SetClickHandler((int number) => { self.OnClickRechargeItem(number).Coroutine(); });
            }
        }

        public static async ETTask OnClickRechargeItem(this UIRechargeComponent self, int chargetNumber)
        {
            FangChenMiComponent fangChenMiComponent = self.ZoneScene().GetComponent<FangChenMiComponent>();
            int code = fangChenMiComponent.CanRechage(chargetNumber);
            if (code != ErrorCore.ERR_Success)
            {
                //EventSystem.Instance.Publish( new EventType.CommonHintError() {  errorValue = code } );
                string tips = "";
                if (code == ErrorCore.ERR_FangChengMi_Tip3)
                {
                    tips = $"{ErrorHelp.Instance.ErrorHintList[code]}";
                }
                else {
                    tips = $"{ErrorHelp.Instance.ErrorHintList[code]} 你本月已充值{fangChenMiComponent.GetMouthTotal()}元";
                }

                PopupTipHelp.OpenPopupTip_3(self.ZoneScene(),"防沉迷提示", tips, () => { }).Coroutine();
                return;
            }
            self.ChargetNumber = chargetNumber;

#if UNITY_IPHONE
            GlobalHelp.OnIOSPurchase(chargetNumber);
#else
            C2M_RechargeRequest c2E_GetAllMailRequest = new C2M_RechargeRequest() { UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId, RechargeNumber = chargetNumber, PayType = self.PayType };
            M2C_RechargeResponse sendChatResponse = (M2C_RechargeResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2E_GetAllMailRequest);

            if (sendChatResponse.Error != ErrorCore.ERR_Success)
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
#endif

            await ETTask.CompletedTask;
        }

        public static void OnRechageSucess(this UIRechargeComponent self)
        {
            FloatTipManager.Instance.ShowFloatTipDi($"充值{self.ChargetNumber}元成功");

            self.ZoneScene().GetComponent<AccountInfoComponent>().PlayerInfo.RechargeInfos.Add(new RechargeInfo()
            {
                    Amount = self.ChargetNumber,
                    Time = TimeHelper.ClientNow(),
                    UserId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId
            });
        }

        public static void OnBtn_Close(this UIRechargeComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIRecharge);
        }
    }

}

