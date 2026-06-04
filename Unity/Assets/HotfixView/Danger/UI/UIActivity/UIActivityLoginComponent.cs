using UnityEngine;
using System.Collections.Generic;
using System.Linq;

namespace ET
{
    public class UIActivityLoginComponent : Entity, IAwake, IDestroy
    {
        public GameObject ItemNodeList;
        public GameObject GongShiBtn;

        public string AssetPath = string.Empty;
    }

    public class UIActivityLoginComponentDestroy : DestroySystem<UIActivityLoginComponent>
    {
        public override void Destroy(UIActivityLoginComponent self)
        {
            if (!string.IsNullOrEmpty(self.AssetPath))
            {
                ResourcesComponent.Instance.UnLoadAsset(self.AssetPath);
            }
        }
    }

    public class UIActivityLoginComponentAwakeSystem : AwakeSystem<UIActivityLoginComponent>
    {
        public override void Awake(UIActivityLoginComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine(); };

            self.GongShiBtn = rc.Get<GameObject>("GongShiBtn");
            self.GongShiBtn.SetActive(false);


#if UNITY_2022_1_OR_NEWER
            if (EventHandle.onChannelType() == 23)
            {
                self.GongShiBtn.SetActive(true);
            }
#endif

            //self.GongShiBtn.SetActive(true);

            ButtonHelp.AddListenerEx(self.GongShiBtn, self.OnBtn_GongShiBtn);

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
        }
    }

    public static class UIActivityLoginComponentSystem
    {

        public static void OnBtn_GongShiBtn(this UIActivityLoginComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UI_Gongshi_1).Coroutine();
        }


        public static async ETTask OnUpdateUI(this UIActivityLoginComponent self)
        {
            long instanceId = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Activity/UIActivityLoginItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            self.AssetPath = path;
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
