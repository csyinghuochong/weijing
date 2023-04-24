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
    }

    public class UIDonationShowComponentAwake : AwakeSystem<UIDonationShowComponent>
    {
        public override void Awake(UIDonationShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Btn_Donation_2 = rc.Get<GameObject>("Btn_Donation_2");
            ButtonHelp.AddListenerEx(self.Btn_Donation_2, () => { self.OnButton_Donation2().Coroutine(); });

            self.InputFieldNumber = rc.Get<GameObject>("InputFieldNumber");


            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.UIDonationPrice.SetActive(false); });

            self.UIDonationPrice = rc.Get<GameObject>("UIDonationPrice");
            self.UIDonationPrice.SetActive(false);

           self.Button_Donation = rc.Get<GameObject>("Button_Donation");
            self.Button_Donation.GetComponent<Button>().onClick.AddListener(() => {
                self.UIDonationPrice.SetActive(!self.UIDonationPrice.activeSelf); 
            } );

            self.RankListNode = rc.Get<GameObject>("RankListNode");

        }
    }

    public static class UIDonationShowComponentSystem
    {

        public static async ETTask OnButton_Donation2(this UIDonationShowComponent self)
        {
            string text = self.InputFieldNumber.GetComponent<InputField>().text;
            int number = int.Parse(text);

            C2M_DonationRequest  request = new C2M_DonationRequest() { Price = number };
            M2C_DonationResponse response = (M2C_DonationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.UIDonationPrice.SetActive(false);

            self.OnUpdateUI().Coroutine();
        }

        public static async ETTask OnUpdateUI(this UIDonationShowComponent self)
        {
            await ETTask.CompletedTask;
        }
    }
}
