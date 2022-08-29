using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ET
{
    public class UIActivityTeHuiComponent : Entity, IAwake
    {
        public GameObject ItemNodeList;
    }

    [ObjectSystem]
    public class UIActivityTeHuiComponentAwakeSystem : AwakeSystem<UIActivityTeHuiComponent>
    {
        public override void Awake(UIActivityTeHuiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine();  };
        }
    }

    public static class UIActivityTeHuiComponentSystem
    { 
        public static async ETTask OnUpdateUI(this UIActivityTeHuiComponent self)
        {
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Activity/UIActivityTeHuiItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceId != self.InstanceId)
            {
                return;
            }

            List<Entity> childs = self.Children.Values.ToList();
            ActivityComponent activityComponent = self.ZoneScene().GetComponent<ActivityComponent>();
            for (int i = 0; i < activityComponent.DayTeHui.Count; i++)
            {
                int activityId = activityComponent.DayTeHui[i];
                UIActivityTeHuiItemComponent uIActivityTeHui = null;
                if (i < childs.Count)
                {
                    uIActivityTeHui = (childs[i] as UIActivityTeHuiItemComponent);
                }
                else
                {
                    GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(bagSpace, self.ItemNodeList);
                    uIActivityTeHui =self.AddChild<UIActivityTeHuiItemComponent, GameObject>(bagSpace);
                }

                uIActivityTeHui.OnUpdateUI(activityId, activityComponent.ActivityReceiveIds.Contains(activityId)) ;
            }
        }
    }
}