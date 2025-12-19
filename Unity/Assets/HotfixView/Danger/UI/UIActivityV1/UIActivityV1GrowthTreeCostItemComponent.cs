using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GrowthTreeCostItemComponent : Entity, IAwake<GameObject>
    {
        public Text Label_ItemNum;
        public GameObject ButtonAdd;
        public GameObject ButtonSub;
        public UIItemComponent UICommonItem;

        public int ItemId;
        public long ItemTotalNum;
        public long ItemGiveNum;
    }

    public class UIActivityV1GrowthTreeCostItemComponentAwake : AwakeSystem<UIActivityV1GrowthTreeCostItemComponent, GameObject>
    {
        public override void Awake(UIActivityV1GrowthTreeCostItemComponent self, GameObject gameObject)
        {
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum").GetComponent<Text>();
            self.ButtonAdd = rc.Get<GameObject>("ButtonAdd");
            self.ButtonSub = rc.Get<GameObject>("ButtonSub");

            GameObject UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem = self.AddChild<UIItemComponent, GameObject>(UICommonItem );
        }
    }

    public static class UIActivityV1GrowthTreeCostItemComponentSystem
    {

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
        }
    }
}