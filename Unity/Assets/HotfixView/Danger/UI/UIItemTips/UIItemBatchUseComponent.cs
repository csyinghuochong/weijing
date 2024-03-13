using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIItemBatchUseComponent: Entity, IAwake
    {
        public GameObject Label_ItemNum;
        public GameObject ImageButton;
        public InputField PriceInputField;
        public GameObject Btn_Cost;
        public GameObject Btn_Add;
        public GameObject Btn_Open;

        public UIItemComponent UICommonItem;
        public BagInfo BagInfo;
        public int UseNum;
        public bool IsHoldDown;
    }

    public class UIItemBatchUseComponentAwakeSystem: AwakeSystem<UIItemBatchUseComponent>
    {
        public override void Awake(UIItemBatchUseComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIItemBatchUse); });

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem);

            self.PriceInputField = rc.Get<GameObject>("PriceInputField").GetComponent<InputField>();
            self.PriceInputField.onValueChanged.AddListener((string value) => { self.OnChange(value); });

            self.Btn_Cost = rc.Get<GameObject>("Btn_Cost");
            self.Btn_Add = rc.Get<GameObject>("Btn_Add");
            ButtonHelp.AddEventTriggers(self.Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(pdata).Coroutine(); },
                EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_CostNum(pdata); },
                EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(pdata).Coroutine(); },
                EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(pdata); }, EventTriggerType.PointerUp);

            self.Btn_Open = rc.Get<GameObject>("Btn_Open");
            self.Btn_Open.GetComponent<Button>().onClick.AddListener(self.OnBtn_Open);
        }
    }

    public static class UIItemBatchUseComponentSystem
    {
        public static void OnInitUI(this UIItemBatchUseComponent self, BagInfo bagInfo)
        {
            self.BagInfo = bagInfo;
            self.UICommonItem.UpdateItem(bagInfo, ItemOperateEnum.None);
            self.UpdateNumber();
        }

        public static void OnChange(this UIItemBatchUseComponent self, string str)
        {
            int num = 0;
            try
            {
                num = int.Parse(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            if (num <= 0 || num > self.BagInfo.ItemNum)
            {
                return;
            }

            self.UseNum = num;
        }

        public static void OnAddNum(this UIItemBatchUseComponent self)
        {
            self.UseNum += 1;
            if (self.UseNum >= self.BagInfo.ItemNum)
            {
                self.UseNum = self.BagInfo.ItemNum;
            }

            self.PriceInputField.SetTextWithoutNotify(self.UseNum.ToString());
        }

        public static void OnCostNum(this UIItemBatchUseComponent self)
        {
            self.UseNum -= 1;
            if (self.UseNum <= 1)
            {
                self.UseNum = 1;
            }

            self.PriceInputField.SetTextWithoutNotify(self.UseNum.ToString());
        }

        public static async ETTask PointerDown_Btn_CostNum(this UIItemBatchUseComponent self, PointerEventData pdata)
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

                if (self.UseNum == 1)
                {
                    break;
                }

                await TimerComponent.Instance.WaitFrameAsync();
            }
        }

        public static void PointerUp_Btn_CostNum(this UIItemBatchUseComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static async ETTask PointerDown_Btn_AddNum(this UIItemBatchUseComponent self, PointerEventData pdata)
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

                if (self.UseNum >= self.BagInfo.ItemNum)
                {
                    break;
                }

                await TimerComponent.Instance.WaitFrameAsync();
            }
        }

        public static void PointerUp_Btn_AddNum(this UIItemBatchUseComponent self, PointerEventData pdata)
        {
            self.IsHoldDown = false;
        }

        public static void UpdateNumber(this UIItemBatchUseComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.BagInfo = bagComponent.GetBagInfo(self.BagInfo.BagInfoID);
            self.Label_ItemNum.GetComponent<Text>().text = self.BagInfo.ItemNum.ToString();
            self.PriceInputField.text = self.BagInfo.ItemNum.ToString();
        }

        public static void OnBtn_Open(this UIItemBatchUseComponent self)
        {
            if (self.UseNum > self.BagInfo.ItemNum || self.UseNum < 1)
            {
                return;
            }

            self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, self.UseNum.ToString()).Coroutine();

            UIHelper.Remove(self.ZoneScene(), UIType.UIItemBatchUse);
        }
    }
}