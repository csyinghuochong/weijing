using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{ 
    
    public class UIJueXingShowComponent : Entity, IAwake
    {

        public GameObject Text_11;
        public GameObject Text_Gold;
        public GameObject ButtonActive;
        public GameObject TextSkillName;
        public GameObject ImageSkillIcon;
        public GameObject ImageJueXingExp;
        public GameObject Text_JueXingExp;
        public UICommonCostItemComponent UICommonCostItem;

        public List<UIJueXingShowItemComponent> UIJueXingShowItems = new List<UIJueXingShowItemComponent>();

        public int JueXingId;
    }

    public class UIJueXingShowComponentAwake : AwakeSystem<UIJueXingShowComponent>
    {

        public override void Awake(UIJueXingShowComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.UIJueXingShowItems.Clear();

            self.Text_11 = rc.Get<GameObject>("Text_11");
            self.Text_Gold = rc.Get<GameObject>("Text_Gold");
            self.ButtonActive = rc.Get<GameObject>("ButtonActive");

            self.TextSkillName = rc.Get<GameObject>("TextSkillName");
            self.ImageSkillIcon = rc.Get<GameObject>("ImageSkillIcon");
            self.ImageJueXingExp = rc.Get<GameObject>("ImageJueXingExp");
            self.Text_JueXingExp = rc.Get<GameObject>("Text_JueXingExp");

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

        public static async ETTask OnButtonActive(this UIJueXingShowComponent self)
        {
            if (self.JueXingId == 0)
            {
                return;
            }
            long instanceid = self.InstanceId;
            C2M_SkillJueXingRequest request = new C2M_SkillJueXingRequest() { JueXingId = self.JueXingId };
            M2C_SkillJueXingResponse response = (M2C_SkillJueXingResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (instanceid != self.InstanceId || response.Error != ErrorCore.ERR_Success)
            {
                return;
            }

            self.OnClickHandler( self.JueXingId );
        }


        public static void OnClickHandler(this UIJueXingShowComponent self, int juexingid)
        {
            self.JueXingId = juexingid;
            for (int i = 0; i < self.UIJueXingShowItems.Count; i++)
            {
                self.UIJueXingShowItems[i].SetSelected(juexingid);  
            }

            OccupationJueXingConfig occupationJueXingConfig = OccupationJueXingConfigCategory.Instance.Get(juexingid);
            SkillConfig skillConfig = SkillConfigCategory.Instance.Get(juexingid);

            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
            self.ImageSkillIcon.GetComponent<Image>().sprite = sp;


            self.Text_Gold.GetComponent<Text>().text = $"消耗：{occupationJueXingConfig.costGold}金币";

            self.TextSkillName.GetComponentInChildren<Text>().text =skillConfig.SkillName;

            self.Text_11.GetComponent<Text>().text =skillConfig.SkillDescribe;

            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() ) ;
            NumericComponent numericComponent = unit.GetComponent<NumericComponent>();

            float value = 1f * numericComponent.GetAsInt(NumericType.JueXingExp) / occupationJueXingConfig.costExp;
            self.Text_JueXingExp.GetComponent<Text>().text = $"{numericComponent.GetAsInt(NumericType.JueXingExp)}/{occupationJueXingConfig.costExp}";
            self.ImageJueXingExp.GetComponent<Image>().fillAmount = Math.Min( value, 1f );

            string[] costitem =  occupationJueXingConfig.costItem.Split(';');
            self.UICommonCostItem.UpdateItem(int.Parse(costitem[0]), int.Parse(costitem[1]));

            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            self.ButtonActive.SetActive(skillSetComponent.GetBySkillID(juexingid) == null);
        }

    }
}