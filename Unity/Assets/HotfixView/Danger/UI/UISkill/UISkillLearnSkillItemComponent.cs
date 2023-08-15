using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLearnSkillItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject Reddot;
        public GameObject SkillIconImg;
        public GameObject BorderImg;
        public GameObject SkillNameText;
        public SkillPro SkillPro;
        public Action<SkillPro> ClickHandler;
    }

    public class UISkillLearnSkillItemComponentAwakeSystem: AwakeSystem<UISkillLearnSkillItemComponent, GameObject>
    {
        public override void Awake(UISkillLearnSkillItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Reddot = rc.Get<GameObject>("Reddot");
            self.SkillIconImg = rc.Get<GameObject>("SkillIconImg");
            self.BorderImg = rc.Get<GameObject>("BorderImg");
            self.SkillNameText = rc.Get<GameObject>("SkillNameText");
            self.Reddot.SetActive(false);
            self.BorderImg.SetActive(false);

            self.SkillIconImg.GetComponent<Button>().onClick.AddListener(self.OnImg_Button);
        }
    }

    public static class UISkillLearnSkillItemComponentSystem
    {
        public static void ShowReddot(this UISkillLearnSkillItemComponent self)
        {
            int skillpoint = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Sp;
            List<int> uplist = self.ZoneScene().GetComponent<SkillSetComponent>().GetCanUpSkill(skillpoint);
            self.Reddot.SetActive(uplist.Contains(self.SkillPro.SkillID));
        }

        public static void OnImg_Button(this UISkillLearnSkillItemComponent self)
        {
            self.ClickHandler(self.SkillPro);
        }

        public static void SetClickHander(this UISkillLearnSkillItemComponent self, Action<SkillPro> action)
        {
            self.ClickHandler = action;
        }

        public static void OnUpdateUI(this UISkillLearnSkillItemComponent self, SkillPro skillPro)
        {
            self.SkillPro = skillPro;
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(skillPro.SkillID);

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            self.SkillNameText.GetComponent<Text>().text = skillConfig.SkillName;
            self.SkillIconImg.GetComponent<Image>().sprite = sp;

            // self.ShowReddot();
        }
    }
}