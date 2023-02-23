using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLifeShieldItemComponent : Entity,IAwake<GameObject>
    {
        public GameObject ImageDi;
        public GameObject ImageIcon;
        public GameObject TextName;
        public Action<int> ClickHandler;

        public int ShieldType;
    }

    public class UISkillLifeShieldItemComponentAwake : AwakeSystem<UISkillLifeShieldItemComponent, GameObject>
    {
        public override void Awake(UISkillLifeShieldItemComponent self, GameObject a)
        {

            self.ImageDi = a.transform.Find("ImageDi").gameObject;

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

        public static void OnButtonClick(this UISkillLifeShieldItemComponent self)
        {
            self.ClickHandler(self.ShieldType);
        }

        public static void OnInitUI(this UISkillLifeShieldItemComponent self, int stype)
        { 
            self.ShieldType = stype;

            int level =  self.ZoneScene().GetComponent<SkillSetComponent>().GetLifeShieldLevel(stype);
        }
    }

}
