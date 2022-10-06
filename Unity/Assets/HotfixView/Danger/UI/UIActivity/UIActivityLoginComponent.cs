using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public class UIActivityLoginComponent : Entity, IAwake
    {
        public GameObject ItemNodeList;
    }

    [ObjectSystem]
    public class UIActivityLoginComponentAwakeSystem : AwakeSystem<UIActivityLoginComponent>
    {
        public override void Awake(UIActivityLoginComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine(); };

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
        }
    }

    public static class UIActivityLoginComponentSystem
    {
        public static async ETTask OnUpdateUI(this UIActivityLoginComponent self)
        {
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Activity/UIActivityLoginItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;            
            }

            List<Entity> childs = self.Children.Values.ToList();
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            int number = 0;
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 31)
                {
                    continue;
                }

                UIActivityLoginItemComponent uIItemComponent = null;
                if (number < childs.Count)
                {
                    uIItemComponent = (childs[number] as UIActivityLoginItemComponent);
                }
                else
                {

                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.ItemNodeList);
                    uIItemComponent = self.AddChild<UIActivityLoginItemComponent, GameObject>(bagSpace);
                }
                number++;
                uIItemComponent.OnUpdateUI(activityConfigs[i]);
                uIItemComponent.SetReceived(activityComponent.ActivityReceiveIds.Contains(activityConfigs[i].Id));
            }
        }
    }
}
