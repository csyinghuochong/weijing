using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISettingTitleComponent : Entity, IAwake
    {
        public GameObject cellContainer1;
        public List<UISettingTitleItemComponent> UITitieList = new List<UISettingTitleItemComponent>();
    }

    [ObjectSystem]
    public class UISettingTitleComponentAwake : AwakeSystem<UISettingTitleComponent>
    {
        public override void Awake(UISettingTitleComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UISettingTitleComponentSystem
    {
        public static void OnUpdateUI(this UISettingTitleComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Setting/UISettingTitleItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            TitleComponent titleComponent = self.ZoneScene().GetComponent<TitleComponent>();
            for (int i = 0; i < titleComponent.TitleList.Count; i++)
            {
                UISettingTitleItemComponent uISettingTitleItem = null;
                if (i < self.UITitieList.Count)
                {
                    uISettingTitleItem = self.UITitieList[i];
                    uISettingTitleItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.cellContainer1);
                    uISettingTitleItem = self.AddChild<UISettingTitleItemComponent, GameObject>(go);
                    self.UITitieList.Add(uISettingTitleItem);
                }
                uISettingTitleItem.OnInitUI(titleComponent.TitleList[i]);
            }

            for (int i = titleComponent.TitleList.Count; i < self.UITitieList.Count; i++)
            {
                self.UITitieList[i].GameObject.SetActive(false);
            }
        }
    }
}
