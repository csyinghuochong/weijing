using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ET
{
    public class UIChengJiuJingLingComponent : Entity,IAwake
    {
        public GameObject cellContainer1;
        public List<UIChengJiuJingLingItemComponent> JingLingUIItems = new List<UIChengJiuJingLingItemComponent>();
    }

    [ObjectSystem]
    public class UIChengJiuJingLingComponentAwake : AwakeSystem<UIChengJiuJingLingComponent>
    {
        public override void Awake(UIChengJiuJingLingComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");

            self.OnInitUI();
            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIChengJiuJingLingComponentSystem
    {
        public static void OnInitUI(this UIChengJiuJingLingComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/ChengJiu/UIChengJiuJinglingItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            
            List<JingLingConfig> titleConfigs = JingLingConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < titleConfigs.Count; i++)
            {
                UIChengJiuJingLingItemComponent uISettingTitleItem = null;
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.cellContainer1);
                uISettingTitleItem = self.AddChild<UIChengJiuJingLingItemComponent, GameObject>(go);
                self.JingLingUIItems.Add(uISettingTitleItem);
                uISettingTitleItem.OnInitUI(titleConfigs[i].Id, false);
            }
        }

        public static void OnUpdateUI(this UIChengJiuJingLingComponent self)
        {
            for (int i = 0; i < self.JingLingUIItems.Count; i++)
            {
                self.JingLingUIItems[i].OnUpdateUI();
            }
        }
    }
}
