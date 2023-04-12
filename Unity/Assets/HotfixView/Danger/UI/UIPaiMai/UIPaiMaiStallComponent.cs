using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPaiMaiStallComponent : Entity, IAwake
    {
        public GameObject Btn_ChangeName;
        public GameObject ImageButton;
        public GameObject Btn_Close;
        public GameObject ItemListNode;
        public GameObject Btn_BuyItem;
        public GameObject Btn_ShouTan;
        public GameObject Lab_Name;

        public List<UI> StallItemUILIist = new List<UI>();
        public PaiMaiItemInfo PaiMaiItemInfo;
        public long UserId;
    }


    public class UIPaiMaiStallComponentAwakeSystem : AwakeSystem<UIPaiMaiStallComponent>
    {
        public override void Awake(UIPaiMaiStallComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose(); });
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { self.OnButtonClose(); });

            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Btn_BuyItem = rc.Get<GameObject>("Btn_BuyItem");
            self.Btn_ShouTan = rc.Get<GameObject>("Btn_ShouTan");
            self.Lab_Name = rc.Get<GameObject>("Lab_Name");
            self.Lab_Name.GetComponent<InputField>().onValueChanged.AddListener((string text) => { self.CheckSensitiveWords(); });

            self.Btn_ChangeName = rc.Get<GameObject>("Btn_ChangeName");

            ButtonHelp.AddListenerEx(self.Btn_BuyItem, () => { self.OnBtn_BuyItem().Coroutine(); });
            ButtonHelp.AddListenerEx(self.Btn_ShouTan, () => { self.OnButtonShouTan(); });
            ButtonHelp.AddListenerEx(self.Btn_ChangeName, () => { self.OnBtn_ChangeName().Coroutine(); });
            self.StallItemUILIist.Clear();
        }
    }


    public static class UIPaiMaiStallComponentSystem
    {
        public static void CheckSensitiveWords(this UIPaiMaiStallComponent self)
        {
            string text_new = "";
            string text_old = self.Lab_Name.GetComponent<InputField>().text;
            MaskWordHelper.Instance.IsContainSensitiveWords(ref text_old, out text_new);
            self.Lab_Name.GetComponent<InputField>().text = text_old;
        }

        public static async ETTask OnBtn_ChangeName(this UIPaiMaiStallComponent self)
        {
            string name = self.Lab_Name.GetComponent<InputField>().text;
            bool mask = MaskWordHelper.Instance.IsContainSensitiveWords(name);
            if (mask)
            {
                FloatTipManager.Instance.ShowFloatTip("请重新输入！");
                return;
            }

            C2M_StallOperationRequest c2M_StallOperationRequest = new C2M_StallOperationRequest()
            {
                StallType = 2,
                Value = name
            };
            M2C_StallOperationResponse m2C_PaiMaiBuyResponse = (M2C_StallOperationResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_StallOperationRequest);
            self.Lab_Name.GetComponent<InputField>().text = name;
        }

        public static  void OnUpdateUI(this UIPaiMaiStallComponent self, Unit unit)
        {
            self.UserId = unit.Id;
         
            long selfId = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.UserId;
            bool ifSelf = selfId == self.UserId;
            self.Btn_BuyItem.SetActive(!ifSelf);
            self.Btn_ShouTan.SetActive(ifSelf);
            if (!string.IsNullOrEmpty(unit.GetComponent<UnitInfoComponent>().StallName))
            {
                self.Lab_Name.GetComponent<InputField>().text = unit.GetComponent<UnitInfoComponent>().StallName;
            }
            else
            {
                self.Lab_Name.GetComponent<InputField>().text = unit.GetComponent<UnitInfoComponent>().UnitName + "的摊位";
            }
            self.RequestStallInfo().Coroutine();
        }

        public static async ETTask RequestStallInfo(this UIPaiMaiStallComponent self)
        {

            long instanceId = self.InstanceId;
            C2P_PaiMaiListRequest c2M_PaiMaiBuyRequest = new C2P_PaiMaiListRequest()
            {
                PaiMaiType = 1,
                UserId = self.UserId
            };
            P2C_PaiMaiListResponse m2C_PaiMaiBuyResponse = (P2C_PaiMaiListResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_PaiMaiBuyRequest);
            if (self.InstanceId != instanceId)
            {
                return;
            }

            var path = ABPathHelper.GetUGUIPath("Main/PaiMai/UIPaiMaiStallItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            int number = 0;
            for (int i = 0; i < m2C_PaiMaiBuyResponse.PaiMaiItemInfos.Count; i++)
            {
                PaiMaiItemInfo paiMaiItemInfo = m2C_PaiMaiBuyResponse.PaiMaiItemInfos[i];
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(paiMaiItemInfo.BagInfo.ItemID);
                if (!ComHelp.IsShowPaiMai(itemConfig.ItemType, itemConfig.ItemSubType))
                {
                    continue;
                }

                UI uI = null;
                if (number < self.StallItemUILIist.Count)
                {
                    uI = self.StallItemUILIist[number];
                    uI.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.ItemListNode) ;
                    go.transform.localScale = Vector3.one * 1f;
                    uI = self.AddChild<UI, string, GameObject>( "BagItemUILIist_" + i, go);
                    UIPaiMaiStallItemComponent uIItemComponent = uI.AddComponent<UIPaiMaiStallItemComponent>();
                    uIItemComponent.SetClickHandler((PaiMaiItemInfo bagInfo) => { self.OnSelectStallItem(bagInfo); });
                    self.StallItemUILIist.Add(uI);
                }
                uI.GetComponent<UIPaiMaiStallItemComponent>().OnUpdateUI(paiMaiItemInfo).Coroutine();
                number++;
            }
            for (int i = number; i < self.StallItemUILIist.Count; i++)
            {
                self.StallItemUILIist[i].GameObject.SetActive(false);
            }
        }

        public static void OnSelectStallItem(this UIPaiMaiStallComponent self , PaiMaiItemInfo bagInfo)
        {
            for (int i = 0;  i < self.StallItemUILIist.Count; i++)
            {
                self.StallItemUILIist[i].GetComponent<UIPaiMaiStallItemComponent>().SetSelected(bagInfo.Id);
            }
            self.PaiMaiItemInfo = bagInfo;
        }

        public static async ETTask OnBtn_BuyItem(this UIPaiMaiStallComponent self)
        {
            UI uI = await UIHelper.Create(  self.DomainScene(), UIType.UIPaiMaiStallBuy );
            uI.GetComponent<UIPaiMaiStallBuyComponent>().OnUpdateUI( self.PaiMaiItemInfo );
        }

        public static void OnButtonClose(this UIPaiMaiStallComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIPaiMaiStall );
        }

        //收回摊位
        public static void OnButtonShouTan(this UIPaiMaiStallComponent self)
        {
            //UIHelper.Remove(self.DomainScene(), UIType.UIPaiMaiStall).Coroutine();
            UI mainUI = UIHelper.GetUI(self.DomainScene(), UIType.UIMain);
            mainUI.GetComponent<UIMainComponent>().OnButtonStallCancel();
        }

    }
}
