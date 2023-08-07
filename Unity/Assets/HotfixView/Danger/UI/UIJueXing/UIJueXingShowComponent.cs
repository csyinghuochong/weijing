using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{ 
    
    public class UIJueXingShowComponent : Entity, IAwake
    {

        public GameObject Text_Gold;
        public GameObject ButtonActive;

      
        public GameObject TextSkillName;

        public GameObject ImageSkillIcon;

        public UICommonCostItemComponent UICommonCostItem;

        public List<UIJueXingShowItemComponent> UIJueXingShowItems = new List<UIJueXingShowItemComponent>();
    }

    public class UIJueXingShowComponentAwake : AwakeSystem<UIJueXingShowComponent>
    {

        public override void Awake(UIJueXingShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIJueXingShowItems.Clear();
            self.Text_Gold = rc.Get<GameObject>("Text_Gold");
            self.ButtonActive = rc.Get<GameObject>("ButtonActive");

            self.TextSkillName = rc.Get<GameObject>("TextSkillName");
            self.ImageSkillIcon = rc.Get<GameObject>("ImageSkillIcon");

            GameObject UICommonCostItem = rc.Get<GameObject>("UICommonCostItem");
            self.UICommonCostItem =  self.AddChild<UICommonCostItemComponent, GameObject>(UICommonCostItem);


            self.OnInitUI();
        }
    }

    public static class UIJueXingShowComponentSystem
    {
        public static void OnInitUI(this UIJueXingShowComponent self)
        {
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;

            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get( occ );
            int[] juexingids = occupationConfig.JueXingSkill;
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            for (int i = 0; i < juexingids.Length; i++)
            {
                GameObject juexingitem = rc.Get<GameObject>($"SkillItem_{i}");
                UIJueXingShowItemComponent uIJueXingShowItem = self.AddChild<UIJueXingShowItemComponent, GameObject>(juexingitem);
                uIJueXingShowItem.OnInitUI( self.OnClickHandler, juexingids[i]);
                self.UIJueXingShowItems.Add(uIJueXingShowItem);
            }

            self.UIJueXingShowItems[0].OnClickImageIcon();
        }

        public static void OnClickHandler(this UIJueXingShowComponent self, int juexingid)
        {
           
            for (int i = 0; i < self.UIJueXingShowItems.Count; i++)
            {
                self.UIJueXingShowItems[i].SetSelected(juexingid);  
            }

            OccupationJueXingConfig occupationJueXingConfig = OccupationJueXingConfigCategory.Instance.Get(juexingid);
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(juexingid);


            self.Text_Gold.GetComponent<Text>().text = $"消耗：{occupationJueXingConfig.costGold}金币";

            self.TextSkillName.GetComponentInChildren<Text>().text =skillConfig.SkillName;  
        }

    }
}