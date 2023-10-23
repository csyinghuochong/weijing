using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public class UIActivityLvLiBaoComponent : Entity, IAwake
    {
        public GameObject ItemNodeList;
        public GameObject UIActivityLvLiBaoItem;
    }


    public class UIActivityLvLiBaoComponentAwakeSystem : AwakeSystem<UIActivityLvLiBaoComponent>
    {
        public override void Awake(UIActivityLvLiBaoComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine(); };

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.UIActivityLvLiBaoItem = rc.Get<GameObject>("UIActivityLvLiBaoItem");
            self.UIActivityLvLiBaoItem.SetActive(false);
        }
    }

    public static class UIActivityLvLiBaoComponentSystem
    {

        public static async ETTask OnUpdateUI(this UIActivityLvLiBaoComponent self)
        {
            await ETTask.CompletedTask;

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

                GameObject bagSpace = GameObject.Instantiate(self.UIActivityLvLiBaoItem);
                bagSpace.SetActive(true);
                UICommonHelper.SetParent(bagSpace, self.ItemNodeList);

                UI ui_item = self.AddChild<UI, string, GameObject>( "UIItem_" + i.ToString(), bagSpace);
                UIActivityLvLiBaoItemComponent uIItemComponent = ui_item.AddComponent<UIActivityLvLiBaoItemComponent>();
                uIItemComponent.OnUpdateUI(activityConfigs[i]);
                uIItemComponent.SetReceived(activityComponent.ActivityReceiveIds.Contains(activityConfigs[i].Id ));
            }
        }
    }
}
