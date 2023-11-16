using System;
using UnityEngine;
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

            self.Btn_Cost = rc.Get<GameObject>("Btn_Cost");
            self.Btn_Cost.GetComponent<Button>().onClick.AddListener(self.OnBtn_Cost);

            self.Btn_Add = rc.Get<GameObject>("Btn_Add");
            self.Btn_Add.GetComponent<Button>().onClick.AddListener(self.OnBtn_Add);

            self.Btn_Open = rc.Get<GameObject>("Btn_Open");
            self.Btn_Open.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Open().Coroutine(); });
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

        public static void UpdateNumber(this UIItemBatchUseComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            self.BagInfo = bagComponent.GetBagInfo(self.BagInfo.BagInfoID);
            self.Label_ItemNum.GetComponent<Text>().text = self.BagInfo.ItemNum.ToString();
            self.PriceInputField.text = self.BagInfo.ItemNum.ToString();
        }

        public static async ETTask OnBtn_Open(this UIItemBatchUseComponent self)
        {
            long useNum = 0;
            try
            {
                useNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }

            if (useNum > self.BagInfo.ItemNum || useNum < 1)
            {
                return;
            }

            self.ZoneScene().GetComponent<BagComponent>().SendUseItem(self.BagInfo, useNum.ToString()).Coroutine();

            UIHelper.Remove(self.ZoneScene(), UIType.UIItemBatchUse);
        }

        public static void OnBtn_Cost(this UIItemBatchUseComponent self)
        {
            long useNum = 0;
            try
            {
                useNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }

            useNum--;

            if (useNum <= 0)
            {
                return;
            }

            self.PriceInputField.text = useNum.ToString();
        }

        public static void OnBtn_Add(this UIItemBatchUseComponent self)
        {
            long useNum = 0;
            try
            {
                useNum = long.Parse(self.PriceInputField.text);
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
                return;
            }

            useNum++;

            if (useNum > self.BagInfo.ItemNum)
            {
                return;
            }

            self.PriceInputField.text = useNum.ToString();
        }
    }
}