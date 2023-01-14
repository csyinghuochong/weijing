using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public  class UINewYearCollectionWordIemComponent : Entity, IAwake<GameObject>
    {
        public GameObject WordList;
        public GameObject RewardList;

        public ActivityConfig ActivityConfig;
        public List<UIItemComponent> WordItems = new List<UIItemComponent>();
    }

    [ObjectSystem]
    public class UINewYearCollectionWordIemComponentAwake : AwakeSystem<UINewYearCollectionWordIemComponent, GameObject>
    {
        public override void Awake(UINewYearCollectionWordIemComponent self, GameObject a)
        {
            ReferenceCollector rc = a.GetComponent<ReferenceCollector>();
            self.WordList = rc.Get<GameObject>("WordList");
            self.RewardList = rc.Get<GameObject>("RewardList");
        }
    }

    public static class UINewYearCollectionWordIemComponentSystem
    {
        public static void OnInitUI(this UINewYearCollectionWordIemComponent self, ActivityConfig  activityConfig)
        {
            self.ActivityConfig = activityConfig;
            string[] wordItems = activityConfig.Par_2.Split('@');
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i =0; i < wordItems.Length; i++)
            {
                int itemId = int.Parse(wordItems[i]);
                GameObject itemObject = GameObject.Instantiate(bundleGameObject);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemObject);
                uIItemComponent.UpdateItem(new BagInfo() {ItemID = itemId });
                uIItemComponent.Label_ItemNum.SetActive(false);
                uIItemComponent.Label_ItemName.SetActive(false);
                self.WordItems.Add(uIItemComponent);
                UICommonHelper.SetParent(itemObject, self.WordList);
            }

            UICommonHelper.ShowItemList(activityConfig.Par_3, self.RewardList, self, 0.8f);
        }

        public static void OnUpdateUI(this UINewYearCollectionWordIemComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            for (int i = 0; i < self.WordItems.Count; i++)
            {
                bool gray = bagComponent.GetItemNumber(self.WordItems[i].Baginfo.ItemID) <= 0;
                UICommonHelper.SetImageGray(self.WordItems[i].Image_ItemIcon, gray);
                UICommonHelper.SetImageGray(self.WordItems[i].Image_ItemQuality, gray);
            }
        }
    }
}
