using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIAppraisalSelectComponent : Entity, IAwake
    {
        public GameObject Text_Tip_1;
        public GameObject ButtonClose;
        public GameObject ItemListNode;
        public GameObject Text_EquipLevel;
        public GameObject Button_Item;
        public GameObject Button_Coin;
        public GameObject UICommonItem_2;
        public GameObject UICommonItem_1;

        public BagInfo BagInfo_Equip;
        public BagInfo BagInfo_Appri;


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
            self.Button_Item = rc.Get<GameObject>("Button_Item");
            self.Button_Coin = rc.Get<GameObject>("Button_Coin");
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
            ItemConfig itemCof = ItemConfigCategory.Instance.Get(bagInfo.ItemID);
            EquipConfig equipCof = EquipConfigCategory.Instance.Get(itemCof.ItemEquipID);
            int appItem = equipCof.AppraisalItem;

            UIItemComponent item_equip = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem_1);
            item_equip.UpdateItem(bagInfo, ItemOperateEnum.None);

            ItemConfig itemConfig_app = ItemConfigCategory.Instance.Get(appItem);
            UIItemComponent item_app = self.AddChild<UIItemComponent, GameObject>(self.UICommonItem_2);
            item_app.UpdateItem(new BagInfo() {ItemID =  appItem,ItemNum = 1 }, ItemOperateEnum.None);
            self.Text_Tip_1.GetComponent<Text>().text = $"需要消耗：{itemConfig_app.ItemName}";

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetBagList();
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < bagInfos.Count; i++)
            {
                Log.ILog.Debug($" {bagInfos[i].ItemID}  {appItem}");

                if (bagInfos[i].ItemID != appItem)
                {
                    continue;
                }
                GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(itemSpace, self.ItemListNode);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                uIItemComponent.UpdateItem(bagInfos[i], ItemOperateEnum.None);
                uIItemComponent.SetClickHandler((BagInfo baginfo) => {  } );
                string pingzhi = $"品质:{bagInfos[i].ItemPar}";
                uIItemComponent.Label_ItemName.GetComponent<Text>().text = pingzhi;
                uIItemComponent.Label_ItemName.SetActive(true);
                self.uIItems.Add(uIItemComponent);
            }
        }

        public static void OnSelectItem(this UIAppraisalSelectComponent self, BagInfo bagInfo)
        { 
            self.BagInfo_Appri = bagInfo;
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
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            bagComponent.SendAppraisalItem(self.BagInfo_Equip, self.BagInfo_Appri.BagInfoID).Coroutine();

            UIHelper.Remove(self.ZoneScene(), UIType.UIAppraisalSelect);
        }
    }
}