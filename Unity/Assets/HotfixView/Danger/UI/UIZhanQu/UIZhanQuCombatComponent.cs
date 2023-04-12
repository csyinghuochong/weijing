using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;

namespace ET
{

    public class UIZhanQuCombatComponent : Entity, IAwake
    {
        public GameObject ItemNodeList;
        public GameObject Lab_MyLv;

    }

    public class UIZhanQuCombatComponentAwakeSystem : AwakeSystem<UIZhanQuCombatComponent>
    {
        public override void Awake(UIZhanQuCombatComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.Lab_MyLv = rc.Get<GameObject>("Lab_MyLv");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIZhanQuCombatComponentSystem
    {

        public static async ETTask OnInitUI(this UIZhanQuCombatComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/ZhanQu/UIZhanQuCombatItem");
            await ETTask.CompletedTask;
            var bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<ActivityConfig> activityConfigs = ActivityConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < activityConfigs.Count; i++)
            {
                if (activityConfigs[i].ActivityType != 22)
                {
                    continue;
                }

                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.ItemNodeList);

                UI ui_item = self.AddChild<UI, string, GameObject>( "UIItem_" + i.ToString(), bagSpace);
                UIZhanQuCombatItemComponent uIItemComponent = ui_item.AddComponent<UIZhanQuCombatItemComponent>();
                uIItemComponent.OnInitUI(activityConfigs[i]);
            }

            self.Lab_MyLv.GetComponent<Text>().text = $"我的战力：{self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Combat}";
        }


    }
}
