using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public class UIActivityLvLiBaoComponent : Entity, IAwake
    {
        public GameObject ItemNodeList;
    }

    [ObjectSystem]
    public class UIActivityLvLiBaoComponentAwakeSystem : AwakeSystem<UIActivityLvLiBaoComponent>
    {
        public override void Awake(UIActivityLvLiBaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine(); };

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
        }
    }

    public static class UIActivityLvLiBaoComponentSystem
    {

        public static async ETTask OnUpdateUI(this UIActivityLvLiBaoComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Activity/UIActivityLvLiBaoItem");
            await ETTask.CompletedTask;
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            //清理下父节点 
            UICommonHelper.DestoryChild(self.ItemNodeList);

            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 3)
                {
                    continue;
                }

                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.ItemNodeList);

                UI ui_item = self.AddChild<UI, string, GameObject>( "UIItem_" + i.ToString(), bagSpace);
                UIActivityLvLiBaoItemComponent uIItemComponent = ui_item.AddComponent<UIActivityLvLiBaoItemComponent>();
                uIItemComponent.OnUpdateUI(activityConfigs[i]);
                uIItemComponent.SetReceived(activityComponent.ActivityReceiveIds.Contains(activityConfigs[i].Id ));
            }
        }
    }
}
