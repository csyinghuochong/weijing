using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRoleXiLianLevelItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextShuLianDu;
        public GameObject TextLevelTip;
        public GameObject TextAttribute;
        public GameObject TextTitle;

        public GameObject Image_Acvityed;
        public GameObject GameObject;
        public float PostionY;
    }

    [ObjectSystem]
    public class UIRoleXiLianLevelItemComponentAwakeSystem : AwakeSystem<UIRoleXiLianLevelItemComponent, GameObject>
    {
        public override void Awake(UIRoleXiLianLevelItemComponent self, GameObject go)
        {
            self.GameObject = go;

            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
            self.TextShuLianDu = rc.Get<GameObject>("TextShuLianDu");
            self.TextLevelTip = rc.Get<GameObject>("TextLevelTip");
            self.TextAttribute = rc.Get<GameObject>("TextAttribute");
            self.TextTitle = rc.Get<GameObject>("TextTitle");
            self.Image_Acvityed = rc.Get<GameObject>("Image_Acvityed");
        }
    }

    public static class UIRoleXiLianLevelItemComponentSystem
    {
        public static void OnUpdateUI(this UIRoleXiLianLevelItemComponent self, int xilianId)
        {
            EquipXiLianConfig equipXiLianConfig = EquipXiLianConfigCategory.Instance.Get(xilianId);
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int shuliandu = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.XiLianLevel);

            bool actived = shuliandu >= equipXiLianConfig.NeedShuLianDu;
            self.TextShuLianDu.GetComponent<Text>().text = $"需要洗练熟练度 {shuliandu}/{equipXiLianConfig.NeedShuLianDu}";
            self.TextShuLianDu.GetComponent<Text>().color = actived ? Color.green : Color.red;
            self.TextTitle.GetComponent<Text>().text = equipXiLianConfig.Title;

            NumericAttribute numericAttribute = ItemViewHelp.AttributeToName[equipXiLianConfig.ProList_Type[0]];
            if (numericAttribute.Float)
            {
                float fvalue = equipXiLianConfig.ProList_Value[0] * 0.001f;
                string svalue = fvalue.ToString("0.#####");
                self.TextAttribute.GetComponent<Text>().text =  $"{ItemViewHelp.GetAttributeName(equipXiLianConfig.ProList_Type[0])} +{svalue}%";
            }
            else
            {
                self.TextAttribute.GetComponent<Text>().text = $"{ItemViewHelp.GetAttributeName(equipXiLianConfig.ProList_Type[0])} +{equipXiLianConfig.ProList_Value[0]}";
            }

            self.Image_Acvityed.SetActive(actived);
        }
    }
}
