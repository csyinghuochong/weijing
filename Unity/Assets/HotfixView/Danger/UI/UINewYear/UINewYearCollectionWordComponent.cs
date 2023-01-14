using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class UINewYearCollectionWordComponent : Entity, IAwake, IDestroy
    {
        public GameObject FriendNodeList;
        public Dictionary<int, UINewYearCollectionWordIemComponent> CollectionWords = new Dictionary<int, UINewYearCollectionWordIemComponent>();
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
        }
    }

    public static class UINewYearCollectionWordComponentSystem
    {
        public static void InitUI(this UINewYearCollectionWordComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWordItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            foreach (var item in ConfigHelper.CollectionWordList)
            {
                
            }
        }

        public static void OnUpdateUI(this UINewYearCollectionWordComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/NewYear/UINewYearCollectionWordItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

           
        }

    }
}
