using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillTianFuItemComponent: Entity, IAwake
    {
        public GameObject TextLv;
        public GameObject ImageIcon3;
        public GameObject ImageIcon2;
        public GameObject ImageIcon1;
        public GameObject TextName3;
        public GameObject TextName2;
        public GameObject TextName1;

        public List<int> TianFuList;
        public Action<int> ClickHandler;
    }



    public class UISkillTianFuItemComponentAwakeSystem : AwakeSystem<UISkillTianFuItemComponent>
    {
        public override void Awake(UISkillTianFuItemComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextLv = rc.Get<GameObject>("TextLv");
            self.ImageIcon3 = rc.Get<GameObject>("ImageIcon3");
            self.ImageIcon2 = rc.Get<GameObject>("ImageIcon2");
            self.ImageIcon1 = rc.Get<GameObject>("ImageIcon1");
            self.ImageIcon3.GetComponent<Button>().onClick.AddListener(() => { self.OnClickTianFu(2); });
            self.ImageIcon2.GetComponent<Button>().onClick.AddListener(() => { self.OnClickTianFu(1); });
            self.ImageIcon1.GetComponent<Button>().onClick.AddListener(() => { self.OnClickTianFu(0); });

            self.TextName3 = rc.Get<GameObject>("TextName3");
            self.TextName2 = rc.Get<GameObject>("TextName2");
            self.TextName1 = rc.Get<GameObject>("TextName1");
        }
    }

    public static class UISkillTianFuItemComponentSystem
    {
        public static GameObject GetKuangByIndex(this UISkillTianFuItemComponent self, int index)
        {
            if (index == 0)
                return self.ImageIcon1;
            else if (index == 1)
                return self.ImageIcon2;
            else
                return self.ImageIcon3;
        }

        public static void OnClickTianFu(this UISkillTianFuItemComponent self, int index)
        {
            self.ClickHandler( self.TianFuList[index] );
        }

        public static void SetClickHanlder(this UISkillTianFuItemComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void InitTianFuList(this UISkillTianFuItemComponent self, List<int> tianfus)
        {
            self.TianFuList = tianfus;

            TalentConfig skillConfig = TalentConfigCategory.Instance.Get(tianfus[0]);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.Icon.ToString());
            self.ImageIcon1.GetComponent<Image>().sprite = sp;
            self.TextName1.GetComponent<Text>().text = skillConfig.Name;

            skillConfig = TalentConfigCategory.Instance.Get(tianfus[1]);
            sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.Icon.ToString());
            self.ImageIcon2.GetComponent<Image>().sprite = sp;
            self.TextName2.GetComponent<Text>().text = skillConfig.Name;

            skillConfig = TalentConfigCategory.Instance.Get(tianfus[2]);
            sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.Icon.ToString());
            self.ImageIcon3.GetComponent<Image>().sprite = sp;
            self.TextName3.GetComponent<Text>().text = skillConfig.Name;

            self.TextLv.GetComponent<Text>().text = skillConfig.LearnRoseLv.ToString() + "级激活此天赋";
        }

        public static void OnActiveTianFu(this UISkillTianFuItemComponent self)
        {
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();

            List<int> activeList = skillSetComponent.TianFuList();
            UICommonHelper.SetImageGray(self.ImageIcon3, !activeList.Contains(self.TianFuList[2]));
            UICommonHelper.SetImageGray(self.ImageIcon2, !activeList.Contains(self.TianFuList[1]));
            UICommonHelper.SetImageGray(self.ImageIcon1, !activeList.Contains(self.TianFuList[0]));
        }

    }

}
