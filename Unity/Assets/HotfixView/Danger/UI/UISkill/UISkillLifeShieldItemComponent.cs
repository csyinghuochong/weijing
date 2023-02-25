using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLifeShieldItemComponent : Entity,IAwake<GameObject>
    {
        public GameObject SelectShow;
        public GameObject ImageIcon;
        public GameObject TextName;
        public Action<int> ClickHandler;

        public int ShieldType;
    }

    public class UISkillLifeShieldItemComponentAwake : AwakeSystem<UISkillLifeShieldItemComponent, GameObject>
    {
        public override void Awake(UISkillLifeShieldItemComponent self, GameObject a)
        {
            self.SelectShow = a.transform.Find("SelectShow").gameObject;
            self.SelectShow.SetActive(false);

            self.ImageIcon = a.transform.Find("ImageIcon").gameObject;
            self.ImageIcon.GetComponent<Button>().onClick.AddListener(self.OnButtonClick);

            self.TextName = a.transform.Find("TextName").gameObject;

        }
    }

    public static class UISkillLifeShieldItemComponentSystem
    {

        public static void SetClickHandler(this UISkillLifeShieldItemComponent self, Action<int> action)
        { 
            self.ClickHandler = action; 
        }

        public static void SetSelected(this UISkillLifeShieldItemComponent self, int stype)
        {
            self.SelectShow.SetActive(self.ShieldType == stype);
        }

        public static void OnButtonClick(this UISkillLifeShieldItemComponent self)
        {
            self.ClickHandler(self.ShieldType);
        }

        public static void OnUpdateUI(this UISkillLifeShieldItemComponent self)
        {
            int level = self.ZoneScene().GetComponent<SkillSetComponent>().GetLifeShieldLevel(self.ShieldType);

            UICommonHelper.SetImageGray(self.ImageIcon, level == 0);
        }

        public static void OnInitUI(this UISkillLifeShieldItemComponent self, int stype)
        { 
            self.ShieldType = stype;

            int showId = self.ZoneScene().GetComponent<SkillSetComponent>().GetLifeShieldShowId(self.ShieldType);
            self.TextName.GetComponent<Text>().text = LifeShieldConfigCategory.Instance.Get(showId).ShieldName;
        }
    }

}
