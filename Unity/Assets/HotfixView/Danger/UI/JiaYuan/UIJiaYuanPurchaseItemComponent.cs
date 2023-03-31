using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPurchaseItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Text_Time;
        public GameObject Text_Price;
        public GameObject Button_Sell;
        public GameObject MakeItem;
        public GameObject MakeItemList;
        public GameObject GameObject;

        public UIItemComponent UICommonItem;
        public JiaYuanPurchaseItem JiaYuanPurchaseItem;
        public List<UIItemComponent> MakeList = new List<UIItemComponent>();

        public Action Action_Buy;
    }

    public class UIJiaYuanPurchaseItemComponentAwake : AwakeSystem<UIJiaYuanPurchaseItemComponent, GameObject>
    {
        public override void Awake(UIJiaYuanPurchaseItemComponent self, GameObject gameObject)
        {
            self.MakeList.Clear();
            self.GameObject = gameObject;
            ReferenceCollector rc= gameObject.GetComponent<ReferenceCollector>();

            self.Text_Price = rc.Get<GameObject>("Text_Price");
            self.Button_Sell = rc.Get<GameObject>("Button_Sell");
            ButtonHelp.AddListenerEx(self.Button_Sell, () => { self.OnButton_Sell().Coroutine(); });

            self.MakeItem = rc.Get<GameObject>("MakeItem");
            self.MakeItem.SetActive(false);

            self.MakeItemList = rc.Get<GameObject>("MakeItemList");

            self.Text_Time = rc.Get<GameObject>("Text_Time");

            GameObject uICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(uICommonItem);
        }
    }

    public static class UIJiaYuanPurchaseItemComponentSystem
    {

        public static async ETTask OnButton_Sell(this UIJiaYuanPurchaseItemComponent self)
        {
            int itemid = self.JiaYuanPurchaseItem.ItemID;

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            if (bagComponent.GetItemNumber(itemid) < 1)
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }
            

            C2M_JiaYuanPurchaseRequest  request = new C2M_JiaYuanPurchaseRequest() {  ItemId = itemid, PurchaseId = self.JiaYuanPurchaseItem.PurchaseId };
            M2C_JiaYuanPurchaseResponse response = (M2C_JiaYuanPurchaseResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }

            self.ZoneScene().GetComponent<JiaYuanComponent>().PurchaseItemList_4 = response.PurchaseItemList;

            self.Action_Buy.Invoke();
        }

        public static bool UpdateLeftTime(this UIJiaYuanPurchaseItemComponent self)
        {
            long serverTime = TimeHelper.ServerNow();
            long endTime = self.JiaYuanPurchaseItem.EndTime;
            if (endTime < serverTime)
            {
                self.Text_Time.GetComponent<Text>().text = "已过期";
                return false;
            }
            else
            {
                self.Text_Time.GetComponent<Text>().text = "剩余时间:" + TimeHelper.ShowLeftTime(endTime - serverTime);
                return true;
            }
        }

        public static void OnUpdateUI(this UIJiaYuanPurchaseItemComponent self, JiaYuanPurchaseItem jiaYuanPurchaseItem, Action action)
        {
            self.Action_Buy = action;
            self.JiaYuanPurchaseItem = jiaYuanPurchaseItem;
            int itemid = jiaYuanPurchaseItem.ItemID;
            int makeid = EquipMakeConfigCategory.Instance.GetMakeId(itemid);
            EquipMakeConfig equipMakeConfig = EquipMakeConfigCategory.Instance.Get(makeid);
            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = itemid , ItemNum = jiaYuanPurchaseItem.LeftNum }, ItemOperateEnum.None);
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            string[] costItems = equipMakeConfig.NeedItems.Split('@');
            for (int i = 0;i < costItems.Length; i++)
            {
                string[] itemInfo = costItems[i].Split(';');
                if (itemInfo.Length < 2)
                {
                    Log.Error($"equipMakeConfig: {equipMakeConfig.NeedItems}");
                    continue;
                }

                UIItemComponent ui_2 = null;
                if (i < self.MakeList.Count)
                {
                    ui_2 = self.MakeList[i];
                    ui_2.GameObject.SetActive(true);
                }
                else
                {
                    GameObject itemSpace = GameObject.Instantiate(bundleGameObject);
                    itemSpace.SetActive(true);
                    UICommonHelper.SetParent(itemSpace, self.MakeItemList);
                    ui_2 = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                    self.MakeList.Add(ui_2);
                }
                ui_2.UpdateItem(new BagInfo() { ItemID = int.Parse(itemInfo[0]), ItemNum = int.Parse(itemInfo[1]) }, ItemOperateEnum.None);
                ui_2.Label_ItemName.SetActive(true);
            }

            for (int i = costItems.Length; i < self.MakeList.Count; i++)
            {
                self.MakeList[i].GameObject.SetActive(false);
            }

            self.Text_Price.GetComponent<Text>().text = "资金:" + jiaYuanPurchaseItem.BuyZiJin.ToString();

            self.UpdateLeftTime();
        }
    }
}
