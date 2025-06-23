using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIDonationShowComponent : Entity, IAwake, IDestroy
    {
        public GameObject Text_Hint_1;
        public GameObject Text_Hint_2;
        public GameObject RankDesListNode;
        public GameObject Btn_Donation_2;
        public GameObject InputFieldNumber;
        public GameObject ImageButton;
        public GameObject UIDonationPrice;
        public GameObject Button_Donation;
        public GameObject RankListNode;
        public GameObject Text_MyDonation;
        public GameObject TextMyDonation;
        public GameObject BtnClose;
        public string AssetPath = string.Empty;

        public List<UIDonationShowItemComponent> uIDonationShowItems = new List<UIDonationShowItemComponent>();
        
        public List<Vector2> UIOldPositionList = new List<Vector2>();
    }

    public class UIDonationShowComponentDestroy : DestroySystem<UIDonationShowComponent>
    {
        public override void Destroy(UIDonationShowComponent self)
        {
            if (!string.IsNullOrEmpty(self.AssetPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);
            }
            
            DataUpdateComponent.Instance.RemoveListener(DataType.LanguageUpdate, self);
        }
    }

    public class UIDonationShowComponentAwake : AwakeSystem<UIDonationShowComponent>
    {
        public override void Awake(UIDonationShowComponent self)
        {

            self.uIDonationShowItems.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_Hint_1 = rc.Get<GameObject>("Text_Hint_1");
            self.Text_Hint_2 = rc.Get<GameObject>("Text_Hint_2");
            
            self.RankDesListNode = rc.Get<GameObject>("RankDesListNode");
            
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
                self.On_Button_Donation();
            } );

            self.RankListNode = rc.Get<GameObject>("RankListNode");

            self.StoreUIdData();
            self.OnLanguageUpdate();
            DataUpdateComponent.Instance.AddListener(DataType.LanguageUpdate, self);
            
            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIDonationShowComponentSystem
    {
        public static void StoreUIdData(this UIDonationShowComponent self)
        {
            int childCount = self.RankDesListNode.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                Transform transform = self.RankDesListNode.transform.GetChild(i);
                self.UIOldPositionList.Add(transform.GetComponent<RectTransform>().sizeDelta);

                if (i == 4)
                {
                    self.UIOldPositionList.Add(transform.Find("Text_Other").GetComponent<RectTransform>().localPosition);
                }
            }
        }

        public static void OnLanguageUpdate(this UIDonationShowComponent self)
        {
            Transform transform = self.RankDesListNode.transform.GetChild(0);
            Vector2 size = self.UIOldPositionList[0];
            if (GameSettingLanguge.Language != 0)
            {
                size.y = 200f;
            }
            transform.GetComponent<RectTransform>().sizeDelta = size;
            
            transform = self.RankDesListNode.transform.GetChild(1);
            size = self.UIOldPositionList[1];
            if (GameSettingLanguge.Language != 0)
            {
                size.y = 200f;
            }
            transform.GetComponent<RectTransform>().sizeDelta = size;
            
            transform = self.RankDesListNode.transform.GetChild(2);
            size = self.UIOldPositionList[2];
            if (GameSettingLanguge.Language != 0)
            {
                size.y = 200f;
            }
            transform.GetComponent<RectTransform>().sizeDelta = size;
            
            transform = self.RankDesListNode.transform.GetChild(3);
            size = self.UIOldPositionList[3];
            if (GameSettingLanguge.Language != 0)
            {
                size.y = 200f;
            }
            transform.GetComponent<RectTransform>().sizeDelta = size;
            
            transform = self.RankDesListNode.transform.GetChild(4);
            size = self.UIOldPositionList[4];
            if (GameSettingLanguge.Language != 0)
            {
                size.y = 300f;
            }
            transform.GetComponent<RectTransform>().sizeDelta = size;

            transform = transform.Find("Text_Other");
            Vector2 position = self.UIOldPositionList[5];
            if (GameSettingLanguge.Language != 0)
            {
                position.y = -115f;
            }
            transform.GetComponent<RectTransform>().localPosition = position;
            
            LayoutRebuilder.ForceRebuildLayoutImmediate(self.RankDesListNode.GetComponent<RectTransform>());
            
            self.Text_Hint_1.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
            self.Text_Hint_2.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 34 : 28;
            self.Text_MyDonation.GetComponent<Text>().fontSize = GameSettingLanguge.Language == 0? 36 : 28;
        }

        public static void On_Button_Donation(this UIDonationShowComponent self)
        {
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            if (userInfo.Lv < 12)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("捐献等级不得小于12级"));
                return;
            }
            self.UIDonationPrice.SetActive(!self.UIDonationPrice.activeSelf);
        }

        public static async ETTask OnButton_Donation2(this UIDonationShowComponent self)
        {
            string text = self.InputFieldNumber.GetComponent<InputField>().text;
            int number = int.Parse(text);
            if (number < 100000)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("最低捐献10万金币！"));
                return;
            }

            long instanceid = self.InstanceId;
            C2M_DonationRequest  request = new C2M_DonationRequest() { Price = number };
            M2C_DonationResponse response = (M2C_DonationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceid != self.InstanceId)
            {
                return;
            }

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
            self.AssetPath = path;
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
            self.Text_MyDonation.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("我已捐献{0}金币"), unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RaceDonationNumber));
            self.TextMyDonation.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("我已捐献{0}金币"), unit.GetComponent<NumericComponent>().GetAsLong(NumericType.RaceDonationNumber));
        }
    }
}
