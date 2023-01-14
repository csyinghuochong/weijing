using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public  class UINewYearCollectionWordIemComponent : Entity, IAwake<GameObject>
    {
        public GameObject WordList;
        public GameObject RewardList;
        public int CollectionWordId;

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
        public static void OnInitUI(this UINewYearCollectionWordIemComponent self, int key, CollectionWord collectionWord)
        {
            self.CollectionWordId = key;

            string[] wordItems = collectionWord.Words.Split('@');
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i =0; i < wordItems.Length; i++)
            {
                int itemId = int.Parse(wordItems[i]);
                GameObject itemObject = GameObject.Instantiate(bundleGameObject);
                UIItemComponent uIItemComponent = self.AddChild<UIItemComponent, GameObject>(itemObject);
                uIItemComponent.UpdateItem(new BagInfo() {ItemID = itemId });
                uIItemComponent.Label_ItemNum.SetActive(false);
                self.WordItems.Add(uIItemComponent);
                UICommonHelper.SetParent(itemObject, self.WordList);
            }

            UICommonHelper.ShowItemList(collectionWord.Reward, self.RewardList, self, 0.8f);
        }
    }
}
