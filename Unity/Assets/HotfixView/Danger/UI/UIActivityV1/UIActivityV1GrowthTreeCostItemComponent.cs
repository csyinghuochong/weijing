using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GrowthTreeCostItemComponent : Entity, IAwake<GameObject>
    {
        public Text Label_ItemNum;
        public GameObject Btn_Add;
        public GameObject Btn_Cost;
        public UIItemComponent UICommonItem;

        public int ItemId;
        public long ItemTotalNum;
        public long UseNum;
        public bool IsHoldDown;
    }

    public class UIActivityV1GrowthTreeCostItemComponentAwake : AwakeSystem<UIActivityV1GrowthTreeCostItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1GrowthTreeCostItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum").GetComponent<Text>();
            
            self.Btn_Add = rc.Get<GameObject>("ButtonAdd");
            self.Btn_Cost = rc.Get<GameObject>("ButtonSub");
            ButtonHelp.AddEventTriggers(self.Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(pdata).Coroutine(); },
              EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_CostNum(pdata); },
                EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(pdata).Coroutine(); },
                EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(pdata); }, EventTriggerType.PointerUp);


            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem );
        }
    }

    public static class UIActivityV1GrowthTreeCostItemComponentSystem
    {

        public static void OnCostNum(this UIActivityV1GrowthTreeCostItemComponent self)
        {
            self.UseNum -= 1;
            if (self.UseNum <= 0)
            {
                self.UseNum = 0;
            }

            self.Label_ItemNum.text = self.UseNum.ToString();
            self.GetParent<UIActivityV1GrowthTreeComponent>().UpdateText_AddNum();
        }

        public static void OnAddNum(this UIActivityV1GrowthTreeCostItemComponent self)
        {
            self.UseNum += 1;
            if (self.UseNum >= self.ItemTotalNum)
            {
                self.UseNum = self.ItemTotalNum;
            }

            self.Label_ItemNum.text = self.UseNum.ToString();
            self.GetParent<UIActivityV1GrowthTreeComponent>().UpdateText_AddNum();
        }

        public static async ETTask PointerDown_Btn_CostNum(this UIActivityV1GrowthTreeCostItemComponent self, PointerEventData pdata)
        {
            int interval = 0;
            self.IsHoldDown = true;
            self.OnCostNum();
            while (self.IsHoldDown)
            {
                interval++;
                if (interval > 60)
                {
                    self.OnCostNum();
                }

                if (self.UseNum <= 0)
                {
                    self.UseNum = 0;
                    break;
                }

                await TimerComponent.Instance.WaitFrameAsync();
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static void PointerUp_Btn_CostNum(this UIActivityV1GrowthTreeCostItemComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static async ETTask PointerDown_Btn_AddNum(this UIActivityV1GrowthTreeCostItemComponent self, PointerEventData pdata)
        {
            int interval = 0;
            self.IsHoldDown = true;
            self.OnAddNum();
            while (self.IsHoldDown)
            {
                interval++;
                if (interval > 60)
                {
                    self.OnAddNum();
                }

                if (self.UseNum >= self.ItemTotalNum)
                {
                    break;
                }

                await TimerComponent.Instance.WaitFrameAsync();
                if (self.IsDisposed)
                {
                    break;
                }
            }
        }

        public static void PointerUp_Btn_AddNum(this UIActivityV1GrowthTreeCostItemComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static void OnInitData(this UIActivityV1GrowthTreeCostItemComponent self, int itemid, long itemnumber)
        {
            self.ItemId = itemid;
            self.ItemTotalNum = itemnumber;
            self.UICommonItem.UpdateItem(new BagInfo() { ItemID = self.ItemId, ItemNum = (int)itemnumber }, ItemOperateEnum.None);

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIActivityV1GrowthTreeCostItemComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            long itemnumber = bagComponent.GetItemNumber(self.ItemId);

            self.ItemTotalNum = itemnumber;

            self.UICommonItem.Label_ItemName.SetActive(true);
            self.UICommonItem.Label_ItemNum.SetActive(true);
            self.UICommonItem.Label_ItemNum.GetComponent<Text>().text = itemnumber.ToString();
            self.UseNum = Math.Min(itemnumber, self.UseNum);
          
            self.Label_ItemNum.text = self.UseNum.ToString();
        }
    }
}