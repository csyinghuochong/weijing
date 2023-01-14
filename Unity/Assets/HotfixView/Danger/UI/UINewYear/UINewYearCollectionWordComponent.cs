using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UINewYearCollectionWordComponent : Entity, IAwake, IDestroy
    {
        public GameObject FriendNodeList;
        public List<UINewYearCollectionWordIemComponent> CollectionWords = new List<UINewYearCollectionWordIemComponent>();
    }

    [ObjectSystem]
    public class UINewYearCollectionWordComponentAwake : AwakeSystem<UINewYearCollectionWordComponent>
    {
        public override void Awake(UINewYearCollectionWordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.FriendNodeList = rc.Get<GameObject>("FriendNodeList");

            self.CollectionWords.Clear();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.OnInitUI();
        }
    }

    public static class UINewYearCollectionWordComponentSystem
    {
        public static void OnInitUI(this UINewYearCollectionWordComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWordItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            foreach (var item in ConfigHelper.CollectionWordList)
            {
                GameObject gamitem = GameObject.Instantiate(bundleGameObject);
                UINewYearCollectionWordIemComponent uINewYear = self.AddChild<UINewYearCollectionWordIemComponent, GameObject>(gamitem);
                uINewYear.OnInitUI(item.Key, item.Value);
                self.CollectionWords.Add(uINewYear);
                UICommonHelper.SetParent( gamitem, self.FriendNodeList);
            }
        }

        public static void OnUpdateUI(this UINewYearCollectionWordComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWordItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

           
        }

    }
}
