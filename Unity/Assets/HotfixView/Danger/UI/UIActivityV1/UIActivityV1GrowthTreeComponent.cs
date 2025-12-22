using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIActivityV1GrowthTreeComponent : Entity, IAwake
    {
        public GameObject UIRewardDescListItem;
        public GameObject UIRewardDescList;
        public GameObject RewardButtonClose;
        public GameObject UIRewardDesc;

        public GameObject UIStageDesc;
        public GameObject StageButtonClose;
        public GameObject UIStageDescList;
        public GameObject UIStageDescItem;

        public Text Text_AddNum;
        public GameObject UIActivityV1GrowthTreeCostItem;
        public GameObject GiveItemList;
        public List<UIActivityV1GrowthTreeCostItemComponent> UIGiveItemList = new List<UIActivityV1GrowthTreeCostItemComponent>();

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

            self.UIRewardDescListItem = rc.Get<GameObject>("UIRewardDescListItem");
            self.UIRewardDescListItem.SetActive(false);
            self.UIRewardDescList = rc.Get<GameObject>("UIRewardDescList");
            self.RewardButtonClose = rc.Get<GameObject>("RewardButtonClose");
            self.RewardButtonClose.GetComponent<Button>().onClick.AddListener(() => 
            {
                self.UIRewardDesc.SetActive(false);
            });
            self.UIRewardDesc = rc.Get<GameObject>("UIRewardDesc");
            self.UIRewardDesc.SetActive(false);

            self.UIStageDesc = rc.Get<GameObject>("UIStageDesc");
            self.StageButtonClose = rc.Get<GameObject>("StageButtonClose");
            self.StageButtonClose.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIStageDesc.SetActive(false);
            });
            self.UIStageDescList = rc.Get<GameObject>("UIStageDescList");
            self.UIStageDescItem = rc.Get<GameObject>("UIStageDescItem");
             self.UIStageDescItem.SetActive(false);
            self.UIStageDesc.SetActive(false);

            self.Text_AddNum = rc.Get<GameObject>("Text_AddNum").GetComponent<Text>();

            self.UIActivityV1GrowthTreeCostItem = rc.Get<GameObject>("UIActivityV1GrowthTreeCostItem");
            self.UIActivityV1GrowthTreeCostItem.SetActive(false);

            self.GiveItemList = rc.Get<GameObject>("GiveItemList");

            self.UICommonItem = rc.Get<GameObject>("UICommonItem");
            self.UICommonItem.SetActive(false);

            self.ShowItemList = rc.Get<GameObject>("ShowItemList");

            self.ButtonStageDesc = rc.Get<GameObject>("ButtonStageDesc");
            self.ButtonStageDesc.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIStageDesc.SetActive(true);
            });

            self.ButtonRewardDesc = rc.Get<GameObject>("ButtonRewardDesc");
            self.ButtonRewardDesc.GetComponent<Button>().onClick.AddListener(() =>
            {
                self.UIRewardDesc.SetActive(true);
            });

            self.ButtonGive = rc.Get<GameObject>("ButtonGive");
            self.ButtonGive.GetComponent<Button>().onClick.AddListener(() => { });

            self.TextGrowNumber = rc.Get<GameObject>("TextGrowNumber").GetComponent<Text>();

            self.Tree_Icon = rc.Get<GameObject>("Tree_Icon").GetComponent<Image>();

            self.InitUIShowItemList();
            self.InitUIGiveItemList();
            self.InitUIStageDescList();
            self.InitUIRewardDescList();
            self.UpdateInfo();
        }
    }

    public static class UIActivityV1GrowthTreeComponentSystem
    {

        public static void InitUIStageDescList(this UIActivityV1GrowthTreeComponent self)
        {
            foreach (var costitem in ActivityConfigHelper.ActivityTreeStageDesc)
            {
                GameObject itemSpace = GameObject.Instantiate(self.UIStageDescItem);

                Text text = itemSpace.transform.Find("Text").GetComponent<Text>();
                text.text = $"{costitem.Name} {costitem.GrowthValue}";

                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.UIStageDescList);
            }
        }

        public static void InitUIRewardDescList(this UIActivityV1GrowthTreeComponent self)
        {
            foreach (var treeTendItem in ActivityConfigHelper.ActivityTreeTendRewardItem)
            {
                
                GameObject itemSpace = GameObject.Instantiate(self.UIRewardDescListItem);

                Text TextGrowValue = itemSpace.transform.Find("TextGrowValue").GetComponent<Text>();
                string str = GameSettingLanguge.LoadLocalization("成长值");
                TextGrowValue.text = $"{treeTendItem.GrowthValueLower}-{treeTendItem.GrowthValueUpper}{str}";

                GameObject ItemRewardList = itemSpace.transform.Find("ItemRewardList").gameObject;
                UICommonHelper.ShowItemList(treeTendItem.Reward, ItemRewardList, self);

                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.UIRewardDescList);
            }
        }

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

        public static void InitUIGiveItemList(this UIActivityV1GrowthTreeComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            foreach (var costitem in ActivityConfigHelper.ActivityTreeCostItem)
            {
                int itemid = costitem.Key;

                long havenum = bagComponent.GetItemNumber(itemid);

                GameObject itemSpace = GameObject.Instantiate(self.UIActivityV1GrowthTreeCostItem);
                itemSpace.SetActive(true);
                UICommonHelper.SetParent(itemSpace, self.GiveItemList);

                UIActivityV1GrowthTreeCostItemComponent costitemcomponent = self.AddChild<UIActivityV1GrowthTreeCostItemComponent, GameObject>(itemSpace);

                costitemcomponent.OnInitData(itemid, havenum);

                self.UIGiveItemList.Add(costitemcomponent);
            }
        }

        public static void UpdateText_AddNum(this UIActivityV1GrowthTreeComponent self)
        {
            int lower = 0;
            int upper = 0;
            for (int i = 0; i < self.UIGiveItemList.Count; i++)
            {
                int itemid = self.UIGiveItemList[i].ItemId;
                int usenum = (int)self.UIGiveItemList[i].UseNum;

                ActivityConfigHelper.ActivityTreeCostItem.TryGetValue(itemid, out var costitemcomponent);
                if (costitemcomponent == default)
                {
                    continue;
                }

                lower += usenum * costitemcomponent.Item1;
                upper += usenum * costitemcomponent.Item2;
            }
            string str1 = GameSettingLanguge.LoadLocalization("预计增加");
            string str2 = GameSettingLanguge.LoadLocalization("点成长值");
            self.Text_AddNum.text = $"{str1}{lower}-{upper}{str2}";
        }

        public static void UpdateUIGiveItemList(this UIActivityV1GrowthTreeComponent self)
        {
            for (int i = 0; i < self.UIGiveItemList.Count; i++)
            {
                self.UIGiveItemList[i].OnUpdateUI();
            }
        }

        public static void UpdateInfo(this UIActivityV1GrowthTreeComponent self)
        {
            ActivityV1Info activityV1Info = self.ZoneScene().GetComponent<ActivityComponent>().ActivityV1Info;


        }

       
    }
}