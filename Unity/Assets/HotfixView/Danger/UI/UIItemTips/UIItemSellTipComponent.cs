using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIItemSellTipComponent : Entity, IAwake,IDestroy
    {
        public GameObject SellMoneyTypeImg;
        public GameObject Btn_Cancel;
        public GameObject Lab_SellSumPro;
        public InputField PriceInputField;
        public GameObject Btn_Cost;
        public GameObject Btn_Add;
        public GameObject ImageButton;
        public GameObject Btn_ChuShou;

        public BagInfo BagInfo;
        public List<string> AssetPath = new List<string>();
    }

    public class UIItemSellTipComponentAwake : AwakeSystem<UIItemSellTipComponent>
    {
        public override void Awake(UIItemSellTipComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.SellMoneyTypeImg = rc.Get<GameObject>("SellMoneyTypeImg");
            self.Btn_Cancel = rc.Get<GameObject>("Btn_Cancel");
            self.Btn_Cancel.GetComponent<Button>().onClick.AddListener( self.OnBtn_Cancel);

            self.Lab_SellSumPro = rc.Get<GameObject>("Lab_SellSumPro");

            self.PriceInputField = rc.Get<GameObject>("PriceInputField").GetComponent<InputField>();
            self.PriceInputField.onValueChanged.AddListener((string text) => { self.UpdateSellPrice(); });

            self.Btn_Cost = rc.Get<GameObject>("Btn_Cost");
            self.Btn_Cost.GetComponent<Button>().onClick.AddListener(self.OnBtn_Cost);

            self.Btn_Add = rc.Get<GameObject>("Btn_Add");
            self.Btn_Add.GetComponent<Button>().onClick.AddListener(self.OnBtn_Add);

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(self.OnBtn_Cancel);

            self.Btn_ChuShou = rc.Get<GameObject>("Btn_ChuShou");
            ButtonHelp.AddListenerEx(self.Btn_ChuShou, self.OnBtn_ChuShou);
        }
    }
    public class UIItemSellTipComponentDestroy : DestroySystem<UIItemSellTipComponent>
    {
        public override void Destroy(UIItemSellTipComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIItemSellTipComponentSystem
    {

        public static void OnBtn_Cost(this UIItemSellTipComponent self)
        {
            long sellNum = 0;
            try
            {
                sellNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }

            sellNum--;

            if (sellNum <= 0)
            {
                return;
            }
            self.PriceInputField.text = sellNum.ToString();
            self.UpdateSellPrice();
        }

        public static void OnBtn_Add(this UIItemSellTipComponent self)
        {
            long sellNum = 0;
            try
            {
                sellNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }

            sellNum++;

            if (sellNum > self.BagInfo.ItemNum)
            {
                return;
            }
            self.PriceInputField.text = sellNum.ToString();
            self.UpdateSellPrice();
        }

        public static void UpdateSellPrice(this UIItemSellTipComponent self)
        {
            long sellNum = 0;
            try
            {
                sellNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(self.BagInfo.ItemID);
            long price = sellNum * itemConfig.SellMoneyValue;
            self.Lab_SellSumPro.GetComponent<Text>().text = price.ToString();
            
            ItemConfig sellTypeItemConfig = ItemConfigCategory.Instance.Get(itemConfig.SellMoneyType);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, sellTypeItemConfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.SellMoneyTypeImg.GetComponent<Image>().sprite = sp;
        }

        public static void OnBtn_ChuShou(this UIItemSellTipComponent self)
        {
            long sellNum = 0;
            try
            {
                sellNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e) 
            {
                Log.Error(e.ToString());
                return;
            }

            if (sellNum <= 0 || sellNum > self.BagInfo.ItemNum)
            {
                return;
            }

            self.ZoneScene().GetComponent<BagComponent>().SendSellItem(self.BagInfo, sellNum.ToString()).Coroutine();
            //播放音效
            UIHelper.PlayUIMusic("10004");

            self.OnBtn_Cancel();
        }

        public static void OnInitUI(this UIItemSellTipComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;

            self.PriceInputField.text = self.BagInfo.ItemNum.ToString();
            self.UpdateSellPrice();
        }

        public static void OnBtn_Cancel(this UIItemSellTipComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIItemSellTip );
        }

    }

}