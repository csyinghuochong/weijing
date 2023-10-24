using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{

    public class UISettingTitleComponent : Entity, IAwake
    {
        public GameObject cellContainer1;
        public GameObject UISettingTitleItem;
        public List<UISettingTitleItemComponent> UITitieList = new List<UISettingTitleItemComponent>();
    }


    public class UISettingTitleComponentAwake : AwakeSystem<UISettingTitleComponent>
    {
        public override void Awake(UISettingTitleComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.cellContainer1 = rc.Get<GameObject>("cellContainer1");
            self.UISettingTitleItem = rc.Get<GameObject>("UISettingTitleItem");
            self.UISettingTitleItem.SetActive(false);

            self.OnInitUI();

            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UISettingTitleComponentSystem
    {
        public static void OnInitUI(this UISettingTitleComponent self)
        {
            TitleComponent titleComponent = self.ZoneScene().GetComponent<TitleComponent>();

            List<TitleConfig> titleConfigs = TitleConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < titleConfigs.Count; i++)
            {
                UISettingTitleItemComponent uISettingTitleItem = null;
                GameObject go = GameObject.Instantiate(self.UISettingTitleItem);
                go.SetActive(true);
                UICommonHelper.SetParent(go, self.cellContainer1);
                uISettingTitleItem = self.AddChild<UISettingTitleItemComponent, GameObject>(go);
                self.UITitieList.Add(uISettingTitleItem);
                uISettingTitleItem.OnInitUI(titleConfigs[i].Id, titleComponent.IsHaveTitle(titleConfigs[i].Id));
            }
        }

        public static void OnUpdateUI(this UISettingTitleComponent self)
        {
            for (int i = 0; i < self.UITitieList.Count; i++)
            {
                self.UITitieList[i].OnUpdateUI();
            }
        }
    }
}
