using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIAppraisalSelectComponent : Entity, IAwake
    {
        public GameObject Text_Coin;
        public GameObject Text_Tip_1;
        public GameObject ButtonClose;
        public GameObject ItemListNode;
        public GameObject Text_EquipLevel;
        public GameObject Button_Item;
        public GameObject Button_Coin;
        public GameObject UICommonItem_2;
        public GameObject UICommonItem_1;
        public GameObject Label_JianDingQuality;
        public GameObject JianDingSet;
        public GameObject Label_JianDingShow;

        public BagInfo BagInfo_Equip;
        public BagInfo BagInfo_Appri;

        public UIItemComponent UIItemComponent_2;
        public List<UIItemComponent> uIItems = new List<UIItemComponent> ();
    }


    [ObjectSystem]
    public class UIAppraisalSelectComponentAwakeSystem : AwakeSystem<UIAppraisalSelectComponent>
    {
        public override void Awake(UIAppraisalSelectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.uIItems.Clear();
            self.Text_Tip_1 = rc.Get<GameObject>("Text_Tip_1");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");
            self.Text_EquipLevel = rc.Get<GameObject>("Text_EquipLevel");
            self.Text_Coin = rc.Get<GameObject>("Text_Coin");
            self.Label_JianDingQuality = rc.Get<GameObject>("Label_JianDingQuality");
            self.JianDingSet = rc.Get<GameObject>("JianDingSet");
            self.JianDingSet.SetActive(false);
            self.Label_JianDingShow = rc.Get<GameObject>("Label_JianDingShow");

            self.Button_Item = rc.Get<GameObject>("Button_Item");
            ButtonHelp.AddListenerEx( self.Button_Item, () => { self.OnButton_Item();  } );
            self.Button_Coin = rc.Get<GameObject>("Button_Coin");
            ButtonHelp.AddListenerEx(self.Button_Coin, () => { self.OnButton_Coin(); });

            self.UICommonItem_2 = rc.Get<GameObject>("UICommonItem_2");
            self.UICommonItem_1 = rc.Get<GameObject>("UICommonItem_1");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIAppraisalSelect); });


            self.BagInfo_Equip = null;
            self.BagInfo_Appri = null;  
        }
    }

    public static class UIAppraisalSelectComponentSystem
    {
        public static void OnInitUI(this UIAppraisalSelectComponent self, BagInfo bagInfo)
        {
            self.BagInfo_Equip = bagInfo;
            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            EquipConfig equipCof = EquipConfigCategory.Instance.Get(itemCof.ItemEquipID);
            int appItem = equipCof.AppraisalItem;

            self.Text_Coin.GetComponent<Text>().text = ComHelp.GetJianDingCoin(itemCof.UseLv).ToString();

            UIItemComponent item_equip = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem_1);
            item_equip.UpdateItem(bagInfo, ItemOperateEnum.None);
            ItemConfig itemConfig_app = ItemConfigCategory.Instance.Get(appItem);
            UIItemComponent item_app = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem_2);
            self.UIItemComponent_2 = item_app;
            self.UIItemComponent_2.GameObject.SetActive(false);
            //item_app.UpdateItem(new BagInfo() {ItemID =  appItem,ItemNum = 1 }, ItemOperateEnum.None);
            self.Text_Tip_1.GetComponent<Text>().text = $"需要消耗：{itemConfig_app.ItemName}";

            self.Text_EquipLevel.GetComponent<Text>().text = itemCof.UseLv + "级";

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetBagList();

            //鉴定符
            List<BagInfo> appList = new List<BagInfo>();
            for (int i = 0; i < bagInfos.Count; i++)
            {
                if (bagInfos[i].ItemID != appItem && bagInfos[i].ItemID != 11200000)
                {
                    continue;
                }
                appList.Add(bagInfos[i]);
            }
            appList.Sort(delegate (BagInfo a, BagInfo b)
            {
                ItemConfig itemConfig_a = ItemConfigCategory.Instance.Get(a.ItemID);
                ItemConfig itemConfig_b = ItemConfigCategory.Instance.Get(b.ItemID);
                int jianDingLva = itemConfig_a.ItemSubType == 121 && !string.IsNullOrEmpty(a.ItemPar) ? int.Parse(a.ItemPar) : 0;
                int jianDingLvb = itemConfig_b.ItemSubType == 121 && !string.IsNullOrEmpty(a.ItemPar) ? int.Parse(b.ItemPar) : 0;
                return jianDingLvb - jianDingLva;
            });

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < appList.Count; i++)
            {
              
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, self.ItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(appList[i], ItemOperateEnum.None);
                uIItemComponent.SetClickHandler((BagInfo baginfo) => { self.OnSelectItem(baginfo, itemCof);  } );
                string pingzhi = $"品质:{appList[i].ItemPar}";
                uIItemComponent.Label_ItemName.GetComponent<Text>().text = pingzhi;
                uIItemComponent.Label_ItemName.SetActive(true);
                self.uIItems.Add(uIItemComponent);
            }
        }

        public static void OnSelectItem(this UIAppraisalSelectComponent self, BagInfo bagInfo,ItemConfig itemCof)
        { 
            self.BagInfo_Appri = bagInfo;
            self.UIItemComponent_2.UpdateItem(bagInfo, ItemOperateEnum.None);
            self.UIItemComponent_2.GameObject.SetActive(true);
            self.Label_JianDingQuality.GetComponent<Text>().text = "品质:" + bagInfo.ItemPar;
            string jianDingStr = "大海捞针";
            int chaValue = int.Parse(bagInfo.ItemPar) - itemCof.UseLv;
            if (chaValue < 0) {
                jianDingStr = "大海捞针";
                self.Label_JianDingShow.GetComponent<Text>().color = new Color(130f / 255f, 130f / 255f, 130f / 255f);
            }
            if (chaValue >= 0 && chaValue < 8) {
                jianDingStr = "一击必中";
                self.Label_JianDingShow.GetComponent<Text>().color = new Color(175f / 255f, 200f / 255f, 20f / 255f);
            }
            if (chaValue >= 8 && chaValue < 16)
            {
                jianDingStr = "十发十中";
                self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(2);
            }
            if (chaValue >= 16 && chaValue < 24)
            {
                jianDingStr = "百年不遇";
                self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(3);
            }
            if (chaValue >= 24 && chaValue < 32)
            {
                jianDingStr = "千载难逢";
                self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(4);
            }
            if (chaValue >= 32 && chaValue < 999)
            {
                jianDingStr = "万里挑一";
                self.Label_JianDingShow.GetComponent<Text>().color = UICommonHelper.QualityReturnColor(5);
            }

            self.Label_JianDingShow.GetComponent<Text>().text = jianDingStr;
            self.JianDingSet.SetActive(true);
            for (int i = 0; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].SetSelected(bagInfo);
            }
        }

        public static void OnButton_Coin(this UIAppraisalSelectComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bagComponent.SendAppraisalItem(self.BagInfo_Equip).Coroutine();
            UIHelper.Remove(self.ZoneScene(), UIType.UIAppraisalSelect);
        }

        public static void OnButton_Item(this UIAppraisalSelectComponent self)
        {
            if (self.BagInfo_Appri == null)
            {
                FloatTipManager.Instance.ShowFloatTip("请选择鉴定符！");
                return;
            }
            if (self.BagInfo_Equip.BagInfoID == self.BagInfo_Appri.BagInfoID)
            {
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bagComponent.SendAppraisalItem(self.BagInfo_Equip, self.BagInfo_Appri.BagInfoID).Coroutine();

            UIHelper.Remove(self.ZoneScene(), UIType.UIAppraisalSelect);

            FloatTipManager.Instance.ShowFloatTip("恭喜您！道具发挥了作用,鉴定成功!");

        }
    }
}