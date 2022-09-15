using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleXiLianLevelItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject SkillListNode;
        public GameObject ImageExp;
        public GameObject ButtonGet;
        public GameObject ItemListNode;
        public GameObject TextShuLianDu;
        public GameObject TextLevelTip;
        public GameObject TextAttribute;
        public GameObject TextTitle;

        public GameObject Image_Acvityed;
        public GameObject GameObject;
        public float PostionY;
        public int XiLianLevelId;
    }

    [ObjectSystem]
    public class UIRoleXiLianLevelItemComponentAwakeSystem : AwakeSystem<UIRoleXiLianLevelItemComponent, GameObject>
    {
        public override void Awake(UIRoleXiLianLevelItemComponent self, GameObject go)
        {
            self.GameObject = go;

            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
            self.SkillListNode = rc.Get<GameObject>("SkillListNode");
            self.ImageExp = rc.Get<GameObject>("ImageExp");
            self.TextShuLianDu = rc.Get<GameObject>("TextShuLianDu");
            self.TextLevelTip = rc.Get<GameObject>("TextLevelTip");
            self.TextAttribute = rc.Get<GameObject>("TextAttribute");
            self.TextTitle = rc.Get<GameObject>("TextTitle");
            self.Image_Acvityed = rc.Get<GameObject>("Image_Acvityed");
            self.ItemListNode = rc.Get<GameObject>("ItemListNode");

            self.ButtonGet = rc.Get<GameObject>("ButtonGet");
            ButtonHelp.AddListenerEx(self.ButtonGet, () => { self.OnButtonGet().Coroutine();  });
        }
    }

    public static class UIRoleXiLianLevelItemComponentSystem
    {
        public static async ETTask OnButtonGet(this UIRoleXiLianLevelItemComponent self)
        {
            C2M_ItemXiLianRewardRequest  request = new C2M_ItemXiLianRewardRequest() { XiLianId = self.XiLianLevelId };
            M2C_ItemXiLianRewardResponse response = (M2C_ItemXiLianRewardResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error!= ErrorCore.ERR_Success)
            {
                return;
            }
            self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.XiLianRewardIds.Add(self.XiLianLevelId);
            self.OnUpdateUI(self.XiLianLevelId);
        }

        public static void OnUpdateUI(this UIRoleXiLianLevelItemComponent self, int xilianId)
        {
            self.XiLianLevelId = xilianId;
            EquipXiLianConfig equipXiLianConfig = EquipXiLianConfigCategory.Instance.Get(xilianId);
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int shuliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.ItemXiLianDu);

            UserInfo userInfo = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo;
            UICommonHelper.DestoryChild(self.ItemListNode);
            UICommonHelper.ShowItemList(equipXiLianConfig.RewardList, self.ItemListNode, self, 1f).Coroutine();

            int xilianLevel = EquipXiLianConfigCategory.Instance.Get(xilianId).XiLianLevel;
            List<int> xilianSkill = XiLianHelper.GetLevelSkill(xilianLevel);
            UICommonHelper.DestoryChild(self.SkillListNode);
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSkillItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            for (int i = 0; i < xilianSkill.Count; i++)
            {
                GameObject bagSpace = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(bagSpace, self.SkillListNode);
                UICommonSkillItemComponent ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(bagSpace);
                ui_item.OnUpdateUI(xilianSkill[i], ABAtlasTypes.RoleSkillIcon);
            }

            bool actived = shuliandu >= equipXiLianConfig.NeedShuLianDu;
            self.Image_Acvityed.SetActive(userInfo.XiLianRewardIds.Contains(xilianId));
            self.ButtonGet.SetActive(actived && !userInfo.XiLianRewardIds.Contains(xilianId));
            self.TextShuLianDu.GetComponent<Text>().text = $"{shuliandu}/{equipXiLianConfig.NeedShuLianDu}";
            //self.TextShuLianDu.GetComponent<Text>().color = actived ? Color.green : Color.red;
            float progress = shuliandu * 1f / equipXiLianConfig.NeedShuLianDu;
            self.ImageExp.GetComponent<Image>().fillAmount = Mathf.Min(progress, 1f);
            self.TextTitle.GetComponent<Text>().text = equipXiLianConfig.Title;
            self.TextLevelTip.GetComponent<Text>().text = "获得"+ equipXiLianConfig.Title + "，洗炼获得高品质属性概率提升";

            if (equipXiLianConfig.ProList_Type[0] != 0)
            {
                NumericAttribute numericAttribute = ItemViewHelp.AttributeToName[equipXiLianConfig.ProList_Type[0]];

                if (numericAttribute.Float)
                {
                    float fvalue = equipXiLianConfig.ProList_Value[0] * 0.001f;
                    string svalue = fvalue.ToString("0.#####");
                    self.TextAttribute.GetComponent<Text>().text = $"{ItemViewHelp.GetAttributeName(equipXiLianConfig.ProList_Type[0])} +{svalue}%";
                }
                else
                {
                    self.TextAttribute.GetComponent<Text>().text = $"{ItemViewHelp.GetAttributeName(equipXiLianConfig.ProList_Type[0])} +{equipXiLianConfig.ProList_Value[0]}";
                }
            }
        }
    }
}
