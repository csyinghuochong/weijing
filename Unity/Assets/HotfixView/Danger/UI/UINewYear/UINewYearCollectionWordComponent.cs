using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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

            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for(int i = 0; i< activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 32)
                {
                    continue;
                }
                GameObject gamitem = GameObject.Instantiate(bundleGameObject);
                UINewYearCollectionWordIemComponent uINewYear = self.AddChild<UINewYearCollectionWordIemComponent, GameObject>(gamitem);
                uINewYear.OnInitUI(activityConfigs[i]);
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
