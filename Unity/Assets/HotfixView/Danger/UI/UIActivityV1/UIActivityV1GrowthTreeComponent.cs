using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GrowthTreeComponent : Entity, IAwake
    {
        public Text Text_AddNum;
        public GameObject UIActivityV1GrowthTreeCostItem;
        public GameObject GiveItemList;

        public GameObject UICommonItem;
        public GameObject ShowItemList;
        public List<UIItemComponent> UIShowItemList = new List<UIItemComponent>();

        public GameObject ButtonStageDesc;
        public GameObject ButtonRewardDesc;
        public GameObject ButtonGive;
        public Text TextGrowNumber;
        public Image Tree_Icon;
    }

    public class UIActivityV1GrowthTreeComponentAwake : AwakeSystem<UIActivityV1GrowthTreeComponent>
    {
        public override void Awake(UIActivityV1GrowthTreeComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_AddNum = rc.Get<GameObject>("Text_AddNum").GetComponent<Text>();

            self.UIActivityV1GrowthTreeCostItem = rc.Get<GameObject>("UIActivityV1GrowthTreeCostItem");
            self.UIActivityV1GrowthTreeCostItem.SetActive(false);

            self.GiveItemList = rc.Get<GameObject>("GiveItemList");

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            self.ShowItemList = rc.Get<GameObject>("ShowItemList");

            self.ButtonStageDesc = rc.Get<GameObject>("ButtonStageDesc");
            self.ButtonStageDesc.GetComponent<Button>().onClick.AddListener(() => { });

            self.ButtonRewardDesc = rc.Get<GameObject>("ButtonRewardDesc");
            self.ButtonRewardDesc.GetComponent<Button>().onClick.AddListener(() => { });

            self.ButtonGive = rc.Get<GameObject>("ButtonGive");
            self.ButtonGive.GetComponent<Button>().onClick.AddListener(() => { });

            self.TextGrowNumber = rc.Get<GameObject>("TextGrowNumber").GetComponent<Text>();

            self.Tree_Icon = rc.Get<GameObject>("Tree_Icon").GetComponent<Image>();

            self.InitUIShowItemList();
            self.UpdateInfo();
        }
    }

    public static class UIActivityV1GrowthTreeComponentSystem
    {

        public static void InitUIShowItemList(this UIActivityV1GrowthTreeComponent self)
        {

            string showstr_1 = GameSettingLanguge.LoadLocalization("增长");
            string showstr_2 = GameSettingLanguge.LoadLocalization("点");

            foreach ( var costitem in ActivityConfigHelper.ActivityTreeCostItem)
            {
                int itemid = costitem.Key;

                int lower = costitem.Value.Item1;
                int upper = costitem.Value.Item2;

                GameObject itemSpace = GameObject.Instantiate(self.UICommonItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.ShowItemList);
                UIItemComponent  uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemSpace);
                
                itemSpace.transform.localScale = Vector3.one * 1f;
               
                uIItemComponent.UpdateItem(new BagInfo() { ItemID = itemid }, ItemOperateEnum.None);

                uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.Label_ItemName.SetActive(true);
                uIItemComponent.Label_ItemName.GetComponent<Text>().text = $"{showstr_1}{lower}-{upper}{showstr_2}";

                self.UIShowItemList.Add(uIItemComponent);
            }
            
        }

        public static void UpdateInfo(this UIActivityV1GrowthTreeComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;


        }

       
    }
}