using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDonationShowComponent : Entity, IAwake
    {
        public GameObject Btn_Donation_2;
        public GameObject InputFieldNumber;
        public GameObject ImageButton;
        public GameObject UIDonationPrice;
        public GameObject Button_Donation;
        public GameObject RankListNode;
        public GameObject Text_MyDonation;
        public GameObject TextMyDonation;
        public GameObject BtnClose;

        public List<UIDonationShowItemComponent> uIDonationShowItems = new List<UIDonationShowItemComponent>();
    }

    public class UIDonationShowComponentAwake : AwakeSystem<UIDonationShowComponent>
    {
        public override void Awake(UIDonationShowComponent self)
        {

            self.uIDonationShowItems.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Donation_2 = rc.Get<GameObject>("Btn_Donation_2");
            ButtonHelp.AddListenerEx(self.Btn_Donation_2, () => { self.OnButton_Donation2().Coroutine(); });

            self.InputFieldNumber = rc.Get<GameObject>("InputFieldNumber");
            self.Text_MyDonation = rc.Get<GameObject>("Text_MyDonation");
            self.TextMyDonation = rc.Get<GameObject>("TextMyDonation");

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.UIDonationPrice.SetActive(false); });

            self.BtnClose = rc.Get<GameObject>("BtnClose");
            self.BtnClose.GetComponent<Button>().onClick.AddListener(() => { self.UIDonationPrice.SetActive(false); });

            self.UIDonationPrice = rc.Get<GameObject>("UIDonationPrice");
            self.UIDonationPrice.SetActive(false);

           self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            self.Button_Donation.GetComponent<Button>().onClick.AddListener(() => {
                self.UIDonationPrice.SetActive(!self.UIDonationPrice.activeSelf); 
            } );

            self.RankListNode = rc.Get<GameObject>("RankListNode");

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIDonationShowComponentSystem
    {

        public static async ETTask OnButton_Donation2(this UIDonationShowComponent self)
        {
            string text = self.InputFieldNumber.GetComponent<InputField>().text;
            int number = int.Parse(text);
            if (number < 100000)
            {
                FloatTipManager.Instance.ShowFloatTip("最低捐献10万金币！");
                return;
            }

            C2M_DonationRequest  request = new C2M_DonationRequest() { Price = number };
            M2C_DonationResponse response = (M2C_DonationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.UIDonationPrice.SetActive(false);
            self.OnUpdateUI().Coroutine();
        }

        public static async ETTask OnUpdateUI(this UIDonationShowComponent self)
        {
            C2U_DonationRankListRequest  request  = new C2U_DonationRankListRequest() { };
            U2C_DonationRankListResponse response = (U2C_DonationRankListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Donation/UIDonationShowItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            for (int i = 0; i < response.RankList.Count; i++)
            {
                UIDonationShowItemComponent ui_1 = null;
                if (i < self.uIDonationShowItems.Count)
                {
                    ui_1 = self.uIDonationShowItems[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(gameObject, self.RankListNode);
                    ui_1 = self.AddChild<UIDonationShowItemComponent, GameObject>(gameObject);
                    self.uIDonationShowItems.Add(ui_1);
                }
                ui_1.OnUpdateUI(i + 1, response.RankList[i]);
            }

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.Text_MyDonation.GetComponent<Text>().text = $"我已捐献{unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RaceDonationNumber)}金币";
            self.TextMyDonation.GetComponent<Text>().text = $"我已捐献{unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RaceDonationNumber)}金币";
        }
    }
}
